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
      

       private int X
        {
            get 
            { 
                return x; 
            }
            set
            {
                x = value;
            }       
        }
       private int HX
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
       public int this[int index] {

            get
            {
                int answer = 0;
                for (int i = 0; i < index; i++)
                {
                    answer += hx;
                    
                }
                return answer;
            }       
        }

        Counter_2() { }
        Counter_2(int x) {
            this.x = x;
        }
        Counter_2(int x, int hx)
        {
            this.x = x;
            this.hx = hx;
        }
        int generateNext() {
           x += hx;
           return x;
        }
        int returnCurrent() {
            return x;
        }

        void increase() {
            x += C;
        }

        static void Main(string[] args)
        {
            Counter_2 a = new Counter_2(1, 2);
            Console.WriteLine( a[10]);
        }
    }
}
