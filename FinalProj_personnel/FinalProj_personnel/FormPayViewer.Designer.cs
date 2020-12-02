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
            this.listViewDeduction = new System.Windows.Forms.ListView();
            this.columnHeaderName3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeduction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFinalWage = new System.Windows.Forms.ListView();
            this.columnHeaderName4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotalPay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonMoney
            // 
            this.buttonMoney.Location = new System.Drawing.Point(43, 70);
            this.buttonMoney.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(100, 39);
            this.buttonMoney.TabIndex = 6;
            this.buttonMoney.Text = "기본급";
            this.buttonMoney.UseVisualStyleBackColor = true;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "+";
            // 
            // buttonAllowance
            // 
            this.buttonAllowance.Location = new System.Drawing.Point(231, 70);
            this.buttonAllowance.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAllowance.Name = "buttonAllowance";
            this.buttonAllowance.Size = new System.Drawing.Size(100, 39);
            this.buttonAllowance.TabIndex = 8;
            this.buttonAllowance.Text = "수당";
            this.buttonAllowance.UseVisualStyleBackColor = true;
            this.buttonAllowance.Click += new System.EventHandler(this.buttonAllowance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // buttonDeduction
            // 
            this.buttonDeduction.Location = new System.Drawing.Point(418, 70);
            this.buttonDeduction.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeduction.Name = "buttonDeduction";
            this.buttonDeduction.Size = new System.Drawing.Size(100, 39);
            this.buttonDeduction.TabIndex = 10;
            this.buttonDeduction.Text = "공제";
            this.buttonDeduction.UseVisualStyleBackColor = true;
            this.buttonDeduction.Click += new System.EventHandler(this.buttonDeduction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "=";
            // 
            // buttonFinalWage
            // 
            this.buttonFinalWage.Location = new System.Drawing.Point(611, 70);
            this.buttonFinalWage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFinalWage.Name = "buttonFinalWage";
            this.buttonFinalWage.Size = new System.Drawing.Size(100, 39);
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
            this.listViewMoney.Location = new System.Drawing.Point(22, 132);
            this.listViewMoney.Margin = new System.Windows.Forms.Padding(2);
            this.listViewMoney.Name = "listViewMoney";
            this.listViewMoney.Size = new System.Drawing.Size(149, 263);
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
            this.listViewAllowance.HideSelection = false;
            this.listViewAllowance.Location = new System.Drawing.Point(211, 132);
            this.listViewAllowance.Margin = new System.Windows.Forms.Padding(2);
            this.listViewAllowance.Name = "listViewAllowance";
            this.listViewAllowance.Size = new System.Drawing.Size(149, 263);
            this.listViewAllowance.TabIndex = 14;
            this.listViewAllowance.UseCompatibleStateImageBehavior = false;
            // 
            // listViewDeduction
            // 
            this.listViewDeduction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName3,
            this.columnHeaderDeduction});
            this.listViewDeduction.GridLines = true;
            this.listViewDeduction.HideSelection = false;
            this.listViewDeduction.Location = new System.Drawing.Point(399, 132);
            this.listViewDeduction.Margin = new System.Windows.Forms.Padding(2);
            this.listViewDeduction.Name = "listViewDeduction";
            this.listViewDeduction.Size = new System.Drawing.Size(149, 263);
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
            this.listViewFinalWage.Location = new System.Drawing.Point(588, 132);
            this.listViewFinalWage.Margin = new System.Windows.Forms.Padding(2);
            this.listViewFinalWage.Name = "listViewFinalWage";
            this.listViewFinalWage.Size = new System.Drawing.Size(149, 263);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 403);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 21);
            this.textBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(212, 405);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 11);
            this.label4.TabIndex = 18;
            this.label4.Text = "수당입력:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(93, 21);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // FormPayViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeaderName1;
        private System.Windows.Forms.ColumnHeader columnHeaderBasePay;
        private System.Windows.Forms.ColumnHeader columnHeaderName3;
        private System.Windows.Forms.ColumnHeader columnHeaderDeduction;
        private System.Windows.Forms.ColumnHeader columnHeaderName4;
        private System.Windows.Forms.ColumnHeader columnHeaderTotalPay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}