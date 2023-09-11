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

namespace Ikuji
{
    public partial class FormDBEdit : Form
    {
        public FormDBEdit()
        {
            InitializeComponent();
        }

        //クラスの宣言
        BabyDBConnections babyDBConnections = new BabyDBConnections();
        DataInputCheck dataInputCheck = new DataInputCheck();

        //コントロールの宣言　※メソッドをまたいで使いたいのでpublic
        public Panel pnlDynamic = new Panel();

        public TextBox txbComment = new TextBox()
        {
            Location = new Point(20, 70),
            Size = new Size(200, 30),
            Text = string.Empty,
            Font = new System.Drawing.Font("MS UI Gothic", 10F)
        };

        public ComboBox cmbHour = new ComboBox()
        {
            Location = new Point(20, 10),
            Size = new Size(80, 30),
            Font = new System.Drawing.Font("MS UI Gothic", 10F)
        };
        public ComboBox cmbMinit = new ComboBox()
        {
            Location = new Point(110, 10),
            Size = new Size(80, 30),
            Font = new System.Drawing.Font("MS UI Gothic", 10F)
        };

        public TextBox txbWeight = new TextBox()
        {
            Location = new Point(60, 10),
            Text = String.Empty,
            Font = new System.Drawing.Font("MS UI Gothic", 10F)
        };
        public TextBox txbTemperature = new TextBox()
        {
            Location = new Point(60, 40),
            Text = String.Empty,
            Font = new System.Drawing.Font("MS UI Gothic", 10F)
        };

        public RadioButton rdbUp = new RadioButton()
        {
            Location = new Point(10, 5),
            Text = String.Empty,
            Font = new System.Drawing.Font("MS UI Gothic", 10F)
        };
        public RadioButton rdbDown = new RadioButton()
        {
            Location = new Point(150, 5),
            Text = string.Empty,
            Font = new System.Drawing.Font("MS UI Gothic", 10F)
        };

        //データグリッドビュー用の赤ちゃんデータ
        private static List<Baby> Baby;

        //変数の宣言
        int babyWeight = 0;
        double babyTemperature = 0;
        string babyComment = "";
        int ControlNumber = 0;
        string othersKind = "";

        private void FormDBEdit_Load(object sender, EventArgs e)
        {
            //cmbViewChangeを"全部"に
            cmbViewChange.SelectedIndex = 0;

            SetButton();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbViewChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbViewChangeが"全部"のとき
            if (cmbViewChange.SelectedIndex == 0)
            {
                GetdgvRecordEditingView();
            }
            //cmbViewChangeが"全部"以外のとき
            if (cmbViewChange.SelectedIndex != 0)
            {
                GenerateDataAtSelect(cmbViewChange.SelectedItem.ToString());
            }

            //DataGridViewのCheckを外す
            dgvRecordEditing.ClearSelection();

            //動的に生成されたパネルを削除
            this.Controls.Remove(pnlDynamic);

            ControlNumber = 0;
        }

        private void dgvRecordEditing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //クリックされたDataGridViewがヘッダーのとき⇒何もしない
            if (dgvRecordEditing.SelectedCells.Count == 0)
            {
                return;
            }

            pnlDynamic.Controls.Clear();
            ControlCreateCommon();
            SelectRowControl();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvRecordEditing.SelectedRows.Count <= 0)
            {
                MessageBox.Show("データが選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //MessageBox.Show(cmbHour.SelectedIndex.ToString());
            //return;

            string dgv1Others = dgvRecordEditing[1, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString();
            bool flg;

            //GetVaildDataBabyからの戻り値がfalseのとき、メソッドを終了
            if (!GetValidDataBaby())
            {
                return;
            }
            
            //もしもtxbCommentのisNullOrEmptyがfalseのとき⇒txbCommentのテキストの空白を消してbabyCommentに代入
            if (!String.IsNullOrEmpty(txbComment.Text))
            {
                babyComment = txbComment.Text.Trim();
            }

            //登録確認メッセージ
            DialogResult result = MessageBox.Show("更新しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            if (dgv1Others == "体重・体温")
            {
                //体重・体温データの更新　失敗時flgにfalseを代入
                var resBaby = GenerateDataBabyWeight();
                flg = babyDBConnections.UpdateBabyDataWeight(resBaby);                
            }
            else
            {
                //ミルクorオムツデータの更新　失敗時flgにfalseを代入
                var resBaby = GenerateDataBabyMilkOmutu();
                flg = babyDBConnections.UpdateBabyDataMilkOmutu(resBaby);
            }

            cmbViewChange_SelectedIndexChanged(e, null);

            if (flg)
            {
                MessageBox.Show("データを更新しました", "確認", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("データを更新できませんでした", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRecordEditing.SelectedRows.Count <= 0)
            {
                MessageBox.Show("データが選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            babyDBConnections.DeleteBabyData(int.Parse(dgvRecordEditing[0, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString()));
            GetdgvRecordEditingView();
            SettingdgvRecordEditing();
        }

        ///////////////////////////////
        //メソッド名：GenerateDataBabyWeight()
        //引　数   ：otherKinds = ラヂオボタンの種類
        //戻り値   ：赤ちゃん体重・体温データ
        //機　能   ：赤ちゃん体重・体温データのセット
        ///////////////////////////////
        private Baby GenerateDataBabyWeight()
        {
            return new Baby
            {
                //Id、体重、体温、日付、コメントをデータにセット
                BabyId = int.Parse(dgvRecordEditing[0, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString()),
                BabyWeight = babyWeight,
                BabyTemperature = babyTemperature,
                BabyDate = dtpMonthDay.Value.Date,
                BabyComment = babyComment,
            };
        }

        ///////////////////////////////
        //メソッド名：GenerateDataBabyMilkOmutu()
        //引　数   ：otherKinds = ラヂオボタンの種類
        //戻り値   ：赤ちゃんミルク・オムツデータ
        //機　能   ：赤ちゃんミルク・オムツデータのセット
        ///////////////////////////////
        private Baby GenerateDataBabyMilkOmutu()
        {
            return new Baby
            {
                //Id、種類、日付、時間、分、コメントをデータにセット
                BabyId = int.Parse(dgvRecordEditing[0, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString()),
                BabySub = othersKind,
                BabyDate = dtpMonthDay.Value.Date,
                BabyHour = cmbHour.SelectedIndex,
                BabyMinit = cmbMinit.SelectedIndex,
                BabyComment = babyComment
            };
        }

        ///////////////////////////////
        //メソッド名：GetValidDataBaby()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDataBaby()
        {
            //選択された行の1列目が体重・体温のとき
            if (dgvRecordEditing[1, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString() == "体重・体温")
            {
                if (!GetValidDataBabyWeight())
                {
                    return false;
                }
            }
            else
            {
                //rdbUpがチェックされているとき⇒rdbUpのテキストをothesKindに代入
                if(rdbUp.Checked) 
                {
                    othersKind = rdbUp.Text;
                }

                //rdbDownがチェックされているとき⇒rdbDownのテキストをothesKindに代入
                if(rdbDown.Checked)
                {
                    othersKind = rdbDown.Text;
                }
            }
            
            return true;
        }

        ///////////////////////////////
        //メソッド名：GetValidDataBabyWeight()
        //引　数   ：なし
        //戻り値   ：true or false
        //機　能   ：入力データの形式チェック
        //          ：エラーがない場合True
        //          ：エラーがある場合False
        ///////////////////////////////
        private bool GetValidDataBabyWeight()
        {
            //もしもtxbWeightがnullでtxbTemperatureもnullのとき⇒MessageBoxでエラーを表示しfalseを返す
            if(txbWeight.Text == String.Empty && txbTemperature.Text == String.Empty)
            {
                MessageBox.Show("体重か体温を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //もしもtxbWeightのisNullOrEmptyがfalseのとき⇒txbWeightのテキストの空白を消してint変換、babyWeightに代入
            if (!String.IsNullOrEmpty(txbWeight.Text))
            {
                //一旦文字をstringに代入
                string babyWeightString = txbWeight.Text.Trim();

                //全角数字を半角数字に変換
                babyWeightString = Regex.Replace(babyWeightString, "[０-９]", p => ((char)(p.Value[0] - '０' + '0')).ToString());

                //babyWeightStringの数字チェックがfalseのとき⇒MessageBoxでエラーを表示してfalseを返す
                if (!dataInputCheck.CheckNumeric(babyWeightString)) 
                {
                    MessageBox.Show("体重は数字で入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                babyWeight = int.Parse(babyWeightString);
            }

            //もしもtxbTemperatureのisNullOrEmptyがfalseのとき⇒txbTemperatureのテキストの空白を消してdouble変換、babyTemperatureに代入
            if (!String.IsNullOrEmpty(txbTemperature.Text))
            {
                //一旦文字をstringに代入
                string babyTemperatureString = txbTemperature.Text.Trim();

                //全角数字を半角数字に変換
                babyTemperatureString = Regex.Replace(babyTemperatureString, "[０-９]", p => ((char)(p.Value[0] - '０' + '0')).ToString());

                //babyTemperatureStringの数字チェックがfalseのとき⇒MessageBoxでエラーを表示してfalseを返す
                if (!dataInputCheck.CheckNumeric(babyTemperatureString))
                {
                    MessageBox.Show("体重は数字で入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                babyTemperature = double.Parse(babyTemperatureString);
            }

            return true;
        }

        ///////////////////////////////
        //メソッド名：SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void SelectRowControl()
        {
            txbComment.Text = dgvRecordEditing[8, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString();
            //Addで配置　※pnlDynamicにAddしてるのでパネル内に設置される。
            pnlDynamic.Controls.Add(txbComment);

            //選択された行の1列目がミルクのとき
            if (dgvRecordEditing[1, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString() == "ミルク")
            {
                ControlCreateCommonTime();
                ControlCreateOmutuMilk("粉ミルク", "母乳");
            }

            //選択された行の1列目がオムツのとき
            if (dgvRecordEditing[1, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString() == "オムツ")
            {
                ControlCreateCommonTime();
                ControlCreateOmutuMilk("うんち", "おしっこ");
            }

            //選択された行の1列目が体重・体温のとき
            if (dgvRecordEditing[1, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString() == "体重・体温")
            {
                ControlCreateWeight();
            }
        }

        ///////////////////////////////
        //メソッド名：GenerateDataAtSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：赤ちゃん情報の検索
        ///////////////////////////////
        private void GenerateDataAtSelect(string strBabyMain)
        {
            Baby baby = new Baby()
            {
                BabyMain = strBabyMain,
            };
            Baby = babyDBConnections.GetBabyData(baby);

            dgvRecordEditing.DataSource = Baby;
            dgvRecordEditing.Refresh();
        }

        ///////////////////////////////
        //メソッド名 : GetgvRecordEditingView()
        //引 数 : なし
        //戻り値 : なし
        //機 能 : データグリッドビューの設定
        ///////////////////////////////
        private void GetdgvRecordEditingView()
        {
            Baby = babyDBConnections.GetBabyData();

            SettingdgvRecordEditing();
        }

        ///////////////////////////////
        //メソッド名 : SettingdgvRecordEditing()
        //引 数 : なし
        //戻り値 : なし
        //機 能 : データグリッドビューの設定
        ///////////////////////////////
        private void SettingdgvRecordEditing()
        {
            //行単位で選択するようにする
            dgvRecordEditing.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //行と列の高さを変更できないように
            dgvRecordEditing.AllowUserToResizeColumns = false;
            dgvRecordEditing.AllowUserToResizeRows = false;
            //セルの複数行選択をオフに
            dgvRecordEditing.MultiSelect = false;
            //セルの編集ができないように
            dgvRecordEditing.ReadOnly = true;
            //ユーザーが新しい行を追加できないようにする
            dgvRecordEditing.AllowUserToAddRows = false;

            //左端の項目列を削除
            dgvRecordEditing.RowHeadersVisible = false;
            //行の自動追加をオフ
            dgvRecordEditing.AllowUserToAddRows = false;

            dgvRecordEditing.DataSource = Baby.ToList();

            //各列幅の指定
            dgvRecordEditing.Columns[0].Width = 40;
            dgvRecordEditing.Columns[1].Width = 70;
            dgvRecordEditing.Columns[2].Width = 70;
            dgvRecordEditing.Columns[3].Width = 60;
            dgvRecordEditing.Columns[4].Width = 60;
            dgvRecordEditing.Columns[5].Width = 70;
            dgvRecordEditing.Columns[6].Width = 60;
            dgvRecordEditing.Columns[7].Width = 60;
            dgvRecordEditing.Columns[8].Width = 100;

            dgvRecordEditing.Refresh();
        }

        ///////////////////////////////
        //メソッド名 : ControlCreateCommon()
        //引 数 : なし
        //戻り値 : なし
        //機 能 : パネルとコメントテキストボックスの動的生成
        ///////////////////////////////
        private void ControlCreateCommon()
        {
            //背景色の設定　※枠線がないので色を背景に合わせると目立たない
            pnlDynamic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185)))));
            //配置位置の設定
            pnlDynamic.Location = new Point(245, 7);
            //サイズの設定
            pnlDynamic.Size = new Size(350, 150);

            //Addで設置　※this＝このフォームのこと
            this.Controls.Add(pnlDynamic);
        }

        ///////////////////////////////
        //メソッド名 : ControlCreateCommonTime()
        //引 数 : なし
        //戻り値 : なし
        //機 能 : 時間コンボボックスと分コンボボックスの動的生成
        ///////////////////////////////
        private void ControlCreateCommonTime()
        {
            string[] arrayHour = new string[24];
            for (int i = 0; i < arrayHour.Length; i++)
            {
                arrayHour[i] = i.ToString();
            }
            cmbHour.Items.AddRange(arrayHour);

            string[] arrayMinit = new string[60];
            for (int i = 0; i < arrayMinit.Length; i++)
            {
                arrayMinit[i] = i.ToString();
            }
            cmbMinit.Items.AddRange(arrayMinit);

            cmbHour.SelectedIndex = int.Parse(dgvRecordEditing[6, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString());
            cmbMinit.SelectedIndex = int.Parse(dgvRecordEditing[7, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString());

            //Addで配置　※pnlDynamicにAddしてるのでパネル内に設置される。
            pnlDynamic.Controls.Add(cmbHour);
            pnlDynamic.Controls.Add(cmbMinit);
        }

        ///////////////////////////////
        //メソッド名 : ControlCreateMilk()
        //引 数 : upName = 上のラヂオボタンのテキスト,
        //　　　　downName = 下のラヂオボタンのテキスト
        //戻り値 : なし
        //機 能 : パネルと各ラヂオボタンの動的生成
        ///////////////////////////////
        private void ControlCreateOmutuMilk(string upName, string downName)
        {
            //パネルの宣言
            Panel pnlCommon = new Panel()
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(252)))), ((int)(((byte)(185))))),
                Location = new Point(10, 35),
                Size = new Size(300, 30)
            };

            //Addで配置　※pnlDynamicにAddしてるのでパネル内に設置される。
            pnlDynamic.Controls.Add(pnlCommon);

            rdbUp.Text = upName;
            rdbDown.Text = downName;

            if (dgvRecordEditing[2, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString() == upName)
            {
                rdbUp.Checked = true;
            }
            if (dgvRecordEditing[2, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString() == downName)
            {
                rdbDown.Checked = true;
            }

            //Addで配置　※pnlMilkにAddしてるのでパネル内に設置される。
            pnlCommon.Controls.Add(rdbUp);
            pnlCommon.Controls.Add(rdbDown);
        }

        ///////////////////////////////
        //メソッド名 : ControlCreateWeight()
        //引 数 : なし
        //戻り値 : なし
        //機 能 : 各テキストボックスの動的生成
        ///////////////////////////////
        private void ControlCreateWeight()
        {
            Label lblWeight = new Label()
            {
                Location = new Point(20, 13),
                Text = "体重",
                Font = new System.Drawing.Font("MS UI Gothic", 10F)
            };

            Label lblTemperature = new Label()
            {
                Text = "体温",
                Location = new Point(20, 43),
                Font = new System.Drawing.Font("MS UI Gothic", 10F)
            };

            txbWeight.Text = dgvRecordEditing[3, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString();
            txbTemperature.Text = dgvRecordEditing[4, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString();

            pnlDynamic.Controls.Add(txbWeight);
            pnlDynamic.Controls.Add(lblWeight);
            pnlDynamic.Controls.Add(txbTemperature);
            pnlDynamic.Controls.Add(lblTemperature);
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

            SideRoundButton btnDelete = new SideRoundButton(0)
            {
                Text = "削除",
                Size = new System.Drawing.Size(60, 30),
                //Location = new System.Drawing.Point(130, 40)
                Location = new System.Drawing.Point(120, 50)
            };
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.Controls.Add(btnDelete);

            SideRoundButton btnUpdate = new SideRoundButton(1)
            {
                Text = "更新",
                Size = new System.Drawing.Size(60, 30),
                //Location = new System.Drawing.Point(130, 75)
                Location = new System.Drawing.Point(190, 50)
            };
            btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.Controls.Add(btnUpdate);
        }

    }
}
