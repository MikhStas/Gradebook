namespace Gradebook
{
    partial class AttendanceReportForm
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
            this.getlessonattendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_lesson_attendanceTableAdapter = new Gradebook.GradebookDataSetTableAdapters.Get_lesson_attendanceTableAdapter();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предметDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.студентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.преподавательDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кафедраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getlessonattendanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаDataGridViewTextBoxColumn,
            this.группаDataGridViewTextBoxColumn,
            this.предметDataGridViewTextBoxColumn,
            this.студентDataGridViewTextBoxColumn,
            this.преподавательDataGridViewTextBoxColumn,
            this.кафедраDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getlessonattendanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(944, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // gradebookDataSet
            // 
            this.gradebookDataSet.DataSetName = "GradebookDataSet";
            this.gradebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getlessonattendanceBindingSource
            // 
            this.getlessonattendanceBindingSource.DataMember = "Get_lesson_attendance";
            this.getlessonattendanceBindingSource.DataSource = this.gradebookDataSet;
            // 
            // get_lesson_attendanceTableAdapter
            // 
            this.get_lesson_attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // студентDataGridViewTextBoxColumn
            // 
            this.студентDataGridViewTextBoxColumn.DataPropertyName = "Студент";
            this.студентDataGridViewTextBoxColumn.HeaderText = "Студент";
            this.студентDataGridViewTextBoxColumn.Name = "студентDataGridViewTextBoxColumn";
            this.студентDataGridViewTextBoxColumn.ReadOnly = true;
            this.студентDataGridViewTextBoxColumn.Width = 200;
            // 
            // преподавательDataGridViewTextBoxColumn
            // 
            this.преподавательDataGridViewTextBoxColumn.DataPropertyName = "Преподаватель";
            this.преподавательDataGridViewTextBoxColumn.HeaderText = "Преподаватель";
            this.преподавательDataGridViewTextBoxColumn.Name = "преподавательDataGridViewTextBoxColumn";
            this.преподавательDataGridViewTextBoxColumn.ReadOnly = true;
            this.преподавательDataGridViewTextBoxColumn.Width = 200;
            // 
            // кафедраDataGridViewTextBoxColumn
            // 
            this.кафедраDataGridViewTextBoxColumn.DataPropertyName = "Кафедра";
            this.кафедраDataGridViewTextBoxColumn.HeaderText = "Кафедра";
            this.кафедраDataGridViewTextBoxColumn.Name = "кафедраDataGridViewTextBoxColumn";
            this.кафедраDataGridViewTextBoxColumn.ReadOnly = true;
            this.кафедраDataGridViewTextBoxColumn.Width = 200;
            // 
            // AttendanceReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 326);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AttendanceReportForm";
            this.Text = "Отчет о посещаемости";
            this.Load += new System.EventHandler(this.AttendanceReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getlessonattendanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GradebookDataSet gradebookDataSet;
        private System.Windows.Forms.BindingSource getlessonattendanceBindingSource;
        private GradebookDataSetTableAdapters.Get_lesson_attendanceTableAdapter get_lesson_attendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предметDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn студентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn преподавательDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кафедраDataGridViewTextBoxColumn;
    }
}