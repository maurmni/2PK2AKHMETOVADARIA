﻿namespace PZ_05
{
    using System;

    namespace PZ_05
    {
        class Program
        {
            static void Main(string[] args)
            {
                int i; //объявление переменной i
                int n; //объявление переменной n
                Console.WriteLine("Введите натуральное число больше 2: "); // на экран пользователя выводится просьба ввести число
                n = Convert.ToInt32(Console.ReadLine()); // ввод чисда и преобразование его в int 

                for (i = 2; i * i <= n; i++) //запускается цикл for
                {
                    if (n % i == 0) //проверка делится ли число n на i, если при делении n на i результат равен 0, то  числo i является делителем
                    {
                        Console.WriteLine("Наименьший натуральный делитель: " + i); //вывод результатов 
                        break; // завершение программы
                    }
                }

                while (i * i > n)  // цикл для вывода числа n
                {
                    Console.WriteLine("Наименьший натуральный делитель: " + n); // вывод результата
                    break; //завершение программы
                }
            }
        }
    }

}
