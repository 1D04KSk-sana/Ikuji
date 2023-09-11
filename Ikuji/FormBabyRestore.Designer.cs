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
            this.dtpBirhDay = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirhDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbNameRestore
            // 
            this.txbNameRestore.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbNameRestore.Location = new System.Drawing.Point(125, 98);
            this.txbNameRestore.Name = "txbNameRestore";
            this.txbNameRestore.Size = new System.Drawing.Size(173, 24);
            this.txbNameRestore.TabIndex = 8;
            // 
            // dtpBirhDay
            // 
            this.dtpBirhDay.CalendarFont = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpBirhDay.Location = new System.Drawing.Point(125, 183);
            this.dtpBirhDay.Name = "dtpBirhDay";
            this.dtpBirhDay.Size = new System.Drawing.Size(200, 19);
            this.dtpBirhDay.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblName.Location = new System.Drawing.Point(41, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 17);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "お名前";
            // 
            // lblBirhDay
            // 
            this.lblBirhDay.AutoSize = true;
            this.lblBirhDay.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBirhDay.Location = new System.Drawing.Point(41, 183);
            this.lblBirhDay.Name = "lblBirhDay";
            this.lblBirhDay.Size = new System.Drawing.Size(73, 17);
            this.lblBirhDay.TabIndex = 11;
            this.lblBirhDay.Text = "お誕生日";
            // 
            // FormBabyRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.lblBirhDay);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dtpBirhDay);
            this.Controls.Add(this.txbNameRestore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FormBabyRestore";
            this.Text = "赤ちゃん登録画面";
            this.Load += new System.EventHandler(this.FormBabyRestore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbNameRestore;
        private System.Windows.Forms.DateTimePicker dtpBirhDay;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirhDay;
    }
}