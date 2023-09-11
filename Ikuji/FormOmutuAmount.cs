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
using System.Xml.Linq;

namespace Ikuji
{
    public partial class FormOmutuAmount : Form
    {
        public FormOmutuAmount()
        {
            InitializeComponent();
        }

        DataInputCheck dataInputCheck = new DataInputCheck();
        BabyDBConnections babyDBConnections = new BabyDBConnections();

        int intOmutuAmount = 0;

        private void FormOmutuAmount_Load(object sender, EventArgs e)
        {
            cmbOmutuSize.SelectedIndex = 0;

            SetButton();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!GetVaildDataBabyRestore())
            {
                return;
            }

            var resBabyOmutu = GenerateDataBaby();
            RestoreUpdateBabyOmutuData(resBabyOmutu);
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
            //もしもtxbCommentのisNullOrEmptyがfalseのとき⇒txbCommentのテキストの空白を消してomutuCommentに代入
            if (String.IsNullOrEmpty(txbOmutuAmount.Text))
            {
                MessageBox.Show("枚数を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //一旦文字をstringに代入
            string babyOmutuAmount = txbOmutuAmount.Text.Trim();

            //全角数字を半角数字に変換
            babyOmutuAmount = Regex.Replace(babyOmutuAmount, "[０-９]", p => ((char)(p.Value[0] - '０' + '0')).ToString());

            //数字チェック
            if (!dataInputCheck.CheckNumeric(babyOmutuAmount))
            {
                MessageBox.Show("枚数は数字で入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            intOmutuAmount = int.Parse(babyOmutuAmount);

            return true;
        }

        ///////////////////////////////
        //メソッド名：GenerateDataBaby()
        //引　数   ：なし
        //戻り値   ：赤ちゃんデータ
        //機　能   ：赤ちゃんデータのセット
        ///////////////////////////////
        private BabyOmutu GenerateDataBaby()
        {
            return new BabyOmutu
            {
                BabyOmutuSize = cmbOmutuSize.SelectedIndex,
                BabyOmutuAmount = intOmutuAmount
            };
        }

        ///////////////////////////////
        //メソッド名：RestoreUpdateBabyOmutuData()
        //引　数   ：赤ちゃん情報
        //戻り値   ：なし
        //機　能   ：赤ちゃん情報の登録
        ///////////////////////////////
        private void RestoreUpdateBabyOmutuData(BabyOmutu resBabyOmutu)
        {
            //登録確認メッセージ
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            //赤ちゃん情報の登録
            bool flg = babyDBConnections.UpdateBabyOmutuData(resBabyOmutu);
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
                Text = "登録ボタン",
                Size = new System.Drawing.Size(150, 40),
                Location = new System.Drawing.Point(20, 260),
            };
            btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            this.Controls.Add(btnRestore);
        }
    }
}
