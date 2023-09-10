using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikuji
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormMain mainForm = new FormMain();

            //スプラッシュウィンドウを表示
            FormLoad.ShowSplash(mainForm);

            //メインウィンドウを表示
            Application.Run(mainForm);
        }
    }
}
