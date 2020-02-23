﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Unity;
using VideoStore_Controller;
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
            if (materialSingleLineTextFieldFIO.Text.Length > 35)
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Максимум символов 35";
            }
            if ((new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldFIO.Text).Success)
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Не текстовое значение";
            }
            else
            {
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

        }

        private void materialRaisedButtonSearchByPassport_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            if (materialSingleLineTextFieldPassportNumber.Text.Length > 10)
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Максимум символов 10";
            }
            if (!(new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldFIO.Text).Success)
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Не текстовое значение";
            }
            else
            {
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
            if (materialSingleLineTextFieldFIO.Text.Length > 35)
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Максимум символов 35";
            }
            if ((new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldFIO.Text).Success)
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Не текстовое значение";
            }

            if (string.IsNullOrEmpty(materialSingleLineTextFieldFIOClent.Text))
            {
                materialLabelError.ForeColor = Color.Red;
                materialLabelError.Text = "Введите ФИО клиента";
            }
            else
            {
                if (materialSingleLineTextFieldPenalties.Text.Length > 4)
                {
                    materialLabelError.ForeColor = Color.Red;
                    materialLabelError.Text = "Максимум символов 4";
                }
                if (!(new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldPenalties.Text).Success)
                {
                    materialLabelError.ForeColor = Color.Red;
                    materialLabelError.Text = "Не цифровое значение";
                }
                if (string.IsNullOrEmpty(materialSingleLineTextFieldPenalties.Text))
                {
                    materialLabelError.ForeColor = Color.Red;
                    materialLabelError.Text = "Введите количество пени";
                }
                else
                {
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

        private void materialRaisedButtonDel_Click(object sender, EventArgs e)
        {
            materialLabelError.ForeColor = Color.White;
            try
            {
                service.delElement(Convert.ToInt32(materialSingleLineTextFieldId.Text));
                materialLabelError.ForeColor = Color.Green;
                materialLabelError.Text = "Успешно";
            }
            catch 
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
                using (FileStream stream = new FileStream(folderPath + "Список клиентов.pdf", FileMode.Create))
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
