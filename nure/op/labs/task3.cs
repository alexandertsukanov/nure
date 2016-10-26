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
           
            int[] a = {5,-3,-2,-1 , 1, 2, 3 , -5};        
            for (int i = 0; i < a.Length; i++)
            {               
                for (int j = 0; j < a.Length; j++)                   
                {
                    if (a[i] == (a[j] * -1) && i < j ) {
                        int tmp = a[j];
                        a[j] = a[i];
                        a[i] = tmp;
                        
                    }
                } 
            }
        }

    }
}
