using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19new
{
    internal class AcademicLeave : Student
    {
        public DateTime returnDay { get; set; }
        public override void Expulsion()
        {
            Console.WriteLine($"Студент на академическом отпуске до {returnDay}");
        }
        public static bool operator >(AcademicLeave student1, AcademicLeave student2)
        {
            return student1.DateofEntrance > student2.DateofEntrance;
        }
        public static bool operator <(AcademicLeave student1, AcademicLeave student2)
        {
            return student1.DateofEntrance < student2.DateofEntrance;
        }


    }
}
