namespace VideoStore_View
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.labelRequiredFields = new System.Windows.Forms.Label();
            this.materialRaisedButtonAddClient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabelInfo = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextFieldPassport = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldFIO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // labelRequiredFields
            // 
            this.labelRequiredFields.AutoSize = true;
            this.labelRequiredFields.BackColor = System.Drawing.Color.Transparent;
            this.labelRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRequiredFields.ForeColor = System.Drawing.Color.Silver;
            this.labelRequiredFields.Location = new System.Drawing.Point(55, 212);
            this.labelRequiredFields.Name = "labelRequiredFields";
            this.labelRequiredFields.Size = new System.Drawing.Size(195, 13);
            this.labelRequiredFields.TabIndex = 22;
            this.labelRequiredFields.Text = "*обязательные для заполнения поля";
            // 
            // materialRaisedButtonAddClient
            // 
            this.materialRaisedButtonAddClient.Depth = 0;
            this.materialRaisedButtonAddClient.Location = new System.Drawing.Point(58, 186);
            this.materialRaisedButtonAddClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAddClient.Name = "materialRaisedButtonAddClient";
            this.materialRaisedButtonAddClient.Primary = true;
            this.materialRaisedButtonAddClient.Size = new System.Drawing.Size(204, 23);
            this.materialRaisedButtonAddClient.TabIndex = 21;
            this.materialRaisedButtonAddClient.Text = "Добавить";
            this.materialRaisedButtonAddClient.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAddClient.Click += new System.EventHandler(this.materialRaisedButtonAddClient_Click);
            // 
            // materialLabelInfo
            // 
            this.materialLabelInfo.AutoSize = true;
            this.materialLabelInfo.BackColor = System.Drawing.Color.Transparent;
            this.materialLabelInfo.Depth = 0;
            this.materialLabelInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelInfo.Location = new System.Drawing.Point(37, 78);
            this.materialLabelInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelInfo.Name = "materialLabelInfo";
            this.materialLabelInfo.Size = new System.Drawing.Size(260, 19);
            this.materialLabelInfo.TabIndex = 20;
            this.materialLabelInfo.Text = "Заполните все обязательные поля";
            // 
            // materialSingleLineTextFieldPassport
            // 
            this.materialSingleLineTextFieldPassport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldPassport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldPassport.Depth = 0;
            this.materialSingleLineTextFieldPassport.Hint = "Номер паспорта*";
            this.materialSingleLineTextFieldPassport.Location = new System.Drawing.Point(41, 146);
            this.materialSingleLineTextFieldPassport.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldPassport.Name = "materialSingleLineTextFieldPassport";
            this.materialSingleLineTextFieldPassport.PasswordChar = '\0';
            this.materialSingleLineTextFieldPassport.SelectedText = "";
            this.materialSingleLineTextFieldPassport.SelectionLength = 0;
            this.materialSingleLineTextFieldPassport.SelectionStart = 0;
            this.materialSingleLineTextFieldPassport.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldPassport.TabIndex = 18;
            this.materialSingleLineTextFieldPassport.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldFIO
            // 
            this.materialSingleLineTextFieldFIO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldFIO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldFIO.Depth = 0;
            this.materialSingleLineTextFieldFIO.Hint = "ФИО*";
            this.materialSingleLineTextFieldFIO.Location = new System.Drawing.Point(41, 117);
            this.materialSingleLineTextFieldFIO.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldFIO.Name = "materialSingleLineTextFieldFIO";
            this.materialSingleLineTextFieldFIO.PasswordChar = '\0';
            this.materialSingleLineTextFieldFIO.SelectedText = "";
            this.materialSingleLineTextFieldFIO.SelectionLength = 0;
            this.materialSingleLineTextFieldFIO.SelectionStart = 0;
            this.materialSingleLineTextFieldFIO.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldFIO.TabIndex = 17;
            this.materialSingleLineTextFieldFIO.UseSystemPasswordChar = false;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 246);
            this.Controls.Add(this.labelRequiredFields);
            this.Controls.Add(this.materialRaisedButtonAddClient);
            this.Controls.Add(this.materialLabelInfo);
            this.Controls.Add(this.materialSingleLineTextFieldPassport);
            this.Controls.Add(this.materialSingleLineTextFieldFIO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClient";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRequiredFields;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAddClient;
        private MaterialSkin.Controls.MaterialLabel materialLabelInfo;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldPassport;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldFIO;
    }
}