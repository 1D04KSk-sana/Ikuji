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

        int time = 600;
        int minute = 0;
        int second = 0;
        int tuchiTime = 0;

        private void FormMilkTimer_Load(object sender, EventArgs e)
        {
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
            timMilk.Enabled = true;
            tuchiTime = minute;

        }

        private void btnTimerStop_Click(object sender, EventArgs e)
        {
            timMilk.Enabled = false;
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
            ntfTimerAlart.BalloonTipTitle = "タイマーが終了しました。";
            ntfTimerAlart.BalloonTipText = tuchiTime.ToString() + "分が経過しました。";
            ntfTimerAlart.ShowBalloonTip(3000);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
