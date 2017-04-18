using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viland.DAL.Entities;

namespace Viland.DAL.Context
{
    public class DatabaseContext: DbContext
    {
        public  DbSet<Article> Articles { get; set; }
        public DatabaseContext()
            : base("LocalConnection")
        {

        }

        public void Commit()
        {
            SaveChanges();
        }

        public void CommitAsync()
        {
            SaveChangesAsync();
        }
    }

    public class VilandDbInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext db)
        {
           
            db.SaveChanges();
        }
    }
}
