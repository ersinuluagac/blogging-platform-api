using Entities.Models;

namespace Services.Interfaces
{
    public interface IArticleService
    {
        IEnumerable<Article> GetAllArticles(bool trackChanges);
        Article GetOneArticleById(int id, bool trackChanges);
        Article CreateOneArticle(Article article);
        void UpdateOneArticle(int id, Article article, bool trackChanges);
        void DeleteOneArticle(int id, bool trackChanges);
    }
}
