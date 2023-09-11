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
        //メソッド名：AddBabyInfomationData()
        //引　数   ：赤ちゃん情報データ
        //戻り値   ：True or False
        //機　能   ：赤ちゃん情報データの登録
        ///////////////////////////////
        public bool AddBabyInfomationData(BabyInfomation resBabyInfomation)
        {
            try
            {
                var context = new BabyContext();
                context.BabyInfomations.Add(resBabyInfomation);
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
        //メソッド名：GetBabyInfomationData()
        //引　数   ：なし
        //戻り値   ：赤ちゃん情報データリスト
        //機　能   ：赤ちゃん情報データの取得
        ///////////////////////////////
        public BabyInfomation GetBabyInfomationData()
        {
            BabyInfomation babyInfomation = null;

            try
            {
                var context = new BabyContext();
                var division = context.BabyInfomations.Single(x => x.BabyInfomationId == 1);

                babyInfomation = new BabyInfomation
                {
                    BabyName = division.BabyName,
                    BabyBirthDay = division.BabyBirthDay,
                };

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            return babyInfomation;
        }

        ///////////////////////////////
        //メソッド名：UpdateBabyInfomationData()
        //引　数   ：なし
        //戻り値   ：赤ちゃん情報データリスト
        //機　能   ：赤ちゃん情報データの取得
        ///////////////////////////////
        public bool UpdateBabyInfomationData(BabyInfomation resBabyInfomation)
        {
            try
            {
                var context = new BabyContext();
                var division = context.BabyInfomations.Single(x => x.BabyInfomationId == 1);

                division.BabyName = resBabyInfomation.BabyName;
                division.BabyBirthDay = resBabyInfomation.BabyBirthDay;
                
                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            };

            return true;
        }

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
        public List<Baby> GetBabyDataMilkOmutu(string babyMainName, DateTime babyDateTime)
        {
            List<Baby> babyList = new List<Baby>();
            List<Baby> babyDateList = new List<Baby>();

            try
            {
                var context = new BabyContext();
                babyList = context.Babys.Where((x) => x.BabyMain == babyMainName && x.BabyDate == babyDateTime.Date).ToList();
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

        ///////////////////////////////
        //メソッド名：DeleteBabyData()
        //引　数   ：なし
        //戻り値   ：赤ちゃんデータ削除完了フラグ
        //機　能   ：赤ちゃんデータの削除
        ///////////////////////////////
        public void DeleteBabyData(int babynumber)
        {
            try
            {
                DialogResult dr = MessageBox.Show("データを削除してもよろしいですか？", "確認", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    var context = new BabyContext();
                    var babyInfo = context.Babys.Single(x => x.BabyId == babynumber);
                    context.Babys.Remove(babyInfo);
                    context.SaveChanges();
                    context.Dispose();
                    MessageBox.Show("データを削除しました。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                division.BabySub = updBaby.BabySub;
                division.BabyDate = updBaby.BabyDate;
                division.BabyHour = updBaby.BabyHour;
                division.BabyMinit = updBaby.BabyMinit;
                division.BabyComment = updBaby.BabyComment;

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
                division.BabyWeight = updBaby.BabyWeight;
                division.BabyTemperature = updBaby.BabyTemperature;
                division.BabyDate = updBaby.BabyDate;
                division.BabyComment = updBaby.BabyComment;



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
