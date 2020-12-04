namespace FinalProj_personnel
{
    partial class tasksearcher
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
            this.comboBox_searchkeyword = new System.Windows.Forms.ComboBox();
            this.textBox_searchtext = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_listdel = new System.Windows.Forms.Button();
            this.button_mod = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_afteretime = new System.Windows.Forms.TextBox();
            this.textBox_afterstime = new System.Windows.Forms.TextBox();
            this.textBox_before_etime = new System.Windows.Forms.TextBox();
            this.textBox_beforestime = new System.Windows.Forms.TextBox();
            this.textBox_mafter_date = new System.Windows.Forms.TextBox();
            this.textBox_mafter_name = new System.Windows.Forms.TextBox();
            this.textBox_madate_before = new System.Windows.Forms.TextBox();
            this.textBox_mnamebefore = new System.Windows.Forms.TextBox();
            this.comboBox_mafter_smallcate = new System.Windows.Forms.ComboBox();
            this.comboBox_mafter_middlecate_ = new System.Windows.Forms.ComboBox();
            this.comboBox_mafter_largecate = new System.Windows.Forms.ComboBox();
            this.comboBox_msmall_before = new System.Windows.Forms.ComboBox();
            this.comboBox_mmiddle_before = new System.Windows.Forms.ComboBox();
            this.comboBox_mlarge_before = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_ref = new System.Windows.Forms.Button();
            this.listView_search = new System.Windows.Forms.ListView();
            this.name_task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.large_cate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.middle_cate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.small_cate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.etime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_idvalue = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_searchkeyword
            // 
            this.comboBox_searchkeyword.FormattingEnabled = true;
            this.comboBox_searchkeyword.Items.AddRange(new object[] {
            "날짜기반검색",
            "사용자기반검색",
            "업무키워드기반검색"});
            this.comboBox_searchkeyword.Location = new System.Drawing.Point(44, 33);
            this.comboBox_searchkeyword.Name = "comboBox_searchkeyword";
            this.comboBox_searchkeyword.Size = new System.Drawing.Size(180, 20);
            this.comboBox_searchkeyword.TabIndex = 0;
            // 
            // textBox_searchtext
            // 
            this.textBox_searchtext.Location = new System.Drawing.Point(246, 33);
            this.textBox_searchtext.Name = "textBox_searchtext";
            this.textBox_searchtext.Size = new System.Drawing.Size(187, 21);
            this.textBox_searchtext.TabIndex = 1;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(454, 34);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "검색하기";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "일일업무 검색하기";
            // 
            // button_listdel
            // 
            this.button_listdel.Location = new System.Drawing.Point(564, 405);
            this.button_listdel.Name = "button_listdel";
            this.button_listdel.Size = new System.Drawing.Size(95, 43);
            this.button_listdel.TabIndex = 5;
            this.button_listdel.Text = "삭제";
            this.button_listdel.UseVisualStyleBackColor = true;
            this.button_listdel.Click += new System.EventHandler(this.button_listdel_Click);
            // 
            // button_mod
            // 
            this.button_mod.Location = new System.Drawing.Point(118, 437);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(75, 23);
            this.button_mod.TabIndex = 6;
            this.button_mod.Text = "수정하기";
            this.button_mod.UseVisualStyleBackColor = true;
            this.button_mod.Click += new System.EventHandler(this.button_mod_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox_idvalue);
            this.groupBox1.Controls.Add(this.textBox_afteretime);
            this.groupBox1.Controls.Add(this.textBox_afterstime);
            this.groupBox1.Controls.Add(this.textBox_before_etime);
            this.groupBox1.Controls.Add(this.textBox_beforestime);
            this.groupBox1.Controls.Add(this.textBox_mafter_date);
            this.groupBox1.Controls.Add(this.textBox_mafter_name);
            this.groupBox1.Controls.Add(this.textBox_madate_before);
            this.groupBox1.Controls.Add(this.textBox_mnamebefore);
            this.groupBox1.Controls.Add(this.comboBox_mafter_smallcate);
            this.groupBox1.Controls.Add(this.comboBox_mafter_middlecate_);
            this.groupBox1.Controls.Add(this.comboBox_mafter_largecate);
            this.groupBox1.Controls.Add(this.comboBox_msmall_before);
            this.groupBox1.Controls.Add(this.button_mod);
            this.groupBox1.Controls.Add(this.comboBox_mmiddle_before);
            this.groupBox1.Controls.Add(this.comboBox_mlarge_before);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(828, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 485);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "수정하기";
            // 
            // textBox_afteretime
            // 
            this.textBox_afteretime.Location = new System.Drawing.Point(183, 365);
            this.textBox_afteretime.Name = "textBox_afteretime";
            this.textBox_afteretime.Size = new System.Drawing.Size(120, 21);
            this.textBox_afteretime.TabIndex = 39;
            // 
            // textBox_afterstime
            // 
            this.textBox_afterstime.Location = new System.Drawing.Point(183, 318);
            this.textBox_afterstime.Name = "textBox_afterstime";
            this.textBox_afterstime.Size = new System.Drawing.Size(120, 21);
            this.textBox_afterstime.TabIndex = 38;
            // 
            // textBox_before_etime
            // 
            this.textBox_before_etime.Location = new System.Drawing.Point(18, 365);
            this.textBox_before_etime.Name = "textBox_before_etime";
            this.textBox_before_etime.Size = new System.Drawing.Size(120, 21);
            this.textBox_before_etime.TabIndex = 37;
            // 
            // textBox_beforestime
            // 
            this.textBox_beforestime.Location = new System.Drawing.Point(19, 318);
            this.textBox_beforestime.Name = "textBox_beforestime";
            this.textBox_beforestime.Size = new System.Drawing.Size(120, 21);
            this.textBox_beforestime.TabIndex = 36;
            // 
            // textBox_mafter_date
            // 
            this.textBox_mafter_date.Location = new System.Drawing.Point(184, 120);
            this.textBox_mafter_date.Name = "textBox_mafter_date";
            this.textBox_mafter_date.Size = new System.Drawing.Size(120, 21);
            this.textBox_mafter_date.TabIndex = 35;
            // 
            // textBox_mafter_name
            // 
            this.textBox_mafter_name.Location = new System.Drawing.Point(184, 57);
            this.textBox_mafter_name.Name = "textBox_mafter_name";
            this.textBox_mafter_name.Size = new System.Drawing.Size(120, 21);
            this.textBox_mafter_name.TabIndex = 34;
            // 
            // textBox_madate_before
            // 
            this.textBox_madate_before.Location = new System.Drawing.Point(18, 120);
            this.textBox_madate_before.Name = "textBox_madate_before";
            this.textBox_madate_before.Size = new System.Drawing.Size(121, 21);
            this.textBox_madate_before.TabIndex = 33;
            // 
            // textBox_mnamebefore
            // 
            this.textBox_mnamebefore.Location = new System.Drawing.Point(18, 57);
            this.textBox_mnamebefore.Name = "textBox_mnamebefore";
            this.textBox_mnamebefore.Size = new System.Drawing.Size(120, 21);
            this.textBox_mnamebefore.TabIndex = 32;
            // 
            // comboBox_mafter_smallcate
            // 
            this.comboBox_mafter_smallcate.FormattingEnabled = true;
            this.comboBox_mafter_smallcate.Location = new System.Drawing.Point(184, 275);
            this.comboBox_mafter_smallcate.Name = "comboBox_mafter_smallcate";
            this.comboBox_mafter_smallcate.Size = new System.Drawing.Size(121, 20);
            this.comboBox_mafter_smallcate.TabIndex = 17;
            // 
            // comboBox_mafter_middlecate_
            // 
            this.comboBox_mafter_middlecate_.FormattingEnabled = true;
            this.comboBox_mafter_middlecate_.Location = new System.Drawing.Point(184, 231);
            this.comboBox_mafter_middlecate_.Name = "comboBox_mafter_middlecate_";
            this.comboBox_mafter_middlecate_.Size = new System.Drawing.Size(121, 20);
            this.comboBox_mafter_middlecate_.TabIndex = 16;
            // 
            // comboBox_mafter_largecate
            // 
            this.comboBox_mafter_largecate.FormattingEnabled = true;
            this.comboBox_mafter_largecate.Location = new System.Drawing.Point(183, 196);
            this.comboBox_mafter_largecate.Name = "comboBox_mafter_largecate";
            this.comboBox_mafter_largecate.Size = new System.Drawing.Size(121, 20);
            this.comboBox_mafter_largecate.TabIndex = 15;
            // 
            // comboBox_msmall_before
            // 
            this.comboBox_msmall_before.FormattingEnabled = true;
            this.comboBox_msmall_before.Location = new System.Drawing.Point(18, 275);
            this.comboBox_msmall_before.Name = "comboBox_msmall_before";
            this.comboBox_msmall_before.Size = new System.Drawing.Size(121, 20);
            this.comboBox_msmall_before.TabIndex = 12;
            // 
            // comboBox_mmiddle_before
            // 
            this.comboBox_mmiddle_before.FormattingEnabled = true;
            this.comboBox_mmiddle_before.Location = new System.Drawing.Point(18, 231);
            this.comboBox_mmiddle_before.Name = "comboBox_mmiddle_before";
            this.comboBox_mmiddle_before.Size = new System.Drawing.Size(121, 20);
            this.comboBox_mmiddle_before.TabIndex = 11;
            // 
            // comboBox_mlarge_before
            // 
            this.comboBox_mlarge_before.FormattingEnabled = true;
            this.comboBox_mlarge_before.Location = new System.Drawing.Point(18, 196);
            this.comboBox_mlarge_before.Name = "comboBox_mlarge_before";
            this.comboBox_mlarge_before.Size = new System.Drawing.Size(121, 20);
            this.comboBox_mlarge_before.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "변경후";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "변경전";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd-tt HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(847, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // button_ref
            // 
            this.button_ref.Location = new System.Drawing.Point(44, 502);
            this.button_ref.Name = "button_ref";
            this.button_ref.Size = new System.Drawing.Size(145, 45);
            this.button_ref.TabIndex = 10;
            this.button_ref.Text = "새로고침";
            this.button_ref.UseVisualStyleBackColor = true;
            this.button_ref.Click += new System.EventHandler(this.button_ref_Click);
            // 
            // listView_search
            // 
            this.listView_search.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_task,
            this.date,
            this.large_cate,
            this.middle_cate,
            this.small_cate,
            this.stime,
            this.etime,
            this.ID});
            this.listView_search.FullRowSelect = true;
            this.listView_search.GridLines = true;
            this.listView_search.HideSelection = false;
            this.listView_search.Location = new System.Drawing.Point(44, 69);
            this.listView_search.Margin = new System.Windows.Forms.Padding(2);
            this.listView_search.Name = "listView_search";
            this.listView_search.Size = new System.Drawing.Size(779, 331);
            this.listView_search.TabIndex = 31;
            this.listView_search.UseCompatibleStateImageBehavior = false;
            this.listView_search.View = System.Windows.Forms.View.Details;
            this.listView_search.Click += new System.EventHandler(this.listView_search_Click);
            // 
            // name_task
            // 
            this.name_task.Text = "name";
            this.name_task.Width = 74;
            // 
            // date
            // 
            this.date.Text = "date";
            this.date.Width = 143;
            // 
            // large_cate
            // 
            this.large_cate.Text = "large_cate";
            this.large_cate.Width = 113;
            // 
            // middle_cate
            // 
            this.middle_cate.Text = "middle_cate";
            this.middle_cate.Width = 118;
            // 
            // small_cate
            // 
            this.small_cate.Text = "small_cate";
            this.small_cate.Width = 101;
            // 
            // stime
            // 
            this.stime.Text = "stime";
            this.stime.Width = 78;
            // 
            // etime
            // 
            this.etime.Text = "etime";
            this.etime.Width = 81;
            // 
            // ID
            // 
            this.ID.Text = "IDvalue";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "날짜검색시 오늘 날짜불러오기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_idvalue
            // 
            this.textBox_idvalue.Location = new System.Drawing.Point(19, 410);
            this.textBox_idvalue.Name = "textBox_idvalue";
            this.textBox_idvalue.Size = new System.Drawing.Size(257, 21);
            this.textBox_idvalue.TabIndex = 40;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(144, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 23);
            this.button5.TabIndex = 42;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(146, 272);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 23);
            this.button6.TabIndex = 43;
            this.button6.Text = ">>";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(146, 316);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 23);
            this.button7.TabIndex = 44;
            this.button7.Text = ">>";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(146, 363);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 23);
            this.button8.TabIndex = 45;
            this.button8.Text = ">>";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "날짜계산은 일단위까지 적용됩니다.";
            // 
            // tasksearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 610);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView_search);
            this.Controls.Add(this.button_ref);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_listdel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_searchtext);
            this.Controls.Add(this.comboBox_searchkeyword);
            this.Name = "tasksearcher";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_searchkeyword;
        private System.Windows.Forms.TextBox textBox_searchtext;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_listdel;
        private System.Windows.Forms.Button button_mod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_mafter_smallcate;
        private System.Windows.Forms.ComboBox comboBox_mafter_middlecate_;
        private System.Windows.Forms.ComboBox comboBox_mafter_largecate;
        private System.Windows.Forms.ComboBox comboBox_msmall_before;
        private System.Windows.Forms.ComboBox comboBox_mmiddle_before;
        private System.Windows.Forms.ComboBox comboBox_mlarge_before;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_ref;
        private System.Windows.Forms.ListView listView_search;
        private System.Windows.Forms.ColumnHeader name_task;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader large_cate;
        private System.Windows.Forms.ColumnHeader middle_cate;
        private System.Windows.Forms.ColumnHeader small_cate;
        private System.Windows.Forms.ColumnHeader stime;
        private System.Windows.Forms.ColumnHeader etime;
        private System.Windows.Forms.TextBox textBox_mafter_date;
        private System.Windows.Forms.TextBox textBox_mafter_name;
        private System.Windows.Forms.TextBox textBox_madate_before;
        private System.Windows.Forms.TextBox textBox_mnamebefore;
        private System.Windows.Forms.TextBox textBox_afteretime;
        private System.Windows.Forms.TextBox textBox_afterstime;
        private System.Windows.Forms.TextBox textBox_before_etime;
        private System.Windows.Forms.TextBox textBox_beforestime;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_idvalue;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}