using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ikuji
{
    public partial class FormBabyRestore : Form
    {
        public FormBabyRestore()
        {
            InitializeComponent();
        }

        BabyDBConnections babyDBConnections = new BabyDBConnections();

        string babyName = String.Empty;

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            using (var dbContext = new BabyContext())
            {
                if (dbContext.BabyInfomations.Count() == 0)
                {
                    DataBabyRestore();
                }
            }
        }

        private void FormBabyRestore_Load(object sender, EventArgs e)
        {
            SetButton();
        }

        ///////////////////////////////
        //メソッド名：DataBabyRestore()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private void DataBabyRestore()
        {
            if (!GetVaildDataBabyRestore())
            {
                return;
            }

            var resBabyInfomation = GenerateDataBaby();
            RestoreAddBabyInfomationData(resBabyInfomation);
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
            if (String.IsNullOrEmpty(txbNameRestore.Text))
            {
                MessageBox.Show("お名前を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            babyName = txbNameRestore.Text.Trim();
            return true;
        }

        ///////////////////////////////
        //メソッド名：GenerateDataBaby()
        //引　数   ：なし
        //戻り値   ：赤ちゃんデータ
        //機　能   ：赤ちゃんデータのセット
        ///////////////////////////////
        private BabyInfomation GenerateDataBaby()
        {
            return new BabyInfomation
            {
                BabyName = babyName,
                BabyBirthDay = dtpBirhDay.Value.Date,
            };
        }

        ///////////////////////////////
        //メソッド名：RestoreAddBabyInfomationData()
        //引　数   ：赤ちゃん情報
        //戻り値   ：なし
        //機　能   ：赤ちゃん情報の登録
        ///////////////////////////////
        private void RestoreAddBabyInfomationData(BabyInfomation resBabyInfomation)
        {
            //登録確認メッセージ
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            //赤ちゃん情報の登録
            bool flg = babyDBConnections.AddBabyInfomationData(resBabyInfomation);
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
