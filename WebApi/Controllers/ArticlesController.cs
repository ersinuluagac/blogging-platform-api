using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/articles")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public ArticlesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllArticles()
        {
            var articles = _manager.ArticleService.GetAllArticles(false);
            return Ok(articles);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetOneArticle([FromRoute(Name = "id")] int id)
        {
            var article = _manager.ArticleService.GetOneArticleById(id, false);
            if (article is null)
                return NotFound();
            return Ok(article);
        }
        [HttpPost]
        public IActionResult CreateOneArticle([FromBody] Article article)
        {
            _manager.ArticleService.CreateOneArticle(article);
            return StatusCode(201, article);
        }
        [HttpPut("{id:int}")]
        public IActionResult UpdateOneArticle([FromRoute(Name = "id")] int id, [FromBody] Article article)
        {
 
            _manager.ArticleService.UpdateOneArticle(id, article, true);
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneArticle([FromRoute(Name = "id")] int id)
        {
            _manager.ArticleService.DeleteOneArticle(id, false);
            return NoContent();
        }
    }
}
