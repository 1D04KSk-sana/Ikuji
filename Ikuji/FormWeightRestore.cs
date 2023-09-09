using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

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
        DataInputCheck dataInputCheck = new DataInputCheck();

        //変数の宣言
        int? babyWeight = 0;
        double? babyTemperature = 0;
        string babyComment = "";

        private void FormWeightRestore_Load(object sender, EventArgs e)
        {
            SetButton();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
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
            if (txbWeight.Text == String.Empty && txbTemperature.Text == String.Empty)
            {
                MessageBox.Show("体重か体温を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return false;
            }

            //もしもtxbWeightのisNullOrEmptyがfalseのとき⇒txbWeightのテキストの空白を消してint変換、babyWeightに代入
            if (!String.IsNullOrEmpty(txbWeight.Text))
            {
                //一旦文字をstringに代入
                string babyWeightString = txbWeight.Text.Trim();

                //全角数字を半角数字に変換
                babyWeightString = Regex.Replace(babyWeightString, "[０-９]", p => ((char)(p.Value[0] - '０' + '0')).ToString());

                //数字チェック
                if (!dataInputCheck.CheckNumeric(babyWeightString))
                {
                    MessageBox.Show("体温は数字で入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                babyWeight = int.Parse(babyWeightString);
            }
            else
            {
                babyWeight = null;
            }

            //もしもtxbTemperatureのisNullOrEmptyがfalseのとき⇒txbTemperatureのテキストの空白を消してdouble変換、babyTemperatureに代入
            if (!String.IsNullOrEmpty(txbTemperature.Text))
            {
                //一旦文字をstringに代入
                string babyTemperatureString = txbTemperature.Text.Trim();

                //全角数字を半角数字に変換
                babyTemperatureString = Regex.Replace(babyTemperatureString, "[０-９]", p => ((char)(p.Value[0] - '０' + '0')).ToString());

                //数字チェック
                if (!dataInputCheck.CheckNumeric(babyTemperatureString))
                {
                    MessageBox.Show("体温は数字で入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
                babyTemperature = double.Parse(babyTemperatureString);
            }
            else
            {
                babyTemperature = null;
            }

            //もしもtxbCommentのisNullOrEmptyがfalseのとき⇒txbCommentのテキストの空白を消してbabyCommentに代入
            if (!String.IsNullOrEmpty(txbComment.Text))
            {
                babyComment = txbComment.Text.Trim();
            }

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
                BabyMain = "体重・体温",
                BabySub = String.Empty,
                BabyWeight = babyWeight,
                BabyTemperature = babyTemperature,
                BabyDate = dtpMonthDay.Value.Date,
                BabyHour = null,
                BabyMinit = null,
                BabyComment = babyComment,
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
