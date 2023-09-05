namespace Ikuji
{
    partial class FormOmutuRestore
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
            this.dtpMonthDay = new System.Windows.Forms.DateTimePicker();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.cmbMinit = new System.Windows.Forms.ComboBox();
            this.pnlUntiOsikko = new System.Windows.Forms.Panel();
            this.Osikko = new System.Windows.Forms.RadioButton();
            this.rdbUnti = new System.Windows.Forms.RadioButton();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.pnlUntiOsikko.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 22);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Location = new System.Drawing.Point(148, 12);
            this.dtpMonthDay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMonthDay.Name = "dtpMonthDay";
            this.dtpMonthDay.Size = new System.Drawing.Size(115, 22);
            this.dtpMonthDay.TabIndex = 3;
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(472, 15);
            this.cmbHour.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(97, 23);
            this.cmbHour.TabIndex = 4;
            // 
            // cmbMinit
            // 
            this.cmbMinit.FormattingEnabled = true;
            this.cmbMinit.Location = new System.Drawing.Point(617, 15);
            this.cmbMinit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMinit.Name = "cmbMinit";
            this.cmbMinit.Size = new System.Drawing.Size(97, 23);
            this.cmbMinit.TabIndex = 5;
            // 
            // pnlUntiOsikko
            // 
            this.pnlUntiOsikko.Controls.Add(this.Osikko);
            this.pnlUntiOsikko.Controls.Add(this.rdbUnti);
            this.pnlUntiOsikko.Location = new System.Drawing.Point(39, 102);
            this.pnlUntiOsikko.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUntiOsikko.Name = "pnlUntiOsikko";
            this.pnlUntiOsikko.Size = new System.Drawing.Size(251, 244);
            this.pnlUntiOsikko.TabIndex = 6;
            // 
            // Osikko
            // 
            this.Osikko.AutoSize = true;
            this.Osikko.Location = new System.Drawing.Point(47, 145);
            this.Osikko.Margin = new System.Windows.Forms.Padding(4);
            this.Osikko.Name = "Osikko";
            this.Osikko.Size = new System.Drawing.Size(103, 19);
            this.Osikko.TabIndex = 1;
            this.Osikko.TabStop = true;
            this.Osikko.Text = "おしっこボタン";
            this.Osikko.UseVisualStyleBackColor = true;
            // 
            // rdbUnti
            // 
            this.rdbUnti.AutoSize = true;
            this.rdbUnti.Location = new System.Drawing.Point(47, 68);
            this.rdbUnti.Margin = new System.Windows.Forms.Padding(4);
            this.rdbUnti.Name = "rdbUnti";
            this.rdbUnti.Size = new System.Drawing.Size(93, 19);
            this.rdbUnti.TabIndex = 0;
            this.rdbUnti.TabStop = true;
            this.rdbUnti.Text = "うんちボタン";
            this.rdbUnti.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(39, 385);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(240, 31);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Text = "登録ボタン";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(396, 385);
            this.txbComment.Margin = new System.Windows.Forms.Padding(4);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(319, 22);
            this.txbComment.TabIndex = 8;
            // 
            // FormOmutuRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.pnlUntiOsikko);
            this.Controls.Add(this.cmbMinit);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.dtpMonthDay);
            this.Controls.Add(this.btnReturn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOmutuRestore";
            this.Text = "FormOmutuRestore";
            this.pnlUntiOsikko.ResumeLayout(false);
            this.pnlUntiOsikko.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dtpMonthDay;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.ComboBox cmbMinit;
        private System.Windows.Forms.Panel pnlUntiOsikko;
        private System.Windows.Forms.RadioButton Osikko;
        private System.Windows.Forms.RadioButton rdbUnti;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txbComment;
    }
}