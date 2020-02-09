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
            this.materialRaisedButtonAddproduct = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialRaisedButtonAddproduct
            // 
            this.materialRaisedButtonAddproduct.Depth = 0;
            this.materialRaisedButtonAddproduct.Location = new System.Drawing.Point(594, 415);
            this.materialRaisedButtonAddproduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAddproduct.Name = "materialRaisedButtonAddproduct";
            this.materialRaisedButtonAddproduct.Primary = true;
            this.materialRaisedButtonAddproduct.Size = new System.Drawing.Size(194, 23);
            this.materialRaisedButtonAddproduct.TabIndex = 0;
            this.materialRaisedButtonAddproduct.Text = "Добавить товар";
            this.materialRaisedButtonAddproduct.UseVisualStyleBackColor = true;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialRaisedButtonAddproduct);
            this.Name = "FormProducts";
            this.Text = "Товары";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAddproduct;
    }
}