using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//На "отлично"

namespace nure.labs
{
    class task2_2
    {
        static void Main(string[] args)
        {
            int m = 900;
            int n = 1000;
            for (int i = 0; i < n; i++)
            {
                if ((i * i) == m) { Console.WriteLine(i); }
            }
        }
    }
}
