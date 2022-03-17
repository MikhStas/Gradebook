namespace Gradebook
{
    partial class LessonsReportForm
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
            this.getlessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_lessonsTableAdapter = new Gradebook.GradebookDataSetTableAdapters.Get_lessonsTableAdapter();
            this.названиеПредметаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИВремяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аудиторияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кафедраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.преподавательDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getlessonsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеПредметаDataGridViewTextBoxColumn,
            this.группаDataGridViewTextBoxColumn,
            this.датаИВремяDataGridViewTextBoxColumn,
            this.аудиторияDataGridViewTextBoxColumn,
            this.кафедраDataGridViewTextBoxColumn,
            this.преподавательDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getlessonsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // gradebookDataSet
            // 
            this.gradebookDataSet.DataSetName = "GradebookDataSet";
            this.gradebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getlessonsBindingSource
            // 
            this.getlessonsBindingSource.DataMember = "Get_lessons";
            this.getlessonsBindingSource.DataSource = this.gradebookDataSet;
            // 
            // get_lessonsTableAdapter
            // 
            this.get_lessonsTableAdapter.ClearBeforeFill = true;
            // 
            // названиеПредметаDataGridViewTextBoxColumn
            // 
            this.названиеПредметаDataGridViewTextBoxColumn.DataPropertyName = "Название предмета";
            this.названиеПредметаDataGridViewTextBoxColumn.HeaderText = "Название предмета";
            this.названиеПредметаDataGridViewTextBoxColumn.Name = "названиеПредметаDataGridViewTextBoxColumn";
            this.названиеПредметаDataGridViewTextBoxColumn.Width = 150;
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            // 
            // датаИВремяDataGridViewTextBoxColumn
            // 
            this.датаИВремяDataGridViewTextBoxColumn.DataPropertyName = "Дата и время";
            this.датаИВремяDataGridViewTextBoxColumn.HeaderText = "Дата и время";
            this.датаИВремяDataGridViewTextBoxColumn.Name = "датаИВремяDataGridViewTextBoxColumn";
            this.датаИВремяDataGridViewTextBoxColumn.Width = 150;
            // 
            // аудиторияDataGridViewTextBoxColumn
            // 
            this.аудиторияDataGridViewTextBoxColumn.DataPropertyName = "Аудитория";
            this.аудиторияDataGridViewTextBoxColumn.HeaderText = "Аудитория";
            this.аудиторияDataGridViewTextBoxColumn.Name = "аудиторияDataGridViewTextBoxColumn";
            this.аудиторияDataGridViewTextBoxColumn.Width = 70;
            // 
            // кафедраDataGridViewTextBoxColumn
            // 
            this.кафедраDataGridViewTextBoxColumn.DataPropertyName = "Кафедра";
            this.кафедраDataGridViewTextBoxColumn.HeaderText = "Кафедра";
            this.кафедраDataGridViewTextBoxColumn.Name = "кафедраDataGridViewTextBoxColumn";
            this.кафедраDataGridViewTextBoxColumn.Width = 300;
            // 
            // преподавательDataGridViewTextBoxColumn
            // 
            this.преподавательDataGridViewTextBoxColumn.DataPropertyName = "Преподаватель";
            this.преподавательDataGridViewTextBoxColumn.HeaderText = "Преподаватель";
            this.преподавательDataGridViewTextBoxColumn.Name = "преподавательDataGridViewTextBoxColumn";
            this.преподавательDataGridViewTextBoxColumn.ReadOnly = true;
            this.преподавательDataGridViewTextBoxColumn.Width = 300;
            // 
            // LessonsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 324);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LessonsReportForm";
            this.Text = "Уроки. Отчет.";
            this.Load += new System.EventHandler(this.LessonsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradebookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getlessonsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GradebookDataSet gradebookDataSet;
        private System.Windows.Forms.BindingSource getlessonsBindingSource;
        private GradebookDataSetTableAdapters.Get_lessonsTableAdapter get_lessonsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПредметаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИВремяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аудиторияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кафедраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn преподавательDataGridViewTextBoxColumn;
    }
}