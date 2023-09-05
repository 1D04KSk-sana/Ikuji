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
            this.btnBabyRestore = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnDBEdit = new System.Windows.Forms.Button();
            this.btnMilkRestore = new System.Windows.Forms.Button();
            this.btnOmutuRestore = new System.Windows.Forms.Button();
            this.btnWeightRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBabyRestore
            // 
            this.btnBabyRestore.Location = new System.Drawing.Point(9, 10);
            this.btnBabyRestore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBabyRestore.Name = "btnBabyRestore";
            this.btnBabyRestore.Size = new System.Drawing.Size(104, 18);
            this.btnBabyRestore.TabIndex = 1;
            this.btnBabyRestore.Text = "赤ちゃん情報編集";
            this.btnBabyRestore.UseVisualStyleBackColor = true;
            this.btnBabyRestore.Click += new System.EventHandler(this.btnBabyRestore_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(9, 259);
            this.btnGraph.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(104, 18);
            this.btnGraph.TabIndex = 2;
            this.btnGraph.Text = "グラフ表示";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnDBEdit
            // 
            this.btnDBEdit.Location = new System.Drawing.Point(263, 259);
            this.btnDBEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDBEdit.Name = "btnDBEdit";
            this.btnDBEdit.Size = new System.Drawing.Size(104, 18);
            this.btnDBEdit.TabIndex = 3;
            this.btnDBEdit.Text = "記録編集";
            this.btnDBEdit.UseVisualStyleBackColor = true;
            this.btnDBEdit.Click += new System.EventHandler(this.btnDBEdit_Click);
            // 
            // btnMilkRestore
            // 
            this.btnMilkRestore.Location = new System.Drawing.Point(9, 282);
            this.btnMilkRestore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMilkRestore.Name = "btnMilkRestore";
            this.btnMilkRestore.Size = new System.Drawing.Size(104, 18);
            this.btnMilkRestore.TabIndex = 4;
            this.btnMilkRestore.Text = "授乳記録";
            this.btnMilkRestore.UseVisualStyleBackColor = true;
            this.btnMilkRestore.Click += new System.EventHandler(this.btnMilkRestore_Click);
            // 
            // btnOmutuRestore
            // 
            this.btnOmutuRestore.Location = new System.Drawing.Point(263, 282);
            this.btnOmutuRestore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOmutuRestore.Name = "btnOmutuRestore";
            this.btnOmutuRestore.Size = new System.Drawing.Size(104, 18);
            this.btnOmutuRestore.TabIndex = 5;
            this.btnOmutuRestore.Text = "オムツ記録";
            this.btnOmutuRestore.UseVisualStyleBackColor = true;
            this.btnOmutuRestore.Click += new System.EventHandler(this.btnOmutuRestore_Click);
            // 
            // btnWeightRestore
            // 
            this.btnWeightRestore.Location = new System.Drawing.Point(9, 306);
            this.btnWeightRestore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWeightRestore.Name = "btnWeightRestore";
            this.btnWeightRestore.Size = new System.Drawing.Size(104, 18);
            this.btnWeightRestore.TabIndex = 6;
            this.btnWeightRestore.Text = "体重体温記録";
            this.btnWeightRestore.UseVisualStyleBackColor = true;
            this.btnWeightRestore.Click += new System.EventHandler(this.btnWeightRestore_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btnWeightRestore);
            this.Controls.Add(this.btnOmutuRestore);
            this.Controls.Add(this.btnMilkRestore);
            this.Controls.Add(this.btnDBEdit);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnBabyRestore);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBabyRestore;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnDBEdit;
        private System.Windows.Forms.Button btnMilkRestore;
        private System.Windows.Forms.Button btnOmutuRestore;
        private System.Windows.Forms.Button btnWeightRestore;
    }
}

