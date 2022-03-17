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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form dep = new DepartmentForm();
            dep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form group = new GroupForm();
            group.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form subject = new SubjectForm();
            subject.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form teacher = new TeacherForm();
            teacher.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form student = new StudentForm();
            student.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form lesson = new LessonForm();
            lesson.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form lessonAttendance = new LessonAttendaceForm();
            lessonAttendance.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form exam = new ExamForm();
            exam.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form examAttendance = new ExamResultForm();
            examAttendance.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form lessonsReport = new LessonsReportForm();
            lessonsReport.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form attendanceReport = new AttendanceReportForm();
            attendanceReport.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form examReport = new ExamReportForm();
            examReport.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form examResultsReport = new ExamResultsReportForm();
            examResultsReport.Show();
        }
    }
}
