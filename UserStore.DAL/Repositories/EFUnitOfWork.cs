using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStore.DAL.EF;
using UserStore.DAL.Entities;
using UserStore.DAL.Interfaces;

namespace UserStore.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ApplicationContext _context;
        private ArticleRepository articleRepository;
        public EFUnitOfWork(string connectionString)
        {
            _context = new ApplicationContext(connectionString);
        }
        public IRepository<Article> Articles
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
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
