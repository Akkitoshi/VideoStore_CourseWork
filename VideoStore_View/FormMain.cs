using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace VideoStore_View
{
    public partial class FormMain : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            var form1 = Container.Resolve<FormInfo>();
            form1.ShowDialog();
        }
    }
}
