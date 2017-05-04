using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            int cavab = qazanc(8, 6);
            Console.WriteLine(cavab);
            Console.WriteLine(c - x);
            Console.WriteLine(c - y);
         }

        public static int qazanc(int gun, int gelir)
        {
            int c = gun * gelir;
            return c;
            if ((c < 1000)||(c == 1000))
            {
                int x = 4 * c / 10;
                return x;
            }
            if ((c > 1000) || (c == 1000))
            {
                int y = 4 * c / 100;
                return y;
            }
        }
    }
}
