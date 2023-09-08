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
            List<Baby> baby = new List<Baby>();

            try
            {
                var context = new BabyContext();
                baby = context.Babys.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return baby;
        }

        ///////////////////////////////
        //メソッド名：GetBabyData()  オーバーロード
        //引　数   ：検索条件
        //戻り値   ：赤ちゃんデータリスト
        //機　能   ：赤ちゃんデータの取得
        ///////////////////////////////
        public List<Baby> GetBabyData(Baby babyCondition)
        {
            List<Baby> baby = new List<Baby>();

            try
            {
                var context = new BabyContext();
                baby = context.Babys.Where(x => x.BabyMain.Contains(babyCondition.BabyMain)).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return baby;
        }

        ///////////////////////////////
        //メソッド名：UpdateBabyDataMilkOmutu()
        //引　数   ：赤ちゃんミルク・オムツデータ
        //戻り値   ：True or False
        //機　能   ：赤ちゃんミルク・オムツデータの更新
        //          ：更新成功の場合True
        //          ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateBabyDataMilkOmutu(Baby updBaby)
        {
            try
            {
                var context = new BabyContext();
                var division = context.Babys.Single(x => x.BabyId == updBaby.BabyId);

                //種類、日付、時間、分、コメントを更新する






                context.SaveChanges();
                context.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        ///////////////////////////////
        //メソッド名：UpdateBabyDataWeight()
        //引　数   ：赤ちゃん体重・体温データ
        //戻り値   ：True or False
        //機　能   ：赤ちゃん体重・体温データの更新
        //          ：更新成功の場合True
        //          ：更新失敗の場合False
        ///////////////////////////////
        public bool UpdateBabyDataWeight(Baby updBaby)
        {
            try
            {
                var context = new BabyContext();
                var division = context.Babys.Single(x => x.BabyId == updBaby.BabyId);

                //体重、体温、日付、コメントを更新する
                division = context.Babys.Single(x => x.BabyWeight == updBaby.BabyWeight);
                division = context.Babys.Single(x => x.BabyTemperature == updBaby.BabyTemperature);
                division = context.Babys.Single(x => x.BabyDate == updBaby.BabyDate);
                division = context.Babys.Single(x => x.BabyComment == updBaby.BabyComment);



                context.SaveChanges();
                context.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
