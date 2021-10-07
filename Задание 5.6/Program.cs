using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._6
{   //Магический квадрат
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            byte n = Convert.ToByte(Console.ReadLine());
            int[,] array = new int[n, n];
            int[] sumi = new int[n];
            int[] sumj = new int[n];
            int sumDiagonal_i = 0;
            int sumDiagonal_j = 0;
            bool chet = false;
            Console.WriteLine();
            Console.WriteLine("Введите элементы массива: ");
            for (byte i = 0; i < n; i++)
            {
                for (byte j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Сумма по строкам
            for (byte i = 0; i < n; i++)
            {
                for (byte j = 0; j < n; j++)
                {
                    sumi[i] += array[i, j];
                }
                if (i > 1 && sumi[i] != sumi[i - 1])
                {
                    Console.WriteLine("Матрица не является магическим квадратом.");
                    chet = true;
                    break;
                }
            }

            //Сумма по столбцам
            if (chet != true)
            {
                for (byte j = 0; j < n; j++)
                {
                    for (byte i = 0; i < n; i++)
                    {
                        sumj[j] += array[i, j];
                    }
                    if (j > 1 && sumj[j] != sumj[j - 1])
                    {
                        Console.WriteLine("Матрица не является магическим квадратом.");
                        chet = true;
                        break;
                    }
                }
            }

            //Сумма по диагонали
            if (chet != true)
            {
                for (int i = 0; i < n; i++)
                {
                    sumDiagonal_i += array[i, i];
                }
            }

            //Сумма по диагонали
            if (chet != true)
            {
                for (int j = 0; j < n; j++)
                {
                    sumDiagonal_j += array[(n - 1 - j), j];
                }
            }

            if (chet != true)
            {
                if (sumDiagonal_j == sumj[0] && sumDiagonal_i == sumi[0] && sumi[0] == sumj[0])
                {
                    Console.WriteLine("Матрица является магическим квадратом.");
                }
                else
                {
                    Console.WriteLine("Матрица не является магическим квадратом.");
                }
            }
            Console.ReadKey();
        }
    }
}
