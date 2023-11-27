namespace PZ_09new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            {
                int count = 1; string lastStr = null;      // бесконечный цикл для ввода строк пользователем
                while (true)
                {
                    string userInput = Console.ReadLine(); 
                    
                    if (userInput.StartsWith("_"))        //если строка начинается с _ то выполняется условие 
                    {
                        lastStr = userInput;
                        break;
                    }
                    count++;               // увеличение счетчика при каждом вводе строки                }
                    Console.WriteLine("\n"); for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(lastStr);
                    }
                }
            }
        }
    }
}