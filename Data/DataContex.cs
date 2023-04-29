global using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=super-herodb;Trusted_Connection=true;TrustServerCertficate=true;");        }//nu are legatura cu proiectul nostru
        public DbSet<SuperHero> SuperHeroes { get; set; } 
    }
}
