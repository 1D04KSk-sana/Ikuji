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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grfHistory_Click(object sender, EventArgs e)
        { 

        }

        private void FormGraph_Load(object sender, EventArgs e)
        {
            cmbGraphChange.Items.Add("–選択されていません–");
            cmbGraphChange.Items.Add("授乳");
            cmbGraphChange.Items.Add("オムツ");
            cmbGraphChange.Items.Add("体重");
            cmbGraphChange.Items.Add("体温");
        }

        private void cmbGraphChange_SelectedIndexChanged(object sender, EventArgs e)
        {

            //授乳が選択されているとき
            if(cmbGraphChange.SelectedIndex == 1)
            {
                ChartMilk();
            }

            //オムツが選択されているとき
            if(cmbGraphChange.SelectedIndex == 2)            
            {
                ChartOmatu();
            }

            //体重が選択されているとき
            if (cmbGraphChange.SelectedIndex == 3)
            {
                ChartWeight();
 
            }

            //体温が選択されているとき
            if (cmbGraphChange.SelectedIndex == 4)
            {
                ChartTemperature();
            }
        }

        private void ChartMilk()
        {
            // 初期化
            grfHistory.Series.Clear();      //グラフをクリア
            grfHistory.Titles.Clear();      //タイトルをクリア
            grfHistory.Legends.Clear();     //凡例をクリア
            grfHistory.ChartAreas.Clear();  //目盛り領域をクリア

            // タイトル
            Title title = new Title("授乳記録", Docking.Top, new Font("Meiryo", 12, FontStyle.Bold), Color.DarkGray);
            grfHistory.Titles.Add(title);

            // グラフ
            Series series = new Series();
            series.ChartType = SeriesChartType.Bubble;   //グラフの種類を選択
            series.MarkerSize = 5;                    //マーカーのサイズ
            series.MarkerColor = Color.Blue;          //マーカーの背景色
            series.MarkerBorderColor = Color.Black;   //マーカーの枠の色
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

            // データ追加
            var hist = new Point[] {
                new Point(1, 30),
                new Point(2, 30)
                };

            // データ設定
            for (int i = 0; i < hist.Length; i++)
            {
                series.Points.AddXY(hist[i].X, hist[i].Y);
            }
        }

        private void ChartOmatu()
        {
            // 初期化
            grfHistory.Series.Clear();      //グラフをクリア
            grfHistory.Titles.Clear();      //タイトルをクリア
            grfHistory.Legends.Clear();     //凡例をクリア
            grfHistory.ChartAreas.Clear();  //目盛り領域をクリア

            // タイトル
            Title title = new Title("オムツ記録", Docking.Top, new Font("Meiryo", 12, FontStyle.Bold), Color.DarkGray);
            grfHistory.Titles.Add(title);

            // グラフ
            Series series = new Series();
            series.ChartType = SeriesChartType.Bubble;   //グラフの種類を選択
            series.MarkerSize = 5;                    //マーカーのサイズ
            series.MarkerColor = Color.Blue;          //マーカーの背景色
            series.MarkerBorderColor = Color.Black;   //マーカーの枠の色
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

            //Y軸のカスタマイズ
            Axis axisY = new Axis();
            axisY.Title = "オムツの消費量";                         //Y軸のタイトル
            axisY.TitleForeColor = Color.DarkGray;       //Y軸のタイトルの色
            axisY.Minimum = 0;                           //Y軸の最小値
            axisY.Maximum = 10;                         //Y軸の最大値
            axisY.Interval = 1;                         //Y軸の間隔
            axisY.MajorGrid.Interval = 100;              //主軸グリッド線の間隔
            axisY.MinorGrid.Interval = 20;               //補助軸グリッド線の間隔
            axisY.MinorGrid.Enabled = true;              //補助軸グリッド線の有効・無効の設定
            axisY.MajorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MinorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MinorGrid.LineColor = Color.LightGray; //補助軸グリッド線の色
            grfHistory.ChartAreas[0].AxisY = axisY;

            // データ追加
            var hist = new Point[] {
                new Point(1, 3),
                new Point(2, 5)
                };

            // データ設定
            for (int i = 0; i < hist.Length; i++)
            {
                series.Points.AddXY(hist[i].X, hist[i].Y);
            }
        }

        private void ChartWeight()
        {
            // 初期化
            grfHistory.Series.Clear();      //グラフをクリア
            grfHistory.Titles.Clear();      //タイトルをクリア
            grfHistory.Legends.Clear();     //凡例をクリア
            grfHistory.ChartAreas.Clear();  //目盛り領域をクリア

            // タイトル
            Title title = new Title("体重記録", Docking.Top, new Font("Meiryo", 12, FontStyle.Bold), Color.DarkGray);
            grfHistory.Titles.Add(title);

            // グラフ
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;             //グラフの種類を選択
            series.Color = ColorTranslator.FromHtml("#32aed4");  //グラフ色の設定
            series.BorderWidth = 3;                              //ボーダーの幅
            series.MarkerSize = 10;                              //マーカーのサイズ
            series.MarkerColor = Color.Blue;                     //マーカーの背景色
            series.MarkerBorderColor = Color.Black;              //マーカーの枠の色
            series.MarkerStyle = MarkerStyle.Circle;             //マーカーの形状
            grfHistory.Series.Add(series);

            //凡例
            grfHistory.ChartAreas.Add("");
            Axis axisX = new Axis();
            axisX.Title = "時間";                                       //X軸のタイトル
            axisX.TitleForeColor = Color.DarkGray;                     //X軸のタイトルの色
            axisX.Minimum = 0;  //X軸の最小値
            axisX.Maximum = 24;   //X軸の最大値
            axisX.Interval = 1;                                        //X軸の間隔 
            axisX.MinorTickMark.Enabled = false;                       //X軸に沿った目盛りの有効・無効の設定
            axisX.MajorTickMark.Enabled = false;                       //X軸に沿った目盛りの有効・無効の設定
            grfHistory.ChartAreas[0].AxisX = axisX;

            Axis axisY = new Axis();
            axisY.Title = "体重";                         //Y軸のタイトル
            axisY.TitleForeColor = Color.DarkGray;       //Y軸のタイトルの色
            axisY.Minimum = 0;                           //Y軸の最小値
            axisY.Maximum = 10000;                         //Y軸の最大値
            axisY.Interval = 2000;                         //Y軸の間隔
            axisY.MajorGrid.Interval = 1000;              //主軸グリッド線の間隔
            axisY.MinorGrid.Interval = 200;               //補助軸グリッド線の間隔
            axisY.MinorGrid.Enabled = true;              //補助軸グリッド線の有効・無効の設定
            axisY.MajorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MinorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MinorGrid.LineColor = Color.LightGray; //補助軸グリッド線の色
            grfHistory.ChartAreas[0].AxisY = axisY;

            // データ追加
            var hist = new Point[] {
                new Point(1, 3000),
                new Point(2, 2000),
                new Point(3, 1500),
                new Point(4, 8000),
                new Point(5, 1800),
                new Point(6, 1000),
                new Point(7, 4000),
                new Point(8, 1300),
                new Point(9, 5000),
                };

            // データ設定
            for (int i = 0; i < hist.Length; i++)
            {
                series.Points.AddXY(hist[i].X, hist[i].Y);
            }
        }

        private void ChartTemperature()
        {
            // 初期化
            grfHistory.Series.Clear();      //グラフをクリア
            grfHistory.Titles.Clear();      //タイトルをクリア
            grfHistory.Legends.Clear();     //凡例をクリア
            grfHistory.ChartAreas.Clear();  //目盛り領域をクリア

            // タイトル
            Title title = new Title("体温記録", Docking.Top, new Font("Meiryo", 12, FontStyle.Bold), Color.DarkGray);
            grfHistory.Titles.Add(title);

            // グラフ
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;             //グラフの種類を選択
            series.Color = ColorTranslator.FromHtml("#32aed4");  //グラフ色の設定
            series.BorderWidth = 3;                              //ボーダーの幅
            series.MarkerSize = 10;                              //マーカーのサイズ
            series.MarkerColor = Color.Blue;                     //マーカーの背景色
            series.MarkerBorderColor = Color.Black;              //マーカーの枠の色
            series.MarkerStyle = MarkerStyle.Square;             //マーカーの形状
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

            Axis axisY = new Axis();
            axisY.Title = "体温";                         //Y軸のタイトル
            axisY.TitleForeColor = Color.DarkGray;       //Y軸のタイトルの色
            axisY.Minimum = 34;                           //Y軸の最小値
            axisY.Maximum = 38;                         //Y軸の最大値
            axisY.Interval = 0.5;                         //Y軸の間隔
            axisY.MajorGrid.Interval = 100;              //主軸グリッド線の間隔
            axisY.MinorGrid.Interval = 20;               //補助軸グリッド線の間隔
            axisY.MinorGrid.Enabled = true;              //補助軸グリッド線の有効・無効の設定
            axisY.MajorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MinorTickMark.Enabled = false;         //Y軸に沿った目盛りの有効・無効の設定
            axisY.MinorGrid.LineColor = Color.LightGray; //補助軸グリッド線の色
            grfHistory.ChartAreas[0].AxisY = axisY;

            // ChartにChartAreaを追加します
            string chart_area1 = "Area1";
            grfHistory.ChartAreas.Add(new ChartArea(chart_area1));
            // ChartにSeriesを追加します
            string legend1 = "Graph1";
            grfHistory.Series.Add(legend1);
            // グラフの種別を指定
            grfHistory.Series[legend1].ChartType = SeriesChartType.Line;  // 折れ線グラフを指定
            grfHistory.Series[legend1].MarkerSize = 20;                     // マークサイズを指定
            grfHistory.Series[legend1].MarkerStyle = MarkerStyle.Circle;    // マークスタイル(形状)を指定


            // データを用意します
            double[] x_values = new double[4] { 1.0, 2.0, 3.0, 5 };
            double[] y_values = new double[4] { 36.0, 37.0, 36.5, 37.0 };
            //double[] bubble_values = new double[4] { 10.0, 10.0, 10.0,10.0 };  // バブルチャートのZ軸(ポイントの大きさを決めるデータ)

            // データをシリーズにセットします
            for (int i = 0; i < y_values.Length; i++)
            {
                //DataPoint dp = new DataPoint((double)x_values[i], y_values[i]);
                double[] y_vals = new double[2] { y_values[i], 10 };
                DataPoint dp = new DataPoint((double)x_values[i], y_vals);
                grfHistory.Series[legend1].Points.Add(dp);
            }
        }
    }
}
