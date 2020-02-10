namespace VideoStore_View
{
    partial class FormClientContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientContract));
            this.labelRequiredFields = new System.Windows.Forms.Label();
            this.materialRaisedButtonAddContract = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabelInfo = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextFieldService = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldClient = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldProduct = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldSumma = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldStart = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldRental = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // labelRequiredFields
            // 
            this.labelRequiredFields.AutoSize = true;
            this.labelRequiredFields.BackColor = System.Drawing.Color.Transparent;
            this.labelRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRequiredFields.ForeColor = System.Drawing.Color.Silver;
            this.labelRequiredFields.Location = new System.Drawing.Point(62, 371);
            this.labelRequiredFields.Name = "labelRequiredFields";
            this.labelRequiredFields.Size = new System.Drawing.Size(195, 13);
            this.labelRequiredFields.TabIndex = 28;
            this.labelRequiredFields.Text = "*обязательные для заполнения поля";
            // 
            // materialRaisedButtonAddContract
            // 
            this.materialRaisedButtonAddContract.Depth = 0;
            this.materialRaisedButtonAddContract.Location = new System.Drawing.Point(65, 345);
            this.materialRaisedButtonAddContract.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAddContract.Name = "materialRaisedButtonAddContract";
            this.materialRaisedButtonAddContract.Primary = true;
            this.materialRaisedButtonAddContract.Size = new System.Drawing.Size(204, 23);
            this.materialRaisedButtonAddContract.TabIndex = 27;
            this.materialRaisedButtonAddContract.Text = "Добавить";
            this.materialRaisedButtonAddContract.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAddContract.Click += new System.EventHandler(this.materialRaisedButtonAddContract_Click);
            // 
            // materialLabelInfo
            // 
            this.materialLabelInfo.AutoSize = true;
            this.materialLabelInfo.BackColor = System.Drawing.Color.Transparent;
            this.materialLabelInfo.Depth = 0;
            this.materialLabelInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelInfo.Location = new System.Drawing.Point(38, 72);
            this.materialLabelInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelInfo.Name = "materialLabelInfo";
            this.materialLabelInfo.Size = new System.Drawing.Size(260, 19);
            this.materialLabelInfo.TabIndex = 26;
            this.materialLabelInfo.Text = "Заполните все обязательные поля";
            // 
            // materialSingleLineTextFieldService
            // 
            this.materialSingleLineTextFieldService.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldService.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldService.Depth = 0;
            this.materialSingleLineTextFieldService.Hint = "Услуга*";
            this.materialSingleLineTextFieldService.Location = new System.Drawing.Point(42, 161);
            this.materialSingleLineTextFieldService.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldService.Name = "materialSingleLineTextFieldService";
            this.materialSingleLineTextFieldService.PasswordChar = '\0';
            this.materialSingleLineTextFieldService.SelectedText = "";
            this.materialSingleLineTextFieldService.SelectionLength = 0;
            this.materialSingleLineTextFieldService.SelectionStart = 0;
            this.materialSingleLineTextFieldService.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldService.TabIndex = 25;
            this.materialSingleLineTextFieldService.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldUser
            // 
            this.materialSingleLineTextFieldUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldUser.Depth = 0;
            this.materialSingleLineTextFieldUser.Hint = "Продавец*";
            this.materialSingleLineTextFieldUser.Location = new System.Drawing.Point(42, 132);
            this.materialSingleLineTextFieldUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldUser.Name = "materialSingleLineTextFieldUser";
            this.materialSingleLineTextFieldUser.PasswordChar = '\0';
            this.materialSingleLineTextFieldUser.SelectedText = "";
            this.materialSingleLineTextFieldUser.SelectionLength = 0;
            this.materialSingleLineTextFieldUser.SelectionStart = 0;
            this.materialSingleLineTextFieldUser.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldUser.TabIndex = 24;
            this.materialSingleLineTextFieldUser.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldClient
            // 
            this.materialSingleLineTextFieldClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldClient.Depth = 0;
            this.materialSingleLineTextFieldClient.Hint = "Клиент*";
            this.materialSingleLineTextFieldClient.Location = new System.Drawing.Point(42, 103);
            this.materialSingleLineTextFieldClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldClient.Name = "materialSingleLineTextFieldClient";
            this.materialSingleLineTextFieldClient.PasswordChar = '\0';
            this.materialSingleLineTextFieldClient.SelectedText = "";
            this.materialSingleLineTextFieldClient.SelectionLength = 0;
            this.materialSingleLineTextFieldClient.SelectionStart = 0;
            this.materialSingleLineTextFieldClient.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldClient.TabIndex = 23;
            this.materialSingleLineTextFieldClient.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldProduct
            // 
            this.materialSingleLineTextFieldProduct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldProduct.Depth = 0;
            this.materialSingleLineTextFieldProduct.Hint = "Товар*";
            this.materialSingleLineTextFieldProduct.Location = new System.Drawing.Point(42, 190);
            this.materialSingleLineTextFieldProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldProduct.Name = "materialSingleLineTextFieldProduct";
            this.materialSingleLineTextFieldProduct.PasswordChar = '\0';
            this.materialSingleLineTextFieldProduct.SelectedText = "";
            this.materialSingleLineTextFieldProduct.SelectionLength = 0;
            this.materialSingleLineTextFieldProduct.SelectionStart = 0;
            this.materialSingleLineTextFieldProduct.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldProduct.TabIndex = 29;
            this.materialSingleLineTextFieldProduct.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldAmount
            // 
            this.materialSingleLineTextFieldAmount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldAmount.Depth = 0;
            this.materialSingleLineTextFieldAmount.Hint = "Количество*";
            this.materialSingleLineTextFieldAmount.Location = new System.Drawing.Point(42, 219);
            this.materialSingleLineTextFieldAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldAmount.Name = "materialSingleLineTextFieldAmount";
            this.materialSingleLineTextFieldAmount.PasswordChar = '\0';
            this.materialSingleLineTextFieldAmount.SelectedText = "";
            this.materialSingleLineTextFieldAmount.SelectionLength = 0;
            this.materialSingleLineTextFieldAmount.SelectionStart = 0;
            this.materialSingleLineTextFieldAmount.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldAmount.TabIndex = 30;
            this.materialSingleLineTextFieldAmount.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldSumma
            // 
            this.materialSingleLineTextFieldSumma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldSumma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldSumma.Depth = 0;
            this.materialSingleLineTextFieldSumma.Hint = "Сумма*";
            this.materialSingleLineTextFieldSumma.Location = new System.Drawing.Point(42, 248);
            this.materialSingleLineTextFieldSumma.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldSumma.Name = "materialSingleLineTextFieldSumma";
            this.materialSingleLineTextFieldSumma.PasswordChar = '\0';
            this.materialSingleLineTextFieldSumma.SelectedText = "";
            this.materialSingleLineTextFieldSumma.SelectionLength = 0;
            this.materialSingleLineTextFieldSumma.SelectionStart = 0;
            this.materialSingleLineTextFieldSumma.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldSumma.TabIndex = 31;
            this.materialSingleLineTextFieldSumma.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldStart
            // 
            this.materialSingleLineTextFieldStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldStart.Depth = 0;
            this.materialSingleLineTextFieldStart.Hint = "Дата заключения*";
            this.materialSingleLineTextFieldStart.Location = new System.Drawing.Point(42, 277);
            this.materialSingleLineTextFieldStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldStart.Name = "materialSingleLineTextFieldStart";
            this.materialSingleLineTextFieldStart.PasswordChar = '\0';
            this.materialSingleLineTextFieldStart.SelectedText = "";
            this.materialSingleLineTextFieldStart.SelectionLength = 0;
            this.materialSingleLineTextFieldStart.SelectionStart = 0;
            this.materialSingleLineTextFieldStart.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldStart.TabIndex = 32;
            this.materialSingleLineTextFieldStart.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldRental
            // 
            this.materialSingleLineTextFieldRental.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldRental.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextFieldRental.Depth = 0;
            this.materialSingleLineTextFieldRental.Hint = "Срок проката*";
            this.materialSingleLineTextFieldRental.Location = new System.Drawing.Point(42, 306);
            this.materialSingleLineTextFieldRental.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldRental.Name = "materialSingleLineTextFieldRental";
            this.materialSingleLineTextFieldRental.PasswordChar = '\0';
            this.materialSingleLineTextFieldRental.SelectedText = "";
            this.materialSingleLineTextFieldRental.SelectionLength = 0;
            this.materialSingleLineTextFieldRental.SelectionStart = 0;
            this.materialSingleLineTextFieldRental.Size = new System.Drawing.Size(239, 23);
            this.materialSingleLineTextFieldRental.TabIndex = 33;
            this.materialSingleLineTextFieldRental.UseSystemPasswordChar = false;
            // 
            // FormClientContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 429);
            this.Controls.Add(this.materialSingleLineTextFieldRental);
            this.Controls.Add(this.materialSingleLineTextFieldStart);
            this.Controls.Add(this.materialSingleLineTextFieldSumma);
            this.Controls.Add(this.materialSingleLineTextFieldAmount);
            this.Controls.Add(this.materialSingleLineTextFieldProduct);
            this.Controls.Add(this.labelRequiredFields);
            this.Controls.Add(this.materialRaisedButtonAddContract);
            this.Controls.Add(this.materialLabelInfo);
            this.Controls.Add(this.materialSingleLineTextFieldService);
            this.Controls.Add(this.materialSingleLineTextFieldUser);
            this.Controls.Add(this.materialSingleLineTextFieldClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientContract";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRequiredFields;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAddContract;
        private MaterialSkin.Controls.MaterialLabel materialLabelInfo;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldService;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldClient;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldProduct;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldAmount;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldSumma;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldStart;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldRental;
    }
}