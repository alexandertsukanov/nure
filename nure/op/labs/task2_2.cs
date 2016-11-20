using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Вариант 6
//На "отлично"
//Даны натуральные числа m и n. Получить все натуральные числа, меньшие n, квадрат суммы цифр которых равен m.

namespace op.nure.labs
{
    class task2_2
    {
        static void Main(string[] args)
        {
            int m = 16;
            int n = 1000;
            for (int i = 0; i < n; i++)
            {
                int number = i;
                int sum = 0;
                while (number != 0) {
                    sum += number % 10;
                    number /= 10;             
                }
                if (Math.Pow(sum, 2) == m)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
