namespace 설문조사
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.조사하기1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 조사하기1
            // 
            this.조사하기1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.조사하기1.Location = new System.Drawing.Point(600, 850);
            this.조사하기1.Name = "조사하기1";
            this.조사하기1.Size = new System.Drawing.Size(120, 40);
            this.조사하기1.TabIndex = 20;
            this.조사하기1.Text = "조사하기";
            this.조사하기1.UseVisualStyleBackColor = true;
            this.조사하기1.Click += new System.EventHandler(this.조사하기1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 25F);
            this.label3.Location = new System.Drawing.Point(185, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(950, 500);
            this.label3.TabIndex = 21;
            this.label3.Text = "요즘 코로나 때문에 비대면 강의로 하다가 점점 시간이 지나서 대면 강의로 바뀌는 추세가 되었습니다. 이때 각 학생들의 생각은 어떠한지 조사하기 위" +
    "해 설문조사를 합니다. 이때 한 명이 여러 번 할 수 있으니 이름과 학번을 작성해주세요. (단, 익명성은 보장됩니다.) ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1136, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1298, 924);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.조사하기1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "대면 비대면 선호도 설문조사";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox 관리자모드;
        private System.Windows.Forms.Button 조사하기;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button 조사하기1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

