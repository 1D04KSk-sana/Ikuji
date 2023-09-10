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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOmutuRestore));
            this.dtpMonthDay = new System.Windows.Forms.DateTimePicker();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.cmbMinit = new System.Windows.Forms.ComboBox();
            this.pnlUntiOsikko = new System.Windows.Forms.Panel();
            this.lblBabySub = new System.Windows.Forms.Label();
            this.rdbOsikko = new System.Windows.Forms.RadioButton();
            this.rdbUnti = new System.Windows.Forms.RadioButton();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMinit = new System.Windows.Forms.Label();
            this.pnlUntiOsikko.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.dtpMonthDay.Location = new System.Drawing.Point(173, 25);
            this.dtpMonthDay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMonthDay.Name = "dtpMonthDay";
            this.dtpMonthDay.Size = new System.Drawing.Size(175, 24);
            this.dtpMonthDay.TabIndex = 3;
            // 
            // cmbHour
            // 
            this.cmbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHour.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbHour.Location = new System.Drawing.Point(410, 25);
            this.cmbHour.Margin = new System.Windows.Forms.Padding(5);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(97, 25);
            this.cmbHour.TabIndex = 4;
            // 
            // cmbMinit
            // 
            this.cmbMinit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinit.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.cmbMinit.FormattingEnabled = true;
            this.cmbMinit.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinit.Location = new System.Drawing.Point(592, 25);
            this.cmbMinit.Margin = new System.Windows.Forms.Padding(5);
            this.cmbMinit.Name = "cmbMinit";
            this.cmbMinit.Size = new System.Drawing.Size(97, 25);
            this.cmbMinit.TabIndex = 5;
            // 
            // pnlUntiOsikko
            // 
            this.pnlUntiOsikko.Controls.Add(this.lblBabySub);
            this.pnlUntiOsikko.Controls.Add(this.rdbOsikko);
            this.pnlUntiOsikko.Controls.Add(this.rdbUnti);
            this.pnlUntiOsikko.Location = new System.Drawing.Point(32, 91);
            this.pnlUntiOsikko.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUntiOsikko.Name = "pnlUntiOsikko";
            this.pnlUntiOsikko.Size = new System.Drawing.Size(251, 191);
            this.pnlUntiOsikko.TabIndex = 6;
            // 
            // lblBabySub
            // 
            this.lblBabySub.AutoSize = true;
            this.lblBabySub.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.lblBabySub.Location = new System.Drawing.Point(13, 36);
            this.lblBabySub.Name = "lblBabySub";
            this.lblBabySub.Size = new System.Drawing.Size(92, 17);
            this.lblBabySub.TabIndex = 18;
            this.lblBabySub.Text = "ミルクの種類";
            // 
            // rdbOsikko
            // 
            this.rdbOsikko.AutoSize = true;
            this.rdbOsikko.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.rdbOsikko.Location = new System.Drawing.Point(47, 131);
            this.rdbOsikko.Margin = new System.Windows.Forms.Padding(5);
            this.rdbOsikko.Name = "rdbOsikko";
            this.rdbOsikko.Size = new System.Drawing.Size(78, 21);
            this.rdbOsikko.TabIndex = 1;
            this.rdbOsikko.TabStop = true;
            this.rdbOsikko.Text = "おしっこ";
            this.rdbOsikko.UseVisualStyleBackColor = true;
            // 
            // rdbUnti
            // 
            this.rdbUnti.AutoSize = true;
            this.rdbUnti.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.rdbUnti.Location = new System.Drawing.Point(47, 81);
            this.rdbUnti.Margin = new System.Windows.Forms.Padding(4);
            this.rdbUnti.Name = "rdbUnti";
            this.rdbUnti.Size = new System.Drawing.Size(66, 21);
            this.rdbUnti.TabIndex = 0;
            this.rdbUnti.TabStop = true;
            this.rdbUnti.Text = "うんち";
            this.rdbUnti.UseVisualStyleBackColor = true;
            // 
            // txbComment
            // 
            this.txbComment.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.txbComment.Location = new System.Drawing.Point(323, 221);
            this.txbComment.Margin = new System.Windows.Forms.Padding(4);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(319, 24);
            this.txbComment.TabIndex = 8;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.lblComment.Location = new System.Drawing.Point(330, 200);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(57, 17);
            this.lblComment.TabIndex = 13;
            this.lblComment.Text = "コメント";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.lblTime.Location = new System.Drawing.Point(515, 31);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(25, 17);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "時";
            // 
            // lblMinit
            // 
            this.lblMinit.AutoSize = true;
            this.lblMinit.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.lblMinit.Location = new System.Drawing.Point(697, 31);
            this.lblMinit.Name = "lblMinit";
            this.lblMinit.Size = new System.Drawing.Size(25, 17);
            this.lblMinit.TabIndex = 15;
            this.lblMinit.Text = "分";
            // 
            // FormOmutuRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMinit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.pnlUntiOsikko);
            this.Controls.Add(this.cmbMinit);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.dtpMonthDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormOmutuRestore";
            this.Text = "オムツ登録画面";
            this.Load += new System.EventHandler(this.FormOmutuRestore_Load);
            this.pnlUntiOsikko.ResumeLayout(false);
            this.pnlUntiOsikko.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpMonthDay;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.ComboBox cmbMinit;
        private System.Windows.Forms.Panel pnlUntiOsikko;
        private System.Windows.Forms.RadioButton rdbOsikko;
        private System.Windows.Forms.RadioButton rdbUnti;
        private System.Windows.Forms.TextBox txbComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMinit;
        private System.Windows.Forms.Label lblBabySub;
    }
}