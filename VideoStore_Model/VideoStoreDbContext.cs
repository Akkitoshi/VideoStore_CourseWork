using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore_Model
{
   public class VideoStoreDbContext : DbContext
    {
        public VideoStoreDbContext() : base("VideoStoreDbContext")
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied =
           System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
       
        public DbSet<User> Users { set; get; }
    }
}
