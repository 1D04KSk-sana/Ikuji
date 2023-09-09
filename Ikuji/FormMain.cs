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
            //btnBabyRestore
            SideRoundButton btnBabyRestore = new SideRoundButton(0);
            btnBabyRestore.Text = "赤ちゃん情報編集";
            btnBabyRestore.Size = new System.Drawing.Size(117, 33);
            btnBabyRestore.Location = new System.Drawing.Point(62, 24);
            btnBabyRestore.Click += new System.EventHandler(this.btnBabyRestore_Click);
            

            //btnDBEdit
            SideRoundButton btnDBEdit = new SideRoundButton(0);
            btnDBEdit.Text = "記録編集";
            btnDBEdit.Size = new System.Drawing.Size(117, 33);
            btnDBEdit.Location = new System.Drawing.Point(404, 24);
            btnDBEdit.Click += new System.EventHandler(this.btnDBEdit_Click);
            this.Controls.Add(btnBabyRestore);
            this.Controls.Add(btnDBEdit);

            //btnMilkRestore
            SideRoundButton btnMilkRestore = new SideRoundButton(1);
            btnMilkRestore.Text = "授乳記録";
            btnMilkRestore.Size = new System.Drawing.Size(117, 33);
            btnMilkRestore.Location = new System.Drawing.Point(127, 199);
            btnMilkRestore.Click += new System.EventHandler(this.btnMilkRestore_Click);
            this.Controls.Add(btnMilkRestore);
            this.Controls.Add(btnDBEdit);

            //btnOmutuRestore
            SideRoundButton btnOmutuRestore = new SideRoundButton(1);
            btnOmutuRestore.Text = "オムツ記録";
            btnOmutuRestore.Size = new System.Drawing.Size(117, 33);
            btnOmutuRestore.Location = new System.Drawing.Point(127, 250);
            btnOmutuRestore.Click += new System.EventHandler(this.btnOmutuRestore_Click);
            this.Controls.Add(btnOmutuRestore);
            this.Controls.Add(btnDBEdit);

            //btnWeightRestore
            SideRoundButton btnWeightRestore = new SideRoundButton(1);
            btnWeightRestore.Text = "体重・体温記録";
            btnWeightRestore.Size = new System.Drawing.Size(117, 33);
            btnWeightRestore.Location = new System.Drawing.Point(327, 199);
            btnWeightRestore.Click += new System.EventHandler(this.btnWeightRestore_Click);
            this.Controls.Add(btnWeightRestore);
            this.Controls.Add(btnDBEdit);

            //btnGraph
            SideRoundButton btnGraph = new SideRoundButton(2);
            btnGraph.Text = "グラフ表示";
            btnGraph.Size = new System.Drawing.Size(117, 33);
            btnGraph.Location = new System.Drawing.Point(327, 250);
            btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            this.Controls.Add(btnGraph);
            this.Controls.Add(btnDBEdit);
        }
    }
}
