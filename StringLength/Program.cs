using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StringLengthInfoLib;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1👩";

            //StringInfo info = new StringInfo(str);
            //Console.WriteLine($"長さ【{str.Length}】");
            //Console.WriteLine($"サロゲート【{info.LengthInTextElements}】");
            //Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            //Console.WriteLine($"バイト数【{sjisEnc.GetByteCount(str)}】");

            StringLengthInfo slInfo = new StringLengthInfo();
            var dict = slInfo.GetInfo(str);

            dict.ToList().ForEach(pair => Console.WriteLine($"{pair.Key}:{pair.Value}"));

            Console.ReadKey();

        }
    }
}
