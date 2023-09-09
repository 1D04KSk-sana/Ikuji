﻿namespace Ikuji
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordEditing)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpMonthDay
            // 
            this.dtpMonthDay.Location = new System.Drawing.Point(131, 19);
            this.dtpMonthDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpMonthDay.Name = "dtpMonthDay";
            this.dtpMonthDay.Size = new System.Drawing.Size(115, 22);
            this.dtpMonthDay.TabIndex = 3;
            // 
            // cmbViewChange
            // 
            this.cmbViewChange.FormattingEnabled = true;
            this.cmbViewChange.Items.AddRange(new object[] {
            "全部",
            "ミルク",
            "オムツ",
            "体重・体温"});
            this.cmbViewChange.Location = new System.Drawing.Point(16, 71);
            this.cmbViewChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbViewChange.Name = "cmbViewChange";
            this.cmbViewChange.Size = new System.Drawing.Size(93, 23);
            this.cmbViewChange.TabIndex = 4;
            this.cmbViewChange.SelectedIndexChanged += new System.EventHandler(this.cmbViewChange_SelectedIndexChanged);
            // 
            // dgvRecordEditing
            // 
            this.dgvRecordEditing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecordEditing.Location = new System.Drawing.Point(12, 139);
            this.dgvRecordEditing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRecordEditing.Name = "dgvRecordEditing";
            this.dgvRecordEditing.RowHeadersWidth = 51;
            this.dgvRecordEditing.RowTemplate.Height = 21;
            this.dgvRecordEditing.Size = new System.Drawing.Size(775, 298);
            this.dgvRecordEditing.TabIndex = 5;
            this.dgvRecordEditing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecordEditing_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(117, 58);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(213, 58);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 25);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // FormDBEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvRecordEditing);
            this.Controls.Add(this.cmbViewChange);
            this.Controls.Add(this.dtpMonthDay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDBEdit";
            this.Text = "FormDBEdit";
            this.Load += new System.EventHandler(this.FormDBEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordEditing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpMonthDay;
        private System.Windows.Forms.ComboBox cmbViewChange;
        private System.Windows.Forms.DataGridView dgvRecordEditing;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}