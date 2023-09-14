using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikuji
{
    public partial class FormMilkTimer : Form
    {
        public FormMilkTimer()
        {
            InitializeComponent();
        }

        SideRoundButton btnTimeDown = new SideRoundButton(0)
        {
            Text = "－1分",
            Size = new System.Drawing.Size(150, 40),
            Location = new System.Drawing.Point(280, 10),
        };
        SideRoundButton btnTimeUp = new SideRoundButton(0)
        {
            Text = "＋1分",
            Size = new System.Drawing.Size(150, 40),
            Location = new System.Drawing.Point(80, 10),
        };
        SideRoundButton btnReset = new SideRoundButton(1)
        {
            Text = "リセット",
            Size = new System.Drawing.Size(150, 40),
            Location = new System.Drawing.Point(80, 70),
        };
        SideRoundButton btnTimerStart = new SideRoundButton(1)
        {
            Text = "スタート",
            Size = new System.Drawing.Size(150, 40),
            Location = new System.Drawing.Point(80, 70),
        };
        SideRoundButton btnTimerStop = new SideRoundButton(2)
        {
            Text = "ストップ",
            Size = new System.Drawing.Size(150, 40),
            Location = new System.Drawing.Point(280, 70),
        };

        int time = 300;
        int minute = 0;
        int second = 0;
        int totalTime = 0;

        private void FormMilkTimer_Load(object sender, EventArgs e)
        {
            SetButton();
        }

        private void btnTimeUp_Click(object sender, EventArgs e)
        {
            if(time　< 1200)
            {
                time = time + 60;
                minute = time / 60;
                second = time % 60;
                lblTimer.Text = string.Format("{0:00}:{1:00}", minute, second);
            }
            else
            {
                MessageBox.Show("タイマーを21分以上に設定できません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTimeDown_Click(object sender, EventArgs e)
        {
            if(time > 60)
            {
                time = time - 60;
                minute = time / 60;
                second = time % 60;
                lblTimer.Text = string.Format("{0:00}:{1:00}", minute, second);
            }
            else
            {
                MessageBox.Show ("タイマーを１分未満に設定できません","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void timMilk_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            minute = time / 60;
            second = time % 60;
            lblTimer.Text = string.Format("{0:00}:{1:00}", minute,second);

            if(minute == 0 && second == 0)
            {
                TimerFinishEvent();
            }

        }

        public void btnTimerStart_Click(object sender, EventArgs e)
        {
            SetButtonStart();

            timMilk.Enabled = true;

            minute = time / 60;
            second = time % 60;
            lblTimer.Text = string.Format("{0:00}:{1:00}", minute, second);
            totalTime = minute;
        }

        private void btnTimerStop_Click(object sender, EventArgs e)
        {
            SetButtonStop();

            timMilk.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timMilk.Enabled = false;
            time = totalTime * 60;
            minute = time / 60;
            second = time % 60;
            lblTimer.Text = string.Format("{0:00}:{1:00}", minute, second);

            SetButtonStop();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ///////////////////////////////
        //メソッド名 : TimerFinishEvent()
        //引 数 : なし
        //戻り値 : なし
        //機 能 : タイマーが終わった時のイベント
        ///////////////////////////////
        private void TimerFinishEvent()
        {
            timMilk.Enabled = false;
            ntfTimerAlart.BalloonTipTitle = "授乳お疲れ様です！";
            ntfTimerAlart.BalloonTipText = totalTime.ToString() + "分が経過しました。";
            ntfTimerAlart.ShowBalloonTip(3000);
        }

        ///////////////////////////////
        //メソッド名 : TimerFinishEvent()
        //引 数 : なし
        //戻り値 : なし
        //機 能 : タイマーが終わった時のイベント
        ///////////////////////////////
        private void SetButtonStop()
        {
            btnReset.Visible = false;
            btnTimerStop.Visible = false;

            btnTimeUp.Visible = true;
            btnTimeDown.Visible = true;
            btnTimerStart.Visible = true;
        }

        ///////////////////////////////
        //メソッド名：SetButtonStart()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：タイマーが終わった後のボタンのセット
        ///////////////////////////////
        private void SetButtonStart()
        {
            btnTimeUp.Visible = false;
            btnTimeDown.Visible = false;
            btnTimerStart.Visible = false;

            btnReset.Visible = true;
            btnTimerStop.Visible = true;
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

            btnReset.Click += new System.EventHandler(this.btnReset_Click);
            pnlTimer.Controls.Add(btnReset);
            btnReset.Visible = false;

            btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            pnlTimer.Controls.Add(btnTimerStart);

            btnTimerStop.Click += new System.EventHandler(this.btnTimerStop_Click);
            pnlTimer.Controls.Add(btnTimerStop);
            btnTimerStop.Visible = false;

            btnTimeUp.Click += new System.EventHandler(this.btnTimeUp_Click);
            pnlTimer.Controls.Add(btnTimeUp);

            btnTimeDown.Click += new System.EventHandler(this.btnTimeDown_Click);
            pnlTimer.Controls.Add(btnTimeDown);
        }
    }
}
