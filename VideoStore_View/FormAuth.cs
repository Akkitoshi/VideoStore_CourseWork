using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using Unity;
using VideoStore_Controller;

namespace VideoStore_View
{

    public partial class FormAuth : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly AuthController service;

        private readonly MaterialSkinManager materialSkinManager;
        public FormAuth(AuthController service)
        {
            InitializeComponent();
            this.service = service;
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void materialRaisedButtonSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialSingleLineTextFieldLogin.Text))
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Заполните все поля";

            }
            if (string.IsNullOrEmpty(materialSingleLineTextFieldPassword.Text))
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Заполните все поля";
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

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSignUp>();
            form.ShowDialog();
        }
    }
}
