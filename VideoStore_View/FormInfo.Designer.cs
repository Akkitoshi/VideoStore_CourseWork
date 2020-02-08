namespace VideoStore_View
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.materialLabelDescription = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelAuthor = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabelDescription
            // 
            this.materialLabelDescription.BackColor = System.Drawing.Color.Transparent;
            this.materialLabelDescription.Depth = 0;
            this.materialLabelDescription.Enabled = false;
            this.materialLabelDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelDescription.ForeColor = System.Drawing.Color.Gray;
            this.materialLabelDescription.Location = new System.Drawing.Point(12, 79);
            this.materialLabelDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDescription.Name = "materialLabelDescription";
            this.materialLabelDescription.Size = new System.Drawing.Size(315, 118);
            this.materialLabelDescription.TabIndex = 0;
            this.materialLabelDescription.Text = "Фирма видео-проката оказывает услуги физическим лицами. В процессе оказания услуг" +
    " заключается договор,рассчитываются затраты, выставляется счет.";
            // 
            // materialLabelAuthor
            // 
            this.materialLabelAuthor.AutoSize = true;
            this.materialLabelAuthor.BackColor = System.Drawing.Color.Transparent;
            this.materialLabelAuthor.Depth = 0;
            this.materialLabelAuthor.Enabled = false;
            this.materialLabelAuthor.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelAuthor.ForeColor = System.Drawing.Color.Silver;
            this.materialLabelAuthor.Location = new System.Drawing.Point(12, 292);
            this.materialLabelAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelAuthor.Name = "materialLabelAuthor";
            this.materialLabelAuthor.Size = new System.Drawing.Size(276, 19);
            this.materialLabelAuthor.TabIndex = 1;
            this.materialLabelAuthor.Text = "Автор: Шакина А.Л.  группа ИСЭбд-31";
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 320);
            this.Controls.Add(this.materialLabelAuthor);
            this.Controls.Add(this.materialLabelDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfo";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cведения об авторе и назначении программы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabelDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabelAuthor;
    }
}