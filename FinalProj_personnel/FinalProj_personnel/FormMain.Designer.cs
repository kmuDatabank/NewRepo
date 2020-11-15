namespace FinalProj_personnel
{
    partial class FormMain
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
            this.buttonPersonnel = new System.Windows.Forms.Button();
            this.buttonWork = new System.Windows.Forms.Button();
            this.buttonApproval = new System.Windows.Forms.Button();
            this.buttonMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPersonnel
            // 
            this.buttonPersonnel.Location = new System.Drawing.Point(67, 125);
            this.buttonPersonnel.Name = "buttonPersonnel";
            this.buttonPersonnel.Size = new System.Drawing.Size(156, 40);
            this.buttonPersonnel.TabIndex = 0;
            this.buttonPersonnel.Text = "인사";
            this.buttonPersonnel.UseVisualStyleBackColor = true;
            // 
            // buttonWork
            // 
            this.buttonWork.Location = new System.Drawing.Point(67, 195);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(156, 39);
            this.buttonWork.TabIndex = 1;
            this.buttonWork.Text = "업무";
            this.buttonWork.UseVisualStyleBackColor = true;
            // 
            // buttonApproval
            // 
            this.buttonApproval.Location = new System.Drawing.Point(67, 257);
            this.buttonApproval.Name = "buttonApproval";
            this.buttonApproval.Size = new System.Drawing.Size(156, 42);
            this.buttonApproval.TabIndex = 2;
            this.buttonApproval.Text = "결재";
            this.buttonApproval.UseVisualStyleBackColor = true;
            // 
            // buttonMail
            // 
            this.buttonMail.Location = new System.Drawing.Point(67, 329);
            this.buttonMail.Name = "buttonMail";
            this.buttonMail.Size = new System.Drawing.Size(156, 42);
            this.buttonMail.TabIndex = 3;
            this.buttonMail.Text = "쪽지";
            this.buttonMail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "직급";
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(318, 28);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 6;
            this.button_logout.Text = "logout";
            this.button_logout.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 436);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMail);
            this.Controls.Add(this.buttonApproval);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.buttonPersonnel);
            this.Name = "FormMain";
            this.Text = "메인 화면";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPersonnel;
        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.Button buttonApproval;
        private System.Windows.Forms.Button buttonMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_logout;
    }
}