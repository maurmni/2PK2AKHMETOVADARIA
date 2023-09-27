namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random random = new Random();
            int p = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 51); // Заполнение массива случайными числами от -50 до 50
                if (array[i] < 0)
                {
                    p++;
                }
            }
            int[] u = new int[array.Length - p];
            int positiveCount = 0; // Копирование положительных элементов в новый массив
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    u[positiveCount] = array[i];
                    positiveCount++;
                }
            }
            
            Console.WriteLine("Положительные числа:");
            for (int i = 0; i < positiveCount; i++)
            {
                Console.WriteLine(u[i]);
            }
            Console.WriteLine("Количество положительных чисел: " + positiveCount); // Вывод положительных чисел

        }   }
}