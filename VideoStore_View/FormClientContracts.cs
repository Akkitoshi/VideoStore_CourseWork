using iTextSharp.text;
using iTextSharp.text.pdf;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        public string emptyNumber = "";

        public FormClientContracts(ClientContractController service, ClientCardController service2)
        {
            InitializeComponent();
            this.service = service;
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
      
        private void materialRaisedButtonSearchByContract_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            if (!string.IsNullOrEmpty(materialSingleLineTextFieldContractNumber.Text))
            {
                try
                {
                    List<ClientContractViewModel> list = service.getByNumber(Convert.ToInt32(materialSingleLineTextFieldContractNumber.Text));
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
                    List<ClientContractViewModel> list = service.getContractByFIO(materialSingleLineTextFieldFIO.Text);
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
            materialSingleLineTextFieldContractNumber.Text = "";
            materialSingleLineTextFieldFIO.Text = "";
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

        private void materialRaisedButtonReturn_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            if (Convert.ToInt32(materialSingleLineTextFieldContractNumber.Text) == 0)
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Введите идентификатор договора";
            }
            
            try
            {
                int id = Convert.ToInt32(materialSingleLineTextFieldContractNumber.Text);
                DateTime returnDate = DateTime.Now;
                service.UpdElement(returnDate, id);
                materialLabelError.ForeColor = Color.Green;
                materialLabelError.Text = "Дата возврата отмечена";
            }
            catch
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Ошибка";
            }
        }

        private void materialRaisedButtonDel_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            try
            {
                service.delElement(Convert.ToInt32(materialSingleLineTextFieldId.Text));
            }
            catch (Exception ex)
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Ошибка";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    pdfTable.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));
                }
                pdfTable.HeaderRows = 1;


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    {
                        if (dataGridView1[k, i].Value != null)
                        {
                            pdfTable.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                        }
                    }
                }

                string folderPath = @"C:\Users\Lenovo\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + "Список договоров.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
            catch
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Ошибка при сохранении";
            }
            materialLabelError.ForeColor = Color.Green;
            materialLabelError.Text = "Успешное сохранение";
        }
    }
}
