using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikuji
{
    class SideRoundButton : Button
    {
        private static int num = 0;

        public void number(int colorcount)
        {
            num = colorcount;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            //型の宣言
            float x = 0.0f;
            float y = 0.0f;
            float w = ClientSize.Width;
            float h = ClientSize.Height;
            GraphicsPath graphics = new GraphicsPath();


            //丸みをつける設定
            graphics.StartFigure();
            graphics.AddArc(x, y, h, h, 90.0f, 180.0f);
            graphics.AddArc(w - h, y, h, h, 270.0f, 180.0f);
            graphics.CloseFigure();
            this.Region = new System.Drawing.Region(graphics);
            Size = new System.Drawing.Size(100, 40);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            //情報編集
            if (num == 0)
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(201)))), ((int)(((byte)(129)))));
                FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(197)))));
                FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            }

            //登録
            if (num == 1)
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
                FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            }

            //グラフ表示
            if (num == 2)
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
                FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            }

            //戻る
            if (num == 3)
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
                FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            }

            //BackColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(201)))), ((int)(((byte)(129)))));
            //クリックしたときの色
            //FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            //マウスを乗せたときの色
            //FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(197)))));
            base.OnPaint(pevent);
        }
    }
}
