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

        private void FormMain_Load(object sender, EventArgs e)
        {
            //DB使用のための変数を設定
            var context = new BabyContext();

            //クラスで設定しているDB内の項目を作成
            context.Babys.Create();

            //作成したDBを保存
            context.SaveChanges();

            //作成した変数を削除
            context.Dispose();

            //ボタンの宣言
            SetButton();
        }

        ///////////////////////////////
        //メソッド名：SetButton()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：ボタンのセット
        ///////////////////////////////
        private void SetButton()
        {
            SideRoundButton btnBabyRestore = new SideRoundButton(0)
            {
                Text = "赤ちゃん情報編集",
                Size = new System.Drawing.Size(117, 33),
                Location = new System.Drawing.Point(62, 24)
            };
            btnBabyRestore.Click += new System.EventHandler(this.btnBabyRestore_Click);
            this.Controls.Add(btnBabyRestore);

            SideRoundButton btnDBEdit = new SideRoundButton(0)
            {
                Text = "記録編集",
                Size = new System.Drawing.Size(117, 33),
                Location = new System.Drawing.Point(404, 24)
            };
            btnDBEdit.Click += new System.EventHandler(this.btnDBEdit_Click);
            this.Controls.Add(btnDBEdit);

            SideRoundButton btnMilkRestore = new SideRoundButton(1)
            {
                Text = "授乳記録",
                Size = new System.Drawing.Size(117, 33),
                Location = new System.Drawing.Point(127, 199),
            };
            btnMilkRestore.Click += new System.EventHandler(this.btnMilkRestore_Click);
            this.Controls.Add(btnMilkRestore);

            SideRoundButton btnOmutuRestore = new SideRoundButton(1)
            {
                Text = "オムツ記録",
                Size = new System.Drawing.Size(117, 33),
                Location = new System.Drawing.Point(127, 250)
            };
            btnOmutuRestore.Click += new System.EventHandler(this.btnOmutuRestore_Click);
            this.Controls.Add(btnOmutuRestore);

            SideRoundButton btnWeightRestore = new SideRoundButton(1)
            {
                Text = "体重・体温記録",
                Size = new System.Drawing.Size(117, 33),
                Location = new System.Drawing.Point(327, 199),
            };
            btnWeightRestore.Click += new System.EventHandler(this.btnWeightRestore_Click);
            this.Controls.Add(btnWeightRestore);

            SideRoundButton btnGraph = new SideRoundButton(2)
            {
                Text = "グラフ表示",
                Size = new System.Drawing.Size(117, 33),
                Location = new System.Drawing.Point(327, 250),
            };
            btnGraph.Click += new System.EventHandler(this.btnWeightRestore_Click);
            this.Controls.Add(btnGraph);
        }
    }
}
