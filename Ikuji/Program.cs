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

            //スプラッシュウィンドウの設定
            FormLoad formLoad = new FormLoad();
            formLoad.ShowDialog();

            Application.Run(new FormMain());
        }
    }
}
