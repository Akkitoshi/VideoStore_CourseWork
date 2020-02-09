namespace VideoStore_View
{
    partial class FormClientContracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientContracts));
            this.materialRaisedButtonActive = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonNoActive = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldFIO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButtonSearchByContract = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButtonSearchByFIO = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldContractNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButtonCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonUpd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonAddContract = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldFIOClent = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButtonPenalties = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabelError = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextFieldPinalties = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialRaisedButtonActive
            // 
            this.materialRaisedButtonActive.Depth = 0;
            this.materialRaisedButtonActive.Location = new System.Drawing.Point(591, 330);
            this.materialRaisedButtonActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonActive.Name = "materialRaisedButtonActive";
            this.materialRaisedButtonActive.Primary = true;
            this.materialRaisedButtonActive.Size = new System.Drawing.Size(310, 23);
            this.materialRaisedButtonActive.TabIndex = 22;
            this.materialRaisedButtonActive.Text = "Действующие договора";
            this.materialRaisedButtonActive.UseVisualStyleBackColor = true;
            this.materialRaisedButtonActive.Click += new System.EventHandler(this.materialRaisedButtonActive_Click);
            // 
            // materialRaisedButtonNoActive
            // 
            this.materialRaisedButtonNoActive.Depth = 0;
            this.materialRaisedButtonNoActive.Location = new System.Drawing.Point(591, 359);
            this.materialRaisedButtonNoActive.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonNoActive.Name = "materialRaisedButtonNoActive";
            this.materialRaisedButtonNoActive.Primary = true;
            this.materialRaisedButtonNoActive.Size = new System.Drawing.Size(310, 23);
            this.materialRaisedButtonNoActive.TabIndex = 21;
            this.materialRaisedButtonNoActive.Text = "Просроченные договора";
            this.materialRaisedButtonNoActive.UseVisualStyleBackColor = true;
            this.materialRaisedButtonNoActive.Click += new System.EventHandler(this.materialRaisedButtonNoActive_Click);
            // 
            // materialSingleLineTextFieldFIO
            // 
            this.materialSingleLineTextFieldFIO.Depth = 0;
            this.materialSingleLineTextFieldFIO.Hint = "ФИО клиента";
            this.materialSingleLineTextFieldFIO.Location = new System.Drawing.Point(28, 359);
            this.materialSingleLineTextFieldFIO.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldFIO.Name = "materialSingleLineTextFieldFIO";
            this.materialSingleLineTextFieldFIO.PasswordChar = '\0';
            this.materialSingleLineTextFieldFIO.SelectedText = "";
            this.materialSingleLineTextFieldFIO.SelectionLength = 0;
            this.materialSingleLineTextFieldFIO.SelectionStart = 0;
            this.materialSingleLineTextFieldFIO.Size = new System.Drawing.Size(310, 23);
            this.materialSingleLineTextFieldFIO.TabIndex = 20;
            this.materialSingleLineTextFieldFIO.UseSystemPasswordChar = false;
            // 
            // materialRaisedButtonSearchByContract
            // 
            this.materialRaisedButtonSearchByContract.Depth = 0;
            this.materialRaisedButtonSearchByContract.Location = new System.Drawing.Point(344, 330);
            this.materialRaisedButtonSearchByContract.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonSearchByContract.Name = "materialRaisedButtonSearchByContract";
            this.materialRaisedButtonSearchByContract.Primary = true;
            this.materialRaisedButtonSearchByContract.Size = new System.Drawing.Size(84, 23);
            this.materialRaisedButtonSearchByContract.TabIndex = 19;
            this.materialRaisedButtonSearchByContract.Text = "ПОИСК";
            this.materialRaisedButtonSearchByContract.UseVisualStyleBackColor = true;
            this.materialRaisedButtonSearchByContract.Click += new System.EventHandler(this.materialRaisedButtonSearchByContract_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(24, 301);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(130, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Поиск контракта";
            // 
            // materialRaisedButtonSearchByFIO
            // 
            this.materialRaisedButtonSearchByFIO.Depth = 0;
            this.materialRaisedButtonSearchByFIO.Location = new System.Drawing.Point(344, 359);
            this.materialRaisedButtonSearchByFIO.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonSearchByFIO.Name = "materialRaisedButtonSearchByFIO";
            this.materialRaisedButtonSearchByFIO.Primary = true;
            this.materialRaisedButtonSearchByFIO.Size = new System.Drawing.Size(84, 23);
            this.materialRaisedButtonSearchByFIO.TabIndex = 17;
            this.materialRaisedButtonSearchByFIO.Text = "ПОИСК";
            this.materialRaisedButtonSearchByFIO.UseVisualStyleBackColor = true;
            this.materialRaisedButtonSearchByFIO.Click += new System.EventHandler(this.materialRaisedButtonSearchByFIO_Click);
            // 
            // materialSingleLineTextFieldContractNumber
            // 
            this.materialSingleLineTextFieldContractNumber.Depth = 0;
            this.materialSingleLineTextFieldContractNumber.Hint = "Идентификатор договора";
            this.materialSingleLineTextFieldContractNumber.Location = new System.Drawing.Point(28, 330);
            this.materialSingleLineTextFieldContractNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldContractNumber.Name = "materialSingleLineTextFieldContractNumber";
            this.materialSingleLineTextFieldContractNumber.PasswordChar = '\0';
            this.materialSingleLineTextFieldContractNumber.SelectedText = "";
            this.materialSingleLineTextFieldContractNumber.SelectionLength = 0;
            this.materialSingleLineTextFieldContractNumber.SelectionStart = 0;
            this.materialSingleLineTextFieldContractNumber.Size = new System.Drawing.Size(310, 23);
            this.materialSingleLineTextFieldContractNumber.TabIndex = 16;
            this.materialSingleLineTextFieldContractNumber.UseSystemPasswordChar = false;
            // 
            // materialRaisedButtonCancel
            // 
            this.materialRaisedButtonCancel.Depth = 0;
            this.materialRaisedButtonCancel.Location = new System.Drawing.Point(749, 389);
            this.materialRaisedButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonCancel.Name = "materialRaisedButtonCancel";
            this.materialRaisedButtonCancel.Primary = true;
            this.materialRaisedButtonCancel.Size = new System.Drawing.Size(84, 23);
            this.materialRaisedButtonCancel.TabIndex = 15;
            this.materialRaisedButtonCancel.Text = "сбросить";
            this.materialRaisedButtonCancel.UseVisualStyleBackColor = true;
            this.materialRaisedButtonCancel.Click += new System.EventHandler(this.materialRaisedButtonCancel_Click);
            // 
            // materialRaisedButtonUpd
            // 
            this.materialRaisedButtonUpd.Depth = 0;
            this.materialRaisedButtonUpd.Location = new System.Drawing.Point(659, 389);
            this.materialRaisedButtonUpd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonUpd.Name = "materialRaisedButtonUpd";
            this.materialRaisedButtonUpd.Primary = true;
            this.materialRaisedButtonUpd.Size = new System.Drawing.Size(84, 23);
            this.materialRaisedButtonUpd.TabIndex = 14;
            this.materialRaisedButtonUpd.Text = "обновить";
            this.materialRaisedButtonUpd.UseVisualStyleBackColor = true;
            this.materialRaisedButtonUpd.Click += new System.EventHandler(this.materialRaisedButtonUpd_Click);
            // 
            // materialRaisedButtonAddContract
            // 
            this.materialRaisedButtonAddContract.Depth = 0;
            this.materialRaisedButtonAddContract.Location = new System.Drawing.Point(591, 443);
            this.materialRaisedButtonAddContract.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAddContract.Name = "materialRaisedButtonAddContract";
            this.materialRaisedButtonAddContract.Primary = true;
            this.materialRaisedButtonAddContract.Size = new System.Drawing.Size(310, 23);
            this.materialRaisedButtonAddContract.TabIndex = 0;
            this.materialRaisedButtonAddContract.Text = " Добавить договор";
            this.materialRaisedButtonAddContract.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAddContract.Click += new System.EventHandler(this.materialRaisedButtonAddContract_Click);
            // 
            // materialSingleLineTextFieldFIOClent
            // 
            this.materialSingleLineTextFieldFIOClent.Depth = 0;
            this.materialSingleLineTextFieldFIOClent.Hint = "ФИО клиента";
            this.materialSingleLineTextFieldFIOClent.Location = new System.Drawing.Point(28, 414);
            this.materialSingleLineTextFieldFIOClent.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldFIOClent.Name = "materialSingleLineTextFieldFIOClent";
            this.materialSingleLineTextFieldFIOClent.PasswordChar = '\0';
            this.materialSingleLineTextFieldFIOClent.SelectedText = "";
            this.materialSingleLineTextFieldFIOClent.SelectionLength = 0;
            this.materialSingleLineTextFieldFIOClent.SelectionStart = 0;
            this.materialSingleLineTextFieldFIOClent.Size = new System.Drawing.Size(310, 23);
            this.materialSingleLineTextFieldFIOClent.TabIndex = 23;
            this.materialSingleLineTextFieldFIOClent.UseSystemPasswordChar = false;
            // 
            // materialRaisedButtonPenalties
            // 
            this.materialRaisedButtonPenalties.Depth = 0;
            this.materialRaisedButtonPenalties.Location = new System.Drawing.Point(344, 443);
            this.materialRaisedButtonPenalties.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonPenalties.Name = "materialRaisedButtonPenalties";
            this.materialRaisedButtonPenalties.Primary = true;
            this.materialRaisedButtonPenalties.Size = new System.Drawing.Size(131, 23);
            this.materialRaisedButtonPenalties.TabIndex = 24;
            this.materialRaisedButtonPenalties.Text = "Начислить пени";
            this.materialRaisedButtonPenalties.UseVisualStyleBackColor = true;
            this.materialRaisedButtonPenalties.Click += new System.EventHandler(this.materialRaisedButtonPenalties_Click);
            // 
            // materialLabelError
            // 
            this.materialLabelError.AutoSize = true;
            this.materialLabelError.BackColor = System.Drawing.Color.Transparent;
            this.materialLabelError.Depth = 0;
            this.materialLabelError.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelError.Location = new System.Drawing.Point(24, 389);
            this.materialLabelError.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelError.Name = "materialLabelError";
            this.materialLabelError.Size = new System.Drawing.Size(13, 19);
            this.materialLabelError.TabIndex = 25;
            this.materialLabelError.Text = "-";
            // 
            // materialSingleLineTextFieldPinalties
            // 
            this.materialSingleLineTextFieldPinalties.Depth = 0;
            this.materialSingleLineTextFieldPinalties.Hint = "Пени";
            this.materialSingleLineTextFieldPinalties.Location = new System.Drawing.Point(28, 443);
            this.materialSingleLineTextFieldPinalties.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldPinalties.Name = "materialSingleLineTextFieldPinalties";
            this.materialSingleLineTextFieldPinalties.PasswordChar = '\0';
            this.materialSingleLineTextFieldPinalties.SelectedText = "";
            this.materialSingleLineTextFieldPinalties.SelectionLength = 0;
            this.materialSingleLineTextFieldPinalties.SelectionStart = 0;
            this.materialSingleLineTextFieldPinalties.Size = new System.Drawing.Size(310, 23);
            this.materialSingleLineTextFieldPinalties.TabIndex = 26;
            this.materialSingleLineTextFieldPinalties.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(9, 77);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(892, 221);
            this.dataGridView1.TabIndex = 27;
            // 
            // FormClientContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialSingleLineTextFieldPinalties);
            this.Controls.Add(this.materialLabelError);
            this.Controls.Add(this.materialRaisedButtonPenalties);
            this.Controls.Add(this.materialSingleLineTextFieldFIOClent);
            this.Controls.Add(this.materialRaisedButtonActive);
            this.Controls.Add(this.materialRaisedButtonNoActive);
            this.Controls.Add(this.materialSingleLineTextFieldFIO);
            this.Controls.Add(this.materialRaisedButtonSearchByContract);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButtonSearchByFIO);
            this.Controls.Add(this.materialSingleLineTextFieldContractNumber);
            this.Controls.Add(this.materialRaisedButtonCancel);
            this.Controls.Add(this.materialRaisedButtonUpd);
            this.Controls.Add(this.materialRaisedButtonAddContract);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientContracts";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договора";
            this.Load += new System.EventHandler(this.FormClientContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonActive;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonNoActive;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldFIO;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonSearchByContract;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonSearchByFIO;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldContractNumber;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonCancel;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonUpd;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAddContract;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldFIOClent;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonPenalties;
        private MaterialSkin.Controls.MaterialLabel materialLabelError;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldPinalties;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}