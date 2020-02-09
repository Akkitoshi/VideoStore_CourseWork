using MaterialSkin.Controls;
using System;
using System.Drawing;
using Unity;
using VideoStore_Controller;
using VideoStore_Model;

namespace VideoStore_View
{
    public partial class FormClient : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClientCardController service;
        public FormClient(ClientCardController service)
        {
            InitializeComponent();
            this.service = service;
        }
        private void materialRaisedButtonAddClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialSingleLineTextFieldFIO.Text))
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Заполните поле ФИО";
            }
            else
            {
                if (string.IsNullOrEmpty(materialSingleLineTextFieldPassport.Text))
                {
                    materialLabelInfo.ForeColor = Color.Red;
                    materialLabelInfo.Text = "Заполните поле номер паспорта";
                }
                else
                {
                    try
                    {
                        service.AddElement(new ClientCard
                        {
                            FIO = materialSingleLineTextFieldFIO.Text,
                            PassportNumber = materialSingleLineTextFieldPassport.Text
                        });

                        materialLabelInfo.ForeColor = Color.Green;
                        materialLabelInfo.Text = "Клиент добавлен";
                        materialRaisedButtonAddClient.Enabled = false;
                    }
                    catch
                    {
                        materialLabelInfo.ForeColor = Color.Red;
                        materialLabelInfo.Text = "Ошибка";
                    }
                }
            }
        }
    }

}
