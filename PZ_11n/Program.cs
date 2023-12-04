namespace PZ_11n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите простое число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int summ;
            int plus = GetLimitSumm(n, out summ);
            Console.WriteLine($"Сумма простых чисел до {n}: {plus}");
        }
        static bool IsSimple(int x) //метод для определения простое число или нет
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return x > 1;
        }
        static int GetLimitSumm(int n, out int summ)  //метод для вычисления суммы простых чисел
        {
            summ = 0;
            for (int i = 2; i <= n; i++)
            {
                if (IsSimple(i))
                {
                    summ += i;
                }
            }
            return (summ);
        }
    }
}