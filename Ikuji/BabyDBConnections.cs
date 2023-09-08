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

        ///////////////////////////////
        //メソッド名：GetBabyData()
        //引　数   ：なし
        //戻り値   ：赤ちゃんデータリスト
        //機　能   ：赤ちゃんデータの取得
        ///////////////////////////////
        public List<Baby> GetBabyData()
        {
            List<Baby> babyList = new List<Baby>();

            try
            {
                var context = new BabyContext();
                babyList = context.Babys.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return babyList;
        }

        ///////////////////////////////
        //メソッド名：GetBabyData()  オーバーロード
        //引　数   ：検索条件
        //戻り値   ：赤ちゃんデータリスト
        //機　能   ：赤ちゃんデータの取得
        ///////////////////////////////
        public List<Baby> GetBabyData(Baby babyCondition)
        {
            List<Baby> babyList = new List<Baby>();

            try
            {
                var context = new BabyContext();
                babyList = context.Babys.Where(x => x.BabyMain.Contains(babyCondition.BabyMain)).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return babyList;
        }

        ///////////////////////////////
        //メソッド名：GetBabyDataMilk()
        //引　数   ：なし
        //戻り値   ：赤ちゃんミルクデータリスト
        //機　能   ：赤ちゃんミルクデータの取得
        ///////////////////////////////
        public List<Baby> GetBabyDataMilkOmutu(string babyMainName)
        {
            List<Baby> babyList = new List<Baby>();

            try
            {
                var context = new BabyContext();
                babyList = context.Babys.Where((x) => x.BabyMain == babyMainName).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return babyList;
        }

        ///////////////////////////////
        //メソッド名：GetBabyDataWeight()
        //引　数   ：なし
        //戻り値   ：赤ちゃん体重データリスト
        //機　能   ：赤ちゃん体重データの取得
        ///////////////////////////////
        public List<Baby> GetBabyDataWeight()
        {
            List<Baby> babyList = new List<Baby>();

            try
            {
                var context = new BabyContext();
                babyList = context.Babys.Where((x) => x.BabyWeight != null).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return babyList;
        }

        ///////////////////////////////
        //メソッド名：GetBabyDataTemperature()
        //引　数   ：なし
        //戻り値   ：赤ちゃん体温データリスト
        //機　能   ：赤ちゃん体温データの取得
        ///////////////////////////////
        public List<Baby> GetBabyDataTemperature()
        {
            List<Baby> babyList = new List<Baby>();

            try
            {
                var context = new BabyContext();
                babyList = context.Babys.Where((x) => x.BabyTemperature != null).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return babyList;
        }
    }
}
