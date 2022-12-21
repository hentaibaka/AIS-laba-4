using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;
using Model;
using Presenter;
using ZedGraph;

namespace View
{
    public partial class Form1 : Form, IView
    {
        public event EventHandler<StudentArgs> EventAddStudentView = delegate { };
        public event EventHandler<StudentArgs> EventDeleteStudentView = delegate { };

        private IModel model = null;
        private StudentPresenter presenter;

        private BindingList<StudentDataRow> StudentsView = new BindingList<StudentDataRow>();
        private int StudentId = 0;
        public Form1()
        {
            InitializeComponent();

            model = new StudentModel();
            presenter = new StudentPresenter(this, model);

            grid.DataSource = StudentsView;
        }
        public void AddStudent(string[] student)
        {
            StudentsView.Add(new StudentDataRow(student[0],
                                                student[1],
                                                student[2],
                                                student[3]));
        }
        public void DeleteStudent(string[] student)
        {
            StudentsView.Remove(StudentsView.ToList().Find(s => s.Id == student[0]));
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddSudentForm form = new AddSudentForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                string[] student = new string[4];
                student[0] = StudentId++.ToString();
                student[1] = form.nameBox.Text;
                student[2] = form.groupBox.Text;
                student[3] = form.specBox.SelectedItem.ToString();

                EventAddStudentView(this, new StudentArgs(student));
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selected = grid.SelectedRows;

            foreach (DataGridViewRow row in selected)
            {
                StudentDataRow temp = StudentsView.ToList().
                    Find(s => s.Id == (string)row.Cells["Id"].Value);

                string[] student = new string[4];
                student[0] = (string)row.Cells["Id"].Value;
                student[1] = (string)row.Cells["Name"].Value;
                student[2] = (string)row.Cells["Group"].Value;
                student[3] = (string)row.Cells["Speciality"].Value;

                EventDeleteStudentView(this, new StudentArgs(student));
            }
        }
        private void plotButton_Click(object sender, EventArgs e)
        {
            GraphPane pane = zedGraph.GraphPane;

            pane.CurveList.Clear();

            List<string> names = new List<string>();

            foreach (StudentDataRow student in StudentsView) 
                if (!names.Contains(student.Speciality)) names.Add(student.Speciality);
            double[] values = new double[names.Count];
            foreach (StudentDataRow student in StudentsView)
            {
                values[names.IndexOf(student.Speciality)]++;
            }

            BarItem curve = pane.AddBar("Студенты", null, values, Color.Blue);

            pane.XAxis.Type = AxisType.Text;
            pane.XAxis.Scale.TextLabels = names.ToArray();

            pane.YAxis.Scale.MajorStep = 1;
            pane.YAxis.Scale.MinorStep = 1;

            zedGraph.AxisChange();

            zedGraph.Invalidate();
        }
    }
}
