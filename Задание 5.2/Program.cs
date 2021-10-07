using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._2
{   //Определить макс и мин в массиве
    class Program
    {
        static void Main(string[] args)
        {
            const byte n = 15;
            Random random = new Random();
            byte[] array = new byte[n];

            for (byte i = 0; i < n; i++)
            {
                array[i] = (byte)random.Next(0, 50);
                Console.Write("{0,4} ", array[i]);
            }

            byte max = array[0];
            byte min = array[0];

            for (int i = 1; i < n; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма максимального и минимального элементов массива равноа {0}", max + min);
            Console.ReadKey();
        }
    }
}
