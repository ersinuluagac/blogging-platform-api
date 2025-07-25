using Entities.Models;

namespace Repositories.Interfaces
{
    public interface IArticleRepository : IBaseRepository<Article>
    {
        IQueryable<Article> GetAllArticles(bool trackChanges);
        Article GetOneArticleById(int id, bool trackChanges);
        void CreateOneArticle(Article article);
        void UpdateOneArticle(Article article);
        void DeleteOneArticle(Article article);
    }
}
