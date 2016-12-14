using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nure.oop
{
    class Counter_2
    {

        private const int C = 1;
        private int x;
        private int hx;
        private int max;


        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value > max)
                {
                    throw new System.IndexOutOfRangeException("Value more than max constant.");
                }
                else
                {
                    x = value;
                }
            }
        }
        public int HX
        {
            get
            {
                return hx;
            }
            set
            {
                hx = value;
            }

        }
        public int Max
        {
            get
            {
                return max;
            }
            set
            {
                max = value;
            }

        }
        public int this[int index]
        {

            get
            {
                int answer = X;
                for (int i = 0; i < index; i++)
                {
                    answer += hx;
                    if (answer > max)
                    {
                        throw new System.IndexOutOfRangeException("Value more than max constant.");
                    }
                }
                return answer;
            }
        }

        Counter_2() { }
        Counter_2(int x)
        {
            X = x;
        }
        Counter_2(int x, int hx)
        {
            X = x;
            HX = hx;
        }
        int generateNext()
        {
            X += HX;
            return X;
        }
        int returnCurrent()
        {
            return X;
        }

        void increase()
        {
            X += C;
        }

        static void Main(string[] args)
        {
            Counter_2 a = new Counter_2(0, 2);
            a.Max = 15;
            Console.WriteLine(a[15]);

        }
    }
}
