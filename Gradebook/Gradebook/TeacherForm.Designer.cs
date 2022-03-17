namespace Gradebook
{
    partial class TeacherForm
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
            this.teacheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradebookDataSet = new Gradebook.GradebookDataSet();
            this.teacherfnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherlnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherpatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new Gradebook.GradebookDataSetTableAdapters.TeacherTableAdapter();
            this.gradebookDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new Gradebook.GradebookDataSetTableAdapters.DepartmentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacheridDataGridViewTextBoxColumn,
            this.depidDataGridViewTextBoxColumn,
            this.teacherfnDataGridViewTextBoxColumn,
            this.teacherlnDataGridViewTextBoxColumn,
            this.teacherpatDataGridViewTextBoxColumn,
            this.teacherphoneDataGridViewTextBoxColumn,
            this.teacherdobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teacherBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // teacheridDataGridViewTextBoxColumn
            // 
            this.teacheridDataGridViewTextBoxColumn.DataPropertyName = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.HeaderText = "ID преподавателя";
            this.teacheridDataGridViewTextBoxColumn.Name = "teacheridDataGridViewTextBoxColumn";
            this.teacheridDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacheridDataGridViewTextBoxColumn.Width = 70;
            // 
            // depidDataGridViewTextBoxColumn
            // 
            this.depidDataGridViewTextBoxColumn.DataPropertyName = "dep_id";
            this.depidDataGridViewTextBoxColumn.DataSource = this.departmentBindingSource;
            this.depidDataGridViewTextBoxColumn.DisplayMember = "dep_name";
            this.depidDataGridViewTextBoxColumn.HeaderText = "Кафедра";
            this.depidDataGridViewTextBoxColumn.Name = "depidDataGridViewTextBoxColumn";
            this.depidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.depidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.depidDataGridViewTextBoxColumn.ValueMember = "dep_id";
            this.depidDataGridViewTextBoxColumn.Width = 300;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.gradebookDataSet;
            // 
            // gradebookDataSet
            // 
            this.gradebookDataSet.DataSetName = "GradebookDataSet";
            this.gradebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherfnDataGridViewTextBoxColumn
            // 
            this.teacherfnDataGridViewTextBoxColumn.DataPropertyName = "teacher_fn";
            this.teacherfnDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.teacherfnDataGridViewTextBoxColumn.Name = "teacherfnDataGridViewTextBoxColumn";
            // 
            // teacherlnDataGridViewTextBoxColumn
            // 
            this.teacherlnDataGridViewTextBoxColumn.DataPropertyName = "teacher_ln";
            this.teacherlnDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.teacherlnDataGridViewTextBoxColumn.Name = "teacherlnDataGridViewTextBoxColumn";
            // 
            // teacherpatDataGridViewTextBoxColumn
            // 
            this.teacherpatDataGridViewTextBoxColumn.DataPropertyName = "teacher_pat";
            this.teacherpatDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.teacherpatDataGridViewTextBoxColumn.Name = "teacherpatDataGridViewTextBoxColumn";
            // 
            // teacherphoneDataGridViewTextBoxColumn
            // 
            this.teacherphoneDataGridViewTextBoxColumn.DataPropertyName = "teacher_phone";
            this.teacherphoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.teacherphoneDataGridViewTextBoxColumn.Name = "teacherphoneDataGridViewTextBoxColumn";
            // 
            // teacherdobDataGridViewTextBoxColumn
            // 
            this.teacherdobDataGridViewTextBoxColumn.DataPropertyName = "teacher_dob";
            this.teacherdobDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.teacherdobDataGridViewTextBoxColumn.Name = "teacherdobDataGridViewTextBoxColumn";
            this.teacherdobDataGridViewTextBoxColumn.Width = 70;
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
            // gradebookDataSetBindingSource
            // 
            this.gradebookDataSetBindingSource.DataSource = this.gradebookDataSet;
            this.gradebookDataSetBindingSource.Position = 0;
            // 
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataMember = "Teacher";
            this.teacherBindingSource1.DataSource = this.gradebookDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Применить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TeacherForm";
            this.Text = "Таблица \"Преподаватели\"";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GradebookDataSet gradebookDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private GradebookDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource gradebookDataSetBindingSource;
        private System.Windows.Forms.BindingSource teacherBindingSource1;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private GradebookDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn depidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherfnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherlnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherpatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}