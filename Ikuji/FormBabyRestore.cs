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

        SideRoundButton btnRestore = new SideRoundButton(1)
        {
            Text = "登録",
            Size = new System.Drawing.Size(150, 40),
            Location = new System.Drawing.Point(20, 260),
        };

        string babyName = String.Empty;
        DateTime babyBirthDay = DateTime.Now.Date;
        bool flgDBCount = true;
        int babyIsOmutuSize = 0;

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (!ControlDataBabyUpdate())
            {
                return;
            }
            this.Close();
        }
        
        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!flgDBCount)
            {
                DataBabyRestore();
                ControlDataBabyUpdate();
                btnRestore.Text = "更新";
                return;
            }

            DataBabyUpdate();

            ControlDataBabyUpdate();
        }

        private void FormBabyRestore_Load(object sender, EventArgs e)
        {
            cmbOmutuSize.SelectedIndex = 0;

            using (var dbContext = new BabyContext())
            {
                if (dbContext.BabyInfomations.Count() == 0)
                {
                    flgDBCount = false;
                }
            }

            if (flgDBCount)
            {
                BabyInfomation babyInfomation = babyDBConnections.GetBabyInfomationData();

                babyName = babyInfomation.BabyName;
                babyBirthDay = babyInfomation.BabyBirthDay;
                babyIsOmutuSize = babyInfomation.BabyIsOmutuSize;

                txbNameRestore.Text = babyName;
                dtpBirhDay.Value = babyBirthDay;
                cmbOmutuSize.SelectedIndex = babyIsOmutuSize;
                btnRestore.Text = "更新";
            }

            SetButton();
        }

        ///////////////////////////////
        //メソッド名：ControlDataBabyUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：コントロールが更新されているか確認
        ///////////////////////////////
        private bool ControlDataBabyUpdate()
        {
            if (flgDBCount)
            {
                BabyInfomation babyInfomation = babyDBConnections.GetBabyInfomationData();

                babyName = babyInfomation.BabyName;
                babyBirthDay = babyInfomation.BabyBirthDay;
                babyIsOmutuSize = babyInfomation.BabyIsOmutuSize;

                if (babyName != txbNameRestore.Text || babyBirthDay != dtpBirhDay.Value.Date || babyIsOmutuSize != cmbOmutuSize.SelectedIndex)
                {
                    DialogResult dialogResult = MessageBox.Show("変更を保存していません。本当に閉じますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (txbNameRestore.Text != String.Empty || dtpBirhDay.Value.Date != DateTime.Now.Date || cmbOmutuSize.SelectedIndex != 0)
                {
                    DialogResult dialogResult = MessageBox.Show("変更を保存していません。本当に閉じますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：DataBabyRestore()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：赤ちゃん情報の登録
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
        //メソッド名：DataBabyUpdate()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：赤ちゃん情報の登録
        ///////////////////////////////
        private void DataBabyUpdate()
        {
            if (!GetVaildDataBabyRestore())
            {
                return;
            }

            var resBabyInfomation = GenerateDataBaby();
            UpdateBabyInfomationData(resBabyInfomation);
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
                BabyIsOmutuSize = cmbOmutuSize.SelectedIndex,
            };
        }

        ///////////////////////////////
        //メソッド名：UpdateBabyInfomationData()
        //引　数   ：赤ちゃん情報
        //戻り値   ：なし
        //機　能   ：赤ちゃん情報の登録
        ///////////////////////////////
        private void UpdateBabyInfomationData(BabyInfomation resBabyInfomation)
        {
            //登録確認メッセージ
            DialogResult result = MessageBox.Show("更新しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            //赤ちゃん情報の登録
            bool flg = babyDBConnections.UpdateBabyInfomationData(resBabyInfomation);
            if (flg)
            {
                MessageBox.Show("データを更新しました", "確認", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("データを更新できませんでした", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                flgDBCount = true;
            }
            else
            {
                MessageBox.Show("データを登録できませんでした", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///////////////////////////////
        //メソッド名：SetButton()
        //引　数   ：btnRestoreTitle = btnReoreのタイトル
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

            btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            this.Controls.Add(btnRestore);
        }
    }
}
