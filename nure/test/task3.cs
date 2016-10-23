using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nure.test
{
    class task3
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 2;
            double z = 0;
            for (double x = 1, y = 1; x <= 2 & y <= 2; x += 0.1, y += 0.2) {
               
                if (x + y <= 1)
                {
                    z = Math.Pow(a, x) + Math.Pow(a, y);
                }
                else if (x + y > 1)
                {
                    z = a * Math.Pow(x, 2) + Math.Log(Math.Abs(b * x * y));
                }
            }
            Console.WriteLine(z);          
        }

    }
}
