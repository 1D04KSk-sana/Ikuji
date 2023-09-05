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
    public partial class FormWeightRestore : Form
    {
        public FormWeightRestore()
        {
            InitializeComponent();
        }

        //クラスの宣言
        BabyDBConnections babyDBConnections = new BabyDBConnections();

        //変数の宣言
        int babyWeight = 0;
        double babyTemperature = 0;
        string babyComment = "";

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            int babyWeight, babyTemperature;

            string babyYearAndMonth,babyComment;

            babyYearAndMonth = dtpMonthDay.Text;

            babyWeight = int.Parse(txbWeight.Text);

            babyTemperature = int.Parse(txbTemperature.Text);

            babyComment = txbComment.Text;

            //GetVaildDataBabyRestoreからの戻り値がfalseのとき、メソッドを終了
            if (!GetVaildDataBabyRestore())
            {
                return;
            }

            //赤ちゃん情報のセット
            var resBaby = GenerateDataBaby();
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
            //もしもtxbWeightがnullでtxbTemperatureもnullのとき⇒MessageBoxでエラーを表示しfalseを返す




            //もしもtxbWeightのisNullOrEmptyがfalseのとき⇒txbWeightのテキストの空白を消してint変換、babyWeightに代入




            //もしもtxbTemperatureのisNullOrEmptyがfalseのとき⇒txbTemperatureのテキストの空白を消してdouble変換、babyTemperatureに代入




            //もしもtxbCommentのisNullOrEmptyがfalseのとき⇒txbCommentのテキストの空白を消してbabyCommentに代入




            return true;
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
        //引　数   ：なし
        //戻り値   ：赤ちゃんデータ
        //機　能   ：赤ちゃんデータのセット
        ///////////////////////////////
        private Baby GenerateDataBaby()
        {
            return new Baby
            {
                BabyMain = "ミルク",
                BabySub = String.Empty,
                BabyWeight = babyWeight,
                BabyTemperature = babyTemperature,
                BabyDate = dtpMonthDay.Value.ToShortDateString(),
                BabyHour = null,
                BabyMinit = null,
                BabyComment = babyComment,
            };
        }
    }
}
