using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public interface IView
    {
        void AddStudent(string[] student);
        void DeleteStudent(string[] student);
        event EventHandler<StudentArgs> EventAddStudentView;
        event EventHandler<StudentArgs> EventDeleteStudentView;
    }
}
