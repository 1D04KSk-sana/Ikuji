namespace Ikuji
{
    partial class FormMilkRestore
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
            this.pnlMilkBonyu = new System.Windows.Forms.Panel();
            this.rdbBonyu = new System.Windows.Forms.RadioButton();
            this.rdbMilk = new System.Windows.Forms.RadioButton();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.pnlMilkBonyu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 22);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Location = new System.Drawing.Point(111, 12);
            this.dtpMonthDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpMonthDay.Name = "dtpMonthDay";
            this.dtpMonthDay.Size = new System.Drawing.Size(115, 22);
            this.dtpMonthDay.TabIndex = 2;
            // 
            // cmbHour
            // 
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
            this.cmbHour.Location = new System.Drawing.Point(453, 10);
            this.cmbHour.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(97, 23);
            this.cmbHour.TabIndex = 3;
            // 
            // cmbMinit
            // 
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
            this.cmbMinit.Location = new System.Drawing.Point(609, 10);
            this.cmbMinit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbMinit.Name = "cmbMinit";
            this.cmbMinit.Size = new System.Drawing.Size(97, 23);
            this.cmbMinit.TabIndex = 4;
            // 
            // pnlMilkBonyu
            // 
            this.pnlMilkBonyu.Controls.Add(this.rdbBonyu);
            this.pnlMilkBonyu.Controls.Add(this.rdbMilk);
            this.pnlMilkBonyu.Location = new System.Drawing.Point(20, 82);
            this.pnlMilkBonyu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMilkBonyu.Name = "pnlMilkBonyu";
            this.pnlMilkBonyu.Size = new System.Drawing.Size(251, 244);
            this.pnlMilkBonyu.TabIndex = 5;
            // 
            // rdbBonyu
            // 
            this.rdbBonyu.AutoSize = true;
            this.rdbBonyu.Location = new System.Drawing.Point(47, 145);
            this.rdbBonyu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbBonyu.Name = "rdbBonyu";
            this.rdbBonyu.Size = new System.Drawing.Size(91, 19);
            this.rdbBonyu.TabIndex = 1;
            this.rdbBonyu.TabStop = true;
            this.rdbBonyu.Text = "母乳";
            this.rdbBonyu.UseVisualStyleBackColor = true;
            // 
            // rdbMilk
            // 
            this.rdbMilk.AutoSize = true;
            this.rdbMilk.Location = new System.Drawing.Point(47, 68);
            this.rdbMilk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbMilk.Name = "rdbMilk";
            this.rdbMilk.Size = new System.Drawing.Size(107, 19);
            this.rdbMilk.TabIndex = 0;
            this.rdbMilk.TabStop = true;
            this.rdbMilk.Text = "粉ミルク";
            this.rdbMilk.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(29, 366);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(240, 31);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "登録ボタン";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(411, 370);
            this.txbComment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(319, 22);
            this.txbComment.TabIndex = 7;
            // 
            // FormMilkRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.pnlMilkBonyu);
            this.Controls.Add(this.cmbMinit);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.dtpMonthDay);
            this.Controls.Add(this.btnReturn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMilkRestore";
            this.Text = "FormMilk";
            this.Load += new System.EventHandler(this.FormMilkRestore_Load);
            this.pnlMilkBonyu.ResumeLayout(false);
            this.pnlMilkBonyu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dtpMonthDay;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.ComboBox cmbMinit;
        private System.Windows.Forms.Panel pnlMilkBonyu;
        private System.Windows.Forms.RadioButton rdbBonyu;
        private System.Windows.Forms.RadioButton rdbMilk;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txbComment;
    }
}