using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._3
{   //Упорядочить по возрастанию, убыванию
    class Program
    {
        static void Main(string[] args)
        {
            const byte n = 10;
            Random random = new Random();
            sbyte[] array = new sbyte[n];
            sbyte t;

            for (byte i = 0; i < n; i++)
            {
                array[i] = (sbyte)random.Next(-50, 50);
                Console.Write("{0,4} ", array[i]);
            }
            for (byte i = 0; i < n / 2; i++)
            {
                for (byte j = (byte)(i + 1); j < n / 2; j++)
                {
                    if (array[i] > array[j])
                    {
                        t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            for (byte i = n / 2; i < n; i++)
            {
                for (byte j = (byte)(i + 1); j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            for (byte i = 0; i < n; i++)
            {
                Console.Write("{0,4} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
