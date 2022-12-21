using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        private static int _Id = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }
        public Student(string name, string speciality, string group)
        {
            Id = _Id++;
            Name = name;
            Speciality = speciality;
            Group = group;
        }
    }
}
