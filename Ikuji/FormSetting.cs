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
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        BabyDBConnections babyDBConnections = new BabyDBConnections();
        bool flgDBCount = false;
        bool babyBirthAlart = false;
        bool babyOmutuAlart = false;

        private void FormSetting_Load(object sender, EventArgs e)
        {
            using (var context = new BabyContext())
            {
                if (context.BabyAlarts.Count() != 0)
                {
                    flgDBCount = true;
                }
            }
            if (flgDBCount)
            {
                var resBabyAlart = babyDBConnections.GetBabyAlartData();
                chkBirthDay.Checked = resBabyAlart.BabyBirthAlart;
                chkOmutu.Checked = resBabyAlart.BabyOmutuAlart;
            }

            SetButton();
        }

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
            var resBabyAlart = GenerateDataBabyAlart();
            RestoreAddBabyData(resBabyAlart);
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
                BabyAlart babyAlart = babyDBConnections.GetBabyAlartData();

                babyBirthAlart = babyAlart.BabyBirthAlart;
                babyOmutuAlart = babyAlart.BabyOmutuAlart;

                if (babyBirthAlart != chkBirthDay.Checked || babyOmutuAlart != chkOmutu.Checked)
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
        //メソッド名：RestoreAddBabyData()
        //引　数   ：赤ちゃん情報
        //戻り値   ：なし
        //機　能   ：赤ちゃん情報の登録
        ///////////////////////////////
        private void RestoreAddBabyData(BabyAlart resBabyAlart)
        {
            //登録確認メッセージ
            DialogResult result = MessageBox.Show("更新しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            //赤ちゃん情報の登録
            bool flg = babyDBConnections.UpdateBabyAlartData(resBabyAlart);
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
        //メソッド名：GenerateDataBabyAlart()
        //引　数   ：なし
        //戻り値   ：赤ちゃん情報データ
        //機　能   ：赤ちゃん情報データのセット
        ///////////////////////////////
        private BabyAlart GenerateDataBabyAlart()
        {
            return new BabyAlart
            {
                BabyBirthAlart = chkBirthDay.Checked,
                BabyOmutuAlart = chkOmutu.Checked,
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

            SideRoundButton btnRestore = new SideRoundButton(1)
            {
                Text = "更新",
                Size = new System.Drawing.Size(150, 40),
                Location = new System.Drawing.Point(20, 260),
            };
            btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            this.Controls.Add(btnRestore);
        }
    }
}
