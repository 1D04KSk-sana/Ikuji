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
        //メソッド名：AddBabyAlartData()
        //引　数   ：赤ちゃん通知データ
        //戻り値   ：True or False
        //機　能   ：赤ちゃん通知データの登録
        ///////////////////////////////
        public bool AddBabyAlartData(BabyAlart resBabyAlart)
        {
            try
            {
                var context = new BabyContext();
                context.BabyAlarts.Add(resBabyAlart);
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
        //メソッド名：UpdateBabyAlartData()
        //引　数   ：なし
        //戻り値   ：赤ちゃん通知データリスト
        //機　能   ：赤ちゃん通知データの取得
        ///////////////////////////////
        public bool UpdateBabyAlartData(BabyAlart resBabyAlart)
        {
            try
            {
                var context = new BabyContext();
                var division = context.BabyAlarts.Single(x => x.BabyAlartId == 1);

                division.BabyBirthAlart = resBabyAlart.BabyBirthAlart;
                division.BabyOmutuAlart = resBabyAlart.BabyOmutuAlart;
                division.Baby3MonthAlart = resBabyAlart.Baby3MonthAlart;

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
        //メソッド名：GetBabyAlartData()
        //引　数   ：なし
        //戻り値   ：なし
        //機　能   ：赤ちゃん通知データの取得
        ///////////////////////////////
        public BabyAlart GetBabyAlartData()
        {
            BabyAlart babyAlart = null;

            try
            {
                var context = new BabyContext();
                var division = context.BabyAlarts.Single(x => x.BabyAlartId == 1);

                babyAlart = new BabyAlart
                {
                    BabyBirthAlart = division.BabyBirthAlart,
                    BabyOmutuAlart = division.BabyOmutuAlart,
                    Baby3MonthAlart = division.Baby3MonthAlart
                };

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            return babyAlart;
        }

        ///////////////////////////////
        //メソッド名：AddBabyOmutuData()
        //引　数   ：赤ちゃんオムツデータ
        //戻り値   ：True or False
        //機　能   ：赤ちゃんオムツデータの登録
        ///////////////////////////////
        public bool AddBabyOmutuData(BabyOmutu resBabyOmutu)
        {
            try
            {
                var context = new BabyContext();
                context.BabyOmutus.Add(resBabyOmutu);
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
        //メソッド名：GetBabyOmutuData()
        //引　数   ：赤ちゃんオムツデータ
        //戻り値   ：True or False
        //機　能   ：赤ちゃんオムツデータの登録
        ///////////////////////////////
        public BabyOmutu GetBabyOmutuData(int intOmutuSize)
        {
            BabyOmutu babyOmutu = null;

            try
            {
                var context = new BabyContext();
                var division = context.BabyOmutus.Single(x => x.BabyOmutuSize == intOmutuSize);

                babyOmutu = new BabyOmutu
                {
                    BabyOmutuSize = division.BabyOmutuSize,
                    BabyOmutuAmount = division.BabyOmutuAmount,
                };

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            return babyOmutu;
        }

        ///////////////////////////////
        //メソッド名：UpdateBabyOmutuData()
        //引　数   ：なし
        //戻り値   ：赤ちゃん情報データリスト
        //機　能   ：赤ちゃん情報データの取得
        ///////////////////////////////
        public bool UpdateBabyOmutuData(BabyOmutu resBabyOmutu)
        {
            try
            {
                var context = new BabyContext();
                var division = context.BabyOmutus.Single(x => x.BabyOmutuSize == resBabyOmutu.BabyOmutuSize);

                division.BabyOmutuAmount = division.BabyOmutuAmount + resBabyOmutu.BabyOmutuAmount;

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
        //メソッド名：DecreaseBabyOmutuData()
        //引　数   ：赤ちゃんオムツデータ
        //戻り値   ：True or False
        //機　能   ：赤ちゃんオムツデータの登録
        ///////////////////////////////
        public int DecreaseBabyOmutuData()
        {
            int babyOmutuAmount = 0;

            try
            {
                var context = new BabyContext();
                var divisionInfomation = context.BabyInfomations.Single(x => x.BabyInfomationId == 1);
                var division = context.BabyOmutus.Single(x => x.BabyOmutuSize == divisionInfomation.BabyIsOmutuSize);

                if (division.BabyOmutuAmount -1 > 0)
                {
                    division.BabyOmutuAmount = division.BabyOmutuAmount - 1;
                    babyOmutuAmount = division.BabyOmutuAmount;
                }

                context.SaveChanges();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return babyOmutuAmount;
        }

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
                    BabyIsOmutuSize = division.BabyIsOmutuSize,
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
                division.BabyIsOmutuSize = resBabyInfomation.BabyIsOmutuSize;
                
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
