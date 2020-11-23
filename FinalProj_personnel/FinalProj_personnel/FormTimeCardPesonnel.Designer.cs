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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewGotoWork = new System.Windows.Forms.DataGridView();
            this.buttonStartMemory = new System.Windows.Forms.Button();
            this.buttonGotoWorkShow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEndMemory = new System.Windows.Forms.Button();
            this.buttonStartThis = new System.Windows.Forms.Button();
            this.buttonEndThis = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(386, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "출퇴근 시간현황";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd-tt hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 28);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridViewGotoWork
            // 
            this.dataGridViewGotoWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGotoWork.Location = new System.Drawing.Point(6, 90);
            this.dataGridViewGotoWork.Name = "dataGridViewGotoWork";
            this.dataGridViewGotoWork.RowHeadersWidth = 62;
            this.dataGridViewGotoWork.RowTemplate.Height = 30;
            this.dataGridViewGotoWork.Size = new System.Drawing.Size(456, 373);
            this.dataGridViewGotoWork.TabIndex = 1;
            // 
            // buttonStartMemory
            // 
            this.buttonStartMemory.Location = new System.Drawing.Point(281, 68);
            this.buttonStartMemory.Name = "buttonStartMemory";
            this.buttonStartMemory.Size = new System.Drawing.Size(58, 32);
            this.buttonStartMemory.TabIndex = 2;
            this.buttonStartMemory.Text = "기록";
            this.buttonStartMemory.UseVisualStyleBackColor = true;
            // 
            // buttonGotoWorkShow
            // 
            this.buttonGotoWorkShow.Location = new System.Drawing.Point(366, 49);
            this.buttonGotoWorkShow.Name = "buttonGotoWorkShow";
            this.buttonGotoWorkShow.Size = new System.Drawing.Size(79, 28);
            this.buttonGotoWorkShow.TabIndex = 3;
            this.buttonGotoWorkShow.Text = "보기";
            this.buttonGotoWorkShow.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonStartThis);
            this.groupBox2.Controls.Add(this.textBoxStartTime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonStartMemory);
            this.groupBox2.Location = new System.Drawing.Point(16, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 188);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "출근 시간기록";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "출근시간: ";
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Location = new System.Drawing.Point(110, 68);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.Size = new System.Drawing.Size(159, 28);
            this.textBoxStartTime.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonEndThis);
            this.groupBox3.Controls.Add(this.textBoxEndTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonEndMemory);
            this.groupBox3.Location = new System.Drawing.Point(16, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 189);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "퇴근 시간기록";
            // 
            // textBoxEndTime
            // 
            this.textBoxEndTime.Location = new System.Drawing.Point(110, 77);
            this.textBoxEndTime.Name = "textBoxEndTime";
            this.textBoxEndTime.Size = new System.Drawing.Size(159, 28);
            this.textBoxEndTime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "퇴근시간: ";
            // 
            // buttonEndMemory
            // 
            this.buttonEndMemory.Location = new System.Drawing.Point(280, 77);
            this.buttonEndMemory.Name = "buttonEndMemory";
            this.buttonEndMemory.Size = new System.Drawing.Size(60, 31);
            this.buttonEndMemory.TabIndex = 2;
            this.buttonEndMemory.Text = "기록";
            this.buttonEndMemory.UseVisualStyleBackColor = true;
            // 
            // buttonStartThis
            // 
            this.buttonStartThis.Location = new System.Drawing.Point(99, 130);
            this.buttonStartThis.Name = "buttonStartThis";
            this.buttonStartThis.Size = new System.Drawing.Size(170, 34);
            this.buttonStartThis.TabIndex = 5;
            this.buttonStartThis.Text = "현재시간 불러오기";
            this.buttonStartThis.UseVisualStyleBackColor = true;
            // 
            // buttonEndThis
            // 
            this.buttonEndThis.Location = new System.Drawing.Point(99, 139);
            this.buttonEndThis.Name = "buttonEndThis";
            this.buttonEndThis.Size = new System.Drawing.Size(170, 34);
            this.buttonEndThis.TabIndex = 7;
            this.buttonEndThis.Text = "현재시간 불러오기";
            this.buttonEndThis.UseVisualStyleBackColor = true;
            // 
            // FormTimeCardPesonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTimeCardPesonnel";
            this.Text = "출근부 화면";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGotoWork)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
    }
}