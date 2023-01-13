using Microsoft.EntityFrameworkCore;
using OracleDBAzureDevOpsAPI.Models;

namespace OracleDBAzureDevOpsAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(_configuration.GetConnectionString("MiConexion"));
        }

        public DbSet<Producto> Producto { get; set; }
    }
}
