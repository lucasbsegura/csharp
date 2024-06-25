using Microsoft.EntityFrameworkCore;
using MyWebApiTutorial.Models;

namespace MyWebApiTutorial
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }

}