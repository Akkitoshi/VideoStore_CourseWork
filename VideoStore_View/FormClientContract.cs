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
            else
            {
                if (string.IsNullOrEmpty(materialSingleLineTextFieldUser.Text))
                {
                    materialLabelInfo.ForeColor = Color.Red;
                    materialLabelInfo.Text = "Заполните поле идентификатор продавца";
                }
                else
                {
                    if (string.IsNullOrEmpty(materialSingleLineTextFieldService.Text))
                    {
                        materialLabelInfo.ForeColor = Color.Red;
                        materialLabelInfo.Text = "Заполните поле идентификатор услуги";
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(materialSingleLineTextFieldProduct.Text))
                        {
                            materialLabelInfo.ForeColor = Color.Red;
                            materialLabelInfo.Text = "Заполните поле идентификатор прордукта";
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(materialSingleLineTextFieldAmount.Text))
                            {
                                materialLabelInfo.ForeColor = Color.Red;
                                materialLabelInfo.Text = "Заполните поле количество";
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(materialSingleLineTextFieldStart.Text))
                                {
                                    materialLabelInfo.ForeColor = Color.Red;
                                    materialLabelInfo.Text = "Заполните поле дата заключения";
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(materialSingleLineTextFieldRental.Text))
                                    {
                                        materialLabelInfo.ForeColor = Color.Red;
                                        materialLabelInfo.Text = "Заполните поле срок проката";
                                    }
                                    else
                                    {
                                        try
                                        {
                                            service.AddElement(new ClientContract
                                            {
                                                ClientId =Convert.ToInt32( materialSingleLineTextFieldClient.Text),
                                                UserId= Convert.ToInt32(materialSingleLineTextFieldUser.Text),
                                                ServiceId= Convert.ToInt32(materialSingleLineTextFieldService.Text),
                                                ProductId= Convert.ToInt32(materialSingleLineTextFieldProduct.Text),
                                                ProductAmount= Convert.ToInt32(materialSingleLineTextFieldAmount.Text),
                                                SummaryPrice= Convert.ToInt32(materialSingleLineTextFieldSumma.Text),
                                                DateOfConclusion= Convert.ToDateTime(materialSingleLineTextFieldStart.Text),
                                                RentalPeriodEnd= Convert.ToDateTime(materialSingleLineTextFieldRental.Text)

                                            }) ;

                                            materialLabelInfo.ForeColor = Color.Green;
                                            materialLabelInfo.Text = "Контракт добавлен";
                                            materialRaisedButtonAddContract.Enabled = false;
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

