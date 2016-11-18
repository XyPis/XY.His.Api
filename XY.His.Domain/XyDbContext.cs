using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;

namespace XY.His
{
    public partial class XyDbContext : DbContext
    {
        static XyDbContext()
        {
            Database.SetInitializer<XyDbContext>(null);
        }

        public XyDbContext(string connectionString)
            : base(string.Format("Name={0}", connectionString))
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
