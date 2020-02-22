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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientContracts));
            this.materialRaisedButtonActive = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonNoActive = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldFIO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButtonSearchByContract = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButtonSearchByFIO = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldContractNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButtonCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonAddContract = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabelError = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButtonReturn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonDel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonSave = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialRaisedButtonActive
            // 
            this.materialRaisedButtonActive.Depth = 0;
            this.materialRaisedButtonActive.Location = new System.Drawing.Point(875, 330);
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
            this.materialRaisedButtonNoActive.Location = new System.Drawing.Point(875, 359);
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
            this.materialLabel1.Size = new System.Drawing.Size(125, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Поиск договора";
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
            this.materialRaisedButtonCancel.Location = new System.Drawing.Point(875, 446);
            this.materialRaisedButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonCancel.Name = "materialRaisedButtonCancel";
            this.materialRaisedButtonCancel.Primary = true;
            this.materialRaisedButtonCancel.Size = new System.Drawing.Size(310, 23);
            this.materialRaisedButtonCancel.TabIndex = 15;
            this.materialRaisedButtonCancel.Text = "сбросить";
            this.materialRaisedButtonCancel.UseVisualStyleBackColor = true;
            this.materialRaisedButtonCancel.Click += new System.EventHandler(this.materialRaisedButtonCancel_Click);
            // 
            // materialRaisedButtonAddContract
            // 
            this.materialRaisedButtonAddContract.Depth = 0;
            this.materialRaisedButtonAddContract.Location = new System.Drawing.Point(875, 386);
            this.materialRaisedButtonAddContract.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAddContract.Name = "materialRaisedButtonAddContract";
            this.materialRaisedButtonAddContract.Primary = true;
            this.materialRaisedButtonAddContract.Size = new System.Drawing.Size(310, 23);
            this.materialRaisedButtonAddContract.TabIndex = 0;
            this.materialRaisedButtonAddContract.Text = " Добавить договор";
            this.materialRaisedButtonAddContract.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAddContract.Click += new System.EventHandler(this.materialRaisedButtonAddContract_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(9, 77);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 221);
            this.dataGridView1.TabIndex = 27;
            // 
            // materialLabelError
            // 
            this.materialLabelError.AutoSize = true;
            this.materialLabelError.BackColor = System.Drawing.Color.Transparent;
            this.materialLabelError.Depth = 0;
            this.materialLabelError.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelError.Location = new System.Drawing.Point(24, 390);
            this.materialLabelError.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelError.Name = "materialLabelError";
            this.materialLabelError.Size = new System.Drawing.Size(13, 19);
            this.materialLabelError.TabIndex = 28;
            this.materialLabelError.Text = "-";
            // 
            // materialRaisedButtonReturn
            // 
            this.materialRaisedButtonReturn.Depth = 0;
            this.materialRaisedButtonReturn.Location = new System.Drawing.Point(434, 330);
            this.materialRaisedButtonReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonReturn.Name = "materialRaisedButtonReturn";
            this.materialRaisedButtonReturn.Primary = true;
            this.materialRaisedButtonReturn.Size = new System.Drawing.Size(156, 23);
            this.materialRaisedButtonReturn.TabIndex = 29;
            this.materialRaisedButtonReturn.Text = "Отметить возврат";
            this.materialRaisedButtonReturn.UseVisualStyleBackColor = true;
            this.materialRaisedButtonReturn.Click += new System.EventHandler(this.materialRaisedButtonReturn_Click);
            // 
            // materialRaisedButtonDel
            // 
            this.materialRaisedButtonDel.Depth = 0;
            this.materialRaisedButtonDel.Location = new System.Drawing.Point(344, 426);
            this.materialRaisedButtonDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonDel.Name = "materialRaisedButtonDel";
            this.materialRaisedButtonDel.Primary = true;
            this.materialRaisedButtonDel.Size = new System.Drawing.Size(140, 23);
            this.materialRaisedButtonDel.TabIndex = 34;
            this.materialRaisedButtonDel.Text = "Удалить договор";
            this.materialRaisedButtonDel.UseVisualStyleBackColor = true;
            this.materialRaisedButtonDel.Click += new System.EventHandler(this.materialRaisedButtonDel_Click);
            // 
            // materialSingleLineTextFieldId
            // 
            this.materialSingleLineTextFieldId.Depth = 0;
            this.materialSingleLineTextFieldId.Hint = "ID договора";
            this.materialSingleLineTextFieldId.Location = new System.Drawing.Point(28, 426);
            this.materialSingleLineTextFieldId.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldId.Name = "materialSingleLineTextFieldId";
            this.materialSingleLineTextFieldId.PasswordChar = '\0';
            this.materialSingleLineTextFieldId.SelectedText = "";
            this.materialSingleLineTextFieldId.SelectionLength = 0;
            this.materialSingleLineTextFieldId.SelectionStart = 0;
            this.materialSingleLineTextFieldId.Size = new System.Drawing.Size(310, 23);
            this.materialSingleLineTextFieldId.TabIndex = 33;
            this.materialSingleLineTextFieldId.UseSystemPasswordChar = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Depth = 0;
            this.buttonSave.Location = new System.Drawing.Point(875, 415);
            this.buttonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Primary = true;
            this.buttonSave.Size = new System.Drawing.Size(310, 25);
            this.buttonSave.TabIndex = 37;
            this.buttonSave.Text = "СОХРАНИТЬ";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormClientContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 490);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.materialRaisedButtonDel);
            this.Controls.Add(this.materialSingleLineTextFieldId);
            this.Controls.Add(this.materialRaisedButtonReturn);
            this.Controls.Add(this.materialLabelError);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialRaisedButtonActive);
            this.Controls.Add(this.materialRaisedButtonNoActive);
            this.Controls.Add(this.materialSingleLineTextFieldFIO);
            this.Controls.Add(this.materialRaisedButtonSearchByContract);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRaisedButtonSearchByFIO);
            this.Controls.Add(this.materialSingleLineTextFieldContractNumber);
            this.Controls.Add(this.materialRaisedButtonCancel);
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
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAddContract;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabelError;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonReturn;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonDel;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldId;
        private MaterialSkin.Controls.MaterialRaisedButton buttonSave;
    }
}