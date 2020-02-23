using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using Unity;
using VideoStore_CourseWork;
using VideoStore_Model;

namespace VideoStore_View
{
    public partial class FormService : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ServicesController service;
        public FormService(ServicesController service)
        {
            InitializeComponent();
            this.service = service;
            materialLabelInfo.ForeColor = Color.White;
        }

        private void materialRaisedButtonAddService_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(materialSingleLineTextFieldName.Text))
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Заполните поле наименование";
            }
            if (materialSingleLineTextFieldName.Text.Length > 20)
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Максимум символов 20";
            }
            if ((new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldName.Text).Success)
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Не текстовое значение";
            }
            else
            {
                try
                {
                    service.AddElement(new Service
                    {
                        Name = materialSingleLineTextFieldName.Text,
                    });

                    materialLabelInfo.ForeColor = Color.Green;
                    materialLabelInfo.Text = "Услуга добавлена";
                    materialRaisedButtonAddService.Enabled = false;
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
