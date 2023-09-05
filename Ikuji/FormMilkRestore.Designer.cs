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
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.btnReturn.Location = new System.Drawing.Point(9, 10);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(56, 18);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Location = new System.Drawing.Point(83, 10);
            this.dtpMonthDay.Name = "dtpMonthDay";
            this.dtpMonthDay.Size = new System.Drawing.Size(87, 19);
            this.dtpMonthDay.TabIndex = 2;
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(340, 8);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(74, 20);
            this.cmbHour.TabIndex = 3;
            // 
            // cmbMinit
            // 
            this.cmbMinit.FormattingEnabled = true;
            this.cmbMinit.Location = new System.Drawing.Point(457, 8);
            this.cmbMinit.Name = "cmbMinit";
            this.cmbMinit.Size = new System.Drawing.Size(74, 20);
            this.cmbMinit.TabIndex = 4;
            // 
            // pnlMilkBonyu
            // 
            this.pnlMilkBonyu.Controls.Add(this.rbdBonyu);
            this.pnlMilkBonyu.Controls.Add(this.rdbMilk);
            this.pnlMilkBonyu.Location = new System.Drawing.Point(15, 66);
            this.pnlMilkBonyu.Name = "pnlMilkBonyu";
            this.pnlMilkBonyu.Size = new System.Drawing.Size(188, 195);
            this.pnlMilkBonyu.TabIndex = 5;
            // 
            // rbdBonyu
            // 
            this.rbdBonyu.AutoSize = true;
            this.rbdBonyu.Location = new System.Drawing.Point(35, 116);
            this.rbdBonyu.Name = "rbdBonyu";
            this.rbdBonyu.Size = new System.Drawing.Size(74, 16);
            this.rbdBonyu.TabIndex = 1;
            this.rbdBonyu.TabStop = true;
            this.rbdBonyu.Text = "母乳ボタン";
            this.rbdBonyu.UseVisualStyleBackColor = true;
            // 
            // rdbMilk
            // 
            this.rdbMilk.AutoSize = true;
            this.rdbMilk.Location = new System.Drawing.Point(35, 54);
            this.rdbMilk.Name = "rdbMilk";
            this.rdbMilk.Size = new System.Drawing.Size(87, 16);
            this.rdbMilk.TabIndex = 0;
            this.rdbMilk.TabStop = true;
            this.rdbMilk.Text = "粉ミルクボタン";
            this.rdbMilk.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(22, 293);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(180, 25);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "登録ボタン";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(308, 296);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(240, 19);
            this.txbComment.TabIndex = 7;
            // 
            // FormMilkRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.pnlMilkBonyu);
            this.Controls.Add(this.cmbMinit);
            this.Controls.Add(this.cmbHour);
            this.Controls.Add(this.dtpMonthDay);
            this.Controls.Add(this.btnReturn);
            this.Margin = new System.Windows.Forms.Padding(2);
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