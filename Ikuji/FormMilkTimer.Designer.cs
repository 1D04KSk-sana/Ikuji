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
            this.ntfTimerAlart = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlTimer = new System.Windows.Forms.Panel();
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
            this.lblTimer.Font = new System.Drawing.Font("MS UI Gothic", 100F);
            this.lblTimer.Location = new System.Drawing.Point(124, 73);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(440, 167);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "10:00";
            // 
            // ntfTimerAlart
            // 
            this.ntfTimerAlart.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfTimerAlart.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfTimerAlart.Icon")));
            this.ntfTimerAlart.Visible = true;
            // 
            // pnlTimer
            // 
            this.pnlTimer.Location = new System.Drawing.Point(39, 221);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(525, 127);
            this.pnlTimer.TabIndex = 1;
            // 
            // FormMilkTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.pnlTimer);
            this.Controls.Add(this.lblTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMilkTimer";
            this.Text = "授乳タイマー";
            this.Load += new System.EventHandler(this.FormMilkTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timMilk;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.NotifyIcon ntfTimerAlart;
        private System.Windows.Forms.Panel pnlTimer;
    }
}