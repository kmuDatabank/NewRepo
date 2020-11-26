namespace FinalProj_personnel
{
    partial class FormApprovallist
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonreturn = new System.Windows.Forms.Button();
            this.textBoxreturn = new System.Windows.Forms.TextBox();
            this.labelreturn = new System.Windows.Forms.Label();
            this.buttonappr = new System.Windows.Forms.Button();
            this.labelappr_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxret = new System.Windows.Forms.ListBox();
            this.listBoxapp = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxing = new System.Windows.Forms.ListBox();
            this.groupBoxSearch_work = new System.Windows.Forms.GroupBox();
            this.listBoxwork = new System.Windows.Forms.ListBox();
            this.groupBoxSarch_name = new System.Windows.Forms.GroupBox();
            this.listViewMyappr = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelname = new System.Windows.Forms.Label();
            this.labelwork = new System.Windows.Forms.Label();
            this.textBoxapptext = new System.Windows.Forms.TextBox();
            this.labelcomment = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSearch_work.SuspendLayout();
            this.groupBoxSarch_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelcomment);
            this.groupBox2.Controls.Add(this.textBoxapptext);
            this.groupBox2.Controls.Add(this.labelwork);
            this.groupBox2.Controls.Add(this.labelname);
            this.groupBox2.Controls.Add(this.buttonreturn);
            this.groupBox2.Controls.Add(this.textBoxreturn);
            this.groupBox2.Controls.Add(this.labelreturn);
            this.groupBox2.Controls.Add(this.buttonappr);
            this.groupBox2.Controls.Add(this.labelappr_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(691, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 509);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결재";
            // 
            // buttonreturn
            // 
            this.buttonreturn.Location = new System.Drawing.Point(184, 443);
            this.buttonreturn.Name = "buttonreturn";
            this.buttonreturn.Size = new System.Drawing.Size(101, 31);
            this.buttonreturn.TabIndex = 24;
            this.buttonreturn.Text = "결재 반려";
            this.buttonreturn.UseVisualStyleBackColor = true;
            this.buttonreturn.Click += new System.EventHandler(this.buttonreturn_Click);
            // 
            // textBoxreturn
            // 
            this.textBoxreturn.Location = new System.Drawing.Point(127, 405);
            this.textBoxreturn.Name = "textBoxreturn";
            this.textBoxreturn.Size = new System.Drawing.Size(158, 21);
            this.textBoxreturn.TabIndex = 23;
            // 
            // labelreturn
            // 
            this.labelreturn.AutoSize = true;
            this.labelreturn.Location = new System.Drawing.Point(22, 408);
            this.labelreturn.Name = "labelreturn";
            this.labelreturn.Size = new System.Drawing.Size(69, 12);
            this.labelreturn.TabIndex = 22;
            this.labelreturn.Text = "반려 코멘트";
            // 
            // buttonappr
            // 
            this.buttonappr.Location = new System.Drawing.Point(184, 346);
            this.buttonappr.Name = "buttonappr";
            this.buttonappr.Size = new System.Drawing.Size(101, 31);
            this.buttonappr.TabIndex = 20;
            this.buttonappr.Text = "결재 승인";
            this.buttonappr.UseVisualStyleBackColor = true;
            this.buttonappr.Click += new System.EventHandler(this.buttonappr_Click);
            // 
            // labelappr_name
            // 
            this.labelappr_name.AutoSize = true;
            this.labelappr_name.Location = new System.Drawing.Point(22, 23);
            this.labelappr_name.Name = "labelappr_name";
            this.labelappr_name.Size = new System.Drawing.Size(57, 12);
            this.labelappr_name.TabIndex = 12;
            this.labelappr_name.Text = "결재 제목";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "관련 업무";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "결재 내용";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "결재 코멘트";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.groupBox3);
            this.groupBoxSearch.Controls.Add(this.groupBox1);
            this.groupBoxSearch.Controls.Add(this.groupBoxSearch_work);
            this.groupBoxSearch.Controls.Add(this.groupBoxSarch_name);
            this.groupBoxSearch.Location = new System.Drawing.Point(15, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(670, 602);
            this.groupBoxSearch.TabIndex = 5;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "내 결재 리스트";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.listBoxret);
            this.groupBox3.Controls.Add(this.listBoxapp);
            this.groupBox3.Location = new System.Drawing.Point(334, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 276);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "결재 완료";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "결재 반려 목록";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "결재 승인 목록";
            // 
            // listBoxret
            // 
            this.listBoxret.FormattingEnabled = true;
            this.listBoxret.ItemHeight = 12;
            this.listBoxret.Location = new System.Drawing.Point(17, 162);
            this.listBoxret.Name = "listBoxret";
            this.listBoxret.Size = new System.Drawing.Size(274, 100);
            this.listBoxret.TabIndex = 15;
            this.listBoxret.SelectedIndexChanged += new System.EventHandler(this.listBoxret_SelectedIndexChanged);
            // 
            // listBoxapp
            // 
            this.listBoxapp.FormattingEnabled = true;
            this.listBoxapp.ItemHeight = 12;
            this.listBoxapp.Location = new System.Drawing.Point(17, 35);
            this.listBoxapp.Name = "listBoxapp";
            this.listBoxapp.Size = new System.Drawing.Size(274, 100);
            this.listBoxapp.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxing);
            this.groupBox1.Location = new System.Drawing.Point(334, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 281);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "결재중";
            // 
            // listBoxing
            // 
            this.listBoxing.FormattingEnabled = true;
            this.listBoxing.ItemHeight = 12;
            this.listBoxing.Location = new System.Drawing.Point(17, 23);
            this.listBoxing.Name = "listBoxing";
            this.listBoxing.Size = new System.Drawing.Size(274, 244);
            this.listBoxing.TabIndex = 14;
            // 
            // groupBoxSearch_work
            // 
            this.groupBoxSearch_work.Controls.Add(this.listBoxwork);
            this.groupBoxSearch_work.Location = new System.Drawing.Point(7, 312);
            this.groupBoxSearch_work.Name = "groupBoxSearch_work";
            this.groupBoxSearch_work.Size = new System.Drawing.Size(310, 281);
            this.groupBoxSearch_work.TabIndex = 17;
            this.groupBoxSearch_work.TabStop = false;
            this.groupBoxSearch_work.Text = "결재 해야 할 업무 리스트";
            // 
            // listBoxwork
            // 
            this.listBoxwork.FormattingEnabled = true;
            this.listBoxwork.ItemHeight = 12;
            this.listBoxwork.Location = new System.Drawing.Point(17, 23);
            this.listBoxwork.Name = "listBoxwork";
            this.listBoxwork.Size = new System.Drawing.Size(263, 244);
            this.listBoxwork.TabIndex = 14;
            this.listBoxwork.SelectedIndexChanged += new System.EventHandler(this.listBoxwork_SelectedIndexChanged);
            // 
            // groupBoxSarch_name
            // 
            this.groupBoxSarch_name.Controls.Add(this.listViewMyappr);
            this.groupBoxSarch_name.Location = new System.Drawing.Point(7, 21);
            this.groupBoxSarch_name.Name = "groupBoxSarch_name";
            this.groupBoxSarch_name.Size = new System.Drawing.Size(310, 283);
            this.groupBoxSarch_name.TabIndex = 0;
            this.groupBoxSarch_name.TabStop = false;
            this.groupBoxSarch_name.Text = "내가 등록한 결재";
            // 
            // listViewMyappr
            // 
            this.listViewMyappr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewMyappr.HideSelection = false;
            this.listViewMyappr.Location = new System.Drawing.Point(17, 25);
            this.listViewMyappr.Name = "listViewMyappr";
            this.listViewMyappr.Size = new System.Drawing.Size(272, 244);
            this.listViewMyappr.TabIndex = 0;
            this.listViewMyappr.UseCompatibleStateImageBehavior = false;
            this.listViewMyappr.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "결재 재목";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "진행 단계";
            this.columnHeader2.Width = 115;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(156, 23);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(0, 12);
            this.labelname.TabIndex = 18;
            // 
            // labelwork
            // 
            this.labelwork.AutoSize = true;
            this.labelwork.Location = new System.Drawing.Point(156, 63);
            this.labelwork.Name = "labelwork";
            this.labelwork.Size = new System.Drawing.Size(0, 12);
            this.labelwork.TabIndex = 25;
            // 
            // textBoxapptext
            // 
            this.textBoxapptext.Location = new System.Drawing.Point(127, 101);
            this.textBoxapptext.Multiline = true;
            this.textBoxapptext.Name = "textBoxapptext";
            this.textBoxapptext.Size = new System.Drawing.Size(158, 179);
            this.textBoxapptext.TabIndex = 26;
            // 
            // labelcomment
            // 
            this.labelcomment.AutoSize = true;
            this.labelcomment.Location = new System.Drawing.Point(156, 312);
            this.labelcomment.Name = "labelcomment";
            this.labelcomment.Size = new System.Drawing.Size(0, 12);
            this.labelcomment.TabIndex = 27;
            // 
            // FormApprovallist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxSearch);
            this.Name = "FormApprovallist";
            this.Text = "결재 리스트";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxSearch_work.ResumeLayout(false);
            this.groupBoxSarch_name.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonreturn;
        private System.Windows.Forms.TextBox textBoxreturn;
        private System.Windows.Forms.Label labelreturn;
        private System.Windows.Forms.Button buttonappr;
        private System.Windows.Forms.Label labelappr_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxing;
        private System.Windows.Forms.GroupBox groupBoxSearch_work;
        private System.Windows.Forms.ListBox listBoxwork;
        private System.Windows.Forms.GroupBox groupBoxSarch_name;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxapp;
        private System.Windows.Forms.ListView listViewMyappr;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxret;
        private System.Windows.Forms.TextBox textBoxapptext;
        private System.Windows.Forms.Label labelwork;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelcomment;
    }
}