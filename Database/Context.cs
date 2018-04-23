
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Database.Mappings;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using System.Data.SqlClient;

namespace Database
{
    public class Context : DbContext
    {
        public Context() { }

        public Context(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TalentoMap());

            modelBuilder.ApplyConfiguration(new ConhecimentoMap());

            modelBuilder.ApplyConfiguration(new TalentoBancoMap());

            modelBuilder.ApplyConfiguration(new TalentoConhecimentoMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if para não realizar a configuração no caso do teste unitário por exemplo
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

                var connectionString = config.GetConnectionString("DefaultConnection");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
