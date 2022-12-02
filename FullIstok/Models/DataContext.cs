using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace FullIstok.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server = (localdb)\mssqllocaldb; Database = FullIstok; Trusted_Connection = True;");
        }        
    }
}
