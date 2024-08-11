using Microsoft.EntityFrameworkCore;
using TaskForProject.Api.Models;

namespace TaskForProject.Api.Dbcontext
{
    public class AppDbContext : DbContext
    {

        private IConfiguration _configuration;

        public DbSet<Book1> book1s { get; set; }
        public DbSet<Book2> book2s { get; set; }

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
        }

    }
}
