using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Unity;
using VideoStore_Controller;
using VideoStore_Model;
using VideoStore_Model.ViewModels;

namespace VideoStore_View
{
    public partial class FormClients : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClientCardController service;
        public string emptyNumber = "";

        public FormClients(ClientCardController service)
        {
            InitializeComponent();
            this.service = service;
            materialLabelError.ForeColor = Color.White;
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            materialLabelError.ForeColor = Color.White;
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
                    dataGridView1.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Ошибка при загрузке данных";
            }
        }
        private void materialRaisedButtonAddClient_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormClient>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }

        }
        private void materialRaisedButtonSearchByFio_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            if (!string.IsNullOrEmpty(materialSingleLineTextFieldFIO.Text))
            {
                try
                {
                    List<ClientCardViewModel> list = service.getClientByFIO(materialSingleLineTextFieldFIO.Text);
                    if (list != null)
                    {
                        dataGridView1.DataSource = list;
                        dataGridView1.Columns[0].Visible = true;
                        dataGridView1.Columns[1].Visible = true;
                        dataGridView1.Columns[2].Visible = true;
                        dataGridView1.Columns[3].Visible = true;
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
            else
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Введите ФИО";
            }

        }

        private void materialRaisedButtonSearchByPassport_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            if (materialSingleLineTextFieldPassportNumber.Text != emptyNumber)
            {
                try
                {
                    List<ClientCardViewModel> list = service.getByPassportNumber(materialSingleLineTextFieldPassportNumber.Text);
                    if (list != null)
                    {
                        dataGridView1.DataSource = list;
                        dataGridView1.Columns[0].Visible = true;
                        dataGridView1.Columns[1].Visible = true;
                        dataGridView1.Columns[2].Visible = true;
                        dataGridView1.Columns[3].Visible = true;
                        dataGridView1.Columns[1].AutoSizeMode =
                            DataGridViewAutoSizeColumnMode.Fill;
                    }
                    if (list == null)
                    {
                        materialLabelError.ForeColor = Color.Red;
                        materialLabelError.Text = "Клиенты отсутсвуют";
                    }
                }
                catch
                {
                    materialLabelError.ForeColor = Color.Red;
                    materialLabelError.Text = "Ошибка";
                }
            }
            else
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Введите номер паспорта";
            }
        }

        private void materialRaisedButtonWithoutPenalties_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            try
            {
                List<ClientCardViewModel> list = service.getClientWithoutPenalties();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    dataGridView1.Columns[3].Visible = true;
                    dataGridView1.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                }
                materialLabelError.ForeColor = Color.White;
                if (list == null)
                {
                    materialLabelError.ForeColor = Color.Red;
                    materialLabelError.Text = "Клиенты отсутсвуют";
                }

            }
            catch
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Ошибка";
            }
        }

        private void materialRaisedButtonWithPenalties_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            try
            {
                List<ClientCardViewModel> list = service.getClientWithPenalties();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    dataGridView1.Columns[3].Visible = true;
                    dataGridView1.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;     
                }
                materialLabelError.ForeColor = Color.White;
                if (list == null)
                {
                    materialLabelError.ForeColor = Color.Red;
                    materialLabelError.Text = "Клиенты отсутсвуют";
                }
            }

            catch
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Ошибка";
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LoadData();
            materialLabelError.ForeColor = Color.White;
            materialSingleLineTextFieldFIOClent.Text = "";
            materialSingleLineTextFieldFIO.Text = "";
            materialSingleLineTextFieldPassportNumber.Text = "";
            materialSingleLineTextFieldPenalties.Text = "";

        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            LoadData();
            materialLabelError.ForeColor = Color.White;
        }

        private void materialRaisedButtonFrequency_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            try
            {
                List<ClientCardViewModel> list = service.getClientFrequency();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    dataGridView1.Columns[3].Visible = true;
                    dataGridView1.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                }
                materialLabelError.ForeColor = Color.White;
                if (list == null)
                {
                    materialLabelError.ForeColor = Color.Red;
                    materialLabelError.Text = "Клиенты отсутсвуют";
                }
            }
            catch
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Ошибка";
            }
        }

        private void materialRaisedButtonPenalties_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            if (string.IsNullOrEmpty(materialSingleLineTextFieldFIOClent.Text) )
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Введите ФИО клиента";
            }
            if (string.IsNullOrEmpty(materialSingleLineTextFieldPenalties.Text))
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Введите количество пени";
            }
            try
            {
                string FIO = materialSingleLineTextFieldFIOClent.Text;
                int Penalties = Convert.ToInt32(materialSingleLineTextFieldPenalties.Text);
                service.UpdElement(FIO, Penalties);
            materialLabelError.ForeColor = Color.Green;
                materialLabelError.Text = "Добавление прошло успешно";
            }
            catch
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Ошибка";
            }
        }

    }
}
