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
using VideoStore_Controller;
using VideoStore_Model.ViewModels;

namespace VideoStore_View
{
    public partial class FormArchieve : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClientCardController service;
        private readonly ClientContractController service2;
        private readonly ArchieveController service1;
        public int Id { set { id = value; } }
        private int? id;
        public FormArchieve(ClientCardController service, ArchieveController service1, ClientContractController service2)
        {
            InitializeComponent();
            this.service = service;
            this.service1 = service1;
            this.service2 = service2;
        }

        public void LoadData1()
        {
            try
            {
                List<ClientCardViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    dataGridView1.Columns[3].Visible = true;
                    dataGridView1.Columns[4].Visible = true;
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
        public void LoadData2()
        {
            try
            {
                List<ClientContractViewModel> list2 = service2.GetList();
                if (list2 != null)
                {
                    dataGridView2.DataSource = list2;
                    dataGridView2.Columns[0].Visible = true;
                    dataGridView2.Columns[1].Visible = true;
                    dataGridView2.Columns[2].Visible = true;
                    dataGridView2.Columns[3].Visible = true;
                    dataGridView2.Columns[4].Visible = true;
                    dataGridView2.Columns[5].Visible = true;
                    dataGridView2.Columns[6].Visible = true;
                    dataGridView2.Columns[7].Visible = true;
                    dataGridView2.Columns[8].Visible = true;
                    dataGridView2.Columns[9].Visible = true;
                    dataGridView2.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void FormArchieve_Load(object sender, EventArgs e)
        {
            LoadData1();

            LoadData2();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            int id =
           Convert.ToInt32(materialSingleLineTextFieldId.Text);
            try
            {
                _ = service1.SaveToJsonAsyncClient("C:\\Users\\Lenovo\\BackupDeleteClient" + id + ".json");
                service.delElement(id);
            }
            catch
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Ошибка при сохранении";
            }
            materialLabelError.ForeColor = Color.Green;
            materialLabelError.Text = "Успешное сохранение";
            LoadData1();
            LoadData2();

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            int id =
           Convert.ToInt32(materialSingleLineTextFieldIdContract.Text);
            try
            {
                _ = service1.SaveToJsonAsyncClient("C:\\Users\\Lenovo\\BackupDeleteContract" + id + ".json");
                service2.delElement(id);
            }
            catch
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Ошибка при сохранении";
            }
            materialLabelError.ForeColor = Color.Green;
            materialLabelError.Text = "Успешное сохранение";

            LoadData1();
            LoadData2();
        }
    }
}

