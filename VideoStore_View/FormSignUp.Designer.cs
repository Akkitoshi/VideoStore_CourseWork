namespace VideoStore_View
{
    partial class FormSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialSingleLineTextFieldFIO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldPosition = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialComboBoxRole = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButtonSignUp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabelInfo = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialSingleLineTextFieldFIO
            // 
            this.materialSingleLineTextFieldFIO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldFIO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldFIO.Depth = 0;
            this.materialSingleLineTextFieldFIO.Hint = "ФИО*";
            this.materialSingleLineTextFieldFIO.Location = new System.Drawing.Point(42, 101);
            this.materialSingleLineTextFieldFIO.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldFIO.Name = "materialSingleLineTextFieldFIO";
            this.materialSingleLineTextFieldFIO.PasswordChar = '\0';
            this.materialSingleLineTextFieldFIO.SelectedText = "";
            this.materialSingleLineTextFieldFIO.SelectionLength = 0;
            this.materialSingleLineTextFieldFIO.SelectionStart = 0;
            this.materialSingleLineTextFieldFIO.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldFIO.TabIndex = 6;
            this.materialSingleLineTextFieldFIO.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldLogin
            // 
            this.materialSingleLineTextFieldLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldLogin.Depth = 0;
            this.materialSingleLineTextFieldLogin.Hint = "Логин*";
            this.materialSingleLineTextFieldLogin.Location = new System.Drawing.Point(42, 188);
            this.materialSingleLineTextFieldLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldLogin.Name = "materialSingleLineTextFieldLogin";
            this.materialSingleLineTextFieldLogin.PasswordChar = '\0';
            this.materialSingleLineTextFieldLogin.SelectedText = "";
            this.materialSingleLineTextFieldLogin.SelectionLength = 0;
            this.materialSingleLineTextFieldLogin.SelectionStart = 0;
            this.materialSingleLineTextFieldLogin.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldLogin.TabIndex = 7;
            this.materialSingleLineTextFieldLogin.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldPassword
            // 
            this.materialSingleLineTextFieldPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldPassword.Depth = 0;
            this.materialSingleLineTextFieldPassword.Hint = "Пароль*";
            this.materialSingleLineTextFieldPassword.Location = new System.Drawing.Point(42, 217);
            this.materialSingleLineTextFieldPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldPassword.Name = "materialSingleLineTextFieldPassword";
            this.materialSingleLineTextFieldPassword.PasswordChar = '*';
            this.materialSingleLineTextFieldPassword.SelectedText = "";
            this.materialSingleLineTextFieldPassword.SelectionLength = 0;
            this.materialSingleLineTextFieldPassword.SelectionStart = 0;
            this.materialSingleLineTextFieldPassword.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldPassword.TabIndex = 8;
            this.materialSingleLineTextFieldPassword.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldPosition
            // 
            this.materialSingleLineTextFieldPosition.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldPosition.Depth = 0;
            this.materialSingleLineTextFieldPosition.Hint = "Должность*";
            this.materialSingleLineTextFieldPosition.Location = new System.Drawing.Point(42, 159);
            this.materialSingleLineTextFieldPosition.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldPosition.Name = "materialSingleLineTextFieldPosition";
            this.materialSingleLineTextFieldPosition.PasswordChar = '\0';
            this.materialSingleLineTextFieldPosition.SelectedText = "";
            this.materialSingleLineTextFieldPosition.SelectionLength = 0;
            this.materialSingleLineTextFieldPosition.SelectionStart = 0;
            this.materialSingleLineTextFieldPosition.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldPosition.TabIndex = 9;
            this.materialSingleLineTextFieldPosition.UseSystemPasswordChar = false;
            // 
            // materialComboBoxRole
            // 
            this.materialComboBoxRole.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.materialComboBoxRole.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialComboBoxRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialComboBoxRole.Depth = 0;
            this.materialComboBoxRole.Hint = "Роль*";
            this.materialComboBoxRole.Location = new System.Drawing.Point(42, 130);
            this.materialComboBoxRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialComboBoxRole.Name = "materialComboBoxRole";
            this.materialComboBoxRole.PasswordChar = '\0';
            this.materialComboBoxRole.SelectedText = "";
            this.materialComboBoxRole.SelectionLength = 0;
            this.materialComboBoxRole.SelectionStart = 0;
            this.materialComboBoxRole.Size = new System.Drawing.Size(239, 23);
            this.materialComboBoxRole.TabIndex = 10;
            this.materialComboBoxRole.Text = "Продавец-консультант";
            this.materialComboBoxRole.UseSystemPasswordChar = false;
            // 
            // materialRaisedButtonSignUp
            // 
            this.materialRaisedButtonSignUp.Depth = 0;
            this.materialRaisedButtonSignUp.Location = new System.Drawing.Point(58, 255);
            this.materialRaisedButtonSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonSignUp.Name = "materialRaisedButtonSignUp";
            this.materialRaisedButtonSignUp.Primary = true;
            this.materialRaisedButtonSignUp.Size = new System.Drawing.Size(204, 23);
            this.materialRaisedButtonSignUp.TabIndex = 11;
            this.materialRaisedButtonSignUp.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            this.materialRaisedButtonSignUp.UseVisualStyleBackColor = true;
            this.materialRaisedButtonSignUp.Click += new System.EventHandler(this.materialRaisedButtonSignUp_Click);
            // 
            // materialLabelInfo
            // 
            this.materialLabelInfo.AutoSize = true;
            this.materialLabelInfo.BackColor = System.Drawing.Color.Transparent;
            this.materialLabelInfo.Depth = 0;
            this.materialLabelInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelInfo.Location = new System.Drawing.Point(38, 70);
            this.materialLabelInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelInfo.Name = "materialLabelInfo";
            this.materialLabelInfo.Size = new System.Drawing.Size(260, 19);
            this.materialLabelInfo.TabIndex = 13;
            this.materialLabelInfo.Text = "Заполните все обязательные поля";
            // 
            // materialLabel1
            // 
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Cursor = System.Windows.Forms.Cursors.Help;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.materialLabel1.ForeColor = System.Drawing.Color.Silver;
            this.materialLabel1.Location = new System.Drawing.Point(42, 288);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(239, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "*обязательные для заполнения поля";
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 316);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabelInfo);
            this.Controls.Add(this.materialRaisedButtonSignUp);
            this.Controls.Add(this.materialComboBoxRole);
            this.Controls.Add(this.materialSingleLineTextFieldPosition);
            this.Controls.Add(this.materialSingleLineTextFieldPassword);
            this.Controls.Add(this.materialSingleLineTextFieldLogin);
            this.Controls.Add(this.materialSingleLineTextFieldFIO);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldFIO;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldPosition;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialComboBoxRole;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonSignUp;
        private MaterialSkin.Controls.MaterialLabel materialLabelInfo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}