using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//На "удволитворительно"

namespace nure.labs
{
    class task2_1
    {
        static void Main(string[] args)
        {
            int number = 12;         
            int a = 1; // Число, которое мы ищем в переменной number
            int counter = 0;
            while (number > 0)
            {
                int tmp = number % 10;
                if (tmp == a) 
                {
                    counter++;
                }               
                number = number / 10;              
            }
            if (counter != 0)
            {
                Console.WriteLine("Число " + a + " содержится в number " + counter + " раз(а)");
            }
            else {
                Console.WriteLine("Число " + a + " не найдено");
            }
        }
    }
}
