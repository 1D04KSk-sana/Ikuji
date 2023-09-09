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

        //クラスの宣言
        BabyDBConnections babyDBConnections = new BabyDBConnections();

        //変数の宣言
        public string omutuComment = "";

        private void FormOmutuRestore_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            cmbHour.Text = dt.Hour.ToString();
            cmbMinit.Text = dt.Minute.ToString();

            SetButton();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string omutuKind = "";

            //GetVaildDataBabyRestoreからの戻り値がfalseのとき、メソッドを終了
            if (!GetVaildDataBabyRestore())
            {
                return;
            }

            //おしっこがチェックされているとき
            if (rdbOsikko.Checked)
            {
                omutuKind = rdbOsikko.Text;
            }
            //うんちがチェックされているとき
            if (rdbUnti.Checked)
            {
                omutuKind = rdbUnti.Text;
            }

            //赤ちゃん情報のセット
            var resBaby = GenerateDataBaby(omutuKind);
            //赤ちゃん情報の登録
            RestoreAddBabyData(resBaby);
        }

        ///////////////////////////////
        //メソッド名：GetValidDataBabyRestore()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetVaildDataBabyRestore()
        {
            //もしもrdbOsikkoがチェックされてなくて、かつrdbUntiがチェックされてないとき⇒MessageBoxでエラーを表示しfalseを返す
            if(!rdbOsikko.Checked && !rdbUnti.Checked) 
            {
                MessageBox.Show("うんちかおしっこか選択してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return false;
            }

            //もしもtxbCommentのisNullOrEmptyがfalseのとき⇒txbCommentのテキストの空白を消してomutuCommentに代入
            if(!String.IsNullOrEmpty(txbComment.Text)) 
            {
                omutuComment = txbComment.Text.Trim();
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：RestoreAddBabyData()
        //引　数   ：resBaby = 赤ちゃん情報
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
        //引　数   ：omutuKinds = 排泄物の種類
        //戻り値   ：赤ちゃんデータ
        //機　能   ：赤ちゃんデータのセット
        ///////////////////////////////
        private Baby GenerateDataBaby(string omutuKinds)
        {
            return new Baby
            {
                BabyMain = "オムツ",
                BabySub = omutuKinds,
                BabyWeight = null,
                BabyTemperature = null,
                BabyDate = dtpMonthDay.Value.Date,
                BabyHour = cmbHour.SelectedIndex,
                BabyMinit = cmbMinit.SelectedIndex,
                BabyComment = omutuComment,
            };
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
        }
    }
}
