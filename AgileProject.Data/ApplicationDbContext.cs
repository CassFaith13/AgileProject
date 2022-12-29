using AgileProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgileProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<MovieEntity> Movies { get; set; }
        public DbSet<ShowEntity> Shows { get; set; }
        public DbSet<RatingEntity> Ratings { get; set; }
    }
}