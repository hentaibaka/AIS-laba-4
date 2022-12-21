using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Shared;

namespace Presenter
{
    public class StudentPresenter
    {
        private IView view;
        private IModel model;

        public StudentPresenter(IView view, IModel model)
        {
            this.view = view;
            this.model = model;

            view.EventAddStudentView += AddStudentView;
            model.EventAddStudentModel += AddStudentModel;

            view.EventDeleteStudentView += DeleteStudentView;
            model.EventDeleteStudentModel += DeleteStudentModel;

        }
        public void AddStudentView(object sender, StudentArgs e)
        {
            model.AddStudent(e.Student);
        }
        public void AddStudentModel(Object sender, StudentArgs e)
        {
            view.AddStudent(e.Student);
        }
        public void DeleteStudentView(object sender, StudentArgs e)
        {
            model.DeleteStudent(e.Student);
        }
        public void DeleteStudentModel(Object sender, StudentArgs e)
        {
            view.DeleteStudent(e.Student);
        }
    }
}
