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
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.gradebookDataSet.Subject);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.subjectTableAdapter.Update(this.gradebookDataSet.Subject);
            this.subjectTableAdapter.Fill(this.gradebookDataSet.Subject);
        }
    }
}
