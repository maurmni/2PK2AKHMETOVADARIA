using System;

namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine()); //создание переменной rows которая означает количество строк в массиве
            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine()); //создание переменной columns которая означает количество столбцов в массиве
            int[,] r = new int[rows, columns]; //создание двумерного массива r параметры которого будут равны тому значению которое пользователь ввел до этого
            for (int i = 0; i < rows; i++) //цикл for для итерации по строкам 
            {
                for (int j = 0; j < columns; j++) //цикл for для итерации по столбцам
                {
                    Console.Write("Введите элемент [{0},{1}]: ", i, j); //просьба пользователя ввести элемент который далее будет помещен в определенную ячейку в массиве
                    r[i, j] = Convert.ToInt32(Console.ReadLine()); //ввод значений в массив
                }
            }
            Console.WriteLine("Элементы массива:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0} ", r[i, j]);
                }
                Console.WriteLine();
            }
            int maxAbsoluteValue = 0; //опрделение числа с максимальным модулем
            int maxRowIndex = 0; //хранение индекса строки в котором находится число с макс. модулем
            int maxColumnIndex = 0; //хранение индекса столбца в котором находится число с макс. модулем

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (Math.Abs(r[i, j]) > Math.Abs(maxAbsoluteValue)) // сравнение модуля числа r[i,j] c модулем числа maxAbsoluteValue
                    {
                        maxAbsoluteValue = r[i, j];
                        maxRowIndex = i;
                        maxColumnIndex = j;
                    }
                }
            }
            Console.WriteLine("Наибольший элемент по модулю: {0}", maxAbsoluteValue);
            Console.WriteLine("Индексы этого элемента: [{0},{1}]", maxRowIndex, maxColumnIndex);

            Console.ReadLine();
        }
    }
}