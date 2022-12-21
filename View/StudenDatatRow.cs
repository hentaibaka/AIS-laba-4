using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class StudentDataRow
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Speciality { get; set; }
        public StudentDataRow(string id, string name, string group, string speciality)
        {
            Id = id;
            Name = name;
            Group = group;
            Speciality = speciality;
        }
    }
}
