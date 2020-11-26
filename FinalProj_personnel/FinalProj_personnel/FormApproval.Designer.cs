namespace FinalProj_personnel
{
    partial class FormApproval
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelRank = new System.Windows.Forms.Label();
            this.groupBoxnewAppr = new System.Windows.Forms.GroupBox();
            this.comboBoxappr2 = new System.Windows.Forms.ComboBox();
            this.comboBoxappr1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonnewappr = new System.Windows.Forms.Button();
            this.comboBoxnewappr_work = new System.Windows.Forms.ComboBox();
            this.textBoxnewappr_comment = new System.Windows.Forms.TextBox();
            this.textBoxnewappr_text = new System.Windows.Forms.TextBox();
            this.textBoxnewappr_name = new System.Windows.Forms.TextBox();
            this.labelnewappr_comment = new System.Windows.Forms.Label();
            this.labelnewappr_text = new System.Windows.Forms.Label();
            this.labelnewappr_work = new System.Windows.Forms.Label();
            this.labelnewappr_name = new System.Windows.Forms.Label();
            this.buttonsearchappr = new System.Windows.Forms.Button();
            this.labelapname = new System.Windows.Forms.Label();
            this.labelaprank = new System.Windows.Forms.Label();
            this.groupBoxnewAppr.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "이름";
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.Location = new System.Drawing.Point(13, 48);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(29, 12);
            this.labelRank.TabIndex = 1;
            this.labelRank.Text = "직급";
            // 
            // groupBoxnewAppr
            // 
            this.groupBoxnewAppr.Controls.Add(this.comboBoxappr2);
            this.groupBoxnewAppr.Controls.Add(this.comboBoxappr1);
            this.groupBoxnewAppr.Controls.Add(this.label6);
            this.groupBoxnewAppr.Controls.Add(this.label5);
            this.groupBoxnewAppr.Controls.Add(this.buttonnewappr);
            this.groupBoxnewAppr.Controls.Add(this.comboBoxnewappr_work);
            this.groupBoxnewAppr.Controls.Add(this.textBoxnewappr_comment);
            this.groupBoxnewAppr.Controls.Add(this.textBoxnewappr_text);
            this.groupBoxnewAppr.Controls.Add(this.textBoxnewappr_name);
            this.groupBoxnewAppr.Controls.Add(this.labelnewappr_comment);
            this.groupBoxnewAppr.Controls.Add(this.labelnewappr_text);
            this.groupBoxnewAppr.Controls.Add(this.labelnewappr_work);
            this.groupBoxnewAppr.Controls.Add(this.labelnewappr_name);
            this.groupBoxnewAppr.Location = new System.Drawing.Point(15, 79);
            this.groupBoxnewAppr.Name = "groupBoxnewAppr";
            this.groupBoxnewAppr.Size = new System.Drawing.Size(323, 517);
            this.groupBoxnewAppr.TabIndex = 2;
            this.groupBoxnewAppr.TabStop = false;
            this.groupBoxnewAppr.Text = "신규 결재 작성";
            // 
            // comboBoxappr2
            // 
            this.comboBoxappr2.FormattingEnabled = true;
            this.comboBoxappr2.Location = new System.Drawing.Point(127, 407);
            this.comboBoxappr2.Name = "comboBoxappr2";
            this.comboBoxappr2.Size = new System.Drawing.Size(158, 20);
            this.comboBoxappr2.TabIndex = 15;
            // 
            // comboBoxappr1
            // 
            this.comboBoxappr1.FormattingEnabled = true;
            this.comboBoxappr1.Location = new System.Drawing.Point(127, 369);
            this.comboBoxappr1.Name = "comboBoxappr1";
            this.comboBoxappr1.Size = new System.Drawing.Size(158, 20);
            this.comboBoxappr1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "결재자 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "결재자 1";
            // 
            // buttonnewappr
            // 
            this.buttonnewappr.Location = new System.Drawing.Point(95, 462);
            this.buttonnewappr.Name = "buttonnewappr";
            this.buttonnewappr.Size = new System.Drawing.Size(101, 31);
            this.buttonnewappr.TabIndex = 11;
            this.buttonnewappr.Text = "결재 등록";
            this.buttonnewappr.UseVisualStyleBackColor = true;
            this.buttonnewappr.Click += new System.EventHandler(this.buttonnewappr_Click);
            // 
            // comboBoxnewappr_work
            // 
            this.comboBoxnewappr_work.FormattingEnabled = true;
            this.comboBoxnewappr_work.Location = new System.Drawing.Point(127, 81);
            this.comboBoxnewappr_work.Name = "comboBoxnewappr_work";
            this.comboBoxnewappr_work.Size = new System.Drawing.Size(158, 20);
            this.comboBoxnewappr_work.TabIndex = 10;
            // 
            // textBoxnewappr_comment
            // 
            this.textBoxnewappr_comment.Location = new System.Drawing.Point(127, 327);
            this.textBoxnewappr_comment.Name = "textBoxnewappr_comment";
            this.textBoxnewappr_comment.Size = new System.Drawing.Size(158, 21);
            this.textBoxnewappr_comment.TabIndex = 9;
            // 
            // textBoxnewappr_text
            // 
            this.textBoxnewappr_text.Location = new System.Drawing.Point(127, 125);
            this.textBoxnewappr_text.Multiline = true;
            this.textBoxnewappr_text.Name = "textBoxnewappr_text";
            this.textBoxnewappr_text.Size = new System.Drawing.Size(158, 185);
            this.textBoxnewappr_text.TabIndex = 8;
            // 
            // textBoxnewappr_name
            // 
            this.textBoxnewappr_name.Location = new System.Drawing.Point(127, 38);
            this.textBoxnewappr_name.Name = "textBoxnewappr_name";
            this.textBoxnewappr_name.Size = new System.Drawing.Size(158, 21);
            this.textBoxnewappr_name.TabIndex = 7;
            // 
            // labelnewappr_comment
            // 
            this.labelnewappr_comment.AutoSize = true;
            this.labelnewappr_comment.Location = new System.Drawing.Point(22, 330);
            this.labelnewappr_comment.Name = "labelnewappr_comment";
            this.labelnewappr_comment.Size = new System.Drawing.Size(69, 12);
            this.labelnewappr_comment.TabIndex = 6;
            this.labelnewappr_comment.Text = "결재 코멘트";
            // 
            // labelnewappr_text
            // 
            this.labelnewappr_text.AutoSize = true;
            this.labelnewappr_text.Location = new System.Drawing.Point(22, 128);
            this.labelnewappr_text.Name = "labelnewappr_text";
            this.labelnewappr_text.Size = new System.Drawing.Size(57, 12);
            this.labelnewappr_text.TabIndex = 5;
            this.labelnewappr_text.Text = "결재 내용";
            // 
            // labelnewappr_work
            // 
            this.labelnewappr_work.AutoSize = true;
            this.labelnewappr_work.Location = new System.Drawing.Point(22, 81);
            this.labelnewappr_work.Name = "labelnewappr_work";
            this.labelnewappr_work.Size = new System.Drawing.Size(57, 12);
            this.labelnewappr_work.TabIndex = 4;
            this.labelnewappr_work.Text = "관련 업무";
            // 
            // labelnewappr_name
            // 
            this.labelnewappr_name.AutoSize = true;
            this.labelnewappr_name.Location = new System.Drawing.Point(22, 41);
            this.labelnewappr_name.Name = "labelnewappr_name";
            this.labelnewappr_name.Size = new System.Drawing.Size(57, 12);
            this.labelnewappr_name.TabIndex = 3;
            this.labelnewappr_name.Text = "결재 제목";
            // 
            // buttonsearchappr
            // 
            this.buttonsearchappr.Location = new System.Drawing.Point(238, 24);
            this.buttonsearchappr.Name = "buttonsearchappr";
            this.buttonsearchappr.Size = new System.Drawing.Size(100, 23);
            this.buttonsearchappr.TabIndex = 3;
            this.buttonsearchappr.Text = "내 결재 리스트";
            this.buttonsearchappr.UseVisualStyleBackColor = true;
            this.buttonsearchappr.Click += new System.EventHandler(this.buttonsearchappr_Click);
            // 
            // labelapname
            // 
            this.labelapname.AutoSize = true;
            this.labelapname.Location = new System.Drawing.Point(68, 13);
            this.labelapname.Name = "labelapname";
            this.labelapname.Size = new System.Drawing.Size(64, 12);
            this.labelapname.TabIndex = 4;
            this.labelapname.Text = "labelname";
            // 
            // labelaprank
            // 
            this.labelaprank.AutoSize = true;
            this.labelaprank.Location = new System.Drawing.Point(68, 48);
            this.labelaprank.Name = "labelaprank";
            this.labelaprank.Size = new System.Drawing.Size(56, 12);
            this.labelaprank.TabIndex = 5;
            this.labelaprank.Text = "labelrank";
            // 
            // FormApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 608);
            this.Controls.Add(this.labelaprank);
            this.Controls.Add(this.labelapname);
            this.Controls.Add(this.buttonsearchappr);
            this.Controls.Add(this.groupBoxnewAppr);
            this.Controls.Add(this.labelRank);
            this.Controls.Add(this.labelName);
            this.Name = "FormApproval";
            this.Text = "결재";
            this.groupBoxnewAppr.ResumeLayout(false);
            this.groupBoxnewAppr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.GroupBox groupBoxnewAppr;
        private System.Windows.Forms.Label labelnewappr_comment;
        private System.Windows.Forms.Label labelnewappr_text;
        private System.Windows.Forms.Label labelnewappr_work;
        private System.Windows.Forms.Label labelnewappr_name;
        private System.Windows.Forms.Button buttonnewappr;
        private System.Windows.Forms.ComboBox comboBoxnewappr_work;
        private System.Windows.Forms.TextBox textBoxnewappr_comment;
        private System.Windows.Forms.TextBox textBoxnewappr_text;
        private System.Windows.Forms.TextBox textBoxnewappr_name;
        private System.Windows.Forms.ComboBox comboBoxappr2;
        private System.Windows.Forms.ComboBox comboBoxappr1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonsearchappr;
        private System.Windows.Forms.Label labelapname;
        private System.Windows.Forms.Label labelaprank;
    }
}