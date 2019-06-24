namespace camerashop
{
    partial class frmBody
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmegapixels = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Weight";
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(117, 196);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(161, 20);
            this.txtweight.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Megapixels";
            // 
            // txtmegapixels
            // 
            this.txtmegapixels.Location = new System.Drawing.Point(117, 228);
            this.txtmegapixels.Name = "txtmegapixels";
            this.txtmegapixels.Size = new System.Drawing.Size(161, 20);
            this.txtmegapixels.TabIndex = 64;
            // 
            // frmBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(291, 289);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmegapixels);
            this.Name = "frmBody";
            this.Controls.SetChildIndex(this.txtmegapixels, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtweight, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtweight;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtmegapixels;
    }
}
