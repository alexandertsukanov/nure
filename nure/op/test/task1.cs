﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вариант 2
// Задание 1

namespace op.nure.test
{
    class task1
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            int answer = 0;
            for (int i = 0; i < 15; i++) {
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(b);
                if ((b % 7 == 0) || (b % 3 == 0)) {
                    answer += b;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
