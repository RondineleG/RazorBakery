using RazorBakery.Models;
using Microsoft.EntityFrameworkCore;
namespace RazorBakery.Data
{
    public class RazorBakeryContext : DbContext
    {
       public DbSet<Produto> Produtos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=RazorBakery.db");
        }
    } 
    
}