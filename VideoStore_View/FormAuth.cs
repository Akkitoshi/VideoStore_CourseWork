using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using Unity;
using VideoStore_Controller;

namespace VideoStore_View
{

    public partial class FormAuth : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly AuthController service;


        public FormAuth(AuthController service)
        {
            InitializeComponent();
            this.service = service;

        }
        private void materialRaisedButtonSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialSingleLineTextFieldLogin.Text))
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Заполните поле логин";

            }
            if (materialSingleLineTextFieldLogin.Text.Length > 15)
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Максимум символов 15";
            }
            else
            {
                if (string.IsNullOrEmpty(materialSingleLineTextFieldPassword.Text))
                {
                    materialLabelInfo.ForeColor = Color.Red;
                    materialLabelInfo.Text = "Заполните поле пароль";
                }
                if (materialSingleLineTextFieldPassword.Text.Length > 15)
                {
                    materialLabelInfo.ForeColor = Color.Red;
                    materialLabelInfo.Text = "Максимум символов 15";
                }
                else
                {
                    string res = service.CheckAuthInfo(materialSingleLineTextFieldLogin.Text, materialSingleLineTextFieldPassword.Text);
                    if (res == "ok")
                    {
                        this.Visible = false;
                        var form1 = Container.Resolve<FormMain>();
                        form1.ShowDialog();
                    }
                    else
                    {
                        materialLabelInfo.ForeColor = Color.Red;
                        materialLabelInfo.Text = "Ошибка";
                        return;
                    }
                }
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSignUp>();
            form.ShowDialog();
        }
    }
}
