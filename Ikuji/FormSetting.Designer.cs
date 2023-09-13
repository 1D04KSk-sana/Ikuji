namespace Ikuji
{
    partial class FormSetting
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
            this.chkBirthDay = new System.Windows.Forms.CheckBox();
            this.chkOmutu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkBirthDay
            // 
            this.chkBirthDay.AutoSize = true;
            this.chkBirthDay.Checked = true;
            this.chkBirthDay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBirthDay.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkBirthDay.Location = new System.Drawing.Point(56, 103);
            this.chkBirthDay.Name = "chkBirthDay";
            this.chkBirthDay.Size = new System.Drawing.Size(163, 21);
            this.chkBirthDay.TabIndex = 0;
            this.chkBirthDay.Text = "お誕生日通知設定";
            this.chkBirthDay.UseVisualStyleBackColor = true;
            // 
            // chkOmutu
            // 
            this.chkOmutu.AutoSize = true;
            this.chkOmutu.Checked = true;
            this.chkOmutu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOmutu.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkOmutu.Location = new System.Drawing.Point(56, 169);
            this.chkOmutu.Name = "chkOmutu";
            this.chkOmutu.Size = new System.Drawing.Size(171, 21);
            this.chkOmutu.TabIndex = 1;
            this.chkOmutu.Text = "オムツ残量通知設定";
            this.chkOmutu.UseVisualStyleBackColor = true;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkOmutu);
            this.Controls.Add(this.chkBirthDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSetting";
            this.Text = "通知設定";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBirthDay;
        private System.Windows.Forms.CheckBox chkOmutu;
    }
}