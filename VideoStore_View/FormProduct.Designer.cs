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
            this.materialSingleLineTextFieldFIO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabelInfo = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButtonAddProduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelRequiredFields = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialSingleLineTextFieldFIO
            // 
            this.materialSingleLineTextFieldFIO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldFIO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldFIO.Depth = 0;
            this.materialSingleLineTextFieldFIO.Hint = "Наименование*";
            this.materialSingleLineTextFieldFIO.Location = new System.Drawing.Point(41, 112);
            this.materialSingleLineTextFieldFIO.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldFIO.Name = "materialSingleLineTextFieldFIO";
            this.materialSingleLineTextFieldFIO.PasswordChar = '\0';
            this.materialSingleLineTextFieldFIO.SelectedText = "";
            this.materialSingleLineTextFieldFIO.SelectionLength = 0;
            this.materialSingleLineTextFieldFIO.SelectionStart = 0;
            this.materialSingleLineTextFieldFIO.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldFIO.TabIndex = 7;
            this.materialSingleLineTextFieldFIO.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextField1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Тип*";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(41, 141);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextField1.TabIndex = 8;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextField2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Цена*";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(41, 170);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextField2.TabIndex = 9;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
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
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.materialSingleLineTextFieldFIO);
            this.Name = "FormProduct";
            this.Text = "Товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldFIO;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialLabel materialLabelInfo;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAddProduct;
        private System.Windows.Forms.Label labelRequiredFields;
    }
}