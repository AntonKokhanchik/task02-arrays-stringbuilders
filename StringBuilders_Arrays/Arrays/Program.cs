using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {

        public static void Write(int[,] arr)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr[i, j]);
                Console.Write("\n");
            }
        }

        public static int FindMin(int[,] arr)
        {
            int min = arr[0,0];
            foreach (int el in arr)
                if (el < min)
                    min = el;
            return min;
        }

        public static int FindMax(int[,] arr)
        {
            int max = arr[0, 0];
            foreach (int el in arr)
                if (el > max)
                    max = el;
            return max;
        }

        public static void SwapMinMax(int[,] arr)
        {
            int min = FindMin(arr);
            int max = FindMax(arr);

            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] == min)
                        arr[i, j] = max;
                    else if (arr[i, j] == max)
                        arr[i, j] = min;        
        }

        static void Main(string[] args)
        {
            int[,] array = new int[2, 3];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j< array.GetLength(1);  j++)
                {
                    int tmp = 0;
                    bool flag;
                    do
                    {
                        Console.WriteLine("Введите элемент целочисленного массива {0},{1}: ", i, j);
                        flag = Int32.TryParse(Console.ReadLine(), out tmp);
                        if(flag)
                            array[i, j] = tmp;
                        else
                            Console.WriteLine("Вы ввели недопустимый символ или число слишком большое");
                    }
                    while (!flag);
                }

            Write(array);

            SwapMinMax(array);

            Console.WriteLine("минимальный {0}", FindMin(array));
            Console.WriteLine("максимальный {0}", FindMax(array));

            Write(array);
            
            Console.ReadLine();
        }
    }
}
