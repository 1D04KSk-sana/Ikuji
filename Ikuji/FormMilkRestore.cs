using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikuji
{
    public partial class FormMilkRestore : Form
    {
        public FormMilkRestore()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();

            formMain.Show();

            this.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string milkYearAndMonth,milkHour,milkMinute,milkComment;

            milkYearAndMonth = dtpMonthDay.Text;

            milkHour = cmbHour.Text;

            milkMinute = cmbMinit.Text;

            milkComment = txbComment.Text;

            MessageBox.Show(milkYearAndMonth+milkHour+milkMinute+milkComment);
        }
    }
}
