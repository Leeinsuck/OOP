namespace 설문조사
{
    partial class Form5
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.제출하기 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.label4.Location = new System.Drawing.Point(310, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(700, 48);
            this.label4.TabIndex = 19;
            this.label4.Text = "대학교 강의 대면 비대면 선호도 조사하기";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 22F);
            this.label1.Location = new System.Drawing.Point(270, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(769, 60);
            this.label1.TabIndex = 20;
            this.label1.Text = "설문조사에 참여해주셔서 감사합니다.";
            // 
            // 제출하기
            // 
            this.제출하기.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.제출하기.Location = new System.Drawing.Point(600, 850);
            this.제출하기.Name = "제출하기";
            this.제출하기.Size = new System.Drawing.Size(120, 40);
            this.제출하기.TabIndex = 21;
            this.제출하기.Text = "제출하기";
            this.제출하기.UseVisualStyleBackColor = true;
            this.제출하기.Click += new System.EventHandler(this.제출하기_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1298, 924);
            this.Controls.Add(this.제출하기);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "대면 비대면 선호도 설문조사";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 제출하기;
    }
}