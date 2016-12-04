using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Вариант 6
//Предприниматель 1 марта открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 2% 
//от имеющейся суммы. Определить прирост суммы вклада за первый, второй, ..., десятый месяц.

namespace op.nure.labs
{
    class task1_1
    {
        static void Main(string[] args)
        {
            double bankAccount = 1000;
            double percent = 0;
            for (int i = 1; i <= 10; i++)
            {                         
                percent = Math.Round(bankAccount * 0.02, 2);
                bankAccount += percent;
                Console.WriteLine("Month " + i + " sum of growth " + percent + " " + bankAccount );                              
            }
      
        }
    }
}
