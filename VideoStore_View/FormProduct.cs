using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using Unity;
using VideoStore_Controller;
using VideoStore_Model;

namespace VideoStore_View
{
    public partial class FormProduct : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ProductsController service;
        public FormProduct(ProductsController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void materialRaisedButtonAddProduct_Click(object sender, EventArgs e)
        {        
            if (string.IsNullOrEmpty(materialSingleLineTextFieldName.Text))
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Заполните поле наименование";
            }
            if (materialSingleLineTextFieldName.Text.Length > 35)
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Максимум символов 35";
            }
            if ((new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldName.Text).Success)
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Не текстовое значение";
            }
            else
            {

                if (string.IsNullOrEmpty(materialSingleLineTextFieldType.Text))
                {
                    materialLabelInfo.ForeColor = Color.Red;
                    materialLabelInfo.Text = "Заполните поле тип";
                }
                if (materialSingleLineTextFieldType.Text.Length > 10)
                {
                    materialLabelInfo.ForeColor = Color.Red;
                    materialLabelInfo.Text = "Максимум символов 10";
                }
                if ((new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldType.Text).Success)
                {
                    materialLabelInfo.ForeColor = Color.Red;
                    materialLabelInfo.Text = "Не текстовое значение";
                }

                else
                {

                    if (!(new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldPrice.Text).Success)
                    {
                        materialLabelInfo.ForeColor = Color.Red;
                        materialLabelInfo.Text = "Не цифровое значение";
                    }
                    if (string.IsNullOrEmpty(materialSingleLineTextFieldPrice.Text))
                    {
                        materialLabelInfo.ForeColor = Color.Red;
                        materialLabelInfo.Text = "Заполните поле цена";
                    }
                    else {
                        if (materialSingleLineTextFieldPrice.Text.Length > 4)
                        {
                            materialLabelInfo.ForeColor = Color.Red;
                            materialLabelInfo.Text = "Максимальное значение 4 цифр";
                        }
                        else
                        {
                            try
                            {
                                service.AddElement(new Product
                                {
                                    Name = materialSingleLineTextFieldName.Text,
                                    Type = materialSingleLineTextFieldType.Text,
                                    Price = Convert.ToInt32(materialSingleLineTextFieldPrice.Text),
                                    CountContracts = 0
                                });

                                materialLabelInfo.ForeColor = Color.Green;
                                materialLabelInfo.Text = "Товар успешно добавлен";
                                materialRaisedButtonAddProduct.Enabled = false;
                                InitializeComponent();
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
    }
}
