namespace FinalProj_personnel
{
    partial class FormPayViewer
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
            this.buttonMoney = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAllowance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeduction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFinalWage = new System.Windows.Forms.Button();
            this.listViewMoney = new System.Windows.Forms.ListView();
            this.listViewAllowance = new System.Windows.Forms.ListView();
            this.listViewDeduction = new System.Windows.Forms.ListView();
            this.listViewFinalWage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonMoney
            // 
            this.buttonMoney.Location = new System.Drawing.Point(60, 24);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(143, 58);
            this.buttonMoney.TabIndex = 6;
            this.buttonMoney.Text = "기본금";
            this.buttonMoney.UseVisualStyleBackColor = true;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "+";
            // 
            // buttonAllowance
            // 
            this.buttonAllowance.Location = new System.Drawing.Point(328, 24);
            this.buttonAllowance.Name = "buttonAllowance";
            this.buttonAllowance.Size = new System.Drawing.Size(143, 58);
            this.buttonAllowance.TabIndex = 8;
            this.buttonAllowance.Text = "수당";
            this.buttonAllowance.UseVisualStyleBackColor = true;
            this.buttonAllowance.Click += new System.EventHandler(this.buttonAllowance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // buttonDeduction
            // 
            this.buttonDeduction.Location = new System.Drawing.Point(596, 24);
            this.buttonDeduction.Name = "buttonDeduction";
            this.buttonDeduction.Size = new System.Drawing.Size(143, 58);
            this.buttonDeduction.TabIndex = 10;
            this.buttonDeduction.Text = "공제";
            this.buttonDeduction.UseVisualStyleBackColor = true;
            this.buttonDeduction.Click += new System.EventHandler(this.buttonDeduction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(788, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "=";
            // 
            // buttonFinalWage
            // 
            this.buttonFinalWage.Location = new System.Drawing.Point(872, 24);
            this.buttonFinalWage.Name = "buttonFinalWage";
            this.buttonFinalWage.Size = new System.Drawing.Size(143, 58);
            this.buttonFinalWage.TabIndex = 12;
            this.buttonFinalWage.Text = "최종 임금";
            this.buttonFinalWage.UseVisualStyleBackColor = true;
            this.buttonFinalWage.Click += new System.EventHandler(this.buttonFinalWage_Click);
            // 
            // listViewMoney
            // 
            this.listViewMoney.HideSelection = false;
            this.listViewMoney.Location = new System.Drawing.Point(30, 117);
            this.listViewMoney.Name = "listViewMoney";
            this.listViewMoney.Size = new System.Drawing.Size(211, 392);
            this.listViewMoney.TabIndex = 13;
            this.listViewMoney.UseCompatibleStateImageBehavior = false;
            // 
            // listViewAllowance
            // 
            this.listViewAllowance.HideSelection = false;
            this.listViewAllowance.Location = new System.Drawing.Point(300, 117);
            this.listViewAllowance.Name = "listViewAllowance";
            this.listViewAllowance.Size = new System.Drawing.Size(211, 392);
            this.listViewAllowance.TabIndex = 14;
            this.listViewAllowance.UseCompatibleStateImageBehavior = false;
            // 
            // listViewDeduction
            // 
            this.listViewDeduction.HideSelection = false;
            this.listViewDeduction.Location = new System.Drawing.Point(569, 117);
            this.listViewDeduction.Name = "listViewDeduction";
            this.listViewDeduction.Size = new System.Drawing.Size(211, 392);
            this.listViewDeduction.TabIndex = 15;
            this.listViewDeduction.UseCompatibleStateImageBehavior = false;
            // 
            // listViewFinalWage
            // 
            this.listViewFinalWage.HideSelection = false;
            this.listViewFinalWage.Location = new System.Drawing.Point(839, 117);
            this.listViewFinalWage.Name = "listViewFinalWage";
            this.listViewFinalWage.Size = new System.Drawing.Size(211, 392);
            this.listViewFinalWage.TabIndex = 16;
            this.listViewFinalWage.UseCompatibleStateImageBehavior = false;
            // 
            // FormPayViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 563);
            this.Controls.Add(this.listViewFinalWage);
            this.Controls.Add(this.listViewDeduction);
            this.Controls.Add(this.listViewAllowance);
            this.Controls.Add(this.listViewMoney);
            this.Controls.Add(this.buttonFinalWage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDeduction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAllowance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMoney);
            this.Name = "FormPayViewer";
            this.Text = "급여보기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAllowance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeduction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFinalWage;
        private System.Windows.Forms.ListView listViewMoney;
        private System.Windows.Forms.ListView listViewAllowance;
        private System.Windows.Forms.ListView listViewDeduction;
        private System.Windows.Forms.ListView listViewFinalWage;
    }
}