namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст содержащий адрес электронной почты: ");
            string text = Console.ReadLine();
            int index = text.IndexOf("@"); //определяю индекс @

            if (index != -1)
            {
                text = text.Remove(index); //удаляю все что после @
                string un = text.Substring(0, index).Trim(); //удаляю пробелы до и после строки и создаю подстроку от 1 символа до @
                int space = un.LastIndexOf(' '); // определяю индекс последнего пробела 
                text = text.Remove(0, space); //удаляю все c первого символа до последнего пробела
                Console.WriteLine($"Здравствуй, {text}!");
            }
            else
            {
                Console.WriteLine("Данные введены некорректно");
            }

        }
    }
}