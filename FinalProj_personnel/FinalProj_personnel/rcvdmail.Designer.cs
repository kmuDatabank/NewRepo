﻿namespace FinalProj_personnel
{
    partial class rcvdmail
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
            this.ListViewReceived = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonOpenMail = new System.Windows.Forms.Button();
            this.comboBox_search = new System.Windows.Forms.ComboBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.qtq123 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListViewReceived
            // 
            this.ListViewReceived.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Title,
            this.Content,
            this.Date,
            this.columnHeader1,
            this.columnHeader2,
            this.qtq123});
            this.ListViewReceived.HideSelection = false;
            this.ListViewReceived.Location = new System.Drawing.Point(12, 106);
            this.ListViewReceived.Name = "ListViewReceived";
            this.ListViewReceived.Size = new System.Drawing.Size(862, 410);
            this.ListViewReceived.TabIndex = 0;
            this.ListViewReceived.UseCompatibleStateImageBehavior = false;
            this.ListViewReceived.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "받는 사람";
            this.Name.Width = 101;
            // 
            // Title
            // 
            this.Title.Text = "제목";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Title.Width = 110;
            // 
            // Content
            // 
            this.Content.Text = "내용";
            this.Content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Content.Width = 250;
            // 
            // Date
            // 
            this.Date.Text = "수신 날짜";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 160;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "읽음여부";
            // 
            // ButtonOpenMail
            // 
            this.ButtonOpenMail.Location = new System.Drawing.Point(897, 12);
            this.ButtonOpenMail.Name = "ButtonOpenMail";
            this.ButtonOpenMail.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenMail.TabIndex = 1;
            this.ButtonOpenMail.Text = "확인";
            this.ButtonOpenMail.UseVisualStyleBackColor = true;
            this.ButtonOpenMail.Click += new System.EventHandler(this.ButtonOpenMail_Click);
            // 
            // comboBox_search
            // 
            this.comboBox_search.FormattingEnabled = true;
            this.comboBox_search.Items.AddRange(new object[] {
            "보낸사람",
            "제목",
            "내용"});
            this.comboBox_search.Location = new System.Drawing.Point(12, 35);
            this.comboBox_search.Name = "comboBox_search";
            this.comboBox_search.Size = new System.Drawing.Size(121, 20);
            this.comboBox_search.TabIndex = 2;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(190, 35);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(287, 21);
            this.textBox_search.TabIndex = 3;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(505, 35);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "검색";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // qtq123
            // 
            this.qtq123.Text = "보낸사람";
            // 
            // FormReceivedMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 549);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.comboBox_search);
            this.Controls.Add(this.ButtonOpenMail);
            this.Controls.Add(this.ListViewReceived);

            this.Text = "myrcvdmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewReceived;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Content;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Button ButtonOpenMail;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox comboBox_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ColumnHeader qtq123;
    }
}