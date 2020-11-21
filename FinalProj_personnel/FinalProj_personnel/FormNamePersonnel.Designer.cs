namespace FinalProj_personnel
{
    partial class FormNamePersonnel
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
            this.buttonDeletePerson = new System.Windows.Forms.Button();
            this.buttonChangePerson = new System.Windows.Forms.Button();
            this.buttonTimeCard = new System.Windows.Forms.Button();
            this.listViewDepartmentType = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonDeletePerson
            // 
            this.buttonDeletePerson.Location = new System.Drawing.Point(686, 256);
            this.buttonDeletePerson.Name = "buttonDeletePerson";
            this.buttonDeletePerson.Size = new System.Drawing.Size(87, 48);
            this.buttonDeletePerson.TabIndex = 32;
            this.buttonDeletePerson.Text = "삭제";
            this.buttonDeletePerson.UseVisualStyleBackColor = true;
            this.buttonDeletePerson.Click += new System.EventHandler(this.buttonDeletePerson_Click);
            // 
            // buttonChangePerson
            // 
            this.buttonChangePerson.Location = new System.Drawing.Point(686, 166);
            this.buttonChangePerson.Name = "buttonChangePerson";
            this.buttonChangePerson.Size = new System.Drawing.Size(87, 52);
            this.buttonChangePerson.TabIndex = 31;
            this.buttonChangePerson.Text = "수정";
            this.buttonChangePerson.UseVisualStyleBackColor = true;
            // 
            // buttonTimeCard
            // 
            this.buttonTimeCard.Location = new System.Drawing.Point(686, 83);
            this.buttonTimeCard.Name = "buttonTimeCard";
            this.buttonTimeCard.Size = new System.Drawing.Size(87, 53);
            this.buttonTimeCard.TabIndex = 30;
            this.buttonTimeCard.Text = "출근부";
            this.buttonTimeCard.UseVisualStyleBackColor = true;
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
            this.listViewDepartmentType.Location = new System.Drawing.Point(28, 47);
            this.listViewDepartmentType.Name = "listViewDepartmentType";
            this.listViewDepartmentType.Size = new System.Drawing.Size(637, 356);
            this.listViewDepartmentType.TabIndex = 29;
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
            // FormNamePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeletePerson);
            this.Controls.Add(this.buttonChangePerson);
            this.Controls.Add(this.buttonTimeCard);
            this.Controls.Add(this.listViewDepartmentType);
            this.Name = "FormNamePersonnel";
            this.Text = "이름별 검색";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeletePerson;
        private System.Windows.Forms.Button buttonChangePerson;
        private System.Windows.Forms.Button buttonTimeCard;
        private System.Windows.Forms.ListView listViewDepartmentType;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderGender;
        private System.Windows.Forms.ColumnHeader columnHeaderAge;
        private System.Windows.Forms.ColumnHeader columnHeaderPosition;
        private System.Windows.Forms.ColumnHeader columnHeaderDepartment;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
    }
}