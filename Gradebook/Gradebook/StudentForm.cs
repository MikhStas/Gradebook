using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gradebook
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.gradebookDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.gradebookDataSet.Student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.Update(this.gradebookDataSet.Student);
            this.studentTableAdapter.Fill(this.gradebookDataSet.Student);
        }
    }
}
