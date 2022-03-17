namespace Gradebook
{
    partial class LessonForm
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
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonTableAdapter = new Gradebook.GradebookDataSetTableAdapters.LessonTableAdapter();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter = new Gradebook.GradebookDataSetTableAdapters.GroupTableAdapter();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new Gradebook.GradebookDataSetTableAdapters.TeacherTableAdapter();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new Gradebook.GradebookDataSetTableAdapters.SubjectTableAdapter();
            this.lessonidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.teacheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.subjectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lessondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lessonidDataGridViewTextBoxColumn,
            this.groupidDataGridViewTextBoxColumn,
            this.teacheridDataGridViewTextBoxColumn,
            this.subjectidDataGridViewTextBoxColumn,
            this.lessondateDataGridViewTextBoxColumn,
            this.lessonroomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // gradebookDataSet
            // 
            this.gradebookDataSet.DataSetName = "GradebookDataSet";
            this.gradebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.gradebookDataSet;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.gradebookDataSet;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.gradebookDataSet;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // lessonidDataGridViewTextBoxColumn
            // 
            this.lessonidDataGridViewTextBoxColumn.DataPropertyName = "lesson_id";
            this.lessonidDataGridViewTextBoxColumn.HeaderText = "ID урока";
            this.lessonidDataGridViewTextBoxColumn.Name = "lessonidDataGridViewTextBoxColumn";
            this.lessonidDataGridViewTextBoxColumn.ReadOnly = true;
            this.lessonidDataGridViewTextBoxColumn.Width = 70;
            // 
            // groupidDataGridViewTextBoxColumn
            // 
            this.groupidDataGridViewTextBoxColumn.DataPropertyName = "group_id";
            this.groupidDataGridViewTextBoxColumn.DataSource = this.groupBindingSource;
            this.groupidDataGridViewTextBoxColumn.DisplayMember = "group_name";
            this.groupidDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupidDataGridViewTextBoxColumn.Name = "groupidDataGridViewTextBoxColumn";
            this.groupidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.groupidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.groupidDataGridViewTextBoxColumn.ValueMember = "group_id";
            // 
            // teacheridDataGridViewTextBoxColumn
            // 
            this.teacheridDataGridViewTextBoxColumn.DataPropertyName = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.DataSource = this.teacherBindingSource;
            this.teacheridDataGridViewTextBoxColumn.DisplayMember = "teacher_ln";
            this.teacheridDataGridViewTextBoxColumn.HeaderText = "Преподаватель";
            this.teacheridDataGridViewTextBoxColumn.Name = "teacheridDataGridViewTextBoxColumn";
            this.teacheridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teacheridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teacheridDataGridViewTextBoxColumn.ValueMember = "teacher_id";
            // 
            // subjectidDataGridViewTextBoxColumn
            // 
            this.subjectidDataGridViewTextBoxColumn.DataPropertyName = "subject_id";
            this.subjectidDataGridViewTextBoxColumn.DataSource = this.subjectBindingSource;
            this.subjectidDataGridViewTextBoxColumn.DisplayMember = "subject_name";
            this.subjectidDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.subjectidDataGridViewTextBoxColumn.Name = "subjectidDataGridViewTextBoxColumn";
            this.subjectidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subjectidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.subjectidDataGridViewTextBoxColumn.ValueMember = "subject_id";
            this.subjectidDataGridViewTextBoxColumn.Width = 150;
            // 
            // lessondateDataGridViewTextBoxColumn
            // 
            this.lessondateDataGridViewTextBoxColumn.DataPropertyName = "lesson_date";
            this.lessondateDataGridViewTextBoxColumn.HeaderText = "Дата/Время";
            this.lessondateDataGridViewTextBoxColumn.Name = "lessondateDataGridViewTextBoxColumn";
            // 
            // lessonroomDataGridViewTextBoxColumn
            // 
            this.lessonroomDataGridViewTextBoxColumn.DataPropertyName = "lesson_room";
            this.lessonroomDataGridViewTextBoxColumn.HeaderText = "Аудитория";
            this.lessonroomDataGridViewTextBoxColumn.Name = "lessonroomDataGridViewTextBoxColumn";
            this.lessonroomDataGridViewTextBoxColumn.Width = 70;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Применить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LessonForm";
            this.Text = "Проводимые уроки";
            this.Load += new System.EventHandler(this.LessonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GradebookDataSet gradebookDataSet;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private GradebookDataSetTableAdapters.LessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private GradebookDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private GradebookDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private GradebookDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn groupidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teacheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn subjectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}