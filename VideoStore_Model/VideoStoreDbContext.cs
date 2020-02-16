using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore_Model
{
   public class VideoDbContext : DbContext
    {
        public VideoDbContext() : base("VideoDbContext")
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied =
           System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DbSet<ClientCard> ClientCards { get; set; }
        public DbSet<ClientContract> ClientContracts { set; get; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { set; get; }
        public DbSet<User> Users { set; get; }
    }
}
