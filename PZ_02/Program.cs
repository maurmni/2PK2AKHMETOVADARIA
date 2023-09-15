using System.ComponentModel.Design;

namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, f, t;
            Console.Write("введите число n: ");
           int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите число x: ");
            x = Convert.ToDouble(Console.ReadLine());
            if (x < 0)
            {
                y = 18 * n / Math.Cos(x);
            }
            else { y = 4 * Math.Pow(x, 2) + 8 * n; }
            if (y > 5)
            {
                f = 30;
            }
            else { f = n * Math.Sqrt(3 * x - 5 * y); }
            t = 100 * x + 20 * n * x * y;
            Console.WriteLine(t);
        } 
    }
}