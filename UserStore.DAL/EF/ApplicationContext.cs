using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using UserStore.DAL.Entities;

namespace UserStore.DAL.EF
{
    public class ApplicationContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string conectionString) : base(conectionString) { }
        public ApplicationContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<ClientProfile> ClientProfiles { get; set; }
        public DbSet<Article> Articles { get; set; }
        public void Commit()
        {
            SaveChanges();
        }

        public void CommitAsync()
        {
            SaveChangesAsync();
        }
    }
    public class UserStoreDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {

            db.SaveChanges();
        }
    }
}
