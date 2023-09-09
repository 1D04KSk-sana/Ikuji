namespace Ikuji
{
    partial class FormGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraph));
            this.dtpMonthDay = new System.Windows.Forms.DateTimePicker();
            this.cmbGraphChange = new System.Windows.Forms.ComboBox();
            this.grfHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grfHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Location = new System.Drawing.Point(121, 15);
            this.dtpMonthDay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMonthDay.Name = "dtpMonthDay";
            this.dtpMonthDay.Size = new System.Drawing.Size(115, 22);
            this.dtpMonthDay.TabIndex = 4;
            this.dtpMonthDay.ValueChanged += new System.EventHandler(this.dtpMonthDay_ValueChanged);
            // 
            // cmbGraphChange
            // 
            this.cmbGraphChange.FormattingEnabled = true;
            this.cmbGraphChange.Items.AddRange(new object[] {
            "-選択されていません-",
            "ミルク",
            "オムツ",
            "体重",
            "体温"});
            this.cmbGraphChange.Location = new System.Drawing.Point(284, 12);
            this.cmbGraphChange.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGraphChange.Name = "cmbGraphChange";
            this.cmbGraphChange.Size = new System.Drawing.Size(93, 23);
            this.cmbGraphChange.TabIndex = 5;
            this.cmbGraphChange.SelectedIndexChanged += new System.EventHandler(this.cmbGraphChange_SelectedIndexChanged);
            // 
            // grfHistory
            // 
            chartArea1.Name = "ChartArea1";
            this.grfHistory.ChartAreas.Add(chartArea1);
            this.grfHistory.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.grfHistory.Location = new System.Drawing.Point(16, 79);
            this.grfHistory.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grfHistory.Name = "grfHistory";
            this.grfHistory.Size = new System.Drawing.Size(992, 393);
            this.grfHistory.TabIndex = 6;
            this.grfHistory.Text = "chart1";
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1024, 487);
            this.Controls.Add(this.grfHistory);
            this.Controls.Add(this.cmbGraphChange);
            this.Controls.Add(this.dtpMonthDay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGraph";
            this.Text = "FormGraph";
            this.Load += new System.EventHandler(this.FormGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grfHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpMonthDay;
        private System.Windows.Forms.ComboBox cmbGraphChange;
        private System.Windows.Forms.DataVisualization.Charting.Chart grfHistory;
    }
}