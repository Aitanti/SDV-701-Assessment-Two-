namespace camerashop
{
    partial class frmMain
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
            this.lstbrands = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbrands
            // 
            this.lstbrands.FormattingEnabled = true;
            this.lstbrands.Location = new System.Drawing.Point(15, 69);
            this.lstbrands.Name = "lstbrands";
            this.lstbrands.Size = new System.Drawing.Size(212, 121);
            this.lstbrands.TabIndex = 0;
            this.lstbrands.DoubleClick += new System.EventHandler(this.lstbrands_DoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(165, 259);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 16);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Capture Camera\'s";
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(28, 259);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(75, 23);
            this.btnOrders.TabIndex = 13;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 294);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstbrands);
            this.Name = "frmMain";
            this.Text = "Capture Cameras";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbrands;
        private System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnOrders;
    }
}

