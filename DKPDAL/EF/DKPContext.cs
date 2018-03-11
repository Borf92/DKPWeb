using System.Data.Entity;
using DKPDAL.Models;

namespace DKPDAL.EF
{
    internal class DkpContext : DbContext
    {
        public DkpContext() : base("name=DBConnection")
        { }

        static DkpContext()
        {
            Database.SetInitializer(new IdentityDbInit());
        }

        public DbSet<Gamer> Gamers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<GameItem> GameItems { get; set; }
        public DbSet<Bill> Bills { get; set; }

        internal static DkpContext Create()
        {
            return new DkpContext();
        }
    }

    internal class IdentityDbInit : DropCreateDatabaseIfModelChanges<DkpContext>
    {
        protected override void Seed(DkpContext context)
        {
            PerformInitialSetup(context);
            base.Seed(context);
        }
        public void PerformInitialSetup(DkpContext context)
        { }
    }
}   
