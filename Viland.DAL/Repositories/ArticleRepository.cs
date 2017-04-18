using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viland.DAL.Context;
using Viland.DAL.Entities;
using Viland.DAL.Interfaces;

namespace Viland.DAL.Repositories
{
    public class ArticleRepository:IRepository<Article>
    {
        private DatabaseContext _context;

        public ArticleRepository(DatabaseContext context)
        {
            this._context = context;
        }
        public void Create(Article item)
        {
            _context.Articles.Add(item);
        }

        public void Delete(int id)
        {
            Article article = _context.Articles.Find(id);
            if (article == null)
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
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
