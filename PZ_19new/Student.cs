using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19new
{
    internal class Student
    {
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime DateofEntrance { get; set; }
        public string Profession { get; set; }
        public double GPA { get; set; }
        public DateTime DateofProm { get; set; }

        public Student() { }
        public Student(string name, DateTime birth, DateTime entrance, string profession, double gpa, DateTime prom)
        {
            Name = name;
            DateofBirth = birth;
            DateofEntrance = entrance;
            Profession = profession;
            GPA = gpa;
            DateofProm = prom;
        }
        public virtual void Expulsion()
        {
            Console.WriteLine("Студент отчислен");
        }
    }
}
