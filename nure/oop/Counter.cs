using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nure.oop
{
    class Counter
    {
        int x;
        int hx;
        const int C = 1;

        Counter() { }
        Counter(int x)
        {
            this.x = x;
        }
        Counter(int x, int hx)
        {
            this.x = x;
            this.hx = hx;
        }
        int generateNext()
        {
            x += hx;
            return x;
        }
        int returnCurrent()
        {
            return x;
        }

        void increase()
        {
            x += C;
        }

        static void Main(string[] args)
        {
            Counter a = new Counter(1, 2);
        }

    }
}
