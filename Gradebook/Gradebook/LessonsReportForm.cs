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
    public partial class LessonsReportForm : Form
    {
        public LessonsReportForm()
        {
            InitializeComponent();
        }

        private void LessonsReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Get_lessons". При необходимости она может быть перемещена или удалена.
            this.get_lessonsTableAdapter.Fill(this.gradebookDataSet.Get_lessons);

        }
    }
}
