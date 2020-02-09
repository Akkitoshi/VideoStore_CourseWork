namespace VideoStore_View
{
    partial class FormProduct
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
            this.materialSingleLineTextFieldName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldType = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabelInfo = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButtonAddProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelRequiredFields = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialSingleLineTextFieldName
            // 
            this.materialSingleLineTextFieldName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldName.Depth = 0;
            this.materialSingleLineTextFieldName.Hint = "Наименование*";
            this.materialSingleLineTextFieldName.Location = new System.Drawing.Point(41, 112);
            this.materialSingleLineTextFieldName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldName.Name = "materialSingleLineTextFieldName";
            this.materialSingleLineTextFieldName.PasswordChar = '\0';
            this.materialSingleLineTextFieldName.SelectedText = "";
            this.materialSingleLineTextFieldName.SelectionLength = 0;
            this.materialSingleLineTextFieldName.SelectionStart = 0;
            this.materialSingleLineTextFieldName.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldName.TabIndex = 7;
            this.materialSingleLineTextFieldName.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldType
            // 
            this.materialSingleLineTextFieldType.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldType.Depth = 0;
            this.materialSingleLineTextFieldType.Hint = "Тип*";
            this.materialSingleLineTextFieldType.Location = new System.Drawing.Point(41, 141);
            this.materialSingleLineTextFieldType.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldType.Name = "materialSingleLineTextFieldType";
            this.materialSingleLineTextFieldType.PasswordChar = '\0';
            this.materialSingleLineTextFieldType.SelectedText = "";
            this.materialSingleLineTextFieldType.SelectionLength = 0;
            this.materialSingleLineTextFieldType.SelectionStart = 0;
            this.materialSingleLineTextFieldType.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldType.TabIndex = 8;
            this.materialSingleLineTextFieldType.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldPrice
            // 
            this.materialSingleLineTextFieldPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldPrice.Depth = 0;
            this.materialSingleLineTextFieldPrice.Hint = "Цена*";
            this.materialSingleLineTextFieldPrice.Location = new System.Drawing.Point(41, 170);
            this.materialSingleLineTextFieldPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldPrice.Name = "materialSingleLineTextFieldPrice";
            this.materialSingleLineTextFieldPrice.PasswordChar = '\0';
            this.materialSingleLineTextFieldPrice.SelectedText = "";
            this.materialSingleLineTextFieldPrice.SelectionLength = 0;
            this.materialSingleLineTextFieldPrice.SelectionStart = 0;
            this.materialSingleLineTextFieldPrice.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldPrice.TabIndex = 9;
            this.materialSingleLineTextFieldPrice.UseSystemPasswordChar = false;
            // 
            // materialLabelInfo
            // 
            this.materialLabelInfo.AutoSize = true;
            this.materialLabelInfo.BackColor = System.Drawing.Color.Transparent;
            this.materialLabelInfo.Depth = 0;
            this.materialLabelInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelInfo.Location = new System.Drawing.Point(37, 73);
            this.materialLabelInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelInfo.Name = "materialLabelInfo";
            this.materialLabelInfo.Size = new System.Drawing.Size(260, 19);
            this.materialLabelInfo.TabIndex = 14;
            this.materialLabelInfo.Text = "Заполните все обязательные поля";
            // 
            // materialRaisedButtonAddProduct
            // 
            this.materialRaisedButtonAddProduct.Depth = 0;
            this.materialRaisedButtonAddProduct.Location = new System.Drawing.Point(57, 216);
            this.materialRaisedButtonAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAddProduct.Name = "materialRaisedButtonAddProduct";
            this.materialRaisedButtonAddProduct.Primary = true;
            this.materialRaisedButtonAddProduct.Size = new System.Drawing.Size(204, 23);
            this.materialRaisedButtonAddProduct.TabIndex = 15;
            this.materialRaisedButtonAddProduct.Text = "Добавить";
            this.materialRaisedButtonAddProduct.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAddProduct.Click += new System.EventHandler(this.materialRaisedButtonAddProduct_Click);
            // 
            // labelRequiredFields
            // 
            this.labelRequiredFields.AutoSize = true;
            this.labelRequiredFields.BackColor = System.Drawing.Color.Transparent;
            this.labelRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRequiredFields.ForeColor = System.Drawing.Color.Silver;
            this.labelRequiredFields.Location = new System.Drawing.Point(54, 242);
            this.labelRequiredFields.Name = "labelRequiredFields";
            this.labelRequiredFields.Size = new System.Drawing.Size(195, 13);
            this.labelRequiredFields.TabIndex = 16;
            this.labelRequiredFields.Text = "*обязательные для заполнения поля";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 269);
            this.Controls.Add(this.labelRequiredFields);
            this.Controls.Add(this.materialRaisedButtonAddProduct);
            this.Controls.Add(this.materialLabelInfo);
            this.Controls.Add(this.materialSingleLineTextFieldPrice);
            this.Controls.Add(this.materialSingleLineTextFieldType);
            this.Controls.Add(this.materialSingleLineTextFieldName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProduct";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldName;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldType;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabelInfo;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAddProduct;
        private System.Windows.Forms.Label labelRequiredFields;
    }
}