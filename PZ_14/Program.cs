using System;

namespace PZ_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*В файле input.txt записаны числа (каждое — с новой строки), их количество не превышает 
100. Необходимо отсортировать их по возрастанию и записать в файл output.txt*/

            Console.WriteLine("Cоздание файла input и output");
            File.Create("C:\\input.txt");
            string input = "C:\\input.txt";
            string output = "C:\\output.txt";
            using (StreamWriter writer = new StreamWriter(input))
            {
                Random rnd = new Random();
                for (int random = 0; random < 100; random++)
                {
                    writer.WriteLine(rnd.Next());
                }
            }
            Console.WriteLine("Запись случайный чисел в файл input.txt завершена");
            using (StreamReader reader = new StreamReader(input))
            {
                string line;
                int[] numbers = new int[100];
                int index = 0;
                Array.Sort(numbers);

                using (StreamWriter outputWriter = new StreamWriter(output))
                {
                    foreach (int num in numbers)
                    {
                        outputWriter.WriteLine(num);
                    }
                    Console.WriteLine("Сортировка и запись чисел в файл output.txt завершенa");
                }
            }
        }
    }
}