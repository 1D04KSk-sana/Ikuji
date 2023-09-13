namespace Ikuji
{
    partial class FormMilkTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMilkTimer));
            this.timMilk = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnTimerStart = new System.Windows.Forms.Button();
            this.btnTimerStop = new System.Windows.Forms.Button();
            this.ntfTimerAlart = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnTimeUp = new System.Windows.Forms.Button();
            this.btnTimeDown = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timMilk
            // 
            this.timMilk.Interval = 1000;
            this.timMilk.Tick += new System.EventHandler(this.timMilk_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("MS UI Gothic", 50F);
            this.lblTimer.Location = new System.Drawing.Point(280, 67);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(220, 84);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "10:00";
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.Location = new System.Drawing.Point(217, 316);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(157, 70);
            this.btnTimerStart.TabIndex = 1;
            this.btnTimerStart.Text = "スタート";
            this.btnTimerStart.UseVisualStyleBackColor = true;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // btnTimerStop
            // 
            this.btnTimerStop.Location = new System.Drawing.Point(399, 316);
            this.btnTimerStop.Name = "btnTimerStop";
            this.btnTimerStop.Size = new System.Drawing.Size(157, 70);
            this.btnTimerStop.TabIndex = 2;
            this.btnTimerStop.Text = "ストップ";
            this.btnTimerStop.UseVisualStyleBackColor = true;
            this.btnTimerStop.Click += new System.EventHandler(this.btnTimerStop_Click);
            // 
            // ntfTimerAlart
            // 
            this.ntfTimerAlart.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfTimerAlart.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfTimerAlart.Icon")));
            this.ntfTimerAlart.Visible = true;
            // 
            // btnTimeUp
            // 
            this.btnTimeUp.Location = new System.Drawing.Point(217, 228);
            this.btnTimeUp.Name = "btnTimeUp";
            this.btnTimeUp.Size = new System.Drawing.Size(157, 70);
            this.btnTimeUp.TabIndex = 3;
            this.btnTimeUp.Text = "１分増やす";
            this.btnTimeUp.UseVisualStyleBackColor = true;
            this.btnTimeUp.Click += new System.EventHandler(this.btnTimeUp_Click);
            // 
            // btnTimeDown
            // 
            this.btnTimeDown.Location = new System.Drawing.Point(399, 228);
            this.btnTimeDown.Name = "btnTimeDown";
            this.btnTimeDown.Size = new System.Drawing.Size(157, 70);
            this.btnTimeDown.TabIndex = 4;
            this.btnTimeDown.Text = "１分減らす";
            this.btnTimeDown.UseVisualStyleBackColor = true;
            this.btnTimeDown.Click += new System.EventHandler(this.btnTimeDown_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(52, 22);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormMilkTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnTimeDown);
            this.Controls.Add(this.btnTimeUp);
            this.Controls.Add(this.btnTimerStop);
            this.Controls.Add(this.btnTimerStart);
            this.Controls.Add(this.lblTimer);
            this.Name = "FormMilkTimer";
            this.Text = "授乳タイマー";
            this.Load += new System.EventHandler(this.FormMilkTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timMilk;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnTimerStart;
        private System.Windows.Forms.Button btnTimerStop;
        private System.Windows.Forms.NotifyIcon ntfTimerAlart;
        private System.Windows.Forms.Button btnTimeUp;
        private System.Windows.Forms.Button btnTimeDown;
        private System.Windows.Forms.Button btnReturn;
    }
}