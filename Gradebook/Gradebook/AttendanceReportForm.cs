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
    public partial class AttendanceReportForm : Form
    {
        public AttendanceReportForm()
        {
            InitializeComponent();
        }

        private void AttendanceReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Get_lesson_attendance". При необходимости она может быть перемещена или удалена.
            this.get_lesson_attendanceTableAdapter.Fill(this.gradebookDataSet.Get_lesson_attendance);

        }
    }
}
