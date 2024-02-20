using crudSmall.Models;
using Microsoft.EntityFrameworkCore;

namespace crudSmall.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

    }
}
