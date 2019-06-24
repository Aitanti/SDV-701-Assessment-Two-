namespace camerashop
{
    partial class frmLens
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfocal = new System.Windows.Forms.TextBox();
            this.txtaperture = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Focal Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Aperture";
            // 
            // txtfocal
            // 
            this.txtfocal.Location = new System.Drawing.Point(119, 196);
            this.txtfocal.Name = "txtfocal";
            this.txtfocal.Size = new System.Drawing.Size(161, 20);
            this.txtfocal.TabIndex = 62;
            // 
            // txtaperture
            // 
            this.txtaperture.Location = new System.Drawing.Point(119, 228);
            this.txtaperture.Name = "txtaperture";
            this.txtaperture.Size = new System.Drawing.Size(161, 20);
            this.txtaperture.TabIndex = 63;
            // 
            // frmLens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(291, 324);
            this.Controls.Add(this.txtaperture);
            this.Controls.Add(this.txtfocal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "frmLens";
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtfocal, 0);
            this.Controls.SetChildIndex(this.txtaperture, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfocal;
        private System.Windows.Forms.TextBox txtaperture;
    }
}
