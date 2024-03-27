namespace _12_radio_button
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_korea = new System.Windows.Forms.RadioButton();
            this.rd_china = new System.Windows.Forms.RadioButton();
            this.rb_japan = new System.Windows.Forms.RadioButton();
            this.rb_others = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_others);
            this.groupBox1.Controls.Add(this.rb_japan);
            this.groupBox1.Controls.Add(this.rd_china);
            this.groupBox1.Controls.Add(this.rb_korea);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "국적";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_female);
            this.groupBox2.Controls.Add(this.rb_male);
            this.groupBox2.Location = new System.Drawing.Point(290, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // rb_korea
            // 
            this.rb_korea.AutoSize = true;
            this.rb_korea.Location = new System.Drawing.Point(33, 52);
            this.rb_korea.Name = "rb_korea";
            this.rb_korea.Size = new System.Drawing.Size(71, 16);
            this.rb_korea.TabIndex = 0;
            this.rb_korea.TabStop = true;
            this.rb_korea.Text = "대한민국";
            this.rb_korea.UseVisualStyleBackColor = true;
            // 
            // rd_china
            // 
            this.rd_china.AutoSize = true;
            this.rd_china.Location = new System.Drawing.Point(33, 92);
            this.rd_china.Name = "rd_china";
            this.rd_china.Size = new System.Drawing.Size(47, 16);
            this.rd_china.TabIndex = 1;
            this.rd_china.TabStop = true;
            this.rd_china.Text = "중국";
            this.rd_china.UseVisualStyleBackColor = true;
            // 
            // rb_japan
            // 
            this.rb_japan.AutoSize = true;
            this.rb_japan.Location = new System.Drawing.Point(33, 131);
            this.rb_japan.Name = "rb_japan";
            this.rb_japan.Size = new System.Drawing.Size(47, 16);
            this.rb_japan.TabIndex = 2;
            this.rb_japan.TabStop = true;
            this.rb_japan.Text = "일본";
            this.rb_japan.UseVisualStyleBackColor = true;
            // 
            // rb_others
            // 
            this.rb_others.AutoSize = true;
            this.rb_others.Location = new System.Drawing.Point(33, 169);
            this.rb_others.Name = "rb_others";
            this.rb_others.Size = new System.Drawing.Size(83, 16);
            this.rb_others.TabIndex = 3;
            this.rb_others.TabStop = true;
            this.rb_others.Text = "그 외 국가 ";
            this.rb_others.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(20, 26);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(35, 16);
            this.rb_male.TabIndex = 3;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "남";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(79, 26);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(35, 16);
            this.rb_female.TabIndex = 4;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "여";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "제출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_others;
        private System.Windows.Forms.RadioButton rb_japan;
        private System.Windows.Forms.RadioButton rd_china;
        private System.Windows.Forms.RadioButton rb_korea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.Button button1;
    }
}

