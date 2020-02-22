using MaterialSkin.Controls;
using System;
using System.Drawing;
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
            else
            {
                if (string.IsNullOrEmpty(materialSingleLineTextFieldType.Text))
                {
                    materialLabelInfo.ForeColor = Color.Red;
                    materialLabelInfo.Text = "Заполните поле тип";
                }
                else
                {
                    if (string.IsNullOrEmpty(materialSingleLineTextFieldPrice.Text))
                    {
                        materialLabelInfo.ForeColor = Color.Red;
                        materialLabelInfo.Text = "Заполните поле цена";
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
                            materialLabelInfo.Text = "Товар добавлен";
                            materialRaisedButtonAddProduct.Enabled = false;
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
