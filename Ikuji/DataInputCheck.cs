using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ikuji
{
    class DataInputCheck
    {
        ///////////////////////////////
        //メソッド名：CheckNumeric()
        //引　数   ：文字列
        //戻り値   ：True or False
        //機　能   ：数値のチェック
        //          ：数値の場合True
        //          ：数値でない場合False
        ///////////////////////////////
        public bool CheckNumeric(string text)
        {
            bool flg;

            Regex regex = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (!regex.IsMatch(text))
                flg = false;
            else
                flg = true;

            return flg;
        }
    }
}
