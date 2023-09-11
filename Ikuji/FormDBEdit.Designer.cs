namespace Ikuji
{
    partial class FormDBEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDBEdit));
            this.dtpMonthDay = new System.Windows.Forms.DateTimePicker();
            this.cmbViewChange = new System.Windows.Forms.ComboBox();
            this.dgvRecordEditing = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordEditing)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Location = new System.Drawing.Point(120, 17);
            this.dtpMonthDay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpMonthDay.Name = "dtpMonthDay";
            this.dtpMonthDay.Size = new System.Drawing.Size(130, 19);
            this.dtpMonthDay.TabIndex = 3;
            // 
            // cmbViewChange
            // 
            this.cmbViewChange.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.cmbViewChange.FormattingEnabled = true;
            this.cmbViewChange.Items.AddRange(new object[] {
            "全部",
            "ミルク",
            "オムツ",
            "体重・体温"});
            this.cmbViewChange.Location = new System.Drawing.Point(8, 57);
            this.cmbViewChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbViewChange.Name = "cmbViewChange";
            this.cmbViewChange.Size = new System.Drawing.Size(98, 25);
            this.cmbViewChange.TabIndex = 4;
            this.cmbViewChange.SelectedIndexChanged += new System.EventHandler(this.cmbViewChange_SelectedIndexChanged);
            // 
            // dgvRecordEditing
            // 
            this.dgvRecordEditing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecordEditing.Location = new System.Drawing.Point(8, 111);
            this.dgvRecordEditing.Name = "dgvRecordEditing";
            this.dgvRecordEditing.RowHeadersWidth = 51;
            this.dgvRecordEditing.RowTemplate.Height = 21;
            this.dgvRecordEditing.Size = new System.Drawing.Size(581, 238);
            this.dgvRecordEditing.TabIndex = 5;
            this.dgvRecordEditing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecordEditing_CellClick);
            // 
            // FormDBEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.dgvRecordEditing);
            this.Controls.Add(this.cmbViewChange);
            this.Controls.Add(this.dtpMonthDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormDBEdit";
            this.Text = "記録編集画面";
            this.Load += new System.EventHandler(this.FormDBEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordEditing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpMonthDay;
        private System.Windows.Forms.ComboBox cmbViewChange;
        private System.Windows.Forms.DataGridView dgvRecordEditing;
    }
}