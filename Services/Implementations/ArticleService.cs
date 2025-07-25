using Entities.Models;
using Repositories.Interfaces;
using Services.Interfaces;

namespace Services.Implementations
{
    public class ArticleService : IArticleService
    {
        private readonly IRepositoryManager _manager;

        public ArticleService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Article> GetAllArticles(bool trackChanges)
        {
            return _manager.Article.GetAllArticles(trackChanges);
        }
        public Article GetOneArticleById(int id, bool trackChanges)
        {
            return _manager.Article.GetOneArticleById(id, trackChanges);
        }
        public Article CreateOneArticle(Article article)
        {
            if (article is null)
                throw new Exception("Article cannot be null");
            _manager.Article.CreateOneArticle(article);
            _manager.Save();
            return article;
        }
        public void UpdateOneArticle(int id, Article article, bool trackChanges)
        {
            var entity = _manager.Article.GetOneArticleById(id, trackChanges);
            if (entity is null)
                throw new Exception($"Article with id {id} does not exist");
            entity.Title = article.Title;
            entity.Content = article.Content;
            _manager.Article.UpdateOneArticle(entity);
            _manager.Save();
        }
        public void DeleteOneArticle(int id, bool trackChanges)
        {
            var entity = _manager.Article.GetOneArticleById(id, trackChanges);
            if (entity is null)
                throw new Exception($"Article with id {id} does not exist");
            _manager.Article.DeleteOneArticle(entity);
            _manager.Save();
        }
    }
}
