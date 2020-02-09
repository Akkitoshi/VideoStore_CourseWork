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


        public FormSignUp(AuthController service)
        {
            this.service = service;
            InitializeComponent();
        }
        private void materialRaisedButtonSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialSingleLineTextFieldFIO.Text))
            {
                materialLabelInfo.ForeColor = Color.Red;
                materialLabelInfo.Text = "Заполните поле ФИО";
            }
            else
            {
                materialLabelInfo.ForeColor = Color.Gray;
                materialLabelInfo.Text = "Заполните обязательные поля";
                if (string.IsNullOrEmpty(materialComboBoxRole.Hint))
                {
                    materialLabelInfo.ForeColor = Color.Red;
                    materialLabelInfo.Text = "Выберите роль";
                }
                else
                {
                    materialLabelInfo.ForeColor = Color.Gray;
                    materialLabelInfo.Text = "Заполните обязательные поля";
                    if (string.IsNullOrEmpty(materialSingleLineTextFieldPosition.Text))
                    {
                        materialLabelInfo.ForeColor = Color.Red;
                        materialLabelInfo.Text = "Заполните поле должность";
                    }
                    else
                    {
                        materialLabelInfo.ForeColor = Color.Gray;
                        materialLabelInfo.Text = "Заполните обязательные поля";

                        if (string.IsNullOrEmpty(materialSingleLineTextFieldLogin.Text))
                        {
                            materialLabelInfo.ForeColor = Color.Red;
                            materialLabelInfo.Text = "Задайте логин";
                        }
                        else
                        {
                            materialLabelInfo.ForeColor = Color.Gray;
                            materialLabelInfo.Text = "Заполните обязательные поля";

                            if (string.IsNullOrEmpty(materialSingleLineTextFieldPassword.Text))
                            {
                                materialLabelInfo.ForeColor = Color.Red;
                                materialLabelInfo.Text = "Задайте пароль";

                            }
                        }

                    }
                }


                if (!string.IsNullOrEmpty(materialSingleLineTextFieldPassword.Text) && !string.IsNullOrEmpty(materialSingleLineTextFieldLogin.Text) && !string.IsNullOrEmpty(materialSingleLineTextFieldPosition.Text) && !string.IsNullOrEmpty(materialComboBoxRole.Hint) && !string.IsNullOrEmpty(materialSingleLineTextFieldFIO.Text))
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
                        materialSingleLineTextFieldFIO.Enabled = false;
                        materialComboBoxRole.Enabled = false;
                        materialSingleLineTextFieldPosition.Enabled = false;
                        materialSingleLineTextFieldLogin.Enabled = false;
                        materialSingleLineTextFieldPassword.Enabled = false;
                        materialRaisedButtonSignUp.Enabled = false;
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