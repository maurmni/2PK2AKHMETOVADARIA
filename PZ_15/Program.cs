namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полный путь к каталогу: "); string link = Console.ReadLine();
            try
            {
                DirectoryInfo directory = new DirectoryInfo(link);
                if (directory.Exists)
                {
                    FileInfo[] files = directory.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        if (file.Length >= 10485761) // 10 Мб = 10485760 байт

                          Console.WriteLine($"Файл размером больше 10 Мб: {file.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("Путь указан неправильно");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
