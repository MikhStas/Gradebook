namespace Gradebook
{
    partial class ExamReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gradebookDataSet = new Gradebook.GradebookDataSet();
            this.getexamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_examsTableAdapter = new Gradebook.GradebookDataSetTableAdapters.Get_examsTableAdapter();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аудиторияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.преподавательDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кафедраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонКафедрыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонПреподавателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getexamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.группаDataGridViewTextBoxColumn,
            this.предметDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.аудиторияDataGridViewTextBoxColumn,
            this.преподавательDataGridViewTextBoxColumn,
            this.кафедраDataGridViewTextBoxColumn,
            this.телефонКафедрыDataGridViewTextBoxColumn,
            this.телефонПреподавателяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getexamsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(894, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // gradebookDataSet
            // 
            this.gradebookDataSet.DataSetName = "GradebookDataSet";
            this.gradebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getexamsBindingSource
            // 
            this.getexamsBindingSource.DataMember = "Get_exams";
            this.getexamsBindingSource.DataSource = this.gradebookDataSet;
            // 
            // get_examsTableAdapter
            // 
            this.get_examsTableAdapter.ClearBeforeFill = true;
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            this.группаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // предметDataGridViewTextBoxColumn
            // 
            this.предметDataGridViewTextBoxColumn.DataPropertyName = "Предмет";
            this.предметDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.предметDataGridViewTextBoxColumn.Name = "предметDataGridViewTextBoxColumn";
            this.предметDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // аудиторияDataGridViewTextBoxColumn
            // 
            this.аудиторияDataGridViewTextBoxColumn.DataPropertyName = "Аудитория";
            this.аудиторияDataGridViewTextBoxColumn.HeaderText = "Аудитория";
            this.аудиторияDataGridViewTextBoxColumn.Name = "аудиторияDataGridViewTextBoxColumn";
            this.аудиторияDataGridViewTextBoxColumn.ReadOnly = true;
            this.аудиторияDataGridViewTextBoxColumn.Width = 50;
            // 
            // преподавательDataGridViewTextBoxColumn
            // 
            this.преподавательDataGridViewTextBoxColumn.DataPropertyName = "Преподаватель";
            this.преподавательDataGridViewTextBoxColumn.HeaderText = "Преподаватель";
            this.преподавательDataGridViewTextBoxColumn.Name = "преподавательDataGridViewTextBoxColumn";
            this.преподавательDataGridViewTextBoxColumn.ReadOnly = true;
            this.преподавательDataGridViewTextBoxColumn.Width = 150;
            // 
            // кафедраDataGridViewTextBoxColumn
            // 
            this.кафедраDataGridViewTextBoxColumn.DataPropertyName = "Кафедра";
            this.кафедраDataGridViewTextBoxColumn.HeaderText = "Кафедра";
            this.кафедраDataGridViewTextBoxColumn.Name = "кафедраDataGridViewTextBoxColumn";
            this.кафедраDataGridViewTextBoxColumn.ReadOnly = true;
            this.кафедраDataGridViewTextBoxColumn.Width = 150;
            // 
            // телефонКафедрыDataGridViewTextBoxColumn
            // 
            this.телефонКафедрыDataGridViewTextBoxColumn.DataPropertyName = "Телефон кафедры";
            this.телефонКафедрыDataGridViewTextBoxColumn.HeaderText = "Телефон кафедры";
            this.телефонКафедрыDataGridViewTextBoxColumn.Name = "телефонКафедрыDataGridViewTextBoxColumn";
            this.телефонКафедрыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонПреподавателяDataGridViewTextBoxColumn
            // 
            this.телефонПреподавателяDataGridViewTextBoxColumn.DataPropertyName = "Телефон преподавателя";
            this.телефонПреподавателяDataGridViewTextBoxColumn.HeaderText = "Телефон преподавателя";
            this.телефонПреподавателяDataGridViewTextBoxColumn.Name = "телефонПреподавателяDataGridViewTextBoxColumn";
            this.телефонПреподавателяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ExamReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 326);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ExamReportForm";
            this.Text = "Экзамены. Отчет.";
            this.Load += new System.EventHandler(this.ExamReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getexamsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GradebookDataSet gradebookDataSet;
        private System.Windows.Forms.BindingSource getexamsBindingSource;
        private GradebookDataSetTableAdapters.Get_examsTableAdapter get_examsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предметDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аудиторияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn преподавательDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кафедраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонКафедрыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонПреподавателяDataGridViewTextBoxColumn;
    }
}