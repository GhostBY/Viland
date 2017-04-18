using Viland.DAL.Entities;

namespace Viland.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Article> Articles { get; }
        void Save();
    }
}