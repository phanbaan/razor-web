
using Microsoft.EntityFrameworkCore;

namespace razor02.Models
{
    public class BlogContext : DbContext
    {


        public BlogContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Article> articles { get; set; }
    }

}