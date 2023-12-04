using System.ComponentModel;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace PZ_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = -8;
            int d = -1;
            int n = 5;
            int result = Cat(n, a, d);  //вызов функции

            double q = 3;
            double b = -0.5;
            int n1 = 6;
            double result1 = Count(n1, q, b);  //вызов функции

            int b1 = 60;
            int q1 = 0;
            int n2 = 62;
            int result2 = Lol(n2, b1, q1);
        }
        static int Cat(int n, int a, int d)  //создание метода
        {

            if (n == 1)
            {
                int res = a + d * (n - 1);  //вычисление арифмктической прогрессии
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t первое задание: ");
                Console.WriteLine($"результат вычислений: {res}");
                return res;
            }
            else
            {
                int t = Cat(n - 1, a, d);  //вызов функции
                t += d;
                Console.WriteLine($"результат вычислений: {t}");
                return t;
            }
        }
        static double Count(int n1, double q, double b)  //создание метода
        {
            if (n1 == 1)
            {
                double res = q + (n1 - 1) * b;  //вычисление геометрической прогрессии
                Console.WriteLine("\n\t второе задание: ");
                Console.WriteLine($"результат вычислений: {res}");
                return res;
            }
            else
            {
                double t = Count(n1 - 1, q, b);  //вызов функции
                t += b;
                Console.WriteLine($"результат вычислений: {t}");
                return t;
            }
        }
        static int Lol(int n2, int b1, int q1)
        {
            {
                if (n2 == 1)
                {
                    q1 = 0;
                    Console.WriteLine("\n\t третье задание: ");
                    return q1;
                }
                else
                {
                    int res3 = Lol(n2 - 1, b1, q1 + 1);
                    res3 = q1;
                    Console.WriteLine($"результат: {res3}");
                    return res3;

                }
            }
        }
    }
}