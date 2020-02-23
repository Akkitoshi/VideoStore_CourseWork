using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Unity;
using VideoStore_CourseWork;
using VideoStore_Model.ViewModels;

namespace VideoStore_View
{
    public partial class FormServices : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ServicesController service;

        public FormServices(ServicesController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FormServices_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<ServicesViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Ошибка";
            }
        }

        private void materialRaisedButtonAddService_Click(object sender, EventArgs e)
        {

            var form = Container.Resolve<FormService>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void materialRaisedButtonDel_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            if (materialSingleLineTextFieldId.Text.Length > 5)
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Максимум символов 5";
            }
            if (!(new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldId.Text).Success)
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Не цифровое значение";
            }
            else
            {
                try
                {
                    service.delElement(Convert.ToInt32(materialSingleLineTextFieldId.Text));
                    LoadData();
                    materialLabelError.ForeColor = Color.Green;
                    materialLabelError.Text = "Успешно";
                }
                catch
                {
                    materialLabelError.ForeColor = Color.Red;
                    materialLabelError.Text = "Ошибка";
                }
            }
        }
    }
}
