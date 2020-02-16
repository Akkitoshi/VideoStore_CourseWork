namespace VideoStore_View
{
    partial class FormProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialRaisedButtonAddproduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialRaisedButtonDel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialRaisedButtonAddproduct
            // 
            this.materialRaisedButtonAddproduct.Depth = 0;
            this.materialRaisedButtonAddproduct.Location = new System.Drawing.Point(137, 415);
            this.materialRaisedButtonAddproduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAddproduct.Name = "materialRaisedButtonAddproduct";
            this.materialRaisedButtonAddproduct.Primary = true;
            this.materialRaisedButtonAddproduct.Size = new System.Drawing.Size(194, 23);
            this.materialRaisedButtonAddproduct.TabIndex = 0;
            this.materialRaisedButtonAddproduct.Text = "Добавить товар";
            this.materialRaisedButtonAddproduct.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAddproduct.Click += new System.EventHandler(this.materialRaisedButtonAddProduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(431, 335);
            this.dataGridView1.TabIndex = 1;
            // 
            // materialRaisedButtonDel
            // 
            this.materialRaisedButtonDel.Depth = 0;
            this.materialRaisedButtonDel.Location = new System.Drawing.Point(226, 466);
            this.materialRaisedButtonDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonDel.Name = "materialRaisedButtonDel";
            this.materialRaisedButtonDel.Primary = true;
            this.materialRaisedButtonDel.Size = new System.Drawing.Size(217, 23);
            this.materialRaisedButtonDel.TabIndex = 34;
            this.materialRaisedButtonDel.Text = "Удалить товар";
            this.materialRaisedButtonDel.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextFieldId
            // 
            this.materialSingleLineTextFieldId.Depth = 0;
            this.materialSingleLineTextFieldId.Hint = "ID товара";
            this.materialSingleLineTextFieldId.Location = new System.Drawing.Point(12, 466);
            this.materialSingleLineTextFieldId.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldId.Name = "materialSingleLineTextFieldId";
            this.materialSingleLineTextFieldId.PasswordChar = '\0';
            this.materialSingleLineTextFieldId.SelectedText = "";
            this.materialSingleLineTextFieldId.SelectionLength = 0;
            this.materialSingleLineTextFieldId.SelectionStart = 0;
            this.materialSingleLineTextFieldId.Size = new System.Drawing.Size(185, 23);
            this.materialSingleLineTextFieldId.TabIndex = 33;
            this.materialSingleLineTextFieldId.UseSystemPasswordChar = false;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 501);
            this.Controls.Add(this.materialRaisedButtonDel);
            this.Controls.Add(this.materialSingleLineTextFieldId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialRaisedButtonAddproduct);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProducts";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAddproduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonDel;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldId;
    }
}