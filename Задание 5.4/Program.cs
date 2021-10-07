using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._4
{   //Определить количество нечетных элементов на четных позициях
    class Program
    {
        static void Main(string[] args)
        {
            const byte n = 20;
            Random random = new Random();
            sbyte[] array = new sbyte[n];
            byte sum = 0;

            for (byte i = 0; i < n; i++)
            {
                array[i] = (sbyte)random.Next(-50, 50);
                Console.Write("{0,4} ", array[i]);
            }
            for (int i = 0; i < n; i += 2)
            {
                if (array[i] >= 0 && array[i] % 2 != 0)
                {
                    sum++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество нечетных положительных элементов на четных местах равно {0}", sum);
            Console.ReadKey();
        }
    }
}
