namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а: ");
            double a = double.Parse(Console.ReadLine());  /*ввод переменной и создание а*/
            Console.WriteLine("Введите число b: ");  
            double b = double.Parse(Console.ReadLine());  /*ввод переменной и создание b*/
            Console.WriteLine("Введите число c: ");
            double c = double.Parse(Console.ReadLine());  /*ввод переменной и создвние c*/
            double result;
            double d; /*создание переменной d (первое слогаемое)*/
            double e; /*создание пременной e (второе слогаемое)*/
            e = Math.Sqrt(Math.Sin(Math.Atan(c)));
            d = Math.Log((Math.Pow(b, Math.Abs(1 / b)))) * (a - (b / 2));
            result = e + d; /*вычисление результата*/
            Console.WriteLine("Результат: " + result); /*показ результата*/
        }
    }
}