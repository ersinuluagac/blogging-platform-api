using Entities.Models;
using Repositories.Contexts;
using Repositories.Interfaces;

namespace Repositories.Implementations
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(RepositoryContext context) : base(context)
        {
            
        }
        public IQueryable<Article> GetAllArticles(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(a => a.Id);
        }
        public Article GetOneArticleById(int id, bool trackChanges)
        {
            return FindByCondition(a => a.Id.Equals(id), trackChanges)
                .SingleOrDefault();
        }
        public void CreateOneArticle(Article article)
        {
            Create(article);
        }
        public void UpdateOneArticle(Article article)
        {
            Update(article);
        }
        public void DeleteOneArticle(Article article)
        {
            Delete(article);
        }
    }
}
