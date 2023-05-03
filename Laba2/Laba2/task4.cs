using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    internal class task4
    {
        delegate int LengthDelegate(string S);
        public static void DO()
        {
            List<string> list = new List<string>()
            {
                "word",  "is", "not", "a", "gorobetc", "fly", "away", "wouldn't", "catch"
            };

            LengthDelegate StringLength = S => S.Length;

            foreach (var element in list)
            {
                Console.WriteLine("{0}({1})", element, StringLength(element));
            }
        }
    }
}