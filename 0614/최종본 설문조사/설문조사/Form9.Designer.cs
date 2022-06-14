namespace 설문조사
{
    partial class Form9
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
            this.dataSet1 = new 설문조사.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.대면비대면테이블BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.선택DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.학생수DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.대면비대면테이블BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.선택DataGridViewTextBoxColumn,
            this.학생수DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.대면비대면테이블BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(99, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(590, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // 대면비대면테이블BindingSource
            // 
            this.대면비대면테이블BindingSource.DataMember = "대면비대면테이블";
            this.대면비대면테이블BindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // 선택DataGridViewTextBoxColumn
            // 
            this.선택DataGridViewTextBoxColumn.DataPropertyName = "선택";
            this.선택DataGridViewTextBoxColumn.HeaderText = "선택";
            this.선택DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.선택DataGridViewTextBoxColumn.Name = "선택DataGridViewTextBoxColumn";
            this.선택DataGridViewTextBoxColumn.Width = 150;
            // 
            // 학생수DataGridViewTextBoxColumn
            // 
            this.학생수DataGridViewTextBoxColumn.DataPropertyName = "학생수";
            this.학생수DataGridViewTextBoxColumn.HeaderText = "학생수";
            this.학생수DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.학생수DataGridViewTextBoxColumn.Name = "학생수DataGridViewTextBoxColumn";
            this.학생수DataGridViewTextBoxColumn.Width = 150;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.대면비대면테이블BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 선택DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 학생수DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 대면비대면테이블BindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
    }
}