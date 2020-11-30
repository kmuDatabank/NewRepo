namespace FinalProj_personnel
{
    partial class FormReadReceived
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
            this.LabelWho = new System.Windows.Forms.Label();
            this.TextBoxContent = new System.Windows.Forms.TextBox();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxWho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelWho
            // 
            this.LabelWho.AutoSize = true;
            this.LabelWho.Location = new System.Drawing.Point(23, 18);
            this.LabelWho.Name = "LabelWho";
            this.LabelWho.Size = new System.Drawing.Size(57, 12);
            this.LabelWho.TabIndex = 8;
            this.LabelWho.Text = "보낸 사람";
            // 
            // TextBoxContent
            // 
            this.TextBoxContent.BackColor = System.Drawing.Color.White;
            this.TextBoxContent.Location = new System.Drawing.Point(25, 68);
            this.TextBoxContent.Multiline = true;
            this.TextBoxContent.Name = "TextBoxContent";
            this.TextBoxContent.ReadOnly = true;
            this.TextBoxContent.Size = new System.Drawing.Size(334, 343);
            this.TextBoxContent.TabIndex = 7;
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.BackColor = System.Drawing.Color.White;
            this.TextBoxTitle.Location = new System.Drawing.Point(58, 41);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.ReadOnly = true;
            this.TextBoxTitle.Size = new System.Drawing.Size(301, 21);
            this.TextBoxTitle.TabIndex = 6;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(23, 44);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(29, 12);
            this.LabelTitle.TabIndex = 5;
            this.LabelTitle.Text = "제목";
            // 
            // TextBoxWho
            // 
            this.TextBoxWho.BackColor = System.Drawing.Color.White;
            this.TextBoxWho.Location = new System.Drawing.Point(86, 14);
            this.TextBoxWho.Name = "TextBoxWho";
            this.TextBoxWho.ReadOnly = true;
            this.TextBoxWho.Size = new System.Drawing.Size(151, 21);
            this.TextBoxWho.TabIndex = 9;
            // 
            // FormReadReceived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 434);
            this.Controls.Add(this.TextBoxWho);
            this.Controls.Add(this.LabelWho);
            this.Controls.Add(this.TextBoxContent);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.LabelTitle);
            this.Name = "FormReadReceived";
            this.Text = "FormReadReceived";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelWho;
        private System.Windows.Forms.TextBox TextBoxContent;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextBoxWho;
    }
}