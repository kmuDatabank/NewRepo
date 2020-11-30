namespace FinalProj_personnel
{
    partial class FormReceivedMail
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
            this.ButtonOpenMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListViewReceived
            // 
            this.ListViewReceived.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Title,
            this.Content,
            this.Date});
            this.ListViewReceived.HideSelection = false;
            this.ListViewReceived.Location = new System.Drawing.Point(12, 12);
            this.ListViewReceived.Name = "ListViewReceived";
            this.ListViewReceived.Size = new System.Drawing.Size(714, 410);
            this.ListViewReceived.TabIndex = 0;
            this.ListViewReceived.UseCompatibleStateImageBehavior = false;
            this.ListViewReceived.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "보낸 사람";
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
            this.Content.Width = 339;
            // 
            // Date
            // 
            this.Date.Text = "수신 날짜";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 160;
            // 
            // ButtonOpenMail
            // 
            this.ButtonOpenMail.Location = new System.Drawing.Point(743, 12);
            this.ButtonOpenMail.Name = "ButtonOpenMail";
            this.ButtonOpenMail.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenMail.TabIndex = 1;
            this.ButtonOpenMail.Text = "확인";
            this.ButtonOpenMail.UseVisualStyleBackColor = true;
            this.ButtonOpenMail.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormReceivedMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 434);
            this.Controls.Add(this.ButtonOpenMail);
            this.Controls.Add(this.ListViewReceived);
      //      this.Name = "FormReceivedMail";
    //        this.Text = "FormReceivedMail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewReceived;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Content;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Button ButtonOpenMail;
    }
}