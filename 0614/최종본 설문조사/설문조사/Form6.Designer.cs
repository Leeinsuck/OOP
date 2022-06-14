namespace 설문조사
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.PASS = new System.Windows.Forms.TextBox();
            this.로그인 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.label1.Location = new System.Drawing.Point(135, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "설문지 관리자 모드";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.ID.Location = new System.Drawing.Point(134, 239);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(208, 31);
            this.ID.TabIndex = 1;
            // 
            // PASS
            // 
            this.PASS.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.PASS.Location = new System.Drawing.Point(134, 309);
            this.PASS.Multiline = true;
            this.PASS.Name = "PASS";
            this.PASS.PasswordChar = '*';
            this.PASS.Size = new System.Drawing.Size(208, 31);
            this.PASS.TabIndex = 2;
            // 
            // 로그인
            // 
            this.로그인.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.로그인.Location = new System.Drawing.Point(367, 252);
            this.로그인.Name = "로그인";
            this.로그인.Size = new System.Drawing.Size(112, 76);
            this.로그인.TabIndex = 3;
            this.로그인.Text = "로그인";
            this.로그인.UseVisualStyleBackColor = true;
            this.로그인.Click += new System.EventHandler(this.로그인_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(648, 494);
            this.Controls.Add(this.로그인);
            this.Controls.Add(this.PASS);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "관리자 모드";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox PASS;
        private System.Windows.Forms.Button 로그인;
    }
}