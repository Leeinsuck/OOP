namespace 설문조사
{
    partial class Form7
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
            this.확인 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 확인
            // 
            this.확인.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.확인.Location = new System.Drawing.Point(135, 92);
            this.확인.Name = "확인";
            this.확인.Size = new System.Drawing.Size(108, 40);
            this.확인.TabIndex = 0;
            this.확인.Text = "확인";
            this.확인.UseVisualStyleBackColor = true;
            this.확인.Click += new System.EventHandler(this.확인_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.label1.Location = new System.Drawing.Point(135, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "로그인 실패";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(378, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.확인);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인 실패";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 확인;
        private System.Windows.Forms.Label label1;
    }
}