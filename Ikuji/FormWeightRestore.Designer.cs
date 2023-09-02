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
            this.btnReturn = new System.Windows.Forms.Button();
            this.dtpMonthDay = new System.Windows.Forms.DateTimePicker();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.txbTemperature = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(9, 10);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(56, 18);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Location = new System.Drawing.Point(99, 12);
            this.dtpMonthDay.Name = "dtpMonthDay";
            this.dtpMonthDay.Size = new System.Drawing.Size(87, 19);
            this.dtpMonthDay.TabIndex = 4;
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(27, 108);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(141, 19);
            this.txbWeight.TabIndex = 5;
            // 
            // txbTemperature
            // 
            this.txbTemperature.Location = new System.Drawing.Point(27, 167);
            this.txbTemperature.Name = "txbTemperature";
            this.txbTemperature.Size = new System.Drawing.Size(141, 19);
            this.txbTemperature.TabIndex = 6;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(27, 272);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(180, 25);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "登録ボタン";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(294, 275);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(240, 19);
            this.txbComment.TabIndex = 9;
            // 
            // FormWeightRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.txbTemperature);
            this.Controls.Add(this.txbWeight);
            this.Controls.Add(this.dtpMonthDay);
            this.Controls.Add(this.btnReturn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormWeightRestore";
            this.Text = "FormWeightRestore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dtpMonthDay;
        private System.Windows.Forms.TextBox txbWeight;
        private System.Windows.Forms.TextBox txbTemperature;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txbComment;
    }
}