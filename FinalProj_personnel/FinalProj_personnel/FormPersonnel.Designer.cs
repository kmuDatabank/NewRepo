namespace FinalProj_personnel
{
    partial class FormPersonnel
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.comboBoxheadDepartment = new System.Windows.Forms.ComboBox();
            this.listViewShow = new System.Windows.Forms.ListView();
            this.columnHeaderDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteDepartment = new System.Windows.Forms.Button();
            this.buttonSaveDepartment = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonChangeDepartment = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSearchDepartmentType = new System.Windows.Forms.Button();
            this.comboBoxDepartmentType = new System.Windows.Forms.ComboBox();
            this.buttonTimeCard = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonMemberSave = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMemberAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMemberGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.급여내역서ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.급여내역서확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_addresssearch = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxDepartmentName);
            this.groupBox5.Controls.Add(this.comboBoxheadDepartment);
            this.groupBox5.Controls.Add(this.listViewShow);
            this.groupBox5.Controls.Add(this.buttonDeleteDepartment);
            this.groupBox5.Controls.Add(this.buttonSaveDepartment);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.buttonChangeDepartment);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(403, 264);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(496, 280);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "부서등록";
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Location = new System.Drawing.Point(357, 74);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(125, 28);
            this.textBoxDepartmentName.TabIndex = 22;
            // 
            // comboBoxheadDepartment
            // 
            this.comboBoxheadDepartment.FormattingEnabled = true;
            this.comboBoxheadDepartment.Location = new System.Drawing.Point(359, 122);
            this.comboBoxheadDepartment.Name = "comboBoxheadDepartment";
            this.comboBoxheadDepartment.Size = new System.Drawing.Size(124, 26);
            this.comboBoxheadDepartment.TabIndex = 21;
            // 
            // listViewShow
            // 
            this.listViewShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDepartment,
            this.columnHeaderHeader});
            this.listViewShow.HideSelection = false;
            this.listViewShow.Location = new System.Drawing.Point(10, 27);
            this.listViewShow.Name = "listViewShow";
            this.listViewShow.Size = new System.Drawing.Size(237, 247);
            this.listViewShow.TabIndex = 20;
            this.listViewShow.UseCompatibleStateImageBehavior = false;
            this.listViewShow.View = System.Windows.Forms.View.Details;
            this.listViewShow.Click += new System.EventHandler(this.listViewShow_Click);
            // 
            // columnHeaderDepartment
            // 
            this.columnHeaderDepartment.Text = "부서명";
            this.columnHeaderDepartment.Width = 98;
            // 
            // columnHeaderHeader
            // 
            this.columnHeaderHeader.Text = "부서장";
            this.columnHeaderHeader.Width = 88;
            // 
            // buttonDeleteDepartment
            // 
            this.buttonDeleteDepartment.Location = new System.Drawing.Point(419, 192);
            this.buttonDeleteDepartment.Name = "buttonDeleteDepartment";
            this.buttonDeleteDepartment.Size = new System.Drawing.Size(71, 30);
            this.buttonDeleteDepartment.TabIndex = 5;
            this.buttonDeleteDepartment.Text = "삭제";
            this.buttonDeleteDepartment.UseVisualStyleBackColor = true;
            this.buttonDeleteDepartment.Click += new System.EventHandler(this.buttonDeleteDepartment_Click);
            // 
            // buttonSaveDepartment
            // 
            this.buttonSaveDepartment.Location = new System.Drawing.Point(254, 192);
            this.buttonSaveDepartment.Name = "buttonSaveDepartment";
            this.buttonSaveDepartment.Size = new System.Drawing.Size(71, 30);
            this.buttonSaveDepartment.TabIndex = 1;
            this.buttonSaveDepartment.Text = "등록";
            this.buttonSaveDepartment.UseVisualStyleBackColor = true;
            this.buttonSaveDepartment.Click += new System.EventHandler(this.buttonSaveDepartment_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "부서장 :";
            // 
            // buttonChangeDepartment
            // 
            this.buttonChangeDepartment.Location = new System.Drawing.Point(334, 192);
            this.buttonChangeDepartment.Name = "buttonChangeDepartment";
            this.buttonChangeDepartment.Size = new System.Drawing.Size(71, 30);
            this.buttonChangeDepartment.TabIndex = 4;
            this.buttonChangeDepartment.Text = "수정";
            this.buttonChangeDepartment.UseVisualStyleBackColor = true;
            this.buttonChangeDepartment.Click += new System.EventHandler(this.buttonChangeDepartment_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "부서명 :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSearchDepartmentType);
            this.groupBox4.Controls.Add(this.comboBoxDepartmentType);
            this.groupBox4.Location = new System.Drawing.Point(393, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 132);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "사원검색 (수정 및 삭제)";
            // 
            // buttonSearchDepartmentType
            // 
            this.buttonSearchDepartmentType.Location = new System.Drawing.Point(140, 65);
            this.buttonSearchDepartmentType.Name = "buttonSearchDepartmentType";
            this.buttonSearchDepartmentType.Size = new System.Drawing.Size(64, 32);
            this.buttonSearchDepartmentType.TabIndex = 22;
            this.buttonSearchDepartmentType.Text = "검색";
            this.buttonSearchDepartmentType.UseVisualStyleBackColor = true;
            this.buttonSearchDepartmentType.Click += new System.EventHandler(this.buttonSearchDepartmentType_Click);
            // 
            // comboBoxDepartmentType
            // 
            this.comboBoxDepartmentType.FormattingEnabled = true;
            this.comboBoxDepartmentType.Location = new System.Drawing.Point(19, 69);
            this.comboBoxDepartmentType.Name = "comboBoxDepartmentType";
            this.comboBoxDepartmentType.Size = new System.Drawing.Size(95, 26);
            this.comboBoxDepartmentType.TabIndex = 2;
            this.comboBoxDepartmentType.Text = "부서별";
            // 
            // buttonTimeCard
            // 
            this.buttonTimeCard.Location = new System.Drawing.Point(40, 55);
            this.buttonTimeCard.Name = "buttonTimeCard";
            this.buttonTimeCard.Size = new System.Drawing.Size(83, 42);
            this.buttonTimeCard.TabIndex = 31;
            this.buttonTimeCard.Text = "출근부";
            this.buttonTimeCard.UseVisualStyleBackColor = true;
            this.buttonTimeCard.Click += new System.EventHandler(this.buttonTimeCard_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonMemberSave);
            this.groupBox3.Controls.Add(this.textBoxAddress);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxPhoneNum);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxDate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBoxDepartment);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBoxPosition);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxMemberAge);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBoxMemberGender);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxMemberName);
            this.groupBox3.Location = new System.Drawing.Point(126, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 486);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "사원등록";
            // 
            // buttonMemberSave
            // 
            this.buttonMemberSave.Location = new System.Drawing.Point(81, 444);
            this.buttonMemberSave.Name = "buttonMemberSave";
            this.buttonMemberSave.Size = new System.Drawing.Size(76, 36);
            this.buttonMemberSave.TabIndex = 16;
            this.buttonMemberSave.Text = "등록";
            this.buttonMemberSave.UseVisualStyleBackColor = true;
            this.buttonMemberSave.Click += new System.EventHandler(this.buttonMemberSave_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(107, 410);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(103, 28);
            this.textBoxAddress.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "주소 :";
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Location = new System.Drawing.Point(107, 362);
            this.textBoxPhoneNum.Multiline = true;
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(103, 28);
            this.textBoxPhoneNum.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "연락처 :";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(107, 312);
            this.textBoxDate.Multiline = true;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(103, 28);
            this.textBoxDate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "입사일 :";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(107, 258);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(103, 26);
            this.comboBoxDepartment.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "소속부서:";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(107, 206);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(103, 26);
            this.comboBoxPosition.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "직급 :";
            // 
            // textBoxMemberAge
            // 
            this.textBoxMemberAge.Location = new System.Drawing.Point(107, 146);
            this.textBoxMemberAge.Multiline = true;
            this.textBoxMemberAge.Name = "textBoxMemberAge";
            this.textBoxMemberAge.Size = new System.Drawing.Size(103, 28);
            this.textBoxMemberAge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "나이 :";
            // 
            // comboBoxMemberGender
            // 
            this.comboBoxMemberGender.FormattingEnabled = true;
            this.comboBoxMemberGender.Location = new System.Drawing.Point(107, 94);
            this.comboBoxMemberGender.Name = "comboBoxMemberGender";
            this.comboBoxMemberGender.Size = new System.Drawing.Size(103, 26);
            this.comboBoxMemberGender.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "성별 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름 :";
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(107, 44);
            this.textBoxMemberName.Multiline = true;
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(103, 28);
            this.textBoxMemberName.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.급여내역서ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1019, 33);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 급여내역서ToolStripMenuItem
            // 
            this.급여내역서ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.급여내역서확인ToolStripMenuItem});
            this.급여내역서ToolStripMenuItem.Name = "급여내역서ToolStripMenuItem";
            this.급여내역서ToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.급여내역서ToolStripMenuItem.Text = "급여내역서";
            // 
            // 급여내역서확인ToolStripMenuItem
            // 
            this.급여내역서확인ToolStripMenuItem.Name = "급여내역서확인ToolStripMenuItem";
            this.급여내역서확인ToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.급여내역서확인ToolStripMenuItem.Text = "급여 내역서 확인";
            this.급여내역서확인ToolStripMenuItem.Click += new System.EventHandler(this.급여내역서확인ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTimeCard);
            this.groupBox1.Location = new System.Drawing.Point(642, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 132);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사원출근부";
            // 
            // button_addresssearch
            // 
            this.button_addresssearch.Location = new System.Drawing.Point(825, 145);
            this.button_addresssearch.Name = "button_addresssearch";
            this.button_addresssearch.Size = new System.Drawing.Size(90, 67);
            this.button_addresssearch.TabIndex = 32;
            this.button_addresssearch.Text = "주소검색";
            this.button_addresssearch.UseVisualStyleBackColor = true;
            this.button_addresssearch.Click += new System.EventHandler(this.button_addresssearch_Click);
            // 
            // FormPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 597);
            this.Controls.Add(this.button_addresssearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPersonnel";
            this.Text = "인사";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPersonnel_FormClosing);
            this.Load += new System.EventHandler(this.FormPersonnel_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxDepartmentType;
        private System.Windows.Forms.Button buttonSaveDepartment;
        private System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonDeleteDepartment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonChangeDepartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSearchDepartmentType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMemberAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMemberGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMemberSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonTimeCard;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView listViewShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeaderDepartment;
        private System.Windows.Forms.ColumnHeader columnHeaderHeader;
        private System.Windows.Forms.ComboBox comboBoxheadDepartment;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.Button button_addresssearch;
        private System.Windows.Forms.ToolStripMenuItem 급여내역서ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 급여내역서확인ToolStripMenuItem;
    }
}

