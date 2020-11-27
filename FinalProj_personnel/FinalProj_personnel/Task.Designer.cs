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
            this.finish = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numbox = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cate_input = new System.Windows.Forms.TextBox();
            this.cate_save = new System.Windows.Forms.Button();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.time = new System.Windows.Forms.TextBox();
            this.road = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.DataGridView();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.taskbox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.todaytaskinput3 = new System.Windows.Forms.TextBox();
            this.todaytaskinput2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.todaytaskinput = new System.Windows.Forms.TextBox();
            this.tasksave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(196, 136);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(67, 21);
            this.finish.TabIndex = 16;
            this.finish.Text = "종료시간";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(6, 134);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(67, 21);
            this.start.TabIndex = 14;
            this.start.Text = "시작시간";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numbox);
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.cate_input);
            this.groupBox3.Controls.Add(this.cate_save);
            this.groupBox3.Controls.Add(this.comboBox9);
            this.groupBox3.Location = new System.Drawing.Point(12, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 189);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "업무마스터";
            // 
            // numbox
            // 
            this.numbox.Location = new System.Drawing.Point(196, 38);
            this.numbox.Name = "numbox";
            this.numbox.Size = new System.Drawing.Size(63, 21);
            this.numbox.TabIndex = 21;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "대분류",
            "중분류",
            "소분류"});
            this.comboBox4.Location = new System.Drawing.Point(6, 84);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(105, 20);
            this.comboBox4.TabIndex = 20;
            this.comboBox4.Text = "대중소분류선택";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cate_input
            // 
            this.cate_input.Location = new System.Drawing.Point(23, 38);
            this.cate_input.Name = "cate_input";
            this.cate_input.Size = new System.Drawing.Size(88, 21);
            this.cate_input.TabIndex = 2;
            // 
            // cate_save
            // 
            this.cate_save.Location = new System.Drawing.Point(23, 129);
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
            this.comboBox9.Items.AddRange(new object[] {
            "등록",
            "수정 ",
            "삭제"});
            this.comboBox9.Location = new System.Drawing.Point(164, 84);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(120, 20);
            this.comboBox9.TabIndex = 18;
            this.comboBox9.Text = "업무리스트";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.time);
            this.groupBox2.Controls.Add(this.road);
            this.groupBox2.Controls.Add(this.list);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.comboBox8);
            this.groupBox2.Controls.Add(this.taskbox);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(332, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 189);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "일일업무검색";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(96, 38);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(61, 21);
            this.time.TabIndex = 29;
            // 
            // road
            // 
            this.road.Location = new System.Drawing.Point(111, 147);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(75, 23);
            this.road.TabIndex = 28;
            this.road.Text = "road";
            this.road.UseVisualStyleBackColor = true;
            this.road.Click += new System.EventHandler(this.road_Click);
            // 
            // list
            // 
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Location = new System.Drawing.Point(207, 29);
            this.list.Name = "list";
            this.list.RowTemplate.Height = 23;
            this.list.Size = new System.Drawing.Size(184, 141);
            this.list.TabIndex = 27;
            this.list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_CellContentClick);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "날짜",
            "업무"});
            this.comboBox5.Location = new System.Drawing.Point(17, 71);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(140, 20);
            this.comboBox5.TabIndex = 20;
            this.comboBox5.Text = "분류";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "검색",
            "수정",
            "삭제"});
            this.comboBox8.Location = new System.Drawing.Point(17, 109);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(140, 20);
            this.comboBox8.TabIndex = 19;
            this.comboBox8.Text = "분류";
            // 
            // taskbox
            // 
            this.taskbox.Location = new System.Drawing.Point(17, 38);
            this.taskbox.Name = "taskbox";
            this.taskbox.Size = new System.Drawing.Size(61, 21);
            this.taskbox.TabIndex = 4;
            this.taskbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "등록";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.finish);
            this.groupBox1.Controls.Add(this.todaytaskinput3);
            this.groupBox1.Controls.Add(this.todaytaskinput2);
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.todaytaskinput);
            this.groupBox1.Controls.Add(this.tasksave);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 189);
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
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(443, 270);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 20);
            this.comboBox6.TabIndex = 29;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Task";
            this.Text = "task";
            this.Load += new System.EventHandler(this.Task_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox cate_input;
        private System.Windows.Forms.Button cate_save;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.TextBox taskbox;
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
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.Button road;
        private System.Windows.Forms.TextBox numbox;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox finish;
        private System.Windows.Forms.ComboBox comboBox6;
    }
}


