using Blog_Website.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blog_Website.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts  { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
