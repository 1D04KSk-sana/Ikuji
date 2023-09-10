using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ikuji
{
    public partial class FormGraph : Form
    {
        public FormGraph()
        {
            InitializeComponent();
        }
        
        //クラスの宣言
        BabyDBConnections babyDBConnections = new BabyDBConnections();

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGraph_Load(object sender, EventArgs e)
        {
            cmbGraphChange.SelectedIndex = 0;
            
            SetButton();
        }

        private void cmbGraphChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartSelect();
        }

        private void dtpMonthDay_ValueChanged(object sender, EventArgs e)
        {
            ChartSelect();
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

        ///////////////////////////////
        //メソッド名：ChartSelect()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：ミルクグラフの設定
        ///////////////////////////////
        private void ChartSelect()
        {
            int intGraphChange = cmbGraphChange.SelectedIndex;

            ChartCommon();

            //授乳が選択されているとき
            if (intGraphChange == 1 || intGraphChange == 2)
            {
                ChartCommonOmutuMilk(intGraphChange);
            }

            //体重が選択されているとき
            if (intGraphChange == 3 || intGraphChange == 4)
            {
                ChartCommonWeightTemperature(intGraphChange);
            }
        }

        ///////////////////////////////
        //メソッド名：ChartCommon()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：グラフの共通設定
        ///////////////////////////////
        private void ChartCommon()
        {
            string chartTitle = cmbGraphChange.SelectedItem.ToString() + "記録";

            if (cmbGraphChange.SelectedIndex == 0)
            {
                chartTitle = cmbGraphChange.SelectedItem.ToString();
            }
            else
            {
                chartTitle = cmbGraphChange.SelectedItem.ToString() + "記録";
            }

            // 初期化
            grfHistory.Series.Clear();      //グラフをクリア
            grfHistory.Titles.Clear();      //タイトルをクリア
            grfHistory.Legends.Clear();     //凡例をクリア
            grfHistory.ChartAreas.Clear();  //目盛り領域をクリア

            // タイトル
            Title title = new Title(chartTitle, Docking.Top, new Font("Meiryo", 12, FontStyle.Bold), Color.DarkGray);
            grfHistory.Titles.Add(title);
        }

        ///////////////////////////////
        //メソッド名：ChartCommonOmutuMilk()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：ミルクグラフの設定
        ///////////////////////////////
        private void ChartCommonOmutuMilk(int chartViewVhange)
        {
            // グラフ
            Series series = new Series();
            series.ChartType = SeriesChartType.Bubble;   //グラフの種類を選択
            series.MarkerSize = 5;                    //マーカーのサイズ
            series.MarkerColor = Color.SkyBlue;          //マーカーの背景色
            //series.MarkerBorderColor = Color.Black;   //マーカーの枠の色
            series.MarkerStyle = MarkerStyle.Circle;  //マーカーの形状 
            grfHistory.Series.Add(series);

            //凡例
            grfHistory.ChartAreas.Add("");
            Axis axisX = new Axis();
            axisX.LabelStyle.Angle = 90;                               //90度回転
            axisX.Title = "時間";                                       //X軸のタイトル
            axisX.TitleForeColor = Color.DarkGray;                     //X軸のタイトルの色
            axisX.Minimum = 0;  //X軸の最小値
            axisX.Maximum = 24;   //X軸の最大値
            axisX.Interval = 1;                                        //X軸の間隔 
            axisX.MinorTickMark.Enabled = false;                       //X軸に沿った目盛りの有効・無効の設定
            axisX.MajorTickMark.Enabled = false;                       //X軸に沿った目盛りの有効・無効の設定
            grfHistory.ChartAreas[0].AxisX = axisX;

            if (chartViewVhange == 1)
            {
                ChartMilk(series);
            }
            if (chartViewVhange == 2)
            {
                ChartOmutu(series);
            }
        }

        ///////////////////////////////
        //メソッド名：ChartCommonWeightTemperature()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：ミルクグラフの設定
        ///////////////////////////////
        private void ChartCommonWeightTemperature(int chartViewVhange)
        {
            // グラフ
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;             //グラフの種類を選択
            series.Color = Color.Pink;  //グラフ色の設定
            series.BorderWidth = 3;                              //ボーダーの幅
            series.MarkerSize = 10;                              //マーカーのサイズ
            series.MarkerColor = Color.DeepPink;                     //マーカーの背景色
            //series.MarkerBorderColor = Color.Black;              //マーカーの枠の色
            series.MarkerStyle = MarkerStyle.Circle;             //マーカーの形状
            series.XValueType = ChartValueType.DateTime;         //横軸を日付に
            grfHistory.Series.Add(series);

            DateTime currentDate = dtpMonthDay.Value.Date;
            DateTime startDate = currentDate.AddDays(-10);

            //凡例
            grfHistory.ChartAreas.Add("");
            Axis axisX = new Axis();
            axisX.Title = "日";                                       //X軸のタイトル
            axisX.TitleForeColor = Color.DarkGray;                     //X軸のタイトルの色
            axisX.Minimum = startDate.ToOADate(); ;  //X軸の最小値
            axisX.Maximum = currentDate.ToOADate(); ;   //X軸の最大値
            axisX.Interval = 1;                                        //X軸の間隔 
            axisX.MinorTickMark.Enabled = false;                       //X軸に沿った目盛りの有効・無効の設定
            axisX.MajorTickMark.Enabled = false;                       //X軸に沿った目盛りの有効・無効の設定
            grfHistory.ChartAreas[0].AxisX = axisX;
            grfHistory.ChartAreas[0].AxisX.LabelStyle.Format = "yy/MM/dd";

            if (chartViewVhange == 3)
            {
                ChartWeight(series);
            }
            if (chartViewVhange == 4)
            {
                ChartTemperature(series);
            }
        }

        ///////////////////////////////
        //メソッド名：ChartMilk()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：ミルクグラフの設定
        ///////////////////////////////
        private void ChartMilk(Series chartSeries)
        {
            // グラフ
            Series seriesOther = new Series();
            seriesOther.ChartType = SeriesChartType.Bubble;   //グラフの種類を選択
            seriesOther.MarkerSize = 5;                    //マーカーのサイズ
            seriesOther.MarkerColor = Color.Pink;          //マーカーの背景色
            //series.MarkerBorderColor = Color.Black;   //マーカーの枠の色
            seriesOther.MarkerStyle = MarkerStyle.Circle;  //マーカーの形状 
            grfHistory.Series.Add(seriesOther);

            //Y軸のカスタマイズ
            Axis axisY = new Axis();
            axisY.Title = "粉ミルク消費量";                         //Y軸のタイトル
            axisY.TitleForeColor = Color.DarkGray;       //Y軸のタイトルの色
            axisY.Minimum = 0;                           //Y軸の最小値
            axisY.Maximum = 100;                         //Y軸の最大値
            axisY.Interval = 10;                         //Y軸の間隔
            axisY.MajorGrid.Interval = 100;              //主軸グリッド線の間隔
            axisY.MinorGrid.Interval = 20;               //補助軸グリッド線の間隔
            axisY.MinorGrid.Enabled = true;              //補助軸グリッド線の有効・無効の設定
            axisY.MajorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MinorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MinorGrid.LineColor = Color.LightGray; //補助軸グリッド線の色
            grfHistory.ChartAreas[0].AxisY = axisY;

            List<Baby> babyList = new List<Baby>();

            babyList = babyDBConnections.GetBabyDataMilkOmutu("ミルク", dtpMonthDay.Value.Date);

            //表示するためのデータがないとき
            if (babyList.Count == 0)
            {
                chartSeries.Points.Add(-1, -1);
                return;
            }

            List<int?> babyHourList = babyList.Select(x => x.BabyHour).ToList();
            List<int?> babyMinitList = babyList.Select(x => x.BabyMinit).ToList();
            List<string> babySubList = babyList.Select(x => x.BabySub).ToList();

            double? doubleCount = 0;

            for (int i = 0; i < babyHourList.Count; i++)
            {
                doubleCount = (double)babyHourList[i] + (double)babyMinitList[i] / 60;
                if (babySubList[i] == "粉ミルク")
                {
                    chartSeries.Points.AddXY(doubleCount, 30);
                }
                if (babySubList[i] == "母乳")
                {
                    seriesOther.Points.AddXY(doubleCount, 30);
                }
            }
        }
        
        ///////////////////////////////
        //メソッド名：ChartOmutu()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：オムツグラフの設定
        ///////////////////////////////
        private void ChartOmutu(Series chartSeries)
        {
            //Y軸のカスタマイズ
            Axis axisY = new Axis();
            //axisY.Title = "オムツの消費量";                         //Y軸のタイトル
            //axisY.TitleForeColor = Color.DarkGray;       //Y軸のタイトルの色
            axisY.Minimum = 0;                           //Y軸の最小値
            axisY.Maximum = 2;                         //Y軸の最大値
            axisY.Interval = 0.5;                         //Y軸の間隔
            axisY.MajorGrid.Interval = 1;              //主軸グリッド線の間隔
            axisY.MinorGrid.Interval = 0.5;               //補助軸グリッド線の間隔
            axisY.MinorGrid.Enabled = true;              //補助軸グリッド線の有効・無効の設定
            axisY.MajorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MinorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MajorGrid.LineColor = Color.White; //補助軸グリッド線の色
            axisY.MinorGrid.LineColor = Color.LightGray;
            grfHistory.ChartAreas[0].AxisY = axisY;

            grfHistory.ChartAreas[0].AxisY.CustomLabels.Add(new CustomLabel(0.5, 0.6, "うんち", 0, LabelMarkStyle.None));
            grfHistory.ChartAreas[0].AxisY.CustomLabels.Add(new CustomLabel(0.5, 2.5, "おしっこ", 0, LabelMarkStyle.None));

            List<Baby> babyList = new List<Baby>();

            babyList = babyDBConnections.GetBabyDataMilkOmutu("オムツ", dtpMonthDay.Value.Date);

            //表示するためのデータがないとき
            if (babyList.Count == 0)
            {
                chartSeries.Points.Add(-1, -1);
                return;
            }

            List<int?> babyHourList = babyList.Select(x => x.BabyHour).ToList();
            List<int?> babyMinitList = babyList.Select(x => x.BabyMinit).ToList();
            List<string> babySubList = babyList.Select(x => x.BabySub).ToList();

            double? doubleCount = 0;
            double intUntiOsikko = 0;

            for (int i = 0; i < babyHourList.Count; i++)
            {
                doubleCount = (double)babyHourList[i] + (double)babyMinitList[i] / 60;
                
                if (babySubList[i] == "うんち")
                {
                    intUntiOsikko = 0.5;
                }
                if (babySubList[i] == "おしっこ")
                {
                    intUntiOsikko = 1.5;
                }
                chartSeries.Points.AddXY(doubleCount, intUntiOsikko);
            }
        }

        ///////////////////////////////
        //メソッド名：ChartWeight()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：体重グラフの設定
        ///////////////////////////////
        private void ChartWeight(Series chartSeries)
        {
            Axis axisY = new Axis();
            axisY.Title = "体重";                         //Y軸のタイトル
            axisY.TitleForeColor = Color.DarkGray;       //Y軸のタイトルの色
            axisY.Minimum = 2000;                           //Y軸の最小値
            axisY.Maximum = 10000;                         //Y軸の最大値
            axisY.Interval = 2000;                         //Y軸の間隔
            axisY.MajorGrid.Interval = 1000;              //主軸グリッド線の間隔
            axisY.MinorGrid.Interval = 500;               //補助軸グリッド線の間隔
            axisY.MinorGrid.Enabled = true;              //補助軸グリッド線の有効・無効の設定
            axisY.MajorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MinorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MajorGrid.LineColor = Color.DarkGray;
            axisY.MinorGrid.LineColor = Color.LightGray; //補助軸グリッド線の色
            
            grfHistory.ChartAreas[0].AxisY = axisY;

            List<Baby> babyList = new List<Baby>();
            babyList = babyDBConnections.GetBabyDataWeight();

            //表示するためのデータがないとき
            if (babyList.Count == 0)
            {
                chartSeries.Points.Add(-1, -1);
                return;
            }

            var babySortList = babyList.OrderBy(x => x.BabyDate);

            List<int?> babyWeightList = babySortList.Select(x => x.BabyWeight).ToList();
            List<DateTime> babyDateList = babySortList.Select(x => x.BabyDate).ToList();

            for (int i = 0; i < babyWeightList.Count; i++)
            {
                chartSeries.Points.AddXY(babyDateList[i].ToOADate(), babyWeightList[i]);
            }
        }

        ///////////////////////////////
        //メソッド名：ChartTemperature()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：体温グラフの設定
        ///////////////////////////////
        private void ChartTemperature(Series chartSeries)
        {
            Axis axisY = new Axis();
            axisY.Title = "体温";                         //Y軸のタイトル
            axisY.TitleForeColor = Color.DarkGray;       //Y軸のタイトルの色
            axisY.Minimum = 34;                           //Y軸の最小値
            axisY.Maximum = 40;                         //Y軸の最大値
            axisY.Interval = 2;                         //Y軸の間隔
            axisY.MajorGrid.Interval = 6;              //主軸グリッド線の間隔
            axisY.MinorGrid.Interval = 2;               //補助軸グリッド線の間隔
            axisY.MinorGrid.Enabled = true;              //補助軸グリッド線の有効・無効の設定
            axisY.MajorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MinorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MajorGrid.LineColor = Color.White;
            axisY.MinorGrid.LineColor = Color.LightGray; //補助軸グリッド線の色
            grfHistory.ChartAreas[0].AxisY = axisY;

            List<Baby> babyList = new List<Baby>();
            babyList = babyDBConnections.GetBabyDataTemperature();

            //表示するためのデータがないとき
            if (babyList.Count == 0)
            {
                chartSeries.Points.Add(-1, -1);
                return;
            }

            var babySortList = babyList.OrderBy(x => x.BabyDate);

            List<double?> babyTemperaturetList = babySortList.Select(x => x.BabyTemperature).ToList();
            List<DateTime> babyDateList = babySortList.Select(x => x.BabyDate).ToList();

            for (int i = 0; i < babyTemperaturetList.Count; i++)
            {
                chartSeries.Points.AddXY(babyDateList[i].ToOADate(), babyTemperaturetList[i]);
            }
        }
    }
}
