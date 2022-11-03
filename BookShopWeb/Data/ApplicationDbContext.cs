using BookShopWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShopWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
