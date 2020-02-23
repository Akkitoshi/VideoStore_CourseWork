using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using Unity;
using VideoStore_Controller;
using VideoStore_Model;

namespace VideoStore_View
{
    public partial class FormClientContract : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClientContractController service;
        public FormClientContract(ClientContractController service)
        {
            InitializeComponent();
            this.service = service;
        }
        private void materialRaisedButtonAddContract_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialSingleLineTextFieldClient.Text))
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Заполните поле идентификатор клиента";
            }
            if (materialSingleLineTextFieldClient.Text.Length > 5)
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Максимум символов 5";
            }
            if (!(new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldClient.Text).Success)
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Не цифровое значение";
            }
            else
            {
                if (string.IsNullOrEmpty(materialSingleLineTextFieldUser.Text))
                {
                    materialLabelInfo.ForeColor = Color.Red;
                    materialLabelInfo.Text = "Заполните поле идентификатор продавца";
                }
                if (materialSingleLineTextFieldUser.Text.Length > 5)
                {
                    materialLabelInfo.ForeColor = Color.Red;
                    materialLabelInfo.Text = "Максимум символов 5";
                }
                if (!(new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldUser.Text).Success)
                {
                    materialLabelInfo.ForeColor = Color.Red;
                    materialLabelInfo.Text = "Не цифровое значение";
                }
                else
                {
                    if (string.IsNullOrEmpty(materialSingleLineTextFieldService.Text))
                    {
                        materialLabelInfo.ForeColor = Color.Red;
                        materialLabelInfo.Text = "Заполните поле идентификатор услуги";
                    }
                    if (materialSingleLineTextFieldService.Text.Length > 5)
                    {
                        materialLabelInfo.ForeColor = Color.Red;
                        materialLabelInfo.Text = "Максимум символов 5";
                    }
                    if (!(new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldService.Text).Success)
                    {
                        materialLabelInfo.ForeColor = Color.Red;
                        materialLabelInfo.Text = "Не цифровое значение";
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(materialSingleLineTextFieldProduct.Text))
                        {
                            materialLabelInfo.ForeColor = Color.Red;
                            materialLabelInfo.Text = "Заполните поле идентификатор прордукта";
                        }
                        if (materialSingleLineTextFieldProduct.Text.Length > 5)
                        {
                            materialLabelInfo.ForeColor = Color.Red;
                            materialLabelInfo.Text = "Максимум символов 5";
                        }
                        if (!(new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldProduct.Text).Success)
                        {
                            materialLabelInfo.ForeColor = Color.Red;
                            materialLabelInfo.Text = "Не цифровое значение";
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(materialSingleLineTextFieldAmount.Text))
                            {
                                materialLabelInfo.ForeColor = Color.Red;
                                materialLabelInfo.Text = "Заполните поле количество";
                            }
                            if (materialSingleLineTextFieldAmount.Text.Length > 5)
                            {
                                materialLabelInfo.ForeColor = Color.Red;
                                materialLabelInfo.Text = "Максимум символов 5";
                            }
                            if (!(new Regex(@"[\d!#h]")).Match(materialSingleLineTextFieldAmount.Text).Success)
                            {
                                materialLabelInfo.ForeColor = Color.Red;
                                materialLabelInfo.Text = "Не цифровое значение";
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(materialSingleLineTextFieldStart.Text))
                                {
                                    materialLabelInfo.ForeColor = Color.Red;
                                    materialLabelInfo.Text = "Заполните поле дата заключения";
                                }
                                if (materialSingleLineTextFieldStart.Text.Length > 10)
                                {
                                    materialLabelInfo.ForeColor = Color.Red;
                                    materialLabelInfo.Text = "Максимум символов 10";
                                }
                                if (!(new Regex(@"\d{2}.\d{2}.\d{4}")).Match(materialSingleLineTextFieldStart.Text).Success)
                                {
                                    materialLabelInfo.ForeColor = Color.Red;
                                    materialLabelInfo.Text = "Введите дату в формате дд.мм.гггг";
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(materialSingleLineTextFieldRental.Text))
                                    {
                                        materialLabelInfo.ForeColor = Color.Red;
                                        materialLabelInfo.Text = "Заполните поле срок проката";
                                    }
                                    if (materialSingleLineTextFieldRental.Text.Length > 10)
                                    {
                                        materialLabelInfo.ForeColor = Color.Red;
                                        materialLabelInfo.Text = "Максимум символов 10";
                                    }
                                    if (!(new Regex(@"\d{2}.\d{2}.\d{4}")).Match(materialSingleLineTextFieldRental.Text).Success)
                                    {
                                        materialLabelInfo.ForeColor = Color.Red;
                                        materialLabelInfo.Text = "Введите дату в формате дд.мм.гггг";
                                    }
                                    else
                                    {
                                        try
                                        {
                                            materialSingleLineTextFieldSumma.Text = ((service.GetPrice(Convert.ToInt32(materialSingleLineTextFieldProduct.Text))) * (Convert.ToInt32(materialSingleLineTextFieldAmount.Text))).ToString();
                                            service.AddElement(new ClientContract
                                            {
                                                ClientId = Convert.ToInt32(materialSingleLineTextFieldClient.Text),
                                                UserId = Convert.ToInt32(materialSingleLineTextFieldUser.Text),
                                                ServiceId = Convert.ToInt32(materialSingleLineTextFieldService.Text),
                                                ProductId = Convert.ToInt32(materialSingleLineTextFieldProduct.Text),
                                                ProductAmount = Convert.ToInt32(materialSingleLineTextFieldAmount.Text),
                                                SummaryPrice = Convert.ToInt32(materialSingleLineTextFieldSumma.Text),
                                                DateOfConclusion = Convert.ToDateTime(materialSingleLineTextFieldStart.Text),
                                                RentalPeriodEnd = Convert.ToDateTime(materialSingleLineTextFieldRental.Text),
                                                ReturnDate = null

                                            });

                                            materialLabelInfo.ForeColor = Color.Green;
                                            materialLabelInfo.Text = "Договор добавлен";

                                            materialRaisedButtonAddContract.Enabled = false;
                                            string Type = service.GetTypeProduct(Convert.ToInt32(materialSingleLineTextFieldProduct.Text));
                                            service.Count(1, Type, Convert.ToInt32(materialSingleLineTextFieldProduct.Text));
                                            service.UpdFrequency(1, Convert.ToInt32(materialSingleLineTextFieldClient.Text));

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
        }
    }
}

