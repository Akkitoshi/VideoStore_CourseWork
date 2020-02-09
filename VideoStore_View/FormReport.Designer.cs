namespace VideoStore_View
{
    partial class FormReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextFieldYear = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButtonCreate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButtonExcel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 66);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "За год";
            // 
            // materialSingleLineTextFieldYear
            // 
            this.materialSingleLineTextFieldYear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.materialSingleLineTextFieldYear.Depth = 0;
            this.materialSingleLineTextFieldYear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialSingleLineTextFieldYear.Hint = "____";
            this.materialSingleLineTextFieldYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialSingleLineTextFieldYear.Location = new System.Drawing.Point(68, 66);
            this.materialSingleLineTextFieldYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldYear.Name = "materialSingleLineTextFieldYear";
            this.materialSingleLineTextFieldYear.PasswordChar = '\0';
            this.materialSingleLineTextFieldYear.SelectedText = "";
            this.materialSingleLineTextFieldYear.SelectionLength = 0;
            this.materialSingleLineTextFieldYear.SelectionStart = 0;
            this.materialSingleLineTextFieldYear.Size = new System.Drawing.Size(92, 23);
            this.materialSingleLineTextFieldYear.TabIndex = 2;
            this.materialSingleLineTextFieldYear.UseSystemPasswordChar = false;
            // 
            // materialRaisedButtonCreate
            // 
            this.materialRaisedButtonCreate.Depth = 0;
            this.materialRaisedButtonCreate.Location = new System.Drawing.Point(166, 66);
            this.materialRaisedButtonCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonCreate.Name = "materialRaisedButtonCreate";
            this.materialRaisedButtonCreate.Primary = true;
            this.materialRaisedButtonCreate.Size = new System.Drawing.Size(186, 23);
            this.materialRaisedButtonCreate.TabIndex = 3;
            this.materialRaisedButtonCreate.Text = "Сформировать";
            this.materialRaisedButtonCreate.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButtonExcel
            // 
            this.materialRaisedButtonExcel.Depth = 0;
            this.materialRaisedButtonExcel.Location = new System.Drawing.Point(358, 66);
            this.materialRaisedButtonExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonExcel.Name = "materialRaisedButtonExcel";
            this.materialRaisedButtonExcel.Primary = true;
            this.materialRaisedButtonExcel.Size = new System.Drawing.Size(186, 23);
            this.materialRaisedButtonExcel.TabIndex = 4;
            this.materialRaisedButtonExcel.Text = "Сохранить в Excel";
            this.materialRaisedButtonExcel.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialRaisedButtonExcel);
            this.Controls.Add(this.materialRaisedButtonCreate);
            this.Controls.Add(this.materialSingleLineTextFieldYear);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormReport";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cтоимость заключенных договоров по видам услуг и месяцам года";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldYear;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonCreate;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonExcel;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}