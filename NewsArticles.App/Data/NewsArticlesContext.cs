using Microsoft.EntityFrameworkCore;
using NewsArticles.Models;

namespace NewsArticles.Data
{
    public class NewsArticlesContext : DbContext
    {
        public NewsArticlesContext(DbContextOptions<NewsArticlesContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().ToTable("Articles");
        }
    }
}
