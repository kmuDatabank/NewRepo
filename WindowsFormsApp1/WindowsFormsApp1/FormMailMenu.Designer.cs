namespace FinalProj_personnel
{
    partial class FormMailMenu
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
            this.ButtonSendMail = new System.Windows.Forms.Button();
            this.ButtonReceivedMail = new System.Windows.Forms.Button();
            this.ButtonTransmittedMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSendMail
            // 
            this.ButtonSendMail.Location = new System.Drawing.Point(53, 34);
            this.ButtonSendMail.Name = "ButtonSendMail";
            this.ButtonSendMail.Size = new System.Drawing.Size(122, 49);
            this.ButtonSendMail.TabIndex = 0;
            this.ButtonSendMail.Text = "쪽지 보내기";
            this.ButtonSendMail.UseVisualStyleBackColor = true;
            this.ButtonSendMail.Click += new System.EventHandler(this.ButtonSendMail_Click);
            // 
            // ButtonReceivedMail
            // 
            this.ButtonReceivedMail.Location = new System.Drawing.Point(53, 118);
            this.ButtonReceivedMail.Name = "ButtonReceivedMail";
            this.ButtonReceivedMail.Size = new System.Drawing.Size(122, 49);
            this.ButtonReceivedMail.TabIndex = 0;
            this.ButtonReceivedMail.Text = "받은 쪽지함";
            this.ButtonReceivedMail.UseVisualStyleBackColor = true;
            this.ButtonReceivedMail.Click += new System.EventHandler(this.ButtonReceivedMail_Click);
            // 
            // ButtonTransmittedMail
            // 
            this.ButtonTransmittedMail.Location = new System.Drawing.Point(53, 202);
            this.ButtonTransmittedMail.Name = "ButtonTransmittedMail";
            this.ButtonTransmittedMail.Size = new System.Drawing.Size(122, 49);
            this.ButtonTransmittedMail.TabIndex = 0;
            this.ButtonTransmittedMail.Text = "보낸 쪽지함";
            this.ButtonTransmittedMail.UseVisualStyleBackColor = true;
            this.ButtonTransmittedMail.Click += new System.EventHandler(this.ButtonTransmittedMail_Click);
            // 
            // FormMailMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 296);
            this.Controls.Add(this.ButtonTransmittedMail);
            this.Controls.Add(this.ButtonReceivedMail);
            this.Controls.Add(this.ButtonSendMail);
            this.Name = "FormMailMenu";
            this.Text = "FormMailMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSendMail;
        private System.Windows.Forms.Button ButtonReceivedMail;
        private System.Windows.Forms.Button ButtonTransmittedMail;
    }
}