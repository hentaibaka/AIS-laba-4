using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class AddSudentForm : Form
    {
        public AddSudentForm()
        {
            InitializeComponent();

            specBox.Items.Add("ИСИТ");
            specBox.Items.Add("ПИ");
            specBox.Items.Add("КБ");
            specBox.Items.Add("ИБ");
        }

    }
}
