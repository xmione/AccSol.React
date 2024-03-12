using AccSol.EF.Data;
using AccSol.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.OpenApi.Models;

internal class Program
{
    private static bool _isWithDbInitialization = true;
    private static bool _addSwaggerUI = true;
    private static ILogger _logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger("Program");
    private static WebApplication? _app;
    private static WebApplicationBuilder? _builder;
    private static ILoggerFactory? _loggerFactory;

    private static IWebHostEnvironment? _environment;
    private static string? _environmentName;
    private static bool _isDevelopment;
    private static string? _connectionString;
    private static string? _testConnectionString;
    private static string? _baseAPIUrl;
    private static int? _baseAPIPort;
    //private static string? _baseWebUrl;
    //private static int? _baseWebPort;

    /// <summary>
    /// Main entry point to the program
    /// </summary>
    /// <param name="args">Argument array
    /// args[0] - [Boolean] Set to true to process DatabaseInitialization(). Default is true.
    /// args[1] - [Boolean] Set to true to process AddSwaggerUI(). Default is true.
    /// </param>
    private static void Main(string[] args)
    {

        if (args.Length > 0)
        {
            _isWithDbInitialization = bool.Parse(args[0]);
            _addSwaggerUI = bool.Parse(args[1]);
        }

        Initialize(args);

        SetAppSettings();

        UseUrls();

        AddServicesToControllers();

        if (_isWithDbInitialization) 
        {
            DatabaseInitialization();
        }
        
        if (_addSwaggerUI) 
        {
            AddSwaggerUI();
        }

        _app?.UseHttpsRedirection();

        if (_environmentName != "http")
        {
            _app?.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        }
        
        _app?.UseAuthorization();

        _app?.MapControllers();

        _app?.Run();


    }
    /// <summary>
    /// Initialize variables and connections.
    /// </summary>
    /// <param name="args">Arguments passed from Main method
    /// args[0] - [Boolean] Set to true to process DatabaseInitialization(). Default is true.
    /// args[1] - [Boolean] Set to true to process AddSwaggerUI(). Default is true.
    /// </param>
    /// <exception cref="InvalidOperationException"></exception>
    private static void Initialize(string[] args)
    {
        _builder = WebApplication.CreateBuilder(args);

        _loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        _logger = _loggerFactory.CreateLogger<Program>();

        Console.WriteLine("Start processing AccSol.API");
        _logger.LogInformation("Start processing AccSol.API");

        _environment = _builder.Environment;
        _environmentName = _environment.EnvironmentName;
        _isDevelopment = _environment.IsDevelopment();
        _connectionString = _builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        _testConnectionString = _builder.Configuration.GetConnectionString("TestConnection") ?? throw new InvalidOperationException("Connection string 'TestConnection' not found.");
        _baseAPIUrl = _builder.Configuration.GetSection("APIBaseURL").Value ?? string.Empty;
        _baseAPIPort = int.Parse(_builder.Configuration.GetSection("APIBasePort").Value ?? string.Empty);
        //var _baseWebUrl = builder.Configuration.GetSection("WebBaseURL").Value ?? string.Empty;
        //var _baseWebPort = int.Parse(builder.Configuration.GetSection("WebBasePort").Value ?? string.Empty);

        _logger.LogInformation($"Connection string {_connectionString}");
        _logger.LogInformation($"_environmentName {_environmentName}");
        _logger.LogInformation($"_isDevelopment {_isDevelopment}");

        if (string.IsNullOrEmpty(_baseAPIUrl))
        {
            throw new InvalidOperationException("APIBaseURL setting not found or empty in the " + $"appsettings.{_environmentName}.json file");
        }
    }

    /// <summary>
    /// Defines the appsettings.json file to use.
    /// </summary>
    private static void SetAppSettings()
    {
        _builder?.Configuration
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                   .AddJsonFile($"appsettings.{_environmentName}.json", optional: true, reloadOnChange: true)
                   .AddEnvironmentVariables();
    }

    /// <summary>
    /// For testing the use of specific urls.
    /// </summary>
    private static void UseUrls()
    {
        // br.ps1 and Web Docker Launch doesn't need this scripts
        //if (_environmentName == "DockerSql")
        //{
        //    var config = builder.Configuration.GetSection("Kestrel:Certificates:Development");
        //    string certsPath = config.GetSection("CertsPath").Value ?? string.Empty;
        //    string password = config.GetSection("Password").Value ?? string.Empty;

        //    builder.WebHost.UseUrls(_baseAPIUrl);
        //    builder.WebHost.ConfigureKestrel(options =>
        //    {
        //        //options.Listen(IPAddress.Loopback, _baseWebPort); // HTTP
        //        options.Listen(IPAddress.Loopback, _baseAPIPort, listenOptions =>
        //        {
        //            var directory = Directory.GetCurrentDirectory();
        //            bool exists = File.Exists(certsPath);
        //            if (exists)
        //            {
        //                listenOptions.UseHttps(certsPath, password);
        //            }
        //        });
        //    });
        //}

    }

    /// <summary>
    /// Adds Services to Controllers
    /// </summary>
    private static void AddServicesToControllers()
    {
        if (_environmentName != "http") 
        {
            // Add services to the container.
            _builder?.Services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
        }

        _builder?.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(_connectionString, b => b.MigrationsAssembly("AccSol.EF")), ServiceLifetime.Scoped);

        _builder?.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        _builder?.Services.AddEndpointsApiExplorer();
        _builder?.Services.AddSwaggerGen(c =>
        {
            _logger?.LogInformation("Adding SwaggerDoc");
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Accsol.API", Version = "v1" });
        });
        _builder?.Services.AddScoped<IRepositoryManager, RepositoryManager>();

        _app = _builder?.Build();

    }

    /// <summary>
    /// Initializes the database through migration and adding of initial data.
    /// </summary>
    private static void DatabaseInitialization()
    {
        try
        {
            _logger.LogInformation($"Processing {_environmentName}");

            // migrate any database changes on startup (includes initial db creation)
            // Important!: This will automatically create the database in case missing.
            //           : No need to switch to master database.
            //Start - Automatically update db from new migrations ====================>

            _logger.LogInformation($"Processing DbContextOptionsBuilder<ApplicationDbcontext for {_environmentName}");
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(_connectionString)
                .Options;
            _logger.LogInformation($"Processing CreateLogger<ApplicationDbContext>()");

            ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger<ApplicationDbContext> contextLogger = loggerFactory.CreateLogger<ApplicationDbContext>();
             
            _logger.LogInformation($"Processing new ApplicationDbContext(contextOptions, contextLogger)");

            using (var scope = _app?.Services.CreateScope())
            {
                var context = scope?.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                _logger.LogInformation($"Testing if can connect to the database.");

                try
                {
                    _logger.LogInformation($"Connection string {_testConnectionString}");
                    using (SqlConnection connection = new SqlConnection(_testConnectionString))
                    {
                        int numberOfRetries = 5;
                        for (int i = 0; i < numberOfRetries; i++)
                        {
                            try
                            {
                                _logger.LogInformation($"connection.Open() Retries: {i + 1}");
                                connection.Open();
                                _logger.LogInformation("Successfully connected to the Database!");
                                _logger.LogInformation($"ServerVersion: {connection.ServerVersion}");
                                _logger.LogInformation($"Database: {connection.Database}");
                                _logger.LogInformation($"DataSource: {connection.DataSource}");
                                _logger.LogInformation($"ConnectionTimeout: {connection.ConnectionTimeout}");

                                break;
                            }
                            catch (Exception ex)
                            {
                                _logger.LogInformation(ex, "Failed to connect to the Database. Retrying...");
                                Thread.Sleep(5000); // Wait for 5 seconds before retrying
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, $"Failed to connect to the database: {ex.Message}");
                }
                finally
                {

                    while (context.Database.GetDbConnection().State == ConnectionState.Open)
                    {
                        _logger.LogInformation("Database connection was open. Closing...");
                        context.Database.CloseConnection();
                    }
                }

                var contextConnectionString = context.Database.GetDbConnection().ConnectionString;

                _logger.LogInformation($"DB Context: {contextConnectionString}");
                _logger.LogInformation("Processing Database.Migrate()");
                context.Database.Migrate();
                _logger.LogInformation("Processing InitializeDatabase()");
                context.InitializeDatabase();

                //End   - Automatically update db from new migrations ====================>
            }



        }
        catch (Exception ex)
        {
            _logger?.LogError(ex, $"Error processing {_environmentName}");
        }
    }

    /// <summary>
    /// Adds the SwaggerUI usually for development purposes.
    /// </summary>
    private static void AddSwaggerUI() 
    {
        _app?.UseSwagger();
        _app?.UseSwaggerUI(c =>
        {
            _logger?.LogInformation("Adding swagger endpoint.");
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "AccSol Accounting Solution V1");
        });
    }
}