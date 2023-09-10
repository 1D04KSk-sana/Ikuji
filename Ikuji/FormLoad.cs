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
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            // フォームの境界線、タイトルバーを無しに設定
            this.FormBorderStyle = FormBorderStyle.None;

            // フォームの背景を黒に設定
            this.BackColor = Color.Black;

            // フォームの不透明度を設定（半透明化）
            //this.Opacity = 0.8;

            // 丸み値
            int radius = 50;
            int diameter = radius * 2;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            float r = 50;
            float x = 0.0f;
            float y = 0.0f;
            float w = ClientSize.Width;
            float h = ClientSize.Height;

            gp.StartFigure();
            gp.AddArc(x, y, r, r, 180.0f, 90.0f);
            gp.AddArc(w - r, y, r, r, 270.0f, 90.0f);
            gp.AddArc(w - r, h - r, r, r, 0.0f, 90.0f);
            gp.AddArc(x, h - r, r, r, 90.0f, 90.0f);
            gp.CloseFigure();

            this.Region = new Region(gp);

            //スプラッシュウィンドウの表示時間
            timer1.Interval = 3000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
