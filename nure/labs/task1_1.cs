using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nure.labs
{
    class task1_1
    {
        static void Main(string[] args)
        {
            double bankAccount = 1000;
            double percent = 0;
            for (int i = 1; i <= 10; i++)
            {                         
                percent = bankAccount * 0.02;
                bankAccount += percent;
                Console.WriteLine("Month " + i + " deposit amount: " + bankAccount);
               
            }
      
        }
    }
}
