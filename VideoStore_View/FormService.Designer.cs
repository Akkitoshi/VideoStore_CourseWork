namespace VideoStore_View
{
    partial class FormService
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
            this.labelRequiredFields = new System.Windows.Forms.Label();
            this.materialRaisedButtonAddService = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabelInfo = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextFieldName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // labelRequiredFields
            // 
            this.labelRequiredFields.AutoSize = true;
            this.labelRequiredFields.BackColor = System.Drawing.Color.Transparent;
            this.labelRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRequiredFields.ForeColor = System.Drawing.Color.Silver;
            this.labelRequiredFields.Location = new System.Drawing.Point(54, 175);
            this.labelRequiredFields.Name = "labelRequiredFields";
            this.labelRequiredFields.Size = new System.Drawing.Size(195, 13);
            this.labelRequiredFields.TabIndex = 21;
            this.labelRequiredFields.Text = "*обязательные для заполнения поля";
            // 
            // materialRaisedButtonAddService
            // 
            this.materialRaisedButtonAddService.Depth = 0;
            this.materialRaisedButtonAddService.Location = new System.Drawing.Point(57, 149);
            this.materialRaisedButtonAddService.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAddService.Name = "materialRaisedButtonAddService";
            this.materialRaisedButtonAddService.Primary = true;
            this.materialRaisedButtonAddService.Size = new System.Drawing.Size(204, 23);
            this.materialRaisedButtonAddService.TabIndex = 20;
            this.materialRaisedButtonAddService.Text = "Добавить";
            this.materialRaisedButtonAddService.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAddService.Click += new System.EventHandler(this.materialRaisedButtonAddService_Click);
            // 
            // materialLabelInfo
            // 
            this.materialLabelInfo.AutoSize = true;
            this.materialLabelInfo.BackColor = System.Drawing.Color.Transparent;
            this.materialLabelInfo.Depth = 0;
            this.materialLabelInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelInfo.Location = new System.Drawing.Point(37, 70);
            this.materialLabelInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelInfo.Name = "materialLabelInfo";
            this.materialLabelInfo.Size = new System.Drawing.Size(260, 19);
            this.materialLabelInfo.TabIndex = 19;
            this.materialLabelInfo.Text = "Заполните все обязательные поля";
            // 
            // materialSingleLineTextFieldName
            // 
            this.materialSingleLineTextFieldName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldName.Depth = 0;
            this.materialSingleLineTextFieldName.Hint = "Наименование*";
            this.materialSingleLineTextFieldName.Location = new System.Drawing.Point(41, 109);
            this.materialSingleLineTextFieldName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldName.Name = "materialSingleLineTextFieldName";
            this.materialSingleLineTextFieldName.PasswordChar = '\0';
            this.materialSingleLineTextFieldName.SelectedText = "";
            this.materialSingleLineTextFieldName.SelectionLength = 0;
            this.materialSingleLineTextFieldName.SelectionStart = 0;
            this.materialSingleLineTextFieldName.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldName.TabIndex = 17;
            this.materialSingleLineTextFieldName.UseSystemPasswordChar = false;
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 201);
            this.Controls.Add(this.labelRequiredFields);
            this.Controls.Add(this.materialRaisedButtonAddService);
            this.Controls.Add(this.materialLabelInfo);
            this.Controls.Add(this.materialSingleLineTextFieldName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormService";
            this.Sizable = false;
            this.Text = "Услуга";
            this.Load += new System.EventHandler(this.materialRaisedButtonAddService_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRequiredFields;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAddService;
        private MaterialSkin.Controls.MaterialLabel materialLabelInfo;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldName;
    }
}