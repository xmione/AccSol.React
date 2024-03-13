using AccSol.React;
using AccSol.React.GraphQL.GraphQLQuery;
using AccSol.React.GraphQL.GraphQLSchema;
using AccSol.React.GraphQL.GraphQLTypes;
using AccSolWeb;
using SpotifyWeb;

var builder = WebApplication.CreateBuilder(args);
 
var _baseAPIUrl = builder.Configuration.GetSection("APIBaseURL").Value ?? string.Empty;

builder.Services.AddHttpClient<AccSolService>((sp, client) =>
{
    client.BaseAddress = new Uri(_baseAPIUrl);
});

// Register AccSolService with baseUrl parameter
builder.Services.AddTransient<AccSolService>(sp =>
{
    var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
    var httpClient = httpClientFactory.CreateClient();
    return new AccSolService(_baseAPIUrl, httpClient);
});


builder.Services.AddHttpClient<SpotifyService>();
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    //.AddQueryType<AppQuery>()
    //.AddType<EmployeeType>()
    //.AddType<DepartmentType>()
    //.AddQueryType<AppSchema>()
    .RegisterService<SpotifyService>()
    .RegisterService<AccSolService>();

builder
  .Services
  .AddCors(options =>
  {
      options.AddDefaultPolicy(builder =>
      {
          builder
              .WithOrigins("https://studio.apollographql.com")
              .AllowAnyHeader()
              .AllowAnyMethod();
      });
  });

var app = builder.Build();

app.UseCors();

app.MapGraphQL();

app.Run();