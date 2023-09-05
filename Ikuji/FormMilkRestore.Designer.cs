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
            this.rbdBonyu = new System.Windows.Forms.RadioButton();
            this.rdbMilk = new System.Windows.Forms.RadioButton();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.pnlMilkBonyu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(15, 14);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(94, 26);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Location = new System.Drawing.Point(139, 14);
            this.dtpMonthDay.Margin = new System.Windows.Forms.Padding(5);
            this.dtpMonthDay.Name = "dtpMonthDay";
            this.dtpMonthDay.Size = new System.Drawing.Size(143, 25);
            this.dtpMonthDay.TabIndex = 2;
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(566, 12);
            this.cmbHour.Margin = new System.Windows.Forms.Padding(5);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(120, 26);
            this.cmbHour.TabIndex = 3;
            // 
            // cmbMinit
            // 
            this.cmbMinit.FormattingEnabled = true;
            this.cmbMinit.Items.AddRange(new object[] {
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
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2",
            "2"});
            this.cmbMinit.Location = new System.Drawing.Point(761, 12);
            this.cmbMinit.Margin = new System.Windows.Forms.Padding(5);
            this.cmbMinit.Name = "cmbMinit";
            this.cmbMinit.Size = new System.Drawing.Size(120, 26);
            this.cmbMinit.TabIndex = 4;
            // 
            // pnlMilkBonyu
            // 
            this.pnlMilkBonyu.Controls.Add(this.rbdBonyu);
            this.pnlMilkBonyu.Controls.Add(this.rdbMilk);
            this.pnlMilkBonyu.Location = new System.Drawing.Point(25, 98);
            this.pnlMilkBonyu.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMilkBonyu.Name = "pnlMilkBonyu";
            this.pnlMilkBonyu.Size = new System.Drawing.Size(314, 293);
            this.pnlMilkBonyu.TabIndex = 5;
            // 
            // rbdBonyu
            // 
            this.rbdBonyu.AutoSize = true;
            this.rbdBonyu.Location = new System.Drawing.Point(59, 174);
            this.rbdBonyu.Margin = new System.Windows.Forms.Padding(5);
            this.rbdBonyu.Name = "rbdBonyu";
            this.rbdBonyu.Size = new System.Drawing.Size(109, 22);
            this.rbdBonyu.TabIndex = 1;
            this.rbdBonyu.TabStop = true;
            this.rbdBonyu.Text = "母乳ボタン";
            this.rbdBonyu.UseVisualStyleBackColor = true;
            // 
            // rdbMilk
            // 
            this.rdbMilk.AutoSize = true;
            this.rdbMilk.Location = new System.Drawing.Point(59, 82);
            this.rdbMilk.Margin = new System.Windows.Forms.Padding(5);
            this.rdbMilk.Name = "rdbMilk";
            this.rdbMilk.Size = new System.Drawing.Size(129, 22);
            this.rdbMilk.TabIndex = 0;
            this.rdbMilk.TabStop = true;
            this.rdbMilk.Text = "粉ミルクボタン";
            this.rdbMilk.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(36, 439);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(5);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(300, 37);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "登録ボタン";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(514, 444);
            this.txbComment.Margin = new System.Windows.Forms.Padding(5);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(398, 25);
            this.txbComment.TabIndex = 7;
            // 
            // FormMilkRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.pnlMilkBonyu);
            this.Controls.Add(this.cmbMinit);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.dtpMonthDay);
            this.Controls.Add(this.btnReturn);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormMilkRestore";
            this.Text = "FormMilk";
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
        private System.Windows.Forms.RadioButton rbdBonyu;
        private System.Windows.Forms.RadioButton rdbMilk;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txbComment;
    }
}