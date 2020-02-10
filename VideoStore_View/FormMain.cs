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

        private void materialRaisedButtonInfo_Click(object sender, EventArgs e)
        {
            var form1 = Container.Resolve<FormInfo>();
            form1.ShowDialog();
        }

        private void materialRaisedButtonProducts_Click(object sender, EventArgs e)
        {
            var form1 = Container.Resolve<FormProducts>();
            form1.ShowDialog();
        }

        private void materialRaisedButtonClients_Click(object sender, EventArgs e)
        {
            var form1 = Container.Resolve<FormClients>();
            form1.ShowDialog();
        }

        private void materialRaisedButtonContracts_Click(object sender, EventArgs e)
        {
            var form1 = Container.Resolve<FormClientContracts>();
            form1.ShowDialog();
        }

        private void materialRaisedButtonDiagramm_Click(object sender, EventArgs e)
        {
            var form1 = Container.Resolve<FormDiagramm>();
            form1.ShowDialog();
        }

        private void materialRaisedButtonReports_Click(object sender, EventArgs e)
        {
            var form1 = Container.Resolve<FormReport>();
            form1.ShowDialog();
        }

        private void materialRaisedButtonArch_Click(object sender, EventArgs e)
        {
            var form1 = Container.Resolve<FormArchieve>();
            form1.ShowDialog();
        }

        private void materialRaisedButtonServices_Click(object sender, EventArgs e)
        {

            var form1 = Container.Resolve<FormServices>();
            form1.ShowDialog();
        }

        private void materialRaisedButtonUsers_Click(object sender, EventArgs e)
        {
            var form1 = Container.Resolve<FormUsers>();
            form1.ShowDialog();
        }
    }
}
