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

        // 角丸の半径を定数として定義
        private const int BorderRadius = 15;

        private void InitializeButton(int num)
        {
            Paint += (sender, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    Rectangle rectA = new Rectangle(0, 0, Width, Height);

                    // 角丸のパスを作成
                    AddRoundedRectangle(path, rectA, 180, 90);

                    Region = new Region(path);
                }

                using (GraphicsPath borderPath = new GraphicsPath())
                {
                    Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

                    // 枠線のパスを作成
                    AddRoundedRectangle(borderPath, rect, 180, 90);

                    // 枠線を描画
                    using (Pen borderPen = new Pen(Color.White, 5))
                    {
                        e.Graphics.DrawPath(borderPen, borderPath);
                    }
                }
            };
            Size = new System.Drawing.Size(100, 40);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            //情報編集・削除(オレンジ)
            if (num == 0)
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(201)))), ((int)(((byte)(129)))));
                FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(197)))));
                FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            }

            //登録・更新(青)
            if (num == 1)
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
                FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            }

            //グラフ表示(赤)
            if (num == 2)
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
                FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            }

            //戻る(ピンク)
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

        // 角丸のパスを作成するメソッド
        private void AddRoundedRectangle(GraphicsPath path, Rectangle rect, float startAngle, float sweepAngle)
        {
            path.AddArc(rect.X, rect.Y, BorderRadius * 2, BorderRadius * 2, startAngle, sweepAngle); // 左上の角
            path.AddArc(rect.X + rect.Width - 2 * BorderRadius, rect.Y, BorderRadius * 2, BorderRadius * 2, startAngle + 90, sweepAngle); // 右上の角
            path.AddArc(rect.X + rect.Width - 2 * BorderRadius, rect.Y + rect.Height - 2 * BorderRadius, BorderRadius * 2, BorderRadius * 2, startAngle + 180, sweepAngle); // 右下の角
            path.AddArc(rect.X, rect.Y + rect.Height - 2 * BorderRadius, BorderRadius * 2, BorderRadius * 2, startAngle + 270, sweepAngle); // 左下の角
            path.CloseAllFigures();
        }
    }
}
