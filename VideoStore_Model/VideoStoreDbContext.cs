using System.Data.Entity;
namespace VideoStore_Model
{
    public class DBCourseWorkContext : DbContext
    {
        public DBCourseWorkContext() : base("DBCourseWorkContext")
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            _ =
           System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DbSet<ClientCard> ClientCards { get; set; }
        public DbSet<ClientContract> ClientContracts { set; get; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { set; get; }
        public DbSet<User> Users { set; get; }
    }
}
