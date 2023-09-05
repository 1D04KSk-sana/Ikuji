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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnBabyRestore_Click(object sender, EventArgs e)
        {
            FormBabyRestore formBabyRestore = new FormBabyRestore();

            formBabyRestore.Owner = this;
            formBabyRestore.FormClosed += ChildForm_FormClosed;
            formBabyRestore.Show();

            this.Hide();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            FormGraph formGraph = new FormGraph();

            formGraph.Owner = this;
            formGraph.FormClosed += ChildForm_FormClosed;
            formGraph.Show();

            this.Hide();
        }

        private void btnDBEdit_Click(object sender, EventArgs e)
        {
            FormDBEdit formDBEdit = new FormDBEdit();

            formDBEdit.Owner = this;
            formDBEdit.FormClosed += ChildForm_FormClosed;
            formDBEdit.Show();

            this.Hide();
        }

        private void btnMilkRestore_Click(object sender, EventArgs e)
        {
            FormMilkRestore formMilkRestore = new FormMilkRestore();

            formMilkRestore.Owner = this;
            formMilkRestore.FormClosed += ChildForm_FormClosed;
            formMilkRestore.Show();

            this.Hide();
        }

        private void btnOmutuRestore_Click(object sender, EventArgs e)
        {
            FormOmutuRestore formOmutuRestore = new FormOmutuRestore();

            formOmutuRestore.Owner = this;
            formOmutuRestore.FormClosed += ChildForm_FormClosed;
            formOmutuRestore.Show();

            this.Hide();
        }

        private void btnWeightRestore_Click(object sender, EventArgs e)
        {
            FormWeightRestore formWeightRestore = new FormWeightRestore();

            formWeightRestore.Owner = this;
            formWeightRestore.FormClosed += ChildForm_FormClosed;
            formWeightRestore.Show();

            this.Hide();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
