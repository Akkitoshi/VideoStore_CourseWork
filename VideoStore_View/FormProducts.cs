using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using VideoStore_Controller;
using VideoStore_Model.ViewModels;

namespace VideoStore_View
{
    public partial class FormProducts : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ProductsController service;

        public FormProducts(ProductsController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<ProductViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    dataGridView1.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void materialRaisedButtonAddProduct_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormProduct>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
