using MaterialSkin.Controls;
using System;
using Unity;

namespace VideoStore_View
{
    public partial class FormReports : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public FormReports()
        {
            InitializeComponent();
        }

        private void materialRaisedButtonReports_Click(object sender, EventArgs e)
        {
            var form1 = Container.Resolve<FormReport2>();
            form1.ShowDialog();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var form1 = Container.Resolve<FormReport3>();
            form1.ShowDialog();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            var form1 = Container.Resolve<FormReport>();
            form1.ShowDialog();
        }
    }
}
