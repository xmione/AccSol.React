using AccSol.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AccSol.EF.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IConfiguration _configuration = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        [ActivatorUtilitiesConstructor]
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public virtual DbSet<Coa> Coa { get; set; } = null!;
        public virtual DbSet<ProjectCategory> ProjectCategory { get; set; } = null!;
        public virtual DbSet<ProjectCode> ProjectCode { get; set; } = null!;
        public virtual DbSet<Employee> Employee { get; set; } = null!;
        public virtual DbSet<Client> Client { get; set; } = null!;
        public virtual DbSet<Department> Department { get; set; } = null!;
        public virtual DbSet<PettyCash> PettyCash { get; set; } = null!;
        public virtual DbSet<Journal> JournalEntry { get; set; } = null!;
        public virtual DbSet<PayeeCategory> PayeeCategory { get; set; } = null!;
        public virtual DbSet<Payee> Payee { get; set; } = null!;

        public void InitializeDatabase()
        {
            Database.EnsureCreated();

            if (Database.CanConnect())
            {
                Console.WriteLine("Database exists and connection can be established.");

                // Check if Clients table has data
                if (Client.Any())
                {
                    Console.WriteLine("Clients table has data.");
                }
                else
                {
                    Console.WriteLine("Clients table does not have data. Running AccSol.EF/Data/CreateInitialData.sql");
                    string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                    string sqlFilePath = Path.Combine(baseDir, "Data", "CreateInitialData.sql");
                    string sqlFile = File.ReadAllText(sqlFilePath);
                    sqlFile = sqlFile.Replace("GO", "");

                    Database.ExecuteSqlRaw(sqlFile);
                }
            }
            else 
            {
                Console.WriteLine("Database does not exist.");
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure index for unique constraint on PCFNo with appropriate column type
            modelBuilder.Entity<PettyCash>()
                .Property(p => p.PCFNo)
                .HasMaxLength(255) // Adjust the maximum length accordingly
                .IsRequired(); // Ensure the column is not nullable

            modelBuilder.Entity<PettyCash>()
                .HasIndex(p => p.PCFNo)
                .IsUnique()
                .HasDatabaseName("IX_PettyCashes_PCFNo"); 

            // Map the Amount property of the PettyCash entity to a SQL Server decimal column
            modelBuilder.Entity<PettyCash>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(18,2)"); 

            modelBuilder.Entity<Journal>()
                .Property(j => j.Credit)
                .HasColumnType("decimal(18,2)"); 

            // Map the Debit property of the Journal entity to a SQL Server decimal column
            modelBuilder.Entity<Journal>()
                .Property(j => j.Debit)
                .HasColumnType("decimal(18,2)"); 
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
