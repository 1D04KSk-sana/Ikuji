namespace Ikuji
{
    partial class FormWeightRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWeightRestore));
            this.dtpMonthDay = new System.Windows.Forms.DateTimePicker();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.txbTemperature = new System.Windows.Forms.TextBox();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.dtpMonthDay.Location = new System.Drawing.Point(173, 24);
            this.dtpMonthDay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMonthDay.Name = "dtpMonthDay";
            this.dtpMonthDay.Size = new System.Drawing.Size(223, 24);
            this.dtpMonthDay.TabIndex = 4;
            // 
            // txbWeight
            // 
            this.txbWeight.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txbWeight.Location = new System.Drawing.Point(36, 143);
            this.txbWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(187, 24);
            this.txbWeight.TabIndex = 5;
            // 
            // txbTemperature
            // 
            this.txbTemperature.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txbTemperature.Location = new System.Drawing.Point(396, 143);
            this.txbTemperature.Margin = new System.Windows.Forms.Padding(4);
            this.txbTemperature.Name = "txbTemperature";
            this.txbTemperature.Size = new System.Drawing.Size(187, 24);
            this.txbTemperature.TabIndex = 6;
            // 
            // txbComment
            // 
            this.txbComment.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txbComment.Location = new System.Drawing.Point(36, 243);
            this.txbComment.Margin = new System.Windows.Forms.Padding(4);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(319, 24);
            this.txbComment.TabIndex = 9;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.lblWeight.Location = new System.Drawing.Point(40, 114);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(42, 17);
            this.lblWeight.TabIndex = 10;
            this.lblWeight.Text = "体重";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.lblTemperature.Location = new System.Drawing.Point(403, 114);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(42, 17);
            this.lblTemperature.TabIndex = 11;
            this.lblTemperature.Text = "体温";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.lblComment.Location = new System.Drawing.Point(40, 214);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(57, 17);
            this.lblComment.TabIndex = 12;
            this.lblComment.Text = "コメント";
            // 
            // FormWeightRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.txbTemperature);
            this.Controls.Add(this.txbWeight);
            this.Controls.Add(this.dtpMonthDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormWeightRestore";
            this.Text = "体重・体温登録画面";
            this.Load += new System.EventHandler(this.FormWeightRestore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpMonthDay;
        private System.Windows.Forms.TextBox txbWeight;
        private System.Windows.Forms.TextBox txbTemperature;
        private System.Windows.Forms.TextBox txbComment;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblComment;
    }
}