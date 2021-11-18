using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float s = 0;
            const int n = 7;
            int[] array = new int[n];
            
            for (int i=0;i<n;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
            }
            Console.WriteLine("Среднее арифметическое чисел равно {0:f2}", s / n);
            Console.ReadKey();
        }
    }
}
