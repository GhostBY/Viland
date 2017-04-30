using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStore.DAL.EF;
using UserStore.DAL.Entities;
using UserStore.DAL.Interfaces;

namespace UserStore.DAL.Repositories
{
    public class ArticleRepository:IRepository<Article>
    {
        private ApplicationContext _context;

        public ArticleRepository(ApplicationContext context)
        {
            _context = context;
        }
        public void Create(Article item)
        {
            _context.Articles.Add(item);
        }

        public void Delete(int id)
        {
            Article article = _context.Articles.Find(id);
            if (article != null)
            {
                _context.Articles.Remove(article);
            }
           
        }

        public IEnumerable<Article> Find(Func<Article, bool> predicate)
        {
            return _context.Articles.Where(predicate).ToList();
        }

        public Article Get(int id)
        {
            return _context.Articles.Find(id);
        }

        public IEnumerable<Article> GetAll()
        {
            return _context.Articles;
        }

        public void Update(Article item)
        {
            _context.Entry(item).State=EntityState.Modified;
        }
    }
}
