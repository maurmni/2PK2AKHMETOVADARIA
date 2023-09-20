using System.Runtime.InteropServices;

namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        /*Вывести на экран построчно числа от 0 ддо 80 из указанного диапазона и с шагом 4*/
        {
            Console.WriteLine("Задание 1");
            int i;
            for (i = 0; i <= 80; i += 4)
            {
                Console.WriteLine(i);
            }
            /*Вывести на экран в одну строку 7 - символов в алфавитном порядке, начиная с символа c*/
            Console.WriteLine("Заданиe 2");
            char d = 'c';
            int u;
            for (u = 0; u < 7; u++)
            {
                Console.WriteLine(d++);
            }
            /*Вывести на экран посимвольно 6 знаков ‘#’ в 5 строках*/
            Console.WriteLine("Задание 3");
            int s, g;
            for (s = 0; s < 6; s++)
            {
                for (g = 0; g < 6; g++)
                {
                    Console.WriteLine("#");
                }
                Console.WriteLine();
            }
            /*Из диапазона значений вывести на экран значения кратные числу 5 через пробел, используя один цикл*/
            Console.WriteLine("Задание 4");
            {
                int q, w = 0;
                for (q = -500; q <= -300; q++)
                {
                    if (q % 5 == 0)
                        Console.Write(q + " "); w++;
                }
                Console.WriteLine("\nКоличество чисел, кратных 5: " + w);
            }
            /*Выводить на экран значение переменных  1 и 40, на каждом шаге итерации одну переменную инкрементировать, а вторую декрементировать до тех пор, пока разница между ними не будет равна(или меньше) 15*/
            Console.WriteLine("Задание 5");
            {
                int a, x;
                for (a = 1, x = 40; x - a > 15; a++, x--)
                    Console.WriteLine($"{a} {x}");
                Console.WriteLine($"Разница между числами: {x - a}");
            }
        }
    }
}