using Repositories.Interfaces;
using Services.Interfaces;

namespace Services.Implementations
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IArticleService> _articleService;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _articleService = new Lazy<IArticleService>(() => new ArticleService(repositoryManager));
        }

        public IArticleService ArticleService => _articleService.Value;
    }
}