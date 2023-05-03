using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    internal class task2
    {
        void print(string text) => Console.WriteLine(text);
        delegate int RandomInt(int x, int y);

        Func<Func<int>[], float> Average = delegate (Func<int>[] delegates)
            {
                int sum = 0;
                foreach (var del in delegates)
                {
                    sum += del();
                }
                return sum / delegates.Length;
            };
        public void DO()
        {
            Func<int>[] delegates =
            {
                ()=>new Random().Next(1,100),
                ()=>new Random().Next(3,10),
                ()=>new Random().Next(60,130),
                ()=>new Random().Next(100,111),
                ()=>new Random().Next(2,4),
            };
           
            print(Average(delegates)+"") ;
        }
        
        
    }
}
