using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вариант 2
// Задание 2

namespace op.nure.test
{
    class task2
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(1, 200);
            Console.WriteLine("n = " + n);
            double first = 1 + 1 / Math.Pow(1, 2);
            for (int i = 2; i <= n; i++)
            {
                first *= 1 + 1 / Math.Pow(i, 2);
            }
            Console.WriteLine(first);
        }

    }
}
