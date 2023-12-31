﻿using System;
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

        //クラスの宣言
        BabyDBConnections babyDBConnections = new BabyDBConnections();

        //変数の宣言
        public string milkComment = "";

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnMilkTimer_Click(object sender, EventArgs e)
        {
            FormMilkTimer formMikTimer = new FormMilkTimer();

            formMikTimer.Owner = this;
            formMikTimer.FormClosed += ChildForm_FormClosed;
            formMikTimer.Show();

            this.Opacity = 0;
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Opacity = 1;
        }

        private void FormMilkRestore_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            cmbHour.Text = dt.Hour.ToString();
            cmbMinit.Text = dt.Minute.ToString();

            SetButton();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string milkKind = "";

            //GetVaildDataBabyRestoreからの戻り値がfalseのとき、メソッドを終了
            if (!GetVaildDataBabyRestore())
            {
                return;
            }

            //粉ミルクがチェックされているとき
            if (rdbMilk.Checked )
            {
                milkKind = rdbMilk.Text;
            }
            //母乳がチェックされているとき
            if (rdbBonyu.Checked )
            {
                milkKind = rdbBonyu.Text;
            }

            //赤ちゃん情報のセット
            var resBaby = GenerateDataBaby(milkKind);
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
            //もしもrdbMilkがチェックされてなくて、かつrdbBonyuがチェックされてないとき⇒MessageBoxでエラーを表示しfalseを返す
            if(!rdbMilk.Checked && !rdbBonyu.Checked) 
            {
                MessageBox.Show("母乳か粉ミルクか選択してください","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            //もしもtxbCommentのisNullOrEmptyがfalseのとき⇒txbCommentのテキストの空白を消してmilkCommentに代入
            if(!String.IsNullOrEmpty(rdbMilk.Text)) 
            {
                milkComment = txbComment.Text.Trim();
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
                BabyWeight = null,
                BabyTemperature = null,
                BabyDate = dtpMonthDay.Value.Date,
                BabyHour = cmbHour.SelectedIndex,
                BabyMinit = cmbMinit.SelectedIndex,
                BabyComment = milkComment,
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
                Text = "登録ボタン",
                Size = new System.Drawing.Size(150, 40),
                Location = new System.Drawing.Point(20, 260),
            };
            btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            this.Controls.Add(btnRestore);

            SideRoundButton btnMilkTimer = new SideRoundButton(0)
            {
                Text = "授乳タイマーへ",
                Size = new System.Drawing.Size(150, 40),
                Location = new System.Drawing.Point(200, 260),
            };
            btnMilkTimer.Click += new System.EventHandler(this.btnMilkTimer_Click);
            this.Controls.Add(btnMilkTimer);
        }
    }
}
