namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random random = new Random();
            int p = 0; //создание переменной p (подсчет кол-ва отрицательных чисел)
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 51); // заполнение массива случайными числами от -50 до 50
                if (array[i] < 0)
                {
                    p++;
                }
            }
            int[] u = new int[array.Length - p]; //созданите переменной u (хранение положительных чисел)
            int positiveCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    u[positiveCount] = array[i];
                    positiveCount++;
                }
            }

            Console.WriteLine("Положительные числа:"); //вывод положительных чисел
            for (int i = 0; i < positiveCount; i++)
            {
                Console.WriteLine(u[i]);
            }
            Console.WriteLine("Количество положительных чисел: " + positiveCount); // вывод количества положительных чисел

        }
    }
}
