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
    public partial class ExamResultForm : Form
    {
        public ExamResultForm()
        {
            InitializeComponent();
        }

        private void ExamResultForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.gradebookDataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Exam". При необходимости она может быть перемещена или удалена.
            this.examTableAdapter.Fill(this.gradebookDataSet.Exam);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.ExamAttendance". При необходимости она может быть перемещена или удалена.
            this.examAttendanceTableAdapter.Fill(this.gradebookDataSet.ExamAttendance);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.examAttendanceTableAdapter.Update(this.gradebookDataSet.ExamAttendance);
            this.examAttendanceTableAdapter.Fill(this.gradebookDataSet.ExamAttendance);
        }
    }
}
