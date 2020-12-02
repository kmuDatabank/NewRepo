namespace FinalProj_personnel
{
    partial class Task
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
            this.master = new System.Windows.Forms.Button();
            this.comboBox_large = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_small = new System.Windows.Forms.ComboBox();
            this.comboBox_middle = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_keyword = new System.Windows.Forms.Button();
            this.button_contributer = new System.Windows.Forms.Button();
            this.button_date = new System.Windows.Forms.Button();
            this.label_stable = new System.Windows.Forms.Label();
            this.textBox_startT = new System.Windows.Forms.TextBox();
            this.textBox_endT = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // master
            // 
            this.master.Location = new System.Drawing.Point(663, 47);
            this.master.Name = "master";
            this.master.Size = new System.Drawing.Size(129, 63);
            this.master.TabIndex = 0;
            this.master.Text = "업무마스터";
            this.master.UseVisualStyleBackColor = true;
            this.master.Click += new System.EventHandler(this.master_Click);
            // 
            // comboBox_large
            // 
            this.comboBox_large.FormattingEnabled = true;
            this.comboBox_large.Location = new System.Drawing.Point(17, 61);
            this.comboBox_large.Name = "comboBox_large";
            this.comboBox_large.Size = new System.Drawing.Size(121, 20);
            this.comboBox_large.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_refresh);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox_endT);
            this.groupBox1.Controls.Add(this.textBox_startT);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_small);
            this.groupBox1.Controls.Add(this.comboBox_middle);
            this.groupBox1.Controls.Add(this.comboBox_large);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 221);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "일일업무선택등록";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd-tt HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 21);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "업무종료시간";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "업무시작시간";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "등록하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "소분류";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "중분류";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "대분류";
            // 
            // comboBox_small
            // 
            this.comboBox_small.FormattingEnabled = true;
            this.comboBox_small.Location = new System.Drawing.Point(314, 61);
            this.comboBox_small.Name = "comboBox_small";
            this.comboBox_small.Size = new System.Drawing.Size(121, 20);
            this.comboBox_small.TabIndex = 3;
            // 
            // comboBox_middle
            // 
            this.comboBox_middle.FormattingEnabled = true;
            this.comboBox_middle.Location = new System.Drawing.Point(166, 61);
            this.comboBox_middle.Name = "comboBox_middle";
            this.comboBox_middle.Size = new System.Drawing.Size(121, 20);
            this.comboBox_middle.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_keyword);
            this.groupBox2.Controls.Add(this.button_contributer);
            this.groupBox2.Controls.Add(this.button_date);
            this.groupBox2.Location = new System.Drawing.Point(13, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 281);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "일일업무검색";
            // 
            // button_keyword
            // 
            this.button_keyword.Location = new System.Drawing.Point(377, 112);
            this.button_keyword.Name = "button_keyword";
            this.button_keyword.Size = new System.Drawing.Size(130, 63);
            this.button_keyword.TabIndex = 2;
            this.button_keyword.Text = "업무키워드검색";
            this.button_keyword.UseVisualStyleBackColor = true;
            this.button_keyword.Click += new System.EventHandler(this.button_keyword_Click);
            // 
            // button_contributer
            // 
            this.button_contributer.Location = new System.Drawing.Point(189, 112);
            this.button_contributer.Name = "button_contributer";
            this.button_contributer.Size = new System.Drawing.Size(125, 63);
            this.button_contributer.TabIndex = 1;
            this.button_contributer.Text = "등록자검색";
            this.button_contributer.UseVisualStyleBackColor = true;
            this.button_contributer.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_date
            // 
            this.button_date.Location = new System.Drawing.Point(3, 112);
            this.button_date.Name = "button_date";
            this.button_date.Size = new System.Drawing.Size(134, 62);
            this.button_date.TabIndex = 0;
            this.button_date.Text = "날짜검색";
            this.button_date.UseVisualStyleBackColor = true;
            this.button_date.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_stable
            // 
            this.label_stable.AutoSize = true;
            this.label_stable.Location = new System.Drawing.Point(717, 29);
            this.label_stable.Name = "label_stable";
            this.label_stable.Size = new System.Drawing.Size(13, 12);
            this.label_stable.TabIndex = 5;
            this.label_stable.Text = "\"\"";
            // 
            // textBox_startT
            // 
            this.textBox_startT.Location = new System.Drawing.Point(17, 165);
            this.textBox_startT.Name = "textBox_startT";
            this.textBox_startT.Size = new System.Drawing.Size(164, 21);
            this.textBox_startT.TabIndex = 12;
            // 
            // textBox_endT
            // 
            this.textBox_endT.Location = new System.Drawing.Point(261, 164);
            this.textBox_endT.Name = "textBox_endT";
            this.textBox_endT.Size = new System.Drawing.Size(174, 21);
            this.textBox_endT.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "현재시간로드";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(261, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "현재시간로드";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(465, 22);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(105, 59);
            this.button_refresh.TabIndex = 6;
            this.button_refresh.Text = "새로고침";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 604);
            this.Controls.Add(this.label_stable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.master);
            this.Name = "Task";
            this.Text = "task";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button master;
        private System.Windows.Forms.ComboBox comboBox_large;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_small;
        private System.Windows.Forms.ComboBox comboBox_middle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_stable;
        private System.Windows.Forms.Button button_keyword;
        private System.Windows.Forms.Button button_contributer;
        private System.Windows.Forms.Button button_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_endT;
        private System.Windows.Forms.TextBox textBox_startT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_refresh;
    }
}


