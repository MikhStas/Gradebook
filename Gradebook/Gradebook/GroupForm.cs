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
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            InitializeComponent();
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gradebookDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.gradebookDataSet.Group);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.groupTableAdapter.Update(this.gradebookDataSet.Group);
            this.groupTableAdapter.Fill(this.gradebookDataSet.Group);
        }
    }
}
