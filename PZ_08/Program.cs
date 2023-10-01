using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ступенчатый массив: ");
            double[][] willow = new double[7][];
            Random rnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                int u = rnd.Next(5, 36); //генерация случайного количества столбцов от 5 до 35
                willow[i] = new double[u];

                for (int j = 0; j < u; j++)
                {
                    willow[i][j] = rnd.NextDouble() * 100; // генерация случайного вещественного числа от 0 до 100
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < willow[i].Length; j++)
                {
                    Console.Write(willow[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nПоследний элемент каждой строки ступенчатого массива: ");
            double[] rle = new double[willow.Length];
            for (int i = 0; i < willow.Length; i++)
            {
                rle[i] = willow[i][willow[i].Length - 1]; //вычисление последнего элемента строки 
                Console.Write(rle[i] + " ");
            }
            for (int i = 0; i < willow.Length; i++)
            {
                Console.Write($"{rle[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("\nМаксимальные элементы каждой строки ступенчатого массива: ");
            double[] mes = new double[7];
            for (int i = 0; i < 7; i++)
            {
                double me = willow[i][0];
                for (int j = 1; j < 7; j++)
                {
                    if (willow[i][j] > me) //определение наибольшнго числа
                    {
                        me = willow[i][j];
                    }
                }
                mes[i] = me;
            }
            foreach (double el in mes)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nЗамена местами первого и максимального элемента: ");
            for (int i = 0; i < 7; i++)
            {
                int maxIn = 0;
                double maxVal = willow[i][0];

                for (int j = 1; j < 7; j++)
                {
                    if (willow[i][j] > maxVal) //определение макс. числа
                    {
                        maxVal = willow[i][j];
                        maxIn = j;
                    }
                }
                double t = willow[i][0];
                willow[i][0] = maxVal;
                willow[i][maxIn] = t;
            }
            for (int i = 0; i < 7; i++)
            {
                Console.Write("\nНовая строка {0}: {1} ", i, string.Join(" ", willow[i]));
            }
            Console.WriteLine();

            Console.WriteLine("\nРеверс каждой строки ступенчатого массива: ");
            for (int i = 0; i < 7; i++)
            {
                Array.Reverse(willow[i]); //реверс
                Console.Write("\nСтрока {0}: ", i);
                for (int j = 0; j < willow[i].Length; j++)
                {
                    Console.Write(willow[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nCреднее значение в каждой строке: ");
            double[] averageValues = new double[7];
            for (int i = 0; i < 7; i++)
            {
                double sum = 0;
                int numb = 7;

                for (int j = 0; j < numb; j++)
                {
                    sum += willow[i][j];
                }
                averageValues[i] = sum / numb; //вычисление среднего значения
                Console.WriteLine("Среднее значение в строке {0}: {1}", i + 1, averageValues[i]);
            }
        }
    }
}