namespace task
{
    partial class 업무
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cate_input = new System.Windows.Forms.TextBox();
            this.cate_save = new System.Windows.Forms.Button();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.todaytaskinput3 = new System.Windows.Forms.TextBox();
            this.todaytaskinput2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.todaytaskinput = new System.Windows.Forms.TextBox();
            this.tasksave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Location = new System.Drawing.Point(38, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 67);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "업무등록";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "종료";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(23, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(67, 21);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "입력시간";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(121, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "시작";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.cate_input);
            this.groupBox3.Controls.Add(this.cate_save);
            this.groupBox3.Controls.Add(this.comboBox9);
            this.groupBox3.Location = new System.Drawing.Point(563, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 189);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "업무마스터";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(23, 84);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(63, 20);
            this.comboBox4.TabIndex = 20;
            this.comboBox4.Text = "분류";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cate_input
            // 
            this.cate_input.Location = new System.Drawing.Point(23, 38);
            this.cate_input.Name = "cate_input";
            this.cate_input.Size = new System.Drawing.Size(140, 21);
            this.cate_input.TabIndex = 2;
            // 
            // cate_save
            // 
            this.cate_save.Location = new System.Drawing.Point(57, 147);
            this.cate_save.Name = "cate_save";
            this.cate_save.Size = new System.Drawing.Size(75, 23);
            this.cate_save.TabIndex = 19;
            this.cate_save.Text = "등록";
            this.cate_save.UseVisualStyleBackColor = true;
            this.cate_save.Click += new System.EventHandler(this.cate_save_Click);
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(100, 84);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(63, 20);
            this.comboBox9.TabIndex = 18;
            this.comboBox9.Text = "분류";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox8);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(332, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 189);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "일일업무등록";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "검색",
            "수정",
            "삭제"});
            this.comboBox8.Location = new System.Drawing.Point(17, 82);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(140, 20);
            this.comboBox8.TabIndex = 19;
            this.comboBox8.Text = "분류";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 21);
            this.textBox3.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(55, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "등록";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.todaytaskinput3);
            this.groupBox1.Controls.Add(this.todaytaskinput2);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.todaytaskinput);
            this.groupBox1.Controls.Add(this.tasksave);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(38, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 189);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "일일업무";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // todaytaskinput3
            // 
            this.todaytaskinput3.Location = new System.Drawing.Point(196, 38);
            this.todaytaskinput3.Name = "todaytaskinput3";
            this.todaytaskinput3.Size = new System.Drawing.Size(67, 21);
            this.todaytaskinput3.TabIndex = 23;
            // 
            // todaytaskinput2
            // 
            this.todaytaskinput2.Location = new System.Drawing.Point(97, 38);
            this.todaytaskinput2.Name = "todaytaskinput2";
            this.todaytaskinput2.Size = new System.Drawing.Size(67, 21);
            this.todaytaskinput2.TabIndex = 22;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "대분류",
            "중분류",
            "소분류"});
            this.comboBox3.Location = new System.Drawing.Point(196, 82);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(67, 20);
            this.comboBox3.TabIndex = 21;
            this.comboBox3.Text = "분류";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "대분류",
            "중분류",
            "소분류"});
            this.comboBox2.Location = new System.Drawing.Point(97, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(70, 20);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.Text = "분류";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // todaytaskinput
            // 
            this.todaytaskinput.Location = new System.Drawing.Point(6, 38);
            this.todaytaskinput.Name = "todaytaskinput";
            this.todaytaskinput.Size = new System.Drawing.Size(67, 21);
            this.todaytaskinput.TabIndex = 2;
            // 
            // tasksave
            // 
            this.tasksave.Location = new System.Drawing.Point(97, 134);
            this.tasksave.Name = "tasksave";
            this.tasksave.Size = new System.Drawing.Size(75, 23);
            this.tasksave.TabIndex = 19;
            this.tasksave.Text = "등록";
            this.tasksave.UseVisualStyleBackColor = true;
            this.tasksave.Click += new System.EventHandler(this.tasksave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 20);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "분류";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // 업무
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "업무";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox cate_input;
        private System.Windows.Forms.Button cate_save;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox todaytaskinput;
        private System.Windows.Forms.Button tasksave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox todaytaskinput3;
        private System.Windows.Forms.TextBox todaytaskinput2;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}

