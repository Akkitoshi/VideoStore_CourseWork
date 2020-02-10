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
    public partial class FormClientContracts : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClientContractController service;
        private readonly ClientCardController service2;
        public string emptyNumber = "";

        public FormClientContracts(ClientContractController service, ClientCardController service2)
        {
            InitializeComponent();
            this.service = service;
            this.service2 = service2;
            materialLabelError.ForeColor = Color.White;
        }

        private void FormClientContracts_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            materialLabelError.ForeColor = Color.White;
            try
            {
                List<ClientContractViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    dataGridView1.Columns[3].Visible = true;
                    dataGridView1.Columns[4].Visible = true;
                    dataGridView1.Columns[5].Visible = true;
                    dataGridView1.Columns[6].Visible = true;
                    dataGridView1.Columns[7].Visible = true;
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
        private void materialRaisedButtonPenalties_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            if (string.IsNullOrEmpty(materialSingleLineTextFieldFIOClent.Text))
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Введите ФИО клиента";
            }
            try
            {
                service2.UpdElement(new ClientCard
                {
                    Penalties = Convert.ToInt32(materialSingleLineTextFieldPinalties.Text)
                });
                materialLabelError.ForeColor = Color.Green;
                materialLabelError.Text = "Добавление прошло успешно";
            }
            catch
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Ошибка";
            }
        }
        private void materialRaisedButtonSearchByContract_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            if (!string.IsNullOrEmpty(materialSingleLineTextFieldContractNumber.Text))
            {
                try
                {
                    List<ClientContractViewModel> list = service.getByNumber(materialSingleLineTextFieldContractNumber.Text);
                    if (list != null)
                    {
                        dataGridView1.DataSource = list;
                        dataGridView1.Columns[0].Visible = true;
                        dataGridView1.Columns[1].Visible = true;
                        dataGridView1.Columns[2].Visible = true;
                        dataGridView1.Columns[3].Visible = true;
                        dataGridView1.Columns[4].Visible = true;
                        dataGridView1.Columns[5].Visible = true;
                        dataGridView1.Columns[6].Visible = true;
                        dataGridView1.Columns[7].Visible = true;
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
                materialLabelError.Text = "Введите идентификатор договора";
            }

        }

        private void materialRaisedButtonSearchByFIO_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            if (!string.IsNullOrEmpty(materialSingleLineTextFieldFIO.Text))
            {
                try
                {
                    List<ClientContractViewModel> list = service.getByNumber(materialSingleLineTextFieldFIO.Text);
                    if (list != null)
                    {
                        dataGridView1.DataSource = list;
                        dataGridView1.Columns[0].Visible = true;
                        dataGridView1.Columns[1].Visible = true;
                        dataGridView1.Columns[2].Visible = true;
                        dataGridView1.Columns[3].Visible = true;
                        dataGridView1.Columns[4].Visible = true;
                        dataGridView1.Columns[5].Visible = true;
                        dataGridView1.Columns[6].Visible = true;
                        dataGridView1.Columns[7].Visible = true;
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

        private void materialRaisedButtonCancel_Click(object sender, EventArgs e)
        {
            LoadData();
            materialLabelError.ForeColor = Color.White;
        }

        private void materialRaisedButtonActive_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            try
            {
                List<ClientContractViewModel> list = service.getByActive();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    dataGridView1.Columns[3].Visible = true;
                    dataGridView1.Columns[4].Visible = true;
                    dataGridView1.Columns[5].Visible = true;
                    dataGridView1.Columns[6].Visible = true;
                    dataGridView1.Columns[7].Visible = true;
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

        private void materialRaisedButtonNoActive_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            try
            {
                List<ClientContractViewModel> list = service.getByNoActive();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    dataGridView1.Columns[3].Visible = true;
                    dataGridView1.Columns[4].Visible = true;
                    dataGridView1.Columns[5].Visible = true;
                    dataGridView1.Columns[6].Visible = true;
                    dataGridView1.Columns[7].Visible = true;
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

        private void materialRaisedButtonUpd_Click(object sender, EventArgs e)
        {
            LoadData();
            materialLabelError.ForeColor = Color.White;
        }

        private void materialRaisedButtonAddContract_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormClientContract>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

    }
}
