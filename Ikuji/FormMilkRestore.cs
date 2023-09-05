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

        BabyDBConnections babyDBConnections = new BabyDBConnections();

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            //string milkYearAndMonth,milkHour,milkMinute,milkComment;

            //milkYearAndMonth = dtpMonthDay.Text;

            //milkHour = cmbHour.Text;

            //milkMinute = cmbMinit.Text;

            //milkComment = txbComment.Text;

            string milkKind = "";

            //粉ミルクがチェックされているとき
            if (rdbMilk.Checked )
            {
                milkKind = rdbMilk.Text;
            }
            //母乳がチェックされているとき
            if (rbdBonyu.Checked )
            {
                milkKind = rbdBonyu.Text;
            }

            //赤ちゃん情報のセット
            var resBaby = GenerateDataBaby(milkKind);
            //赤ちゃん情報の登録
            RestoreAddBabyData(resBaby);
        }

        ///////////////////////////////
        //メソッド名：RestoreAddBabyData()
        //引　数   ：赤ちゃん情報
        //戻り値   ：なし
        //機　能   ：赤ちゃん情報の登録
        ///////////////////////////////
        private void RestoreAddBabyData(Baby resBaby)
        {
            //登録確認メッセージ
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            //赤ちゃん情報の登録
            bool flg = babyDBConnections.AddBabyData(resBaby);
            if (flg)
            {
                MessageBox.Show("データを登録しました", "確認", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("データを登録できませんでした", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///////////////////////////////
        //メソッド名：GenerateDataBaby()
        //引　数   ：milkKinds = ミルクの種類
        //戻り値   ：赤ちゃんデータ
        //機　能   ：赤ちゃんデータのセット
        ///////////////////////////////
        private Baby GenerateDataBaby(string milkKinds)
        {
            return new Baby
            {
                BabyMain = "ミルク",
                BabySub = milkKinds,
                BabyDate = dtpMonthDay.Value.ToShortDateString(),
                BabyHour = 1,
                BabyMinit = 35,
                BabyComment = txbComment.Text,
            };
        }
    }
}
