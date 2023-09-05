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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txbNameRestore = new System.Windows.Forms.TextBox();
            this.txbYearRestore = new System.Windows.Forms.TextBox();
            this.txbMonthRestore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(9, 9);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(56, 19);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(33, 291);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(180, 25);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Text = "登録ボタン";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txbNameRestore
            // 
            this.txbNameRestore.Location = new System.Drawing.Point(39, 39);
            this.txbNameRestore.Name = "txbNameRestore";
            this.txbNameRestore.Size = new System.Drawing.Size(173, 19);
            this.txbNameRestore.TabIndex = 8;
            // 
            // txbYearRestore
            // 
            this.txbYearRestore.Location = new System.Drawing.Point(40, 76);
            this.txbYearRestore.Name = "txbYearRestore";
            this.txbYearRestore.Size = new System.Drawing.Size(173, 19);
            this.txbYearRestore.TabIndex = 9;
            // 
            // txbMonthRestore
            // 
            this.txbMonthRestore.Location = new System.Drawing.Point(309, 76);
            this.txbMonthRestore.Name = "txbMonthRestore";
            this.txbMonthRestore.Size = new System.Drawing.Size(173, 19);
            this.txbMonthRestore.TabIndex = 10;
            // 
            // FormBabyRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.txbMonthRestore);
            this.Controls.Add(this.txbYearRestore);
            this.Controls.Add(this.txbNameRestore);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnReturn);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormBabyRestore";
            this.Text = "FormBabyRestore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txbNameRestore;
        private System.Windows.Forms.TextBox txbYearRestore;
        private System.Windows.Forms.TextBox txbMonthRestore;
    }
}