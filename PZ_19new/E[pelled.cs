using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19new
{
    internal class Expelled : Student
    {
        public override void Expulsion()
        {
            if (GPA < 2.5)
            {
                Console.WriteLine("Студент отчислен");
            }
        }
        public static bool operator >(Expelled student1, Expelled student2)
        {
            return student1.DateofEntrance > student2.DateofEntrance;
        }
        public static bool operator <(Expelled student1, Expelled student2)
        {
            return student1.DateofEntrance < student2.DateofEntrance;
        }
    }
}
