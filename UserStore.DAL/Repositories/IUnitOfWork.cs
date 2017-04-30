using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStore.DAL.Entities;
using UserStore.DAL.Interfaces;

namespace UserStore.DAL.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<Article> Articles { get; }
        void Save();
    }
}
