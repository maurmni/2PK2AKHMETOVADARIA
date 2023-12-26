using System;

namespace PZ_12new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку: ");
            string str = Console.ReadLine();
            string strReverse = Rever(str);
            Console.WriteLine($"Перевернутая строка: {strReverse}");
        }

        static string Rever(string str)
        {
            char[] ch = str.ToCharArray();
            for (int i = 0; i < str.Length / 2; i++)
            {
                char temp = ch[i];
                ch[i] = ch[str.Length - i - 1];
                ch[str.Length - i - 1] = temp;
            }
            return new string(ch);
        }
    }
}
