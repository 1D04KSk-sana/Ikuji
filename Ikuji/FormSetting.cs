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
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            SetButton();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ///////////////////////////////
        //メソッド名：SetButton()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：ボタンのセット
        ///////////////////////////////
        private void SetButton()
        {
            SideRoundButton btnReturn = new SideRoundButton(3)
            {
                Text = "戻る",
                Size = new System.Drawing.Size(60, 30),
                Location = new System.Drawing.Point(20, 15)
            };
            btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            this.Controls.Add(btnReturn);

            SideRoundButton btnRestore = new SideRoundButton(1)
            {
                Text = "更新",
                Size = new System.Drawing.Size(150, 40),
                Location = new System.Drawing.Point(20, 260),
            };
            //btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            this.Controls.Add(btnRestore);
        }
    }
}
