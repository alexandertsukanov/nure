using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Вариант 6
//Поменять местами в одномерном массиве противоположные по знаку элементы (например 5.7 и -5.7), с учетов перестановки каждого элемента не более одного раза.

namespace op.nure.labs
{
    class task3
    {

        static void Main(string[] args)
        {

            int[] a = { 5, 3, 8, -3, 3, 1, -1, -3, -3 };
            int[] swapped = new int[a.Length];
            for (int i = 0; i < swapped.Length; i++) {
                swapped[i] = -1;
            } 
            int lastinswap = 0;         
            for (int i = 0; i < a.Length; i++)
            {              
                for (int j = i; j < a.Length; j++)                   
                {
                    if (a[i] == (a[j] * -1) && !swapped.Contains(i) && !swapped.Contains(j))
                    {
                        swapped[lastinswap] = i;
                        swapped[lastinswap + 1] = j;
                        lastinswap += 2;
                        int tmp = a[j];
                        a[j] = a[i];
                        a[i] = tmp;
                        break;                     
                    }
                } 
            }
            Console.WriteLine(string.Join(", ", a));
            
        }

    }
}
