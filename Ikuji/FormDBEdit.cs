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

        //パネルの宣言　※メソッドをまたいで使いたいのでpublic
        public Panel pnlDynamic = new Panel();

        private void FormDBEdit_Load(object sender, EventArgs e)
        {
            TestSettingdgvRecordEditing();
        }

        private void dgvRecordEditing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //動的に生成されたパネル内のコントロールを削除
            pnlDynamic.Controls.Clear();
            //this＝このフォームからRemoveでパネルを削除
            //this.Controls.Remove(pnlDynamic);

            ControlCreateCommon();

            //選択された行の1列目がミルクのとき
            if (dgvRecordEditing[0, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString() == "ミルク")
            {
                ControlCreateCommonTime();
                ControlCreateOmutuMilk("粉ミルク", "母乳");
            }

            //選択された行の1列目がオムツのとき
            if (dgvRecordEditing[0, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString() == "オムツ")
            {
                ControlCreateCommonTime();
                ControlCreateOmutuMilk("うんち", "おしっこ");
            }

            //選択された行の1列目がミルクのとき
            if (dgvRecordEditing[0, dgvRecordEditing.CurrentCellAddress.Y].Value.ToString() == "体重・体温")
            {
                ControlCreateWeight();
            }
        }

        ///////////////////////////////
        //メソッド名 : TestSettingdgvRecordEditing()
        //引 数 : なし
        //戻り値 : なし
        //機 能 : データグリッドビューのテスト用設定
        ///////////////////////////////
        private void TestSettingdgvRecordEditing()
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

            //列数を指定
            dgvRecordEditing.ColumnCount = 2;

            //ヘッダーの設定
            dgvRecordEditing.Columns[0].HeaderText = "モード";
            dgvRecordEditing.Columns[1].HeaderText = "test";

            //データの設定
            dgvRecordEditing.Rows.Add("ミルク",0);
            dgvRecordEditing.Rows.Add("オムツ",1);
            dgvRecordEditing.Rows.Add("体重・体温",2);
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

            //テキストボックスの宣言
            TextBox txbComment = new TextBox();

            //配置位置の設定
            txbComment.Location = new Point(10, 130);
            //サイズの設定
            txbComment.Size = new Size(200, 30);

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
            //コンボボックスの宣言
            ComboBox cmbHour = new ComboBox();

            //配置位置の設定
            cmbHour.Location = new Point(10, 10);
            //サイズの設定
            cmbHour.Size = new Size(80, 30);

            //コンボボックスの宣言
            ComboBox cmbMinit = new ComboBox();

            //配置位置の設定
            cmbMinit.Location = new Point(100, 10);
            //サイズの設定
            cmbMinit.Size = new Size(80, 30);

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
            pnlCommon.Size = new Size(150, 80);

            //Addで配置　※pnlDynamicにAddしてるのでパネル内に設置される。
            pnlDynamic.Controls.Add(pnlCommon);

            //ラヂオボタンの宣言
            RadioButton rdbUp = new RadioButton();

            //配置位置の設定
            rdbUp.Location = new Point(10, 10);
            //テキストの設定
            rdbUp.Text = upName;

            //ラヂオボタンの宣言
            RadioButton rdbDown = new RadioButton();

            //配置位置の設定
            rdbDown.Location = new Point(10, 40);
            //テキストの設定
            rdbDown.Text = downName;

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
            //ここに上のコードを参考にして各テキストボックスを生成してください
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();

            formMain.Show();

            this.Close();
        }
    }
}
