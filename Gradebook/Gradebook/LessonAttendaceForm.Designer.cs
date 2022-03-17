namespace Gradebook
{
    partial class LessonAttendaceForm
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
            this.lessonAttedanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonAttedanceTableAdapter = new Gradebook.GradebookDataSetTableAdapters.LessonAttedanceTableAdapter();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonTableAdapter = new Gradebook.GradebookDataSetTableAdapters.LessonTableAdapter();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Gradebook.GradebookDataSetTableAdapters.StudentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lessonidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonAttedanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lessonidDataGridViewTextBoxColumn,
            this.studidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonAttedanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // gradebookDataSet
            // 
            this.gradebookDataSet.DataSetName = "GradebookDataSet";
            this.gradebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonAttedanceBindingSource
            // 
            this.lessonAttedanceBindingSource.DataMember = "LessonAttedance";
            this.lessonAttedanceBindingSource.DataSource = this.gradebookDataSet;
            // 
            // lessonAttedanceTableAdapter
            // 
            this.lessonAttedanceTableAdapter.ClearBeforeFill = true;
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataMember = "Lesson";
            this.lessonBindingSource.DataSource = this.gradebookDataSet;
            // 
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.gradebookDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Применить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lessonidDataGridViewTextBoxColumn
            // 
            this.lessonidDataGridViewTextBoxColumn.DataPropertyName = "lesson_id";
            this.lessonidDataGridViewTextBoxColumn.DataSource = this.lessonBindingSource;
            this.lessonidDataGridViewTextBoxColumn.DisplayMember = "lesson_date";
            this.lessonidDataGridViewTextBoxColumn.HeaderText = "Урок";
            this.lessonidDataGridViewTextBoxColumn.Name = "lessonidDataGridViewTextBoxColumn";
            this.lessonidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lessonidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lessonidDataGridViewTextBoxColumn.ValueMember = "lesson_id";
            this.lessonidDataGridViewTextBoxColumn.Width = 150;
            // 
            // studidDataGridViewTextBoxColumn
            // 
            this.studidDataGridViewTextBoxColumn.DataPropertyName = "stud_id";
            this.studidDataGridViewTextBoxColumn.DataSource = this.studentBindingSource;
            this.studidDataGridViewTextBoxColumn.DisplayMember = "stud_surname";
            this.studidDataGridViewTextBoxColumn.HeaderText = "Студент";
            this.studidDataGridViewTextBoxColumn.Name = "studidDataGridViewTextBoxColumn";
            this.studidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.studidDataGridViewTextBoxColumn.ValueMember = "stud_id";
            this.studidDataGridViewTextBoxColumn.Width = 150;
            // 
            // LessonAttendaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LessonAttendaceForm";
            this.Text = "Учет посещаемости";
            this.Load += new System.EventHandler(this.LessonAttendaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonAttedanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GradebookDataSet gradebookDataSet;
        private System.Windows.Forms.BindingSource lessonAttedanceBindingSource;
        private GradebookDataSetTableAdapters.LessonAttedanceTableAdapter lessonAttedanceTableAdapter;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private GradebookDataSetTableAdapters.LessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private GradebookDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewComboBoxColumn lessonidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn studidDataGridViewTextBoxColumn;
    }
}