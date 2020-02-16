namespace VideoStore_View
{
    partial class FormClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.materialRaisedButtonAddClient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialRaisedButtonCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldFIO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButtonSearchByPassport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButtonSearchByFio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldPassportNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButtonWithoutPenalties = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonWithPenalties = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabelError = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButtonFrequency = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldPenalties = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButtonPenalties = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldFIOClent = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButtonDel = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialRaisedButtonAddClient
            // 
            this.materialRaisedButtonAddClient.Depth = 0;
            this.materialRaisedButtonAddClient.Location = new System.Drawing.Point(428, 502);
            this.materialRaisedButtonAddClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAddClient.Name = "materialRaisedButtonAddClient";
            this.materialRaisedButtonAddClient.Primary = true;
            this.materialRaisedButtonAddClient.Size = new System.Drawing.Size(310, 23);
            this.materialRaisedButtonAddClient.TabIndex = 0;
            this.materialRaisedButtonAddClient.Text = " Добавить клиента";
            this.materialRaisedButtonAddClient.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAddClient.Click += new System.EventHandler(this.materialRaisedButtonAddClient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(731, 317);
            this.dataGridView1.TabIndex = 1;
            // 
            // materialRaisedButtonCancel
            // 
            this.materialRaisedButtonCancel.Depth = 0;
            this.materialRaisedButtonCancel.Location = new System.Drawing.Point(598, 558);
            this.materialRaisedButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonCancel.Name = "materialRaisedButtonCancel";
            this.materialRaisedButtonCancel.Primary = true;
            this.materialRaisedButtonCancel.Size = new System.Drawing.Size(140, 23);
            this.materialRaisedButtonCancel.TabIndex = 3;
            this.materialRaisedButtonCancel.Text = "сбросить";
            this.materialRaisedButtonCancel.UseVisualStyleBackColor = true;
            this.materialRaisedButtonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // materialSingleLineTextFieldFIO
            // 
            this.materialSingleLineTextFieldFIO.Depth = 0;
            this.materialSingleLineTextFieldFIO.Hint = "ФИО клиента";
            this.materialSingleLineTextFieldFIO.Location = new System.Drawing.Point(12, 415);
            this.materialSingleLineTextFieldFIO.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldFIO.Name = "materialSingleLineTextFieldFIO";
            this.materialSingleLineTextFieldFIO.PasswordChar = '\0';
            this.materialSingleLineTextFieldFIO.SelectedText = "";
            this.materialSingleLineTextFieldFIO.SelectionLength = 0;
            this.materialSingleLineTextFieldFIO.SelectionStart = 0;
            this.materialSingleLineTextFieldFIO.Size = new System.Drawing.Size(310, 23);
            this.materialSingleLineTextFieldFIO.TabIndex = 5;
            this.materialSingleLineTextFieldFIO.UseSystemPasswordChar = false;
            // 
            // materialRaisedButtonSearchByPassport
            // 
            this.materialRaisedButtonSearchByPassport.Depth = 0;
            this.materialRaisedButtonSearchByPassport.Location = new System.Drawing.Point(328, 444);
            this.materialRaisedButtonSearchByPassport.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonSearchByPassport.Name = "materialRaisedButtonSearchByPassport";
            this.materialRaisedButtonSearchByPassport.Primary = true;
            this.materialRaisedButtonSearchByPassport.Size = new System.Drawing.Size(84, 23);
            this.materialRaisedButtonSearchByPassport.TabIndex = 7;
            this.materialRaisedButtonSearchByPassport.Text = "ПОИСК";
            this.materialRaisedButtonSearchByPassport.UseVisualStyleBackColor = true;
            this.materialRaisedButtonSearchByPassport.Click += new System.EventHandler(this.materialRaisedButtonSearchByPassport_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 393);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(116, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Поиск клиента";
            // 
            // materialRaisedButtonSearchByFio
            // 
            this.materialRaisedButtonSearchByFio.Depth = 0;
            this.materialRaisedButtonSearchByFio.Location = new System.Drawing.Point(328, 415);
            this.materialRaisedButtonSearchByFio.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonSearchByFio.Name = "materialRaisedButtonSearchByFio";
            this.materialRaisedButtonSearchByFio.Primary = true;
            this.materialRaisedButtonSearchByFio.Size = new System.Drawing.Size(84, 23);
            this.materialRaisedButtonSearchByFio.TabIndex = 9;
            this.materialRaisedButtonSearchByFio.Text = "ПОИСК";
            this.materialRaisedButtonSearchByFio.UseVisualStyleBackColor = true;
            this.materialRaisedButtonSearchByFio.Click += new System.EventHandler(this.materialRaisedButtonSearchByFio_Click);
            // 
            // materialSingleLineTextFieldPassportNumber
            // 
            this.materialSingleLineTextFieldPassportNumber.Depth = 0;
            this.materialSingleLineTextFieldPassportNumber.Hint = "Номер паспорта";
            this.materialSingleLineTextFieldPassportNumber.Location = new System.Drawing.Point(12, 444);
            this.materialSingleLineTextFieldPassportNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldPassportNumber.Name = "materialSingleLineTextFieldPassportNumber";
            this.materialSingleLineTextFieldPassportNumber.PasswordChar = '\0';
            this.materialSingleLineTextFieldPassportNumber.SelectedText = "";
            this.materialSingleLineTextFieldPassportNumber.SelectionLength = 0;
            this.materialSingleLineTextFieldPassportNumber.SelectionStart = 0;
            this.materialSingleLineTextFieldPassportNumber.Size = new System.Drawing.Size(310, 23);
            this.materialSingleLineTextFieldPassportNumber.TabIndex = 10;
            this.materialSingleLineTextFieldPassportNumber.UseSystemPasswordChar = false;
            // 
            // materialRaisedButtonWithoutPenalties
            // 
            this.materialRaisedButtonWithoutPenalties.Depth = 0;
            this.materialRaisedButtonWithoutPenalties.Location = new System.Drawing.Point(428, 473);
            this.materialRaisedButtonWithoutPenalties.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonWithoutPenalties.Name = "materialRaisedButtonWithoutPenalties";
            this.materialRaisedButtonWithoutPenalties.Primary = true;
            this.materialRaisedButtonWithoutPenalties.Size = new System.Drawing.Size(310, 23);
            this.materialRaisedButtonWithoutPenalties.TabIndex = 11;
            this.materialRaisedButtonWithoutPenalties.Text = "Клиенты с начисленными пени";
            this.materialRaisedButtonWithoutPenalties.UseVisualStyleBackColor = true;
            this.materialRaisedButtonWithoutPenalties.Click += new System.EventHandler(this.materialRaisedButtonWithoutPenalties_Click);
            // 
            // materialRaisedButtonWithPenalties
            // 
            this.materialRaisedButtonWithPenalties.Depth = 0;
            this.materialRaisedButtonWithPenalties.Location = new System.Drawing.Point(428, 444);
            this.materialRaisedButtonWithPenalties.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonWithPenalties.Name = "materialRaisedButtonWithPenalties";
            this.materialRaisedButtonWithPenalties.Primary = true;
            this.materialRaisedButtonWithPenalties.Size = new System.Drawing.Size(310, 23);
            this.materialRaisedButtonWithPenalties.TabIndex = 12;
            this.materialRaisedButtonWithPenalties.Text = "Клиенты без начисленных пени";
            this.materialRaisedButtonWithPenalties.UseVisualStyleBackColor = true;
            this.materialRaisedButtonWithPenalties.Click += new System.EventHandler(this.materialRaisedButtonWithPenalties_Click);
            // 
            // materialLabelError
            // 
            this.materialLabelError.AutoSize = true;
            this.materialLabelError.BackColor = System.Drawing.Color.Transparent;
            this.materialLabelError.Depth = 0;
            this.materialLabelError.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelError.Location = new System.Drawing.Point(12, 477);
            this.materialLabelError.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelError.Name = "materialLabelError";
            this.materialLabelError.Size = new System.Drawing.Size(13, 19);
            this.materialLabelError.TabIndex = 13;
            this.materialLabelError.Text = "-";
            // 
            // materialRaisedButtonFrequency
            // 
            this.materialRaisedButtonFrequency.Depth = 0;
            this.materialRaisedButtonFrequency.Location = new System.Drawing.Point(428, 415);
            this.materialRaisedButtonFrequency.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonFrequency.Name = "materialRaisedButtonFrequency";
            this.materialRaisedButtonFrequency.Primary = true;
            this.materialRaisedButtonFrequency.Size = new System.Drawing.Size(310, 23);
            this.materialRaisedButtonFrequency.TabIndex = 14;
            this.materialRaisedButtonFrequency.Text = "Клиенты по количеству обращений";
            this.materialRaisedButtonFrequency.UseVisualStyleBackColor = true;
            this.materialRaisedButtonFrequency.Click += new System.EventHandler(this.materialRaisedButtonFrequency_Click);
            // 
            // materialSingleLineTextFieldPenalties
            // 
            this.materialSingleLineTextFieldPenalties.Depth = 0;
            this.materialSingleLineTextFieldPenalties.Hint = "Пени";
            this.materialSingleLineTextFieldPenalties.Location = new System.Drawing.Point(12, 560);
            this.materialSingleLineTextFieldPenalties.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldPenalties.Name = "materialSingleLineTextFieldPenalties";
            this.materialSingleLineTextFieldPenalties.PasswordChar = '\0';
            this.materialSingleLineTextFieldPenalties.SelectedText = "";
            this.materialSingleLineTextFieldPenalties.SelectionLength = 0;
            this.materialSingleLineTextFieldPenalties.SelectionStart = 0;
            this.materialSingleLineTextFieldPenalties.Size = new System.Drawing.Size(310, 23);
            this.materialSingleLineTextFieldPenalties.TabIndex = 30;
            this.materialSingleLineTextFieldPenalties.UseSystemPasswordChar = false;
            // 
            // materialRaisedButtonPenalties
            // 
            this.materialRaisedButtonPenalties.Depth = 0;
            this.materialRaisedButtonPenalties.Location = new System.Drawing.Point(328, 560);
            this.materialRaisedButtonPenalties.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonPenalties.Name = "materialRaisedButtonPenalties";
            this.materialRaisedButtonPenalties.Primary = true;
            this.materialRaisedButtonPenalties.Size = new System.Drawing.Size(140, 23);
            this.materialRaisedButtonPenalties.TabIndex = 28;
            this.materialRaisedButtonPenalties.Text = "Начислить пени";
            this.materialRaisedButtonPenalties.UseVisualStyleBackColor = true;
            this.materialRaisedButtonPenalties.Click += new System.EventHandler(this.materialRaisedButtonPenalties_Click);
            // 
            // materialSingleLineTextFieldFIOClent
            // 
            this.materialSingleLineTextFieldFIOClent.Depth = 0;
            this.materialSingleLineTextFieldFIOClent.Hint = "ФИО клиента";
            this.materialSingleLineTextFieldFIOClent.Location = new System.Drawing.Point(12, 531);
            this.materialSingleLineTextFieldFIOClent.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldFIOClent.Name = "materialSingleLineTextFieldFIOClent";
            this.materialSingleLineTextFieldFIOClent.PasswordChar = '\0';
            this.materialSingleLineTextFieldFIOClent.SelectedText = "";
            this.materialSingleLineTextFieldFIOClent.SelectionLength = 0;
            this.materialSingleLineTextFieldFIOClent.SelectionStart = 0;
            this.materialSingleLineTextFieldFIOClent.Size = new System.Drawing.Size(310, 23);
            this.materialSingleLineTextFieldFIOClent.TabIndex = 27;
            this.materialSingleLineTextFieldFIOClent.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldId
            // 
            this.materialSingleLineTextFieldId.Depth = 0;
            this.materialSingleLineTextFieldId.Hint = "ID клиента";
            this.materialSingleLineTextFieldId.Location = new System.Drawing.Point(12, 596);
            this.materialSingleLineTextFieldId.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldId.Name = "materialSingleLineTextFieldId";
            this.materialSingleLineTextFieldId.PasswordChar = '\0';
            this.materialSingleLineTextFieldId.SelectedText = "";
            this.materialSingleLineTextFieldId.SelectionLength = 0;
            this.materialSingleLineTextFieldId.SelectionStart = 0;
            this.materialSingleLineTextFieldId.Size = new System.Drawing.Size(310, 23);
            this.materialSingleLineTextFieldId.TabIndex = 31;
            this.materialSingleLineTextFieldId.UseSystemPasswordChar = false;
            // 
            // materialRaisedButtonDel
            // 
            this.materialRaisedButtonDel.Depth = 0;
            this.materialRaisedButtonDel.Location = new System.Drawing.Point(328, 596);
            this.materialRaisedButtonDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonDel.Name = "materialRaisedButtonDel";
            this.materialRaisedButtonDel.Primary = true;
            this.materialRaisedButtonDel.Size = new System.Drawing.Size(140, 23);
            this.materialRaisedButtonDel.TabIndex = 32;
            this.materialRaisedButtonDel.Text = "Удалить клиента";
            this.materialRaisedButtonDel.UseVisualStyleBackColor = true;
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 631);
            this.Controls.Add(this.materialRaisedButtonDel);
            this.Controls.Add(this.materialSingleLineTextFieldId);
            this.Controls.Add(this.materialSingleLineTextFieldPenalties);
            this.Controls.Add(this.materialRaisedButtonPenalties);
            this.Controls.Add(this.materialSingleLineTextFieldFIOClent);
            this.Controls.Add(this.materialRaisedButtonFrequency);
            this.Controls.Add(this.materialLabelError);
            this.Controls.Add(this.materialRaisedButtonWithPenalties);
            this.Controls.Add(this.materialRaisedButtonWithoutPenalties);
            this.Controls.Add(this.materialSingleLineTextFieldPassportNumber);
            this.Controls.Add(this.materialRaisedButtonSearchByFio);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButtonSearchByPassport);
            this.Controls.Add(this.materialSingleLineTextFieldFIO);
            this.Controls.Add(this.materialRaisedButtonCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialRaisedButtonAddClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClients";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.FormClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAddClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldFIO;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonSearchByPassport;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonSearchByFio;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldPassportNumber;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonWithoutPenalties;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonWithPenalties;
        private MaterialSkin.Controls.MaterialLabel materialLabelError;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonFrequency;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldPenalties;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonPenalties;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldFIOClent;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldId;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonDel;
    }
}