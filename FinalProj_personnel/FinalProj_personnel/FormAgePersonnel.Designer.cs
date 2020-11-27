namespace FinalProj_personnel
{
    partial class FormAgePersonnel
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
            this.listViewDepartmentType = new System.Windows.Forms.ListView();
            this.columnHeaderAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonDepartSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.comboBoxMemberGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewDepartmentType
            // 
            this.listViewDepartmentType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAge,
            this.columnHeaderName,
            this.columnHeaderGender,
            this.columnHeaderPosition,
            this.columnHeaderDepartment,
            this.columnHeaderDate,
            this.columnHeaderPhone,
            this.columnHeaderAddress});
            this.listViewDepartmentType.FullRowSelect = true;
            this.listViewDepartmentType.GridLines = true;
            this.listViewDepartmentType.HideSelection = false;
            this.listViewDepartmentType.Location = new System.Drawing.Point(21, 94);
            this.listViewDepartmentType.Name = "listViewDepartmentType";
            this.listViewDepartmentType.Size = new System.Drawing.Size(766, 469);
            this.listViewDepartmentType.TabIndex = 25;
            this.listViewDepartmentType.UseCompatibleStateImageBehavior = false;
            this.listViewDepartmentType.View = System.Windows.Forms.View.Details;
            this.listViewDepartmentType.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewDepartmentType_MouseDown);
            // 
            // columnHeaderAge
            // 
            this.columnHeaderAge.Text = "나이";
            this.columnHeaderAge.Width = 69;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "이름";
            this.columnHeaderName.Width = 72;
            // 
            // columnHeaderGender
            // 
            this.columnHeaderGender.Text = "성별";
            this.columnHeaderGender.Width = 77;
            // 
            // columnHeaderPosition
            // 
            this.columnHeaderPosition.Text = "직급";
            this.columnHeaderPosition.Width = 74;
            // 
            // columnHeaderDepartment
            // 
            this.columnHeaderDepartment.Text = "소속부서";
            this.columnHeaderDepartment.Width = 100;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "입사일";
            this.columnHeaderDate.Width = 84;
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "연락처";
            this.columnHeaderPhone.Width = 80;
            // 
            // columnHeaderAddress
            // 
            this.columnHeaderAddress.Text = "주소";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "이름으로 사원 검색하시오:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(285, 38);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(136, 28);
            this.textBoxInput.TabIndex = 33;
            // 
            // buttonDepartSearch
            // 
            this.buttonDepartSearch.Location = new System.Drawing.Point(465, 38);
            this.buttonDepartSearch.Name = "buttonDepartSearch";
            this.buttonDepartSearch.Size = new System.Drawing.Size(75, 30);
            this.buttonDepartSearch.TabIndex = 32;
            this.buttonDepartSearch.Text = "검색";
            this.buttonDepartSearch.UseVisualStyleBackColor = true;
            this.buttonDepartSearch.Click += new System.EventHandler(this.buttonDepartSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxDepartment);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.numericUpDownAge);
            this.groupBox3.Controls.Add(this.textBoxAddress);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxPhoneNum);
            this.groupBox3.Controls.Add(this.comboBoxMemberGender);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxDate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBoxPosition);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxMemberName);
            this.groupBox3.Location = new System.Drawing.Point(811, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 492);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(수정 list)";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(107, 267);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(103, 26);
            this.comboBoxDepartment.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "소속부서:";
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(107, 154);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(103, 28);
            this.numericUpDownAge.TabIndex = 30;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(107, 432);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(103, 28);
            this.textBoxAddress.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "주소 :";
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Location = new System.Drawing.Point(107, 380);
            this.textBoxPhoneNum.Multiline = true;
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(103, 28);
            this.textBoxPhoneNum.TabIndex = 13;
            // 
            // comboBoxMemberGender
            // 
            this.comboBoxMemberGender.FormattingEnabled = true;
            this.comboBoxMemberGender.Location = new System.Drawing.Point(107, 96);
            this.comboBoxMemberGender.Name = "comboBoxMemberGender";
            this.comboBoxMemberGender.Size = new System.Drawing.Size(103, 26);
            this.comboBoxMemberGender.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "성별 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "연락처 :";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(107, 321);
            this.textBoxDate.Multiline = true;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(103, 28);
            this.textBoxDate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "입사일 :";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(107, 211);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(103, 26);
            this.comboBoxPosition.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "직급 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "나이 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름 :";
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(107, 41);
            this.textBoxMemberName.Multiline = true;
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(103, 28);
            this.textBoxMemberName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("돋움체", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(198, 572);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(392, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "(수정 및 삭제를 원하시면 우클릭으로 선택하세요.)";
            // 
            // FormAgePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 597);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonDepartSearch);
            this.Controls.Add(this.listViewDepartmentType);
            this.Name = "FormAgePersonnel";
            this.Text = "나이별";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewDepartmentType;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderGender;
        private System.Windows.Forms.ColumnHeader columnHeaderAge;
        private System.Windows.Forms.ColumnHeader columnHeaderPosition;
        private System.Windows.Forms.ColumnHeader columnHeaderDepartment;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonDepartSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.ComboBox comboBoxMemberGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.Label label10;
    }
}