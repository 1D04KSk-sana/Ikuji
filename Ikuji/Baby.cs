using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikuji
{
    internal class Baby
    {
        public int BabyId { get; set; }
        //オムツ・ミルク・体重・体温
        public string BabyMain { get; set; }
        //おしっこ・うんこ・母乳・粉ミルク
        public string BabySub { get; set; }
        //体重
        public int? BabyWeight { get; set; }
        //体温
        public double? BabyTemperature { get; set; }
        //日付
        public string BabyDate { get; set; }
        //時間
        public int BabyHour { get; set; }
        //分
        public int BabyMinit { get; set; }
        //コメント
        public string BabyComment { get; set; }
    }
}
