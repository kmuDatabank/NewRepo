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
            this.columnHeaderName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBasePay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAllowance = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDeduction = new System.Windows.Forms.ListView();
            this.columnHeaderName3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeduction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFinalWage = new System.Windows.Forms.ListView();
            this.columnHeaderName4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotalPay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonpayfix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMoney
            // 
            this.buttonMoney.Location = new System.Drawing.Point(61, 105);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(143, 58);
            this.buttonMoney.TabIndex = 6;
            this.buttonMoney.Text = "기본급";
            this.buttonMoney.UseVisualStyleBackColor = true;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "+";
            // 
            // buttonAllowance
            // 
            this.buttonAllowance.Location = new System.Drawing.Point(330, 105);
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
            this.label2.Location = new System.Drawing.Point(520, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // buttonDeduction
            // 
            this.buttonDeduction.Location = new System.Drawing.Point(597, 105);
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
            this.label3.Location = new System.Drawing.Point(790, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "=";
            // 
            // buttonFinalWage
            // 
            this.buttonFinalWage.Location = new System.Drawing.Point(873, 105);
            this.buttonFinalWage.Name = "buttonFinalWage";
            this.buttonFinalWage.Size = new System.Drawing.Size(143, 58);
            this.buttonFinalWage.TabIndex = 12;
            this.buttonFinalWage.Text = "최종 임금";
            this.buttonFinalWage.UseVisualStyleBackColor = true;
            this.buttonFinalWage.Click += new System.EventHandler(this.buttonFinalWage_Click);
            // 
            // listViewMoney
            // 
            this.listViewMoney.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName1,
            this.columnHeaderBasePay});
            this.listViewMoney.GridLines = true;
            this.listViewMoney.HideSelection = false;
            this.listViewMoney.Location = new System.Drawing.Point(31, 198);
            this.listViewMoney.Name = "listViewMoney";
            this.listViewMoney.Size = new System.Drawing.Size(211, 392);
            this.listViewMoney.TabIndex = 13;
            this.listViewMoney.UseCompatibleStateImageBehavior = false;
            this.listViewMoney.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName1
            // 
            this.columnHeaderName1.Text = "이름";
            // 
            // columnHeaderBasePay
            // 
            this.columnHeaderBasePay.Text = "기본급";
            this.columnHeaderBasePay.Width = 113;
            // 
            // listViewAllowance
            // 
            this.listViewAllowance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewAllowance.GridLines = true;
            this.listViewAllowance.HideSelection = false;
            this.listViewAllowance.Location = new System.Drawing.Point(301, 198);
            this.listViewAllowance.Name = "listViewAllowance";
            this.listViewAllowance.Size = new System.Drawing.Size(211, 392);
            this.listViewAllowance.TabIndex = 14;
            this.listViewAllowance.UseCompatibleStateImageBehavior = false;
            this.listViewAllowance.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "수당";
            this.columnHeader2.Width = 113;
            // 
            // listViewDeduction
            // 
            this.listViewDeduction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName3,
            this.columnHeaderDeduction});
            this.listViewDeduction.GridLines = true;
            this.listViewDeduction.HideSelection = false;
            this.listViewDeduction.Location = new System.Drawing.Point(570, 198);
            this.listViewDeduction.Name = "listViewDeduction";
            this.listViewDeduction.Size = new System.Drawing.Size(211, 392);
            this.listViewDeduction.TabIndex = 15;
            this.listViewDeduction.UseCompatibleStateImageBehavior = false;
            this.listViewDeduction.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName3
            // 
            this.columnHeaderName3.Text = "이름";
            // 
            // columnHeaderDeduction
            // 
            this.columnHeaderDeduction.Text = "공제";
            this.columnHeaderDeduction.Width = 108;
            // 
            // listViewFinalWage
            // 
            this.listViewFinalWage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName4,
            this.columnHeaderTotalPay});
            this.listViewFinalWage.GridLines = true;
            this.listViewFinalWage.HideSelection = false;
            this.listViewFinalWage.Location = new System.Drawing.Point(840, 198);
            this.listViewFinalWage.Name = "listViewFinalWage";
            this.listViewFinalWage.Size = new System.Drawing.Size(211, 392);
            this.listViewFinalWage.TabIndex = 16;
            this.listViewFinalWage.UseCompatibleStateImageBehavior = false;
            this.listViewFinalWage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName4
            // 
            this.columnHeaderName4.Text = "이름";
            // 
            // columnHeaderTotalPay
            // 
            this.columnHeaderTotalPay.Text = "최종임금";
            this.columnHeaderTotalPay.Width = 99;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 32);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 28);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // buttonpayfix
            // 
            this.buttonpayfix.Location = new System.Drawing.Point(330, 622);
            this.buttonpayfix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonpayfix.Name = "buttonpayfix";
            this.buttonpayfix.Size = new System.Drawing.Size(143, 34);
            this.buttonpayfix.TabIndex = 20;
            this.buttonpayfix.Text = "수당수정";
            this.buttonpayfix.UseVisualStyleBackColor = true;
            this.buttonpayfix.Click += new System.EventHandler(this.buttonpayfix_Click);
            // 
            // FormPayViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 675);
            this.Controls.Add(this.buttonpayfix);
            this.Controls.Add(this.dateTimePicker1);
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
        private System.Windows.Forms.ColumnHeader columnHeaderName1;
        private System.Windows.Forms.ColumnHeader columnHeaderBasePay;
        private System.Windows.Forms.ColumnHeader columnHeaderName3;
        private System.Windows.Forms.ColumnHeader columnHeaderDeduction;
        private System.Windows.Forms.ColumnHeader columnHeaderName4;
        private System.Windows.Forms.ColumnHeader columnHeaderTotalPay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonpayfix;
    }
}