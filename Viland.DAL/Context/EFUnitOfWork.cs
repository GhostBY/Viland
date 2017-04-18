using System;
using Viland.DAL.Entities;
using Viland.DAL.Interfaces;
using Viland.DAL.Repositories;

namespace Viland.DAL.Context
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private ArticleRepository articleRepository;

        public EFUnitOfWork(string connectionString)
        {
            _context = new DatabaseContext();
        }

        public IRepository<Article> Articles
        {
            get
            {
                if (articleRepository == null)
                    articleRepository = new ArticleRepository(_context);
                return articleRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}