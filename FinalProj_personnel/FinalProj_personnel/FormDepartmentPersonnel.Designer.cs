﻿namespace FinalProj_personnel
{
    partial class FormDepartmentPersonnel
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
            this.buttonDepartChange = new System.Windows.Forms.Button();
            this.buttonDepartDelete = new System.Windows.Forms.Button();
            this.buttonDepartSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.listViewDepartmentType = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDepartChange
            // 
            this.buttonDepartChange.Location = new System.Drawing.Point(446, 37);
            this.buttonDepartChange.Name = "buttonDepartChange";
            this.buttonDepartChange.Size = new System.Drawing.Size(79, 35);
            this.buttonDepartChange.TabIndex = 23;
            this.buttonDepartChange.Text = "수정";
            this.buttonDepartChange.UseVisualStyleBackColor = true;
            this.buttonDepartChange.Click += new System.EventHandler(this.buttonDepartChange_Click_1);
            // 
            // buttonDepartDelete
            // 
            this.buttonDepartDelete.Location = new System.Drawing.Point(561, 36);
            this.buttonDepartDelete.Name = "buttonDepartDelete";
            this.buttonDepartDelete.Size = new System.Drawing.Size(74, 37);
            this.buttonDepartDelete.TabIndex = 24;
            this.buttonDepartDelete.Text = "삭제";
            this.buttonDepartDelete.UseVisualStyleBackColor = true;
            this.buttonDepartDelete.Click += new System.EventHandler(this.buttonDepartDelete_Click);
            // 
            // buttonDepartSearch
            // 
            this.buttonDepartSearch.Location = new System.Drawing.Point(337, 37);
            this.buttonDepartSearch.Name = "buttonDepartSearch";
            this.buttonDepartSearch.Size = new System.Drawing.Size(75, 35);
            this.buttonDepartSearch.TabIndex = 27;
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
            this.groupBox3.Location = new System.Drawing.Point(654, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 492);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
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
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(216, 39);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(106, 28);
            this.textBoxInput.TabIndex = 29;
            // 
            // listViewDepartmentType
            // 
            this.listViewDepartmentType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderGender,
            this.columnHeaderAge,
            this.columnHeaderPosition,
            this.columnHeaderDepartment,
            this.columnHeaderDate,
            this.columnHeaderPhone,
            this.columnHeaderAddress});
            this.listViewDepartmentType.HideSelection = false;
            this.listViewDepartmentType.Location = new System.Drawing.Point(24, 92);
            this.listViewDepartmentType.Name = "listViewDepartmentType";
            this.listViewDepartmentType.Size = new System.Drawing.Size(613, 480);
            this.listViewDepartmentType.TabIndex = 30;
            this.listViewDepartmentType.UseCompatibleStateImageBehavior = false;
            this.listViewDepartmentType.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "이름";
            // 
            // columnHeaderGender
            // 
            this.columnHeaderGender.Text = "성별";
            // 
            // columnHeaderAge
            // 
            this.columnHeaderAge.DisplayIndex = 4;
            this.columnHeaderAge.Text = "나이";
            // 
            // columnHeaderPosition
            // 
            this.columnHeaderPosition.DisplayIndex = 2;
            this.columnHeaderPosition.Text = "직급";
            // 
            // columnHeaderDepartment
            // 
            this.columnHeaderDepartment.DisplayIndex = 3;
            this.columnHeaderDepartment.Text = "소속부서";
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "입사일";
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "연락처";
            // 
            // columnHeaderAddress
            // 
            this.columnHeaderAddress.Text = "주소";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "이름으로 검색하시오:";
            // 
            // FormDepartmentPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 620);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listViewDepartmentType);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonDepartSearch);
            this.Controls.Add(this.buttonDepartDelete);
            this.Controls.Add(this.buttonDepartChange);
            this.Name = "FormDepartmentPersonnel";
            this.Text = "부서별 사원검색";
          
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDepartChange;
        private System.Windows.Forms.Button buttonDepartDelete;
        private System.Windows.Forms.Button buttonDepartSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMemberGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.ListView listViewDepartmentType;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderGender;
        private System.Windows.Forms.ColumnHeader columnHeaderAge;
        private System.Windows.Forms.ColumnHeader columnHeaderPosition;
        private System.Windows.Forms.ColumnHeader columnHeaderDepartment;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
    }
}