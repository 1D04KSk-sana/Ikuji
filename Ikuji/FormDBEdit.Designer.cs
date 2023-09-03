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
            this.btnReturn = new System.Windows.Forms.Button();
            this.dtpMonthDay = new System.Windows.Forms.DateTimePicker();
            this.cmbViewChange = new System.Windows.Forms.ComboBox();
            this.dgvRecordEditing = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordEditing)).BeginInit();
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
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Location = new System.Drawing.Point(116, 15);
            this.dtpMonthDay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMonthDay.Name = "dtpMonthDay";
            this.dtpMonthDay.Size = new System.Drawing.Size(115, 22);
            this.dtpMonthDay.TabIndex = 3;
            // 
            // cmbViewChange
            // 
            this.cmbViewChange.FormattingEnabled = true;
            this.cmbViewChange.Location = new System.Drawing.Point(16, 71);
            this.cmbViewChange.Margin = new System.Windows.Forms.Padding(4);
            this.cmbViewChange.Name = "cmbViewChange";
            this.cmbViewChange.Size = new System.Drawing.Size(93, 23);
            this.cmbViewChange.TabIndex = 4;
            // 
            // dgvRecordEditing
            // 
            this.dgvRecordEditing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecordEditing.Location = new System.Drawing.Point(28, 218);
            this.dgvRecordEditing.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecordEditing.Name = "dgvRecordEditing";
            this.dgvRecordEditing.RowHeadersWidth = 51;
            this.dgvRecordEditing.RowTemplate.Height = 21;
            this.dgvRecordEditing.Size = new System.Drawing.Size(708, 191);
            this.dgvRecordEditing.TabIndex = 5;
            this.dgvRecordEditing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecordEditing_CellClick);
            // 
            // FormDBEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRecordEditing);
            this.Controls.Add(this.cmbViewChange);
            this.Controls.Add(this.dtpMonthDay);
            this.Controls.Add(this.btnReturn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDBEdit";
            this.Text = "FormDBEdit";
            this.Load += new System.EventHandler(this.FormDBEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordEditing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dtpMonthDay;
        private System.Windows.Forms.ComboBox cmbViewChange;
        private System.Windows.Forms.DataGridView dgvRecordEditing;
    }
}