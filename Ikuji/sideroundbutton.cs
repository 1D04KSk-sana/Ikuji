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
        public SideRoundButton(int num)
        {
            InitializeButton(num);
        }

        private void InitializeButton(int num)
        {
            this.Paint += (sender, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = 15; // 角丸の半径を設定
                    Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                    path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90); // 左上の角
                    path.AddArc(rect.X + rect.Width - 2 * radius, rect.Y, radius * 2, radius * 2, 270, 90); // 右上の角
                    path.AddArc(rect.X + rect.Width - 2 * radius, rect.Y + rect.Height - 2 * radius, radius * 2, radius * 2, 0, 90); // 右下の角
                    path.AddArc(rect.X, rect.Y + rect.Height - 2 * radius, radius * 2, radius * 2, 90, 90); // 左下の角
                    path.CloseAllFigures();

                    this.Region = new Region(path);
                }
            };

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
            
        }

        
    }
}
