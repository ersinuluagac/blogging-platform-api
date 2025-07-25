using Repositories.Contexts;
using Repositories.Interfaces;

namespace Repositories.Implementations
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IArticleRepository> _articleRepository;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _articleRepository = new Lazy<IArticleRepository>(() => new ArticleRepository(_context));
        }

        public IArticleRepository Article => _articleRepository.Value;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
