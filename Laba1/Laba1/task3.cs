using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

delegate float Mid(int x1, int x2, int x3);

namespace Laba1
{
    internal class task3
    {
        public void DO()
        {
            Mid addNumbers = (x1, x2, x3) => (float) (x1 + x2 + x3) / 3;
            Console.WriteLine(addNumbers(4,3,8));
            
        }
    }
}
