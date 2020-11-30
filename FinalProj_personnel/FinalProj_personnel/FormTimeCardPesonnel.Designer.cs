namespace FinalProj_personnel
{
    partial class FormTimeCardPesonnel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGotoWorkShow = new System.Windows.Forms.Button();
            this.dataGridViewGotoWork = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonStartMemory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStartThis = new System.Windows.Forms.Button();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonEndThis = new System.Windows.Forms.Button();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEndMemory = new System.Windows.Forms.Button();
            this.radioButton_holiday = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGotoWork)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGotoWorkShow);
            this.groupBox1.Controls.Add(this.dataGridViewGotoWork);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(270, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(328, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "출퇴근 시간현황";
            // 
            // buttonGotoWorkShow
            // 
            this.buttonGotoWorkShow.Location = new System.Drawing.Point(256, 33);
            this.buttonGotoWorkShow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGotoWorkShow.Name = "buttonGotoWorkShow";
            this.buttonGotoWorkShow.Size = new System.Drawing.Size(55, 19);
            this.buttonGotoWorkShow.TabIndex = 3;
            this.buttonGotoWorkShow.Text = "보기";
            this.buttonGotoWorkShow.UseVisualStyleBackColor = true;
            this.buttonGotoWorkShow.Click += new System.EventHandler(this.buttonGotoWorkShow_Click);
            // 
            // dataGridViewGotoWork
            // 
            this.dataGridViewGotoWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGotoWork.Location = new System.Drawing.Point(4, 60);
            this.dataGridViewGotoWork.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewGotoWork.Name = "dataGridViewGotoWork";
            this.dataGridViewGotoWork.RowHeadersWidth = 62;
            this.dataGridViewGotoWork.RowTemplate.Height = 30;
            this.dataGridViewGotoWork.Size = new System.Drawing.Size(319, 249);
            this.dataGridViewGotoWork.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd-tt HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 31);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // buttonStartMemory
            // 
            this.buttonStartMemory.Location = new System.Drawing.Point(197, 45);
            this.buttonStartMemory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartMemory.Name = "buttonStartMemory";
            this.buttonStartMemory.Size = new System.Drawing.Size(41, 21);
            this.buttonStartMemory.TabIndex = 2;
            this.buttonStartMemory.Text = "기록";
            this.buttonStartMemory.UseVisualStyleBackColor = true;
            this.buttonStartMemory.Click += new System.EventHandler(this.buttonStartMemory_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonStartThis);
            this.groupBox2.Controls.Add(this.textBoxStartTime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonStartMemory);
            this.groupBox2.Location = new System.Drawing.Point(11, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(245, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "출근 시간기록";
            // 
            // buttonStartThis
            // 
            this.buttonStartThis.Location = new System.Drawing.Point(69, 87);
            this.buttonStartThis.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartThis.Name = "buttonStartThis";
            this.buttonStartThis.Size = new System.Drawing.Size(119, 23);
            this.buttonStartThis.TabIndex = 5;
            this.buttonStartThis.Text = "현재시간 불러오기";
            this.buttonStartThis.UseVisualStyleBackColor = true;
            this.buttonStartThis.Click += new System.EventHandler(this.buttonStartThis_Click);
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Location = new System.Drawing.Point(77, 45);
            this.textBoxStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.Size = new System.Drawing.Size(112, 21);
            this.textBoxStartTime.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "출근시간: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonEndThis);
            this.groupBox3.Controls.Add(this.textBoxEndTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonEndMemory);
            this.groupBox3.Location = new System.Drawing.Point(11, 186);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(245, 126);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "퇴근 시간기록";
            // 
            // buttonEndThis
            // 
            this.buttonEndThis.Location = new System.Drawing.Point(69, 93);
            this.buttonEndThis.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEndThis.Name = "buttonEndThis";
            this.buttonEndThis.Size = new System.Drawing.Size(119, 23);
            this.buttonEndThis.TabIndex = 7;
            this.buttonEndThis.Text = "현재시간 불러오기";
            this.buttonEndThis.UseVisualStyleBackColor = true;
            this.buttonEndThis.Click += new System.EventHandler(this.buttonEndThis_Click);
            // 
            // textBoxEndTime
            // 
            this.textBoxEndTime.Location = new System.Drawing.Point(77, 51);
            this.textBoxEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEndTime.Name = "textBoxEndTime";
            this.textBoxEndTime.Size = new System.Drawing.Size(112, 21);
            this.textBoxEndTime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "퇴근시간: ";
            // 
            // buttonEndMemory
            // 
            this.buttonEndMemory.Location = new System.Drawing.Point(196, 51);
            this.buttonEndMemory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEndMemory.Name = "buttonEndMemory";
            this.buttonEndMemory.Size = new System.Drawing.Size(42, 21);
            this.buttonEndMemory.TabIndex = 2;
            this.buttonEndMemory.Text = "기록";
            this.buttonEndMemory.UseVisualStyleBackColor = true;
            this.buttonEndMemory.Click += new System.EventHandler(this.buttonEndMemory_Click);
            // 
            // radioButton_holiday
            // 
            this.radioButton_holiday.AutoSize = true;
            this.radioButton_holiday.Location = new System.Drawing.Point(21, 325);
            this.radioButton_holiday.Name = "radioButton_holiday";
            this.radioButton_holiday.Size = new System.Drawing.Size(71, 16);
            this.radioButton_holiday.TabIndex = 5;
            this.radioButton_holiday.TabStop = true;
            this.radioButton_holiday.Text = "휴일여부";
            this.radioButton_holiday.UseVisualStyleBackColor = true;
            // 
            // FormTimeCardPesonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 353);
            this.Controls.Add(this.radioButton_holiday);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTimeCardPesonnel";
            this.Text = "출근부 화면";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGotoWork)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewGotoWork;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonStartMemory;
        private System.Windows.Forms.Button buttonGotoWorkShow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStartThis;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonEndThis;
        private System.Windows.Forms.TextBox textBoxEndTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEndMemory;
        private System.Windows.Forms.RadioButton radioButton_holiday;
    }
}