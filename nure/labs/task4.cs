using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Вариант 6
//Дана двумерная квадратная матрица. Вычислить сумму тех из ее элементов, 
//расположенных на главной диагонали и выше нее, которые превосходят по величине все элементы, расположенные ниже главной диагонали. 
//Если на главной диагонали и выше нее нет элементов с указанным свойством, то ответом должно служить сообщение об этом.

namespace nure.labs
{
    class task4
    {
        static void Main(string[] args)
        {
            int[,] a = {{1, 103, 3},                  
                        {6, 5, 3},
                        {4, 21, 22}
                       };
            int rowLength = a.GetLength(0);
            int colLength = a.GetLength(1);
            bool isHighest = false;
            int answer = 0;
            for (int i = 0; i < rowLength; i++)
            {
                int tmp = 0;
                for (int j = 0; j < colLength; j++)
                {
                    if (j >= i)
                    {
                        for (int z = 1; z < colLength; z++)
                        {
                            for (int m = 0; m < rowLength; m++)
                            {                             
                                if (m < z && a[i, j] > a[z, m])
                                {                                  
                                    tmp = a[i, j];
                                    isHighest = true;
                                }
                                else if (m < z)
                                {
                                    isHighest = false;
                                    break;
                                }
                            }
                            if (!isHighest) { break; }
                        }
                        if (isHighest)
                        {
                            answer += tmp;
                            isHighest = false;
                        }
                    }

                }

            }
            if (answer != 0)
            {
                Console.WriteLine("Сумма: " + answer);
            }
            else
            {
                Console.WriteLine("Нету элементов превосходящих по величине все элементы, которые рсположены ниже главной диагонали.");
            }
        }
    }
}
