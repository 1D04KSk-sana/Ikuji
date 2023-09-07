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
    public partial class FormDBEdit : Form
    {
        public FormDBEdit()
        {
            InitializeComponent();
        }

        //クラスの宣言
        BabyDBConnections babyDBConnections = new BabyDBConnections();

        //コントロールの宣言　※メソッドをまたいで使いたいのでpublic
        public Panel pnlDynamic = new Panel();
        
        //データグリッドビュー用の赤ちゃんデータ
        private static List<Baby> Baby;

        private static int ControlNumber = 0;

        private void FormDBEdit_Load(object sender, EventArgs e)
        {
            //cmbViewChangeを"全部"に
            cmbViewChange.SelectedIndex = 0;
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

            dgvRecordEditing.ClearSelection();

            //動的に生成されたパネルを削除
            this.Controls.Remove(pnlDynamic);

            ControlNumber = 0;
        }

        private void dgvRecordEditing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ControlNumber == 0)
            {
                ControlCreateCommon();
                ControlNumber = 1;
            }
            if (ControlNumber == 1)
            {
                //動的に生成されたパネル内のコントロールを削除
                pnlDynamic.Controls.Clear();
            }

            SelectRowControl();
        }

        ///////////////////////////////
        //メソッド名：SelectRowControl()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：選択された行に対してのコントロールの変更
        ///////////////////////////////
        private void SelectRowControl()
        {
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

            //選択された行の1列目がミルクのとき
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
            pnlDynamic.BackColor = Color.Gray;
            //配置位置の設定
            pnlDynamic.Location = new Point(200, 10);
            //サイズの設定
            pnlDynamic.Size = new Size(350, 150);

            //Addで設置　※this＝このフォームのこと
            this.Controls.Add(pnlDynamic);

            TextBox txbComment = new TextBox();

            //配置位置の設定
            txbComment.Location = new Point(10, 80);
            //サイズの設定
            txbComment.Size = new Size(200, 30);
            txbComment.Text = dgvRecordEditing[8, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString();

            //Addで配置　※pnlDynamicにAddしてるのでパネル内に設置される。
            pnlDynamic.Controls.Add(txbComment);
        }

        ///////////////////////////////
        //メソッド名 : ControlCreateCommonTime()
        //引 数 : なし
        //戻り値 : なし
        //機 能 : 時間コンボボックスと分コンボボックスの動的生成
        ///////////////////////////////
        private void ControlCreateCommonTime()
        {
            ComboBox cmbHour = new ComboBox();
            ComboBox cmbMinit = new ComboBox();

            //配置位置の設定
            cmbHour.Location = new Point(10, 10);
            //サイズの設定
            cmbHour.Size = new Size(80, 30);

            string[] arrayHour = new string[24];
            for (int i = 0; i < arrayHour.Length; i++)
            {
                arrayHour[i] = i.ToString();
            }
            cmbHour.Items.AddRange(arrayHour);

            cmbHour.SelectedIndex = int.Parse(dgvRecordEditing[6, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString());

            //配置位置の設定
            cmbMinit.Location = new Point(100, 10);
            //サイズの設定
            cmbMinit.Size = new Size(80, 30);

            string[] arrayMinit = new string[60];
            for (int i = 0; i < arrayMinit.Length; i++)
            {
                arrayMinit[i] = i.ToString();
            }
            cmbMinit.Items.AddRange(arrayMinit);

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
            Panel pnlCommon = new Panel();

            //背景色の設定　※枠線がないので色を背景に合わせると目立たない
            pnlCommon.BackColor = Color.DarkGray;
            //配置位置の設定
            pnlCommon.Location = new Point(10, 40);
            //サイズの設定
            pnlCommon.Size = new Size(300, 30);

            //Addで配置　※pnlDynamicにAddしてるのでパネル内に設置される。
            pnlDynamic.Controls.Add(pnlCommon);

            RadioButton rdbDown = new RadioButton();
            RadioButton rdbUp = new RadioButton();

            //配置位置の設定
            rdbUp.Location = new Point(10, 5);
            //テキストの設定
            rdbUp.Text = upName;

            //配置位置の設定
            rdbDown.Location = new Point(150, 5);
            //テキストの設定
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
            TextBox txbWeight = new TextBox();
            TextBox txbTemperature = new TextBox();

            txbWeight.Location = new Point(50, 10);
            txbWeight.Text = dgvRecordEditing[3, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString();

            txbTemperature.Location = new Point(50, 40);
            txbTemperature.Text = dgvRecordEditing[4, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString();

            Label lblWeight = new Label();
            lblWeight.Text = "体重";
            lblWeight.Location = new Point(10, 13);

            Label lblTemperature = new Label();
            lblTemperature.Text = "体温";
            lblTemperature.Location = new Point(10, 43);

            pnlDynamic.Controls.Add(txbWeight);
            pnlDynamic.Controls.Add(lblWeight);
            pnlDynamic.Controls.Add(txbTemperature);
            pnlDynamic.Controls.Add(lblTemperature);
        }
    }
}
