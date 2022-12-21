using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Model
{
    public class StudentModel : IModel
    {
        public IList<Student> Students { get; set; } = new List<Student>();

        public event EventHandler<StudentArgs> EventAddStudentModel = delegate { };
        public event EventHandler<StudentArgs> EventDeleteStudentModel = delegate { };
        public void AddStudent(string[] student)
        {
            Student temp = new Student(student[1], student[3], student[2]);
            Students.Add(temp);
            EventAddStudentModel(this, new StudentArgs(student));
        }
        public void DeleteStudent(string[] student)
        {
            Students.Remove(Students.ToList().Find(s => s.Id.ToString() == student[0]));
            EventDeleteStudentModel(this, new StudentArgs(student));
        }
    }
}
