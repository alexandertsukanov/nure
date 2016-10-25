using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Вариант 6
//Написать метод, входными параметрами которого являются две строки. Метод должен возвращать позицию первого вхождения в первую 
//строку какого-либо символа из второй строки, либо -1,
//если первая строка не содержит ни одного символа, принадлежащего и второй строке. 

namespace nure.labs
{
    class task5
    {

        public static int Comapre(String a, String b)
        {

            for (int i = 0; i < b.Length; i++)
            {
                if (a.Contains(b.ElementAt(i)))
                {
                    return a.IndexOf(b.ElementAt(i));
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Comapre("adb", "zb"));
        }
    }
}
