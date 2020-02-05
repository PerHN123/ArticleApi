using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ArticleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        List<Article> articles = new List<Article>();
        public ArticleController()
        {
            articles.Add(new Article(1 ,"Tim", "Ting og sager", "mange ord her", 2000));
            articles.Add(new Article(2, "Tim", "Ting og sager2", "flere ord her", 2001));
            articles.Add(new Article(3, "Tim", "Ting og sager3", "de sidste ord her", 2002));
        }
     
        // GET: api/Article
        [HttpGet]
        public IEnumerable<Article> Get()
        {
            return articles;
        }

        // GET: api/Article/5
        [HttpGet("{id}", Name = "Get")]
        public Article Get(int id)
        {
            return articles.FirstOrDefault(x => x.Id == id);
        }

        // POST: api/Article
        [HttpPost]
        public void Post(Article val)
        {
            if (!articles.Exists(x => x.Id == val.Id)){
                articles.Add(val);
            }
        }

        // DELETE: api/Article/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            articles.RemoveAll(x => x.Id == id);
        }
    }
}
