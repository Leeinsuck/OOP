namespace 설문조사
{
    partial class Form8
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
            this.돌아가기 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.대면비대면테이블BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new 설문조사.DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.대면비대면테이블BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // 돌아가기
            // 
            this.돌아가기.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.돌아가기.Location = new System.Drawing.Point(600, 850);
            this.돌아가기.Name = "돌아가기";
            this.돌아가기.Size = new System.Drawing.Size(120, 40);
            this.돌아가기.TabIndex = 0;
            this.돌아가기.Text = "종료하기";
            this.돌아가기.UseVisualStyleBackColor = true;
            this.돌아가기.Click += new System.EventHandler(this.돌아가기_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.label1.Location = new System.Drawing.Point(480, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "설문지 관리자 모드";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label2.Location = new System.Drawing.Point(810, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "대면 기타사유";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label3.Location = new System.Drawing.Point(810, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "비대면 기타사유";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.textBox1.Location = new System.Drawing.Point(810, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 250);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "비대면 하면 공부를 안할꺼 같아서";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.textBox2.Location = new System.Drawing.Point(810, 520);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 250);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "거리가 너무 멀어서\r\n코로나 걸려서\r\n다리를 다쳐 거동이 불편해서\r\n";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(50, 170);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(665, 511);
            this.pieChart1.TabIndex = 9;
            this.pieChart1.Text = "pieChart1";
            // 
            // 대면비대면테이블BindingSource
            // 
            this.대면비대면테이블BindingSource.DataMember = "대면비대면테이블";
            this.대면비대면테이블BindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 725);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "대면/비대면";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 725);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "대면";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(585, 725);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 45);
            this.button3.TabIndex = 14;
            this.button3.Text = "비대면";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1298, 924);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.돌아가기);
            this.Controls.Add(this.textBox2);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "관리자 모드";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.대면비대면테이블BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 돌아가기;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.BindingSource 대면비대면테이블BindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}