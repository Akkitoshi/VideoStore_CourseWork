namespace VideoStore_View
{
    partial class FormAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
            this.materialRaisedButtonSignIn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonSignUp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabelInfo = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.SuspendLayout();
            // 
            // materialRaisedButtonSignIn
            // 
            this.materialRaisedButtonSignIn.Depth = 0;
            this.materialRaisedButtonSignIn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.materialRaisedButtonSignIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialRaisedButtonSignIn.Location = new System.Drawing.Point(66, 173);
            this.materialRaisedButtonSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonSignIn.Name = "materialRaisedButtonSignIn";
            this.materialRaisedButtonSignIn.Primary = true;
            this.materialRaisedButtonSignIn.Size = new System.Drawing.Size(204, 23);
            this.materialRaisedButtonSignIn.TabIndex = 2;
            this.materialRaisedButtonSignIn.Text = "ВОЙТИ";
            this.materialRaisedButtonSignIn.UseVisualStyleBackColor = true;
            this.materialRaisedButtonSignIn.Click += new System.EventHandler(this.materialRaisedButtonSignIn_Click);
            // 
            // materialRaisedButtonSignUp
            // 
            this.materialRaisedButtonSignUp.Depth = 0;
            this.materialRaisedButtonSignUp.Location = new System.Drawing.Point(66, 202);
            this.materialRaisedButtonSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonSignUp.Name = "materialRaisedButtonSignUp";
            this.materialRaisedButtonSignUp.Primary = true;
            this.materialRaisedButtonSignUp.Size = new System.Drawing.Size(204, 23);
            this.materialRaisedButtonSignUp.TabIndex = 3;
            this.materialRaisedButtonSignUp.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            this.materialRaisedButtonSignUp.UseVisualStyleBackColor = true;
            this.materialRaisedButtonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // materialSingleLineTextFieldLogin
            // 
            this.materialSingleLineTextFieldLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldLogin.Depth = 0;
            this.materialSingleLineTextFieldLogin.Hint = "Логин";
            this.materialSingleLineTextFieldLogin.Location = new System.Drawing.Point(47, 110);
            this.materialSingleLineTextFieldLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldLogin.Name = "materialSingleLineTextFieldLogin";
            this.materialSingleLineTextFieldLogin.PasswordChar = '\0';
            this.materialSingleLineTextFieldLogin.SelectedText = "";
            this.materialSingleLineTextFieldLogin.SelectionLength = 0;
            this.materialSingleLineTextFieldLogin.SelectionStart = 0;
            this.materialSingleLineTextFieldLogin.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldLogin.TabIndex = 4;
            this.materialSingleLineTextFieldLogin.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldPassword
            // 
            this.materialSingleLineTextFieldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldPassword.Depth = 0;
            this.materialSingleLineTextFieldPassword.Hint = "Пароль";
            this.materialSingleLineTextFieldPassword.Location = new System.Drawing.Point(47, 139);
            this.materialSingleLineTextFieldPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldPassword.Name = "materialSingleLineTextFieldPassword";
            this.materialSingleLineTextFieldPassword.PasswordChar = '*';
            this.materialSingleLineTextFieldPassword.SelectedText = "";
            this.materialSingleLineTextFieldPassword.SelectionLength = 0;
            this.materialSingleLineTextFieldPassword.SelectionStart = 0;
            this.materialSingleLineTextFieldPassword.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldPassword.TabIndex = 5;
            this.materialSingleLineTextFieldPassword.UseSystemPasswordChar = false;
            // 
            // materialLabelInfo
            // 
            this.materialLabelInfo.AllowDrop = true;
            this.materialLabelInfo.AutoSize = true;
            this.materialLabelInfo.BackColor = System.Drawing.Color.Transparent;
            this.materialLabelInfo.Depth = 0;
            this.materialLabelInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelInfo.Location = new System.Drawing.Point(74, 71);
            this.materialLabelInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelInfo.Name = "materialLabelInfo";
            this.materialLabelInfo.Size = new System.Drawing.Size(182, 19);
            this.materialLabelInfo.TabIndex = 6;
            this.materialLabelInfo.Text = "Введите логин и пароль";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackColor = System.Drawing.Color.White;
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.materialTabSelector1.Location = new System.Drawing.Point(249, 30);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(75, 23);
            this.materialTabSelector1.TabIndex = 7;
            this.materialTabSelector1.Text = "тема";
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(336, 237);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialLabelInfo);
            this.Controls.Add(this.materialSingleLineTextFieldPassword);
            this.Controls.Add(this.materialSingleLineTextFieldLogin);
            this.Controls.Add(this.materialRaisedButtonSignUp);
            this.Controls.Add(this.materialRaisedButtonSignIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonSignIn;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonSignUp;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabelInfo;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}