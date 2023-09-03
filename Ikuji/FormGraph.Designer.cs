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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dtpMonthDay = new System.Windows.Forms.DateTimePicker();
            this.cmbGraphChange = new System.Windows.Forms.ComboBox();
            this.grfHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grfHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 22);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "戻る";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Location = new System.Drawing.Point(121, 15);
            this.dtpMonthDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpMonthDay.Name = "dtpMonthDay";
            this.dtpMonthDay.Size = new System.Drawing.Size(115, 22);
            this.dtpMonthDay.TabIndex = 4;
            // 
            // cmbGraphChange
            // 
            this.cmbGraphChange.FormattingEnabled = true;
            this.cmbGraphChange.Location = new System.Drawing.Point(284, 12);
            this.cmbGraphChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGraphChange.Name = "cmbGraphChange";
            this.cmbGraphChange.Size = new System.Drawing.Size(93, 23);
            this.cmbGraphChange.TabIndex = 5;
            // 
            // grfHistory
            // 
            chartArea1.Name = "ChartArea1";
            this.grfHistory.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grfHistory.Legends.Add(legend1);
            this.grfHistory.Location = new System.Drawing.Point(97, 138);
            this.grfHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grfHistory.Name = "grfHistory";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grfHistory.Series.Add(series1);
            this.grfHistory.Size = new System.Drawing.Size(400, 375);
            this.grfHistory.TabIndex = 6;
            this.grfHistory.Text = "chart1";
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grfHistory);
            this.Controls.Add(this.cmbGraphChange);
            this.Controls.Add(this.dtpMonthDay);
            this.Controls.Add(this.btnReturn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGraph";
            this.Text = "FormGraph";
            ((System.ComponentModel.ISupportInitialize)(this.grfHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dtpMonthDay;
        private System.Windows.Forms.ComboBox cmbGraphChange;
        private System.Windows.Forms.DataVisualization.Charting.Chart grfHistory;
    }
}