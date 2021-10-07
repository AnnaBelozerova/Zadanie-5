using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{   //Среднее арифметическое 7-ми чисел
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность из 7 чисел:");
            const byte n = 7;
            int[] array = new int[n];

            float sum = 0;

            for (byte i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine("{0:f2}", (sum / n));
            Console.ReadKey();
        }
    }
}
