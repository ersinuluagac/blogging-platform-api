using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contexts.Configs;

namespace Repositories.Contexts
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleConfig());
        }
    }
}
