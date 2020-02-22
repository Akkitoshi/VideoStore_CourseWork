using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using VideoStore_Controller;
using VideoStore_Model;

namespace VideoStore_View
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormAuth>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<DbContext, DBCourseWorkContext>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<ClientCardController>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<AuthController>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<ClientContractController>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<ProductsController>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<ArchieveController>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<EncryptionController>(new
           HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}
