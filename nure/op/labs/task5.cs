using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Вариант 6
//Написать метод, входными параметрами которого являются две строки. Метод должен возвращать позицию первого вхождения в первую 
//строку какого-либо символа из второй строки, либо -1,
//если первая строка не содержит ни одного символа, принадлежащего и второй строке. 

namespace op.nure.labs
{
    class task5
    {

        public static int Compare(String a, String b)
        {

            for (int i = 0; i < a.Length; i++)
            {
                if (b.Contains(a.ElementAt(i)))
                {
                    Console.WriteLine("Element value: " + a.ElementAt(i));
                    Console.Write("Index of first element b in a is: ");
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Compare("123456", "4zbz6"));
        }
    }
}
