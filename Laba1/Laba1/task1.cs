using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate float arithmeticOperation(float number1, float number2);
delegate void Output(string text);

namespace Laba1
{
    internal class task1
    {
        public void DO()
        {
            arithmeticOperation addTwoNumbers = (x1, x2) => x1 + x2;
            arithmeticOperation minusTwoNumbers = (x1, x2) => x1 - x2;
            arithmeticOperation divideTwoNumbers = (x1, x2) => x1 / x2;
            arithmeticOperation multiplyTwoNumbers = (x1, x2) => x1 * x2;
            Output print = (s) => Console.WriteLine(s);
            print("" + addTwoNumbers(2, 3));
            print("" + minusTwoNumbers(2, 3));
            print("" + divideTwoNumbers(2, 3));
            print("" + multiplyTwoNumbers(2, 3));
        }


        
    }
}
