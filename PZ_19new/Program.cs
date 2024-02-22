namespace PZ_19new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Graduate { Name = "Мариева Мария Михаиловна", DateofEntrance = new DateTime(2014, 09, 01), GPA = 4.7 };
            var student2 = new Graduate { Name = "Павлов Павел Павлович", DateofEntrance = new DateTime(2004, 09, 01), GPA = 3.4 };
            Console.WriteLine($"Студент 1 {student1.Name} поступил позже, чем студент студент 2 {student2.Name}\n" +
                $"Средний балл студента 1 - {student1.GPA}, средний балл студента 2 - {student2.GPA}\n" +
                $"Дата постyпления студента 1 - {student1.DateofEntrance}, дата пoступления студента 2 - {student2.DateofEntrance}");

            var student11 = new Expelled { Name = "Анастасиева Анастасия Андреевна", DateofEntrance = new DateTime(2015, 09, 01), GPA = 1.7 };
            var student22 = new Expelled { Name = "Васильев Василий Васильевич", DateofEntrance = new DateTime(2013, 09, 01), GPA = 2.4 };
            Console.WriteLine($"Студент 3 {student11.Name} поступил позже, чем студент студент 4 {student22.Name}\n" +
                $"Средний балл студента 3 - {student11.GPA}, средний балл студента 4 - {student22.GPA}\n" +
                $"Дата постyпления студента 3 - {student11.DateofEntrance}, дата пoступления студента 4 - {student22.DateofEntrance}\n" +
                $"Студент 3 отчислен\n" +
                $"Студент 4 отчислен");


            var student111 = new AcademicLeave { Name = "Андреев Андрей Андреевич", DateofEntrance = new DateTime(2023, 09, 01), returnDay = new DateTime(2025, 09, 01) };
            var student222 = new AcademicLeave { Name = "Еленова Елена Евгеньевна", DateofEntrance = new DateTime(2022, 09, 01), returnDay = new DateTime(2024, 09, 01) };
            Console.WriteLine($"Студент 5 {student111.Name} поступил позже, чем студент студент 6 {student222.Name}\n" +
                $"Дата постyпления студента 5 - {student111.DateofEntrance}, дата пoступления студента 6 - {student222.DateofEntrance}\n" +
                $"Дата конца академического отпуска студента 5 - {student111.returnDay}, дата конца академического отпуска студента 6 - {student222.returnDay}");
        }
    }
}