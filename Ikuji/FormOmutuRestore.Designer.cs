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
            this.dtpMonthDay = new System.Windows.Forms.DateTimePicker();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.cmbMinit = new System.Windows.Forms.ComboBox();
            this.pnlUntiOsikko = new System.Windows.Forms.Panel();
            this.rdbOsikko = new System.Windows.Forms.RadioButton();
            this.rdbUnti = new System.Windows.Forms.RadioButton();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.pnlUntiOsikko.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Location = new System.Drawing.Point(173, 24);
            this.dtpMonthDay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMonthDay.Name = "dtpMonthDay";
            this.dtpMonthDay.Size = new System.Drawing.Size(115, 22);
            this.dtpMonthDay.TabIndex = 3;
            // 
            // cmbHour
            // 
            this.cmbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbHour.Location = new System.Drawing.Point(457, 24);
            this.cmbHour.Margin = new System.Windows.Forms.Padding(5);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(97, 23);
            this.cmbHour.TabIndex = 4;
            // 
            // cmbMinit
            // 
            this.cmbMinit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbMinit.Location = new System.Drawing.Point(603, 22);
            this.cmbMinit.Margin = new System.Windows.Forms.Padding(5);
            this.cmbMinit.Name = "cmbMinit";
            this.cmbMinit.Size = new System.Drawing.Size(97, 23);
            this.cmbMinit.TabIndex = 5;
            // 
            // pnlUntiOsikko
            // 
            this.pnlUntiOsikko.Controls.Add(this.rdbOsikko);
            this.pnlUntiOsikko.Controls.Add(this.rdbUnti);
            this.pnlUntiOsikko.Location = new System.Drawing.Point(39, 102);
            this.pnlUntiOsikko.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUntiOsikko.Name = "pnlUntiOsikko";
            this.pnlUntiOsikko.Size = new System.Drawing.Size(251, 244);
            this.pnlUntiOsikko.TabIndex = 6;
            // 
            // rdbOsikko
            // 
            this.rdbOsikko.AutoSize = true;
            this.rdbOsikko.Location = new System.Drawing.Point(47, 145);
            this.rdbOsikko.Margin = new System.Windows.Forms.Padding(5);
            this.rdbOsikko.Name = "rdbOsikko";
            this.rdbOsikko.Size = new System.Drawing.Size(70, 19);
            this.rdbOsikko.TabIndex = 1;
            this.rdbOsikko.TabStop = true;
            this.rdbOsikko.Text = "おしっこ";
            this.rdbOsikko.UseVisualStyleBackColor = true;
            // 
            // rdbUnti
            // 
            this.rdbUnti.AutoSize = true;
            this.rdbUnti.Location = new System.Drawing.Point(47, 68);
            this.rdbUnti.Margin = new System.Windows.Forms.Padding(4);
            this.rdbUnti.Name = "rdbUnti";
            this.rdbUnti.Size = new System.Drawing.Size(60, 19);
            this.rdbUnti.TabIndex = 0;
            this.rdbUnti.TabStop = true;
            this.rdbUnti.Text = "うんち";
            this.rdbUnti.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.btnRestore.Location = new System.Drawing.Point(36, 366);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(160, 61);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Text = "登録ボタン";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(381, 385);
            this.txbComment.Margin = new System.Windows.Forms.Padding(4);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(319, 22);
            this.txbComment.TabIndex = 8;
            // 
            // FormOmutuRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.pnlUntiOsikko);
            this.Controls.Add(this.cmbMinit);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.dtpMonthDay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOmutuRestore";
            this.Text = "FormOmutuRestore";
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
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txbComment;
    }
}