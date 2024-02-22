using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19new
{
    internal class Graduate : Student
    {
        public override void Expulsion()
        {
            Console.WriteLine("Выпускник");
            Console.WriteLine($"Средний балл: {GPA}");
        }
        public static bool operator >(Graduate student1, Graduate student2)
        {
            return student1.DateofEntrance > student2.DateofEntrance;
        }
        public static bool operator <(Graduate student1, Graduate student2)
        {
            return student1.DateofEntrance < student2.DateofEntrance;
        }
    }
}
