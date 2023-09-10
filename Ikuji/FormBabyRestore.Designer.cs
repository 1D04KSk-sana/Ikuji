namespace Ikuji
{
    partial class FormBabyRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBabyRestore));
            this.txbNameRestore = new System.Windows.Forms.TextBox();
            this.txbYearRestore = new System.Windows.Forms.TextBox();
            this.txbMonthRestore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbNameRestore
            // 
            this.txbNameRestore.Location = new System.Drawing.Point(36, 95);
            this.txbNameRestore.Margin = new System.Windows.Forms.Padding(4);
            this.txbNameRestore.Name = "txbNameRestore";
            this.txbNameRestore.Size = new System.Drawing.Size(229, 22);
            this.txbNameRestore.TabIndex = 8;
            // 
            // txbYearRestore
            // 
            this.txbYearRestore.Location = new System.Drawing.Point(36, 148);
            this.txbYearRestore.Margin = new System.Windows.Forms.Padding(4);
            this.txbYearRestore.Name = "txbYearRestore";
            this.txbYearRestore.Size = new System.Drawing.Size(229, 22);
            this.txbYearRestore.TabIndex = 9;
            // 
            // txbMonthRestore
            // 
            this.txbMonthRestore.Location = new System.Drawing.Point(405, 95);
            this.txbMonthRestore.Margin = new System.Windows.Forms.Padding(4);
            this.txbMonthRestore.Name = "txbMonthRestore";
            this.txbMonthRestore.Size = new System.Drawing.Size(229, 22);
            this.txbMonthRestore.TabIndex = 10;
            // 
            // FormBabyRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbMonthRestore);
            this.Controls.Add(this.txbYearRestore);
            this.Controls.Add(this.txbNameRestore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormBabyRestore";
            this.Text = "FormBabyRestore";
            this.Load += new System.EventHandler(this.FormBabyRestore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbNameRestore;
        private System.Windows.Forms.TextBox txbYearRestore;
        private System.Windows.Forms.TextBox txbMonthRestore;
    }
}