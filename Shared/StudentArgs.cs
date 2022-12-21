using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class StudentArgs : EventArgs
    {
        public string[] Student { get; set; }
        public StudentArgs(string[] student)
        {
            Student = student;
        }
    }
}
