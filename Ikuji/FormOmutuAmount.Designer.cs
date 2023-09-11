namespace Ikuji
{
    partial class FormOmutuAmount
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
            this.lblOmutuSize = new System.Windows.Forms.Label();
            this.cmbOmutuSize = new System.Windows.Forms.ComboBox();
            this.txbOmutuAmount = new System.Windows.Forms.TextBox();
            this.lblOmutuAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOmutuSize
            // 
            this.lblOmutuSize.AutoSize = true;
            this.lblOmutuSize.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.lblOmutuSize.Location = new System.Drawing.Point(39, 103);
            this.lblOmutuSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOmutuSize.Name = "lblOmutuSize";
            this.lblOmutuSize.Size = new System.Drawing.Size(48, 17);
            this.lblOmutuSize.TabIndex = 14;
            this.lblOmutuSize.Text = "サイズ";
            // 
            // cmbOmutuSize
            // 
            this.cmbOmutuSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOmutuSize.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbOmutuSize.FormattingEnabled = true;
            this.cmbOmutuSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "ビッグ"});
            this.cmbOmutuSize.Location = new System.Drawing.Point(109, 100);
            this.cmbOmutuSize.Name = "cmbOmutuSize";
            this.cmbOmutuSize.Size = new System.Drawing.Size(121, 25);
            this.cmbOmutuSize.TabIndex = 0;
            // 
            // txbOmutuAmount
            // 
            this.txbOmutuAmount.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbOmutuAmount.Location = new System.Drawing.Point(109, 176);
            this.txbOmutuAmount.Name = "txbOmutuAmount";
            this.txbOmutuAmount.Size = new System.Drawing.Size(121, 24);
            this.txbOmutuAmount.TabIndex = 15;
            // 
            // lblOmutuAmount
            // 
            this.lblOmutuAmount.AutoSize = true;
            this.lblOmutuAmount.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.lblOmutuAmount.Location = new System.Drawing.Point(39, 179);
            this.lblOmutuAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOmutuAmount.Name = "lblOmutuAmount";
            this.lblOmutuAmount.Size = new System.Drawing.Size(42, 17);
            this.lblOmutuAmount.TabIndex = 16;
            this.lblOmutuAmount.Text = "枚数";
            // 
            // FormOmutuAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.lblOmutuAmount);
            this.Controls.Add(this.txbOmutuAmount);
            this.Controls.Add(this.lblOmutuSize);
            this.Controls.Add(this.cmbOmutuSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormOmutuAmount";
            this.Text = "FormOmutuAmount";
            this.Load += new System.EventHandler(this.FormOmutuAmount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOmutuSize;
        private System.Windows.Forms.ComboBox cmbOmutuSize;
        private System.Windows.Forms.TextBox txbOmutuAmount;
        private System.Windows.Forms.Label lblOmutuAmount;
    }
}