﻿using System;
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
    public partial class FormBabyRestore : Form
    {
        public FormBabyRestore()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string babyName,babyYear,babyMonth;

            babyName = txbNameRestore.Text;

            babyYear = txbYearRestore.Text;

            babyMonth = txbMonthRestore.Text;

        }
    }
}
