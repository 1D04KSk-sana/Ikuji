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
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.btnReturn.Location = new System.Drawing.Point(27, 19);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(63, 30);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Location = new System.Drawing.Point(130, 19);
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
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.btnRestore.Location = new System.Drawing.Point(27, 293);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(120, 49);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "登録ボタン";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(297, 293);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(240, 19);
            this.txbComment.TabIndex = 9;
            // 
            // FormWeightRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.txbTemperature);
            this.Controls.Add(this.txbWeight);
            this.Controls.Add(this.dtpMonthDay);
            this.Controls.Add(this.btnReturn);
            this.Margin = new System.Windows.Forms.Padding(2);
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