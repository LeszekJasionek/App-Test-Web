using App_Test_Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace App_Test_Web
{
    public class DbTestContext : DbContext
    {
        public DbTestContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
