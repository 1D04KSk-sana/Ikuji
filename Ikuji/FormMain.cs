using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        BabyDBConnections babyDBConnections = new BabyDBConnections();

        private void btnBabyRestore_Click(object sender, EventArgs e)
        {
            FormBabyRestore formBabyRestore = new FormBabyRestore();

            formBabyRestore.Owner = this;
            formBabyRestore.FormClosed += ChildForm_FormClosed;
            formBabyRestore.Show();

            this.Opacity = 0;
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            FormGraph formGraph = new FormGraph();

            formGraph.Owner = this;
            formGraph.FormClosed += ChildForm_FormClosed;
            formGraph.Show();

            this.Opacity = 0;
        }

        private void btnDBEdit_Click(object sender, EventArgs e)
        {
            FormDBEdit formDBEdit = new FormDBEdit();

            formDBEdit.Owner = this;
            formDBEdit.FormClosed += ChildForm_FormClosed;
            formDBEdit.Show();

            this.Opacity = 0;
        }

        private void btnMilkRestore_Click(object sender, EventArgs e)
        {
            FormMilkRestore formMilkRestore = new FormMilkRestore();

            formMilkRestore.Owner = this;
            formMilkRestore.FormClosed += ChildForm_FormClosed;
            formMilkRestore.Show();

            this.Opacity = 0;
        }

        private void btnOmutuRestore_Click(object sender, EventArgs e)
        {
            FormOmutuRestore formOmutuRestore = new FormOmutuRestore();

            formOmutuRestore.Owner = this;
            formOmutuRestore.FormClosed += ChildForm_FormClosed;
            formOmutuRestore.Show();

            this.Opacity = 0;
        }

        private void btnOmutuAmount_Click(object sender, EventArgs e)
        {
            FormOmutuAmount formOmutuAmount = new FormOmutuAmount();

            formOmutuAmount.Owner = this;
            formOmutuAmount.FormClosed += ChildForm_FormClosed;
            formOmutuAmount.Show();

            this.Opacity = 0;
        }

        private void btnWeightRestore_Click(object sender, EventArgs e)
        {
            FormWeightRestore formWeightRestore = new FormWeightRestore();

            formWeightRestore.Owner = this;
            formWeightRestore.FormClosed += ChildForm_FormClosed;
            formWeightRestore.Show();

            this.Opacity = 0;
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
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
            
            if (context.BabyInfomations.Count() != 0)
            {
                SetBirthDay();
            }
            if (context.BabyOmutus.Count() == 0)
            {
                SetOmutuList();
            }

            //作成した変数を削除
            context.Dispose();

            //ボタンの宣言
            SetButton();
        }

        ///////////////////////////////
        //メソッド名：SetOmutuList()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：おむつDBのセット
        ///////////////////////////////
        private void SetOmutuList()
        {
            BabyOmutu itemSSize = new BabyOmutu()
            {
                BabyOmutuId = 1,
                BabyOmutuSize = 0,
                BabyOmutuAmount = 0
            };
            BabyOmutu itemMSize = new BabyOmutu()
            {
                BabyOmutuId = 2,
                BabyOmutuSize = 1,
                BabyOmutuAmount = 0
            };
            BabyOmutu itemLSize = new BabyOmutu()
            {
                BabyOmutuId = 3,
                BabyOmutuSize = 2,
                BabyOmutuAmount = 0
            };
            BabyOmutu itemBigSize = new BabyOmutu()
            {
                BabyOmutuId = 4,
                BabyOmutuSize = 3,
                BabyOmutuAmount = 0
            };

            babyDBConnections.AddBabyOmutuData(itemSSize);
            babyDBConnections.AddBabyOmutuData(itemMSize);
            babyDBConnections.AddBabyOmutuData(itemLSize);
            babyDBConnections.AddBabyOmutuData(itemBigSize);
        }

        ///////////////////////////////
        //メソッド名：SetBirthDay()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：日付のセット
        ///////////////////////////////
        private void SetBirthDay()
        {
            DateTime nowDateTime = DateTime.Now.Date;

            BabyInfomation babyInfomation = babyDBConnections.GetBabyInfomationData();
            DateTime birthDateTime = babyInfomation.BabyBirthDay;

            if (nowDateTime.Month == birthDateTime.Month && nowDateTime.Day == birthDateTime.Day)
            {
                int intYearOld = nowDateTime.Year - birthDateTime.Year;

                ntfBabyInfomation.BalloonTipIcon = ToolTipIcon.None;
                ntfBabyInfomation.BalloonTipTitle = "お誕生日おめでとうございます！";
                ntfBabyInfomation.BalloonTipText = intYearOld.ToString() + "歳ですね！\n健やかに育って下さい！";
                ntfBabyInfomation.ShowBalloonTip(3000);
            }

            DateTime month3DateTime = birthDateTime.AddMonths(3);
            DateTime month4DateTime = birthDateTime.AddMonths(4);

            if (nowDateTime >= month3DateTime && nowDateTime <= month4DateTime)
            {
                ntfBabyInfomation.BalloonTipIcon = ToolTipIcon.Info;
                ntfBabyInfomation.BalloonTipTitle = "三か月検診の時期が迫っています！";
                ntfBabyInfomation.BalloonTipText = "時期などの目安は通知をクリックしてサイトをご確認ください。";

                // バルーンテキストがクリックされたときのイベントハンドラを設定します
                ntfBabyInfomation.BalloonTipClicked += (sender, e) =>
                {
                    // リンクを開く処理をここに追加します
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://www.city.osaka.lg.jp/kodomo/page/0000370520.html",
                        UseShellExecute = true
                    });
                };

                ntfBabyInfomation.ShowBalloonTip(3000);
            }
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
                Location = new System.Drawing.Point(127, 220),
            };
            btnMilkRestore.Click += new System.EventHandler(this.btnMilkRestore_Click);
            this.Controls.Add(btnMilkRestore);

            SideRoundButton btnOmutuRestore = new SideRoundButton(1)
            {
                Text = "オムツ記録",
                Size = new System.Drawing.Size(117, 33),
                Location = new System.Drawing.Point(127, 280)
            };
            btnOmutuRestore.Click += new System.EventHandler(this.btnOmutuRestore_Click);
            this.Controls.Add(btnOmutuRestore);

            SideRoundButton btnOmutuAmount = new SideRoundButton(1)
            {
                Text = "+",
                Size = new System.Drawing.Size(40, 33),
                Location = new System.Drawing.Point(70, 282)
            };
            btnOmutuAmount.Click += new System.EventHandler(this.btnOmutuAmount_Click);
            this.Controls.Add(btnOmutuAmount);

            SideRoundButton btnWeightRestore = new SideRoundButton(1)
            {
                Text = "体重・体温記録",
                Size = new System.Drawing.Size(117, 33),
                Location = new System.Drawing.Point(327, 220),
            };
            btnWeightRestore.Click += new System.EventHandler(this.btnWeightRestore_Click);
            this.Controls.Add(btnWeightRestore);

            SideRoundButton btnGraph = new SideRoundButton(2)
            {
                Text = "グラフ表示",
                Size = new System.Drawing.Size(117, 33),
                Location = new System.Drawing.Point(327, 280),
            };
            btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            this.Controls.Add(btnGraph);
        }
    }
}
