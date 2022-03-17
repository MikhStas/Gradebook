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
    public partial class LessonAttendaceForm : Form
    {
        public LessonAttendaceForm()
        {
            InitializeComponent();
        }

        private void LessonAttendaceForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.gradebookDataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Lesson". При необходимости она может быть перемещена или удалена.
            this.lessonTableAdapter.Fill(this.gradebookDataSet.Lesson);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.LessonAttedance". При необходимости она может быть перемещена или удалена.
            this.lessonAttedanceTableAdapter.Fill(this.gradebookDataSet.LessonAttedance);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lessonAttedanceTableAdapter.Update(this.gradebookDataSet.LessonAttedance);
            this.lessonAttedanceTableAdapter.Fill(this.gradebookDataSet.LessonAttedance);
        }
    }
}
