using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using Unity;
using VideoStore_Controller;
using VideoStore_Model;

namespace VideoStore_View
{
    public partial class FormSignUp : MaterialForm
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private int? id;
        private readonly AuthController service;
        private readonly MaterialSkinManager materialSkinManager;
        public FormSignUp(AuthController service)
        {
            this.service = service;
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void materialRaisedButtonSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialSingleLineTextFieldFIO.Text))
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Заполните поле ФИО";
            }
            if (string.IsNullOrEmpty(materialComboBoxRole.Text))
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Выберите роль";
            }
            if (string.IsNullOrEmpty(materialSingleLineTextFieldPosition.Text))
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Заполните поле должность";
            }
            if (string.IsNullOrEmpty(materialSingleLineTextFieldLogin.Text))
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Задайте логин";
            }
            if (string.IsNullOrEmpty(materialSingleLineTextFieldPassword.Text))
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Задайте пароль";

                if (!(string.IsNullOrEmpty(materialSingleLineTextFieldPassword.Text) && string.IsNullOrEmpty(materialSingleLineTextFieldLogin.Text) && string.IsNullOrEmpty(materialSingleLineTextFieldPosition.Text) && string.IsNullOrEmpty(materialComboBoxRole.Text) && string.IsNullOrEmpty(materialSingleLineTextFieldFIO.Text)))
                    try
                    {
                        service.AddElement(new User
                        {
                            FIO = materialSingleLineTextFieldFIO.Text,
                            Role = materialComboBoxRole.Text,
                            Position = materialSingleLineTextFieldPosition.Text,
                            Login = materialSingleLineTextFieldLogin.Text,
                            Password = materialSingleLineTextFieldPassword.Text
                        });

                        materialLabelInfo.ForeColor = Color.DarkSeaGreen;
                        materialLabelInfo.Text = "Успешная регистрация";
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