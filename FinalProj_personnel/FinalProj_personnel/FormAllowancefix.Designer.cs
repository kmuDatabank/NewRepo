namespace FinalProj_personnel
{
    partial class FormAllowancefix
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxn = new System.Windows.Forms.TextBox();
            this.buttons = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxh = new System.Windows.Forms.TextBox();
            this.textBoxnw = new System.Windows.Forms.TextBox();
            this.buttonc = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxadd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(355, 421);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "날짜";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "휴일수당";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "야근수당";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBoxn
            // 
            this.textBoxn.Location = new System.Drawing.Point(164, 18);
            this.textBoxn.Name = "textBoxn";
            this.textBoxn.Size = new System.Drawing.Size(100, 21);
            this.textBoxn.TabIndex = 2;
            // 
            // buttons
            // 
            this.buttons.Location = new System.Drawing.Point(270, 18);
            this.buttons.Name = "buttons";
            this.buttons.Size = new System.Drawing.Size(75, 23);
            this.buttons.TabIndex = 3;
            this.buttons.Text = "검색";
            this.buttons.UseVisualStyleBackColor = true;
            this.buttons.Click += new System.EventHandler(this.buttons_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "날짜";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "휴일수당";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "야근수당";
            // 
            // textBoxh
            // 
            this.textBoxh.Location = new System.Drawing.Point(515, 162);
            this.textBoxh.Name = "textBoxh";
            this.textBoxh.Size = new System.Drawing.Size(100, 21);
            this.textBoxh.TabIndex = 9;
            // 
            // textBoxnw
            // 
            this.textBoxnw.Location = new System.Drawing.Point(515, 223);
            this.textBoxnw.Name = "textBoxnw";
            this.textBoxnw.Size = new System.Drawing.Size(100, 21);
            this.textBoxnw.TabIndex = 10;
            // 
            // buttonc
            // 
            this.buttonc.Location = new System.Drawing.Point(478, 329);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(75, 23);
            this.buttonc.TabIndex = 11;
            this.buttonc.Text = "변경";
            this.buttonc.UseVisualStyleBackColor = true;
            this.buttonc.Click += new System.EventHandler(this.buttonc_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "연장근로";
            // 
            // textBoxadd
            // 
            this.textBoxadd.Location = new System.Drawing.Point(515, 284);
            this.textBoxadd.Name = "textBoxadd";
            this.textBoxadd.Size = new System.Drawing.Size(100, 21);
            this.textBoxadd.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "연장근로";
            // 
            // FormAllowancefix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 498);
            this.Controls.Add(this.textBoxadd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonc);
            this.Controls.Add(this.textBoxnw);
            this.Controls.Add(this.textBoxh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttons);
            this.Controls.Add(this.textBoxn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView1);
            this.Name = "FormAllowancefix";
            this.Text = "수당수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxn;
        private System.Windows.Forms.Button buttons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxh;
        private System.Windows.Forms.TextBox textBoxnw;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBoxadd;
        private System.Windows.Forms.Label label6;
    }
}