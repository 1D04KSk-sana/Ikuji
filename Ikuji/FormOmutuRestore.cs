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
    public partial class FormOmutuRestore : Form
    {
        public FormOmutuRestore()
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
            string omutsuYearAndDay,omutsuHour,omutsuMinute,omutsuComment;

            omutsuYearAndDay = dtpMonthDay.Text;

            omutsuHour = cmbHour.Text;

            omutsuMinute = cmbMinit.Text;

            omutsuComment = txbComment.Text;
        }
    }
}
