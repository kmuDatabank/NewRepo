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
            this.listView_large = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_modbefore = new System.Windows.Forms.ComboBox();
            this.comboBox_modafter = new System.Windows.Forms.ComboBox();
            this.textBox_modbefore = new System.Windows.Forms.TextBox();
            this.textBox_modafter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_del = new System.Windows.Forms.Button();
            this.button_mod = new System.Windows.Forms.Button();
            this.large_category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.middle_category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.small_category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            "대분류",
            "중분류",
            "소분류"});
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
            this.groupBox1.Size = new System.Drawing.Size(326, 229);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "업무등록";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "분류목록";
            // 
            // listView_large
            // 
            this.listView_large.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.large_category,
            this.middle_category,
            this.small_category});
            this.listView_large.HideSelection = false;
            this.listView_large.Location = new System.Drawing.Point(12, 81);
            this.listView_large.Name = "listView_large";
            this.listView_large.Size = new System.Drawing.Size(577, 447);
            this.listView_large.TabIndex = 9;
            this.listView_large.UseCompatibleStateImageBehavior = false;
            this.listView_large.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_mod);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_modafter);
            this.groupBox2.Controls.Add(this.textBox_modbefore);
            this.groupBox2.Controls.Add(this.comboBox_modafter);
            this.groupBox2.Controls.Add(this.comboBox_modbefore);
            this.groupBox2.Location = new System.Drawing.Point(677, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 215);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "선택수정,";
            // 
            // comboBox_modbefore
            // 
            this.comboBox_modbefore.FormattingEnabled = true;
            this.comboBox_modbefore.Items.AddRange(new object[] {
            "대분류",
            "중분류",
            "소분류"});
            this.comboBox_modbefore.Location = new System.Drawing.Point(6, 50);
            this.comboBox_modbefore.Name = "comboBox_modbefore";
            this.comboBox_modbefore.Size = new System.Drawing.Size(99, 20);
            this.comboBox_modbefore.TabIndex = 2;
            // 
            // comboBox_modafter
            // 
            this.comboBox_modafter.FormattingEnabled = true;
            this.comboBox_modafter.Items.AddRange(new object[] {
            "대분류",
            "중분류",
            "소분류"});
            this.comboBox_modafter.Location = new System.Drawing.Point(145, 50);
            this.comboBox_modafter.Name = "comboBox_modafter";
            this.comboBox_modafter.Size = new System.Drawing.Size(121, 20);
            this.comboBox_modafter.TabIndex = 3;
            // 
            // textBox_modbefore
            // 
            this.textBox_modbefore.Location = new System.Drawing.Point(6, 97);
            this.textBox_modbefore.Multiline = true;
            this.textBox_modbefore.Name = "textBox_modbefore";
            this.textBox_modbefore.Size = new System.Drawing.Size(99, 28);
            this.textBox_modbefore.TabIndex = 4;
            // 
            // textBox_modafter
            // 
            this.textBox_modafter.Location = new System.Drawing.Point(145, 97);
            this.textBox_modafter.Multiline = true;
            this.textBox_modafter.Name = "textBox_modafter";
            this.textBox_modafter.Size = new System.Drawing.Size(121, 28);
            this.textBox_modafter.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "변경전";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "변경뒤";
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(29, 545);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(119, 48);
            this.button_del.TabIndex = 13;
            this.button_del.Text = "선택된분류제거";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_mod
            // 
            this.button_mod.Location = new System.Drawing.Point(90, 175);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(75, 23);
            this.button_mod.TabIndex = 14;
            this.button_mod.Text = "수정하기";
            this.button_mod.UseVisualStyleBackColor = true;
            this.button_mod.Click += new System.EventHandler(this.button_mod_Click);
            // 
            // large_category
            // 
            this.large_category.Text = "대분류";
            this.large_category.Width = 136;
            // 
            // middle_category
            // 
            this.middle_category.Text = "중분류";
            this.middle_category.Width = 151;
            // 
            // small_category
            // 
            this.small_category.Text = "소분류";
            this.small_category.Width = 156;
            // 
            // mastertask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 629);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView_large);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "mastertask";
            this.Text = "업무마스터";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ListView listView_large;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_modbefore;
        private System.Windows.Forms.TextBox textBox_modafter;
        private System.Windows.Forms.TextBox textBox_modbefore;
        private System.Windows.Forms.ComboBox comboBox_modafter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_mod;
        private System.Windows.Forms.ColumnHeader large_category;
        private System.Windows.Forms.ColumnHeader middle_category;
        private System.Windows.Forms.ColumnHeader small_category;
    }
}