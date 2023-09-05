using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikuji
{
    class BabyDBConnections
    {
        ///////////////////////////////
        //メソッド名：AddBabyData()
        //引　数   ：赤ちゃんデータ
        //戻り値   ：True or False
        //機　能   ：赤ちゃんデータの登録
        ///////////////////////////////
        public bool AddBabyData(Baby resBaby)
        {
            try
            {
                var context = new BabyContext();
                context.Babys.Add(resBaby);
                context.SaveChanges();
                context.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
