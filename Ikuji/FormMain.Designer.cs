namespace Ikuji
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ntfBabyInfomation = new System.Windows.Forms.NotifyIcon(this.components);
            this.pctSetting = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ntfBabyInfomation
            // 
            this.ntfBabyInfomation.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfBabyInfomation.Icon")));
            this.ntfBabyInfomation.Text = "notifyIcon1";
            this.ntfBabyInfomation.Visible = true;
            // 
            // pctSetting
            // 
            this.pctSetting.Image = global::Ikuji.Properties.Resources.Setting;
            this.pctSetting.Location = new System.Drawing.Point(762, 411);
            this.pctSetting.Name = "pctSetting";
            this.pctSetting.Size = new System.Drawing.Size(25, 25);
            this.pctSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSetting.TabIndex = 1;
            this.pctSetting.TabStop = false;
            this.pctSetting.Click += new System.EventHandler(this.pctSetting_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::Ikuji.Properties.Resources.Icon_Touka_Mini;
            this.pctLogo.Location = new System.Drawing.Point(277, 54);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(200, 200);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctSetting);
            this.Controls.Add(this.pctLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Ikuji";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.NotifyIcon ntfBabyInfomation;
        private System.Windows.Forms.PictureBox pctSetting;
    }
}

