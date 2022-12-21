using Model;
using Presenter;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_laba_4
{
    public partial class Form1 : Form, IView
    {
        public event EventHandler<StudentArgs> EventAddStudentView = delegate { };

        private IModel model;
        private StudentPresenter presenter;
        public Form1()
        {
            InitializeComponent();

            model = new StudentModel();
            presenter = new StudentPresenter(this, model);
        }
        public void AddStudent(Student student)
        {

        }
        private void AddButton_Click(object sender, EventArgs e)
        {

        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
        private void GlistButton_Click(object sender, EventArgs e)
        {

        }
    }
}
