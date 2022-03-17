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
    public partial class LessonForm : Form
    {
        public LessonForm()
        {
            InitializeComponent();
        }

        private void LessonForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.gradebookDataSet.Subject);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.gradebookDataSet.Teacher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.gradebookDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Lesson". При необходимости она может быть перемещена или удалена.
            this.lessonTableAdapter.Fill(this.gradebookDataSet.Lesson);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lessonTableAdapter.Update(this.gradebookDataSet.Lesson);
            this.lessonTableAdapter.Fill(this.gradebookDataSet.Lesson);
        }
    }
}
