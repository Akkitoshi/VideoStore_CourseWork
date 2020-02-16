namespace VideoStore_View
{
    partial class FormUsers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialRaisedButtonDel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextFieldId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(481, 324);
            this.dataGridView1.TabIndex = 2;
            // 
            // materialRaisedButtonDel
            // 
            this.materialRaisedButtonDel.Depth = 0;
            this.materialRaisedButtonDel.Enabled = false;
            this.materialRaisedButtonDel.Location = new System.Drawing.Point(276, 401);
            this.materialRaisedButtonDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonDel.Name = "materialRaisedButtonDel";
            this.materialRaisedButtonDel.Primary = true;
            this.materialRaisedButtonDel.Size = new System.Drawing.Size(217, 23);
            this.materialRaisedButtonDel.TabIndex = 36;
            this.materialRaisedButtonDel.Text = "Удалить продавца";
            this.materialRaisedButtonDel.UseVisualStyleBackColor = true;
            this.materialRaisedButtonDel.Click += new System.EventHandler(this.materialRaisedButtonDel_Click);
            // 
            // materialSingleLineTextFieldId
            // 
            this.materialSingleLineTextFieldId.Depth = 0;
            this.materialSingleLineTextFieldId.Enabled = false;
            this.materialSingleLineTextFieldId.Hint = "ID продавца";
            this.materialSingleLineTextFieldId.Location = new System.Drawing.Point(63, 401);
            this.materialSingleLineTextFieldId.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldId.Name = "materialSingleLineTextFieldId";
            this.materialSingleLineTextFieldId.PasswordChar = '\0';
            this.materialSingleLineTextFieldId.SelectedText = "";
            this.materialSingleLineTextFieldId.SelectionLength = 0;
            this.materialSingleLineTextFieldId.SelectionStart = 0;
            this.materialSingleLineTextFieldId.Size = new System.Drawing.Size(185, 23);
            this.materialSingleLineTextFieldId.TabIndex = 35;
            this.materialSingleLineTextFieldId.UseSystemPasswordChar = false;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 430);
            this.Controls.Add(this.materialRaisedButtonDel);
            this.Controls.Add(this.materialSingleLineTextFieldId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUsers";
            this.Text = "Продавцы-консультанты";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonDel;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldId;
    }
}