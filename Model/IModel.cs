using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Model
{
    public interface IModel
    {
        event EventHandler<StudentArgs> EventAddStudentModel;
        event EventHandler<StudentArgs> EventDeleteStudentModel;
        void AddStudent(string[] student);
        void DeleteStudent(string[] student);
    }
}
