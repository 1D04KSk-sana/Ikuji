﻿namespace Ikuji
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
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnMilkRestore = new System.Windows.Forms.Button();
            this.btnOmutuRestore = new System.Windows.Forms.Button();
            this.btnWeightRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnGraph.Location = new System.Drawing.Point(327, 257);
            this.btnGraph.Margin = new System.Windows.Forms.Padding(2);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(117, 33);
            this.btnGraph.TabIndex = 2;
            this.btnGraph.Text = "グラフ表示";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnMilkRestore
            // 
            this.btnMilkRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.btnMilkRestore.Location = new System.Drawing.Point(127, 199);
            this.btnMilkRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnMilkRestore.Name = "btnMilkRestore";
            this.btnMilkRestore.Size = new System.Drawing.Size(117, 33);
            this.btnMilkRestore.TabIndex = 4;
            this.btnMilkRestore.Text = "授乳記録";
            this.btnMilkRestore.UseVisualStyleBackColor = false;
            this.btnMilkRestore.Click += new System.EventHandler(this.btnMilkRestore_Click);
            // 
            // btnOmutuRestore
            // 
            this.btnOmutuRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.btnOmutuRestore.Location = new System.Drawing.Point(127, 250);
            this.btnOmutuRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnOmutuRestore.Name = "btnOmutuRestore";
            this.btnOmutuRestore.Size = new System.Drawing.Size(117, 33);
            this.btnOmutuRestore.TabIndex = 5;
            this.btnOmutuRestore.Text = "オムツ記録";
            this.btnOmutuRestore.UseVisualStyleBackColor = false;
            this.btnOmutuRestore.Click += new System.EventHandler(this.btnOmutuRestore_Click);
            // 
            // btnWeightRestore
            // 
            this.btnWeightRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.btnWeightRestore.Location = new System.Drawing.Point(327, 199);
            this.btnWeightRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnWeightRestore.Name = "btnWeightRestore";
            this.btnWeightRestore.Size = new System.Drawing.Size(117, 33);
            this.btnWeightRestore.TabIndex = 6;
            this.btnWeightRestore.Text = "体重体温記録";
            this.btnWeightRestore.UseVisualStyleBackColor = false;
            this.btnWeightRestore.Click += new System.EventHandler(this.btnWeightRestore_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btnWeightRestore);
            this.Controls.Add(this.btnOmutuRestore);
            this.Controls.Add(this.btnMilkRestore);
            this.Controls.Add(this.btnGraph);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnMilkRestore;
        private System.Windows.Forms.Button btnOmutuRestore;
        private System.Windows.Forms.Button btnWeightRestore;
    }
}

