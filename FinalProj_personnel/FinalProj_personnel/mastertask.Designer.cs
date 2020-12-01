namespace FinalProj_personnel
{
    partial class mastertask
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
            this.comboBox_add1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_adder = new System.Windows.Forms.TextBox();
            this.button_addTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_del_large = new System.Windows.Forms.Button();
            this.listView_large = new System.Windows.Forms.ListView();
            this.listView_middle = new System.Windows.Forms.ListView();
            this.listView_small = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_del_middle = new System.Windows.Forms.Button();
            this.button_del_small = new System.Windows.Forms.Button();
            this.button_modL = new System.Windows.Forms.Button();
            this.context = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_modM = new System.Windows.Forms.Button();
            this.button_mods = new System.Windows.Forms.Button();
            this.button_rf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "분류목록";
            // 
            // comboBox_add1
            // 
            this.comboBox_add1.FormattingEnabled = true;
            this.comboBox_add1.Items.AddRange(new object[] {
            "large_cate",
            "middle_cate",
            "small_cate"});
            this.comboBox_add1.Location = new System.Drawing.Point(85, 43);
            this.comboBox_add1.Name = "comboBox_add1";
            this.comboBox_add1.Size = new System.Drawing.Size(121, 20);
            this.comboBox_add1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름짓기";
            // 
            // textBox_adder
            // 
            this.textBox_adder.Location = new System.Drawing.Point(85, 88);
            this.textBox_adder.Multiline = true;
            this.textBox_adder.Name = "textBox_adder";
            this.textBox_adder.Size = new System.Drawing.Size(173, 28);
            this.textBox_adder.TabIndex = 3;
            // 
            // button_addTask
            // 
            this.button_addTask.Location = new System.Drawing.Point(8, 174);
            this.button_addTask.Name = "button_addTask";
            this.button_addTask.Size = new System.Drawing.Size(75, 23);
            this.button_addTask.TabIndex = 4;
            this.button_addTask.Text = "업무등록";
            this.button_addTask.UseVisualStyleBackColor = true;
            this.button_addTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_addTask);
            this.groupBox1.Controls.Add(this.comboBox_add1);
            this.groupBox1.Controls.Add(this.textBox_adder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(669, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 288);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "업무등록";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "대분류목록";
            // 
            // button_del_large
            // 
            this.button_del_large.Location = new System.Drawing.Point(27, 487);
            this.button_del_large.Name = "button_del_large";
            this.button_del_large.Size = new System.Drawing.Size(160, 48);
            this.button_del_large.TabIndex = 13;
            this.button_del_large.Text = "선택된대분류제거";
            this.button_del_large.UseVisualStyleBackColor = true;
            this.button_del_large.Click += new System.EventHandler(this.button_del_Click);
            // 
            // listView_large
            // 
            this.listView_large.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.context});
            this.listView_large.HideSelection = false;
            this.listView_large.Location = new System.Drawing.Point(27, 78);
            this.listView_large.Name = "listView_large";
            this.listView_large.Size = new System.Drawing.Size(160, 403);
            this.listView_large.TabIndex = 14;
            this.listView_large.UseCompatibleStateImageBehavior = false;
            this.listView_large.View = System.Windows.Forms.View.Details;
            // 
            // listView_middle
            // 
            this.listView_middle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_middle.HideSelection = false;
            this.listView_middle.Location = new System.Drawing.Point(216, 78);
            this.listView_middle.Name = "listView_middle";
            this.listView_middle.Size = new System.Drawing.Size(160, 400);
            this.listView_middle.TabIndex = 15;
            this.listView_middle.UseCompatibleStateImageBehavior = false;
            this.listView_middle.View = System.Windows.Forms.View.Details;
            // 
            // listView_small
            // 
            this.listView_small.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView_small.HideSelection = false;
            this.listView_small.Location = new System.Drawing.Point(426, 78);
            this.listView_small.Name = "listView_small";
            this.listView_small.Size = new System.Drawing.Size(160, 400);
            this.listView_small.TabIndex = 16;
            this.listView_small.UseCompatibleStateImageBehavior = false;
            this.listView_small.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "중분류목록";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "소분류목록";
            // 
            // button_del_middle
            // 
            this.button_del_middle.Location = new System.Drawing.Point(216, 487);
            this.button_del_middle.Name = "button_del_middle";
            this.button_del_middle.Size = new System.Drawing.Size(160, 48);
            this.button_del_middle.TabIndex = 19;
            this.button_del_middle.Text = "선택된중분류제거";
            this.button_del_middle.UseVisualStyleBackColor = true;
            this.button_del_middle.Click += new System.EventHandler(this.button_del_middle_Click);
            // 
            // button_del_small
            // 
            this.button_del_small.Location = new System.Drawing.Point(426, 487);
            this.button_del_small.Name = "button_del_small";
            this.button_del_small.Size = new System.Drawing.Size(160, 48);
            this.button_del_small.TabIndex = 20;
            this.button_del_small.Text = "선택된소분류제거";
            this.button_del_small.UseVisualStyleBackColor = true;
            this.button_del_small.Click += new System.EventHandler(this.button_del_small_Click);
            // 
            // button_modL
            // 
            this.button_modL.Location = new System.Drawing.Point(41, 550);
            this.button_modL.Name = "button_modL";
            this.button_modL.Size = new System.Drawing.Size(119, 48);
            this.button_modL.TabIndex = 21;
            this.button_modL.Text = "대분류수정";
            this.button_modL.UseVisualStyleBackColor = true;
            this.button_modL.Click += new System.EventHandler(this.button3_Click);
            // 
            // context
            // 
            this.context.Text = "대분류";
            this.context.Width = 135;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "중분류";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "소분류";
            this.columnHeader2.Width = 132;
            // 
            // button_modM
            // 
            this.button_modM.Location = new System.Drawing.Point(241, 550);
            this.button_modM.Name = "button_modM";
            this.button_modM.Size = new System.Drawing.Size(119, 48);
            this.button_modM.TabIndex = 22;
            this.button_modM.Text = "중분류수정";
            this.button_modM.UseVisualStyleBackColor = true;
            this.button_modM.Click += new System.EventHandler(this.button_modM_Click);
            // 
            // button_mods
            // 
            this.button_mods.Location = new System.Drawing.Point(441, 550);
            this.button_mods.Name = "button_mods";
            this.button_mods.Size = new System.Drawing.Size(119, 48);
            this.button_mods.TabIndex = 23;
            this.button_mods.Text = "소분류수정";
            this.button_mods.UseVisualStyleBackColor = true;
            this.button_mods.Click += new System.EventHandler(this.button_mods_Click);
            // 
            // button_rf
            // 
            this.button_rf.Location = new System.Drawing.Point(655, 376);
            this.button_rf.Name = "button_rf";
            this.button_rf.Size = new System.Drawing.Size(160, 48);
            this.button_rf.TabIndex = 24;
            this.button_rf.Text = "새로고침\r\n";
            this.button_rf.UseVisualStyleBackColor = true;
            this.button_rf.Click += new System.EventHandler(this.button_rf_Click);
            // 
            // mastertask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 629);
            this.Controls.Add(this.button_rf);
            this.Controls.Add(this.button_mods);
            this.Controls.Add(this.button_modM);
            this.Controls.Add(this.button_modL);
            this.Controls.Add(this.button_del_small);
            this.Controls.Add(this.button_del_middle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView_small);
            this.Controls.Add(this.listView_middle);
            this.Controls.Add(this.listView_large);
            this.Controls.Add(this.button_del_large);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "mastertask";
            this.Text = "업무마스터";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_add1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_adder;
        private System.Windows.Forms.Button button_addTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_del_large;
        private System.Windows.Forms.ListView listView_large;
        private System.Windows.Forms.ListView listView_middle;
        private System.Windows.Forms.ListView listView_small;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_del_middle;
        private System.Windows.Forms.Button button_del_small;
        private System.Windows.Forms.Button button_modL;
        private System.Windows.Forms.ColumnHeader context;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button_modM;
        private System.Windows.Forms.Button button_mods;
        private System.Windows.Forms.Button button_rf;
    }
}