namespace FinalProj_personnel
{
    partial class FormSendMail
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.ComboBoxTo = new System.Windows.Forms.ComboBox();
            this.LabelReceiver = new System.Windows.Forms.Label();
            this.ButtonSendMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(25, 46);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(29, 12);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "제목";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(60, 43);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(277, 21);
            this.TextBoxTitle.TabIndex = 1;
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Location = new System.Drawing.Point(27, 70);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(310, 329);
            this.TextBoxMessage.TabIndex = 2;
            // 
            // ComboBoxTo
            // 
            this.ComboBoxTo.FormattingEnabled = true;
            this.ComboBoxTo.Location = new System.Drawing.Point(88, 17);
            this.ComboBoxTo.Name = "ComboBoxTo";
            this.ComboBoxTo.Size = new System.Drawing.Size(168, 20);
            this.ComboBoxTo.TabIndex = 3;
            // 
            // LabelReceiver
            // 
            this.LabelReceiver.AutoSize = true;
            this.LabelReceiver.Location = new System.Drawing.Point(25, 20);
            this.LabelReceiver.Name = "LabelReceiver";
            this.LabelReceiver.Size = new System.Drawing.Size(57, 12);
            this.LabelReceiver.TabIndex = 4;
            this.LabelReceiver.Text = "받는 사람";
            // 
            // ButtonSendMail
            // 
            this.ButtonSendMail.Location = new System.Drawing.Point(262, 15);
            this.ButtonSendMail.Name = "ButtonSendMail";
            this.ButtonSendMail.Size = new System.Drawing.Size(75, 23);
            this.ButtonSendMail.TabIndex = 5;
            this.ButtonSendMail.Text = "전송";
            this.ButtonSendMail.UseVisualStyleBackColor = true;
            this.ButtonSendMail.Click += new System.EventHandler(this.ButtonSendMail_Click);
            // 
            // FormSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 419);
            this.Controls.Add(this.ButtonSendMail);
            this.Controls.Add(this.LabelReceiver);
            this.Controls.Add(this.ComboBoxTo);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.LabelTitle);
            this.Name = "FormSendMail";
            this.Text = "FormSendMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelReceiver;
        private System.Windows.Forms.Button ButtonSendMail;
        public System.Windows.Forms.TextBox TextBoxTitle;
        public System.Windows.Forms.TextBox TextBoxMessage;
        public System.Windows.Forms.ComboBox ComboBoxTo;
    }
}