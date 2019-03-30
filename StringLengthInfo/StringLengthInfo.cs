using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace StringLengthInfoLib
{
    public class StringLengthInfo
    {

        public Dictionary<string,long> GetInfo(string str) 
        {
            Dictionary<string, long> dict = new Dictionary<string, long>();

            // 文字長さ
            dict.Add("length", str.Length);
            // 文字数（サロゲートペア対応）
            StringInfo info = new StringInfo(str);
            dict.Add("length（サロゲートペア対応）", info.LengthInTextElements);
            // バイト数
            dict.Add("SJISバイト数", Encoding.GetEncoding("Shift_JIS").GetByteCount(str));
            dict.Add("UTF8バイト数", Encoding.GetEncoding("UTF-8").GetByteCount(str));

            return dict;
        }

    }
}
