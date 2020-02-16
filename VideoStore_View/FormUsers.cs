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
using VideoStore_CourseWork;
using VideoStore_Model.ViewModels;

namespace VideoStore_View
{
    public partial class FormUsers : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly UsersController service;

        public FormUsers(UsersController service)
        {
            InitializeComponent();
            this.service = service;
        }
        private void FormUsers_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                List<UserViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
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

        private void materialRaisedButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                service.delElement(Convert.ToInt32(materialSingleLineTextFieldId.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
