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
            this.buttonDeletePerson = new System.Windows.Forms.Button();
            this.buttonChangePerson = new System.Windows.Forms.Button();
            this.listViewDepartmentType = new System.Windows.Forms.ListView();
            this.columnHeaderAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonDeletePerson
            // 
            this.buttonDeletePerson.Location = new System.Drawing.Point(685, 232);
            this.buttonDeletePerson.Name = "buttonDeletePerson";
            this.buttonDeletePerson.Size = new System.Drawing.Size(87, 48);
            this.buttonDeletePerson.TabIndex = 28;
            this.buttonDeletePerson.Text = "삭제";
            this.buttonDeletePerson.UseVisualStyleBackColor = true;
            // 
            // buttonChangePerson
            // 
            this.buttonChangePerson.Location = new System.Drawing.Point(685, 142);
            this.buttonChangePerson.Name = "buttonChangePerson";
            this.buttonChangePerson.Size = new System.Drawing.Size(87, 52);
            this.buttonChangePerson.TabIndex = 27;
            this.buttonChangePerson.Text = "수정";
            this.buttonChangePerson.UseVisualStyleBackColor = true;
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
            this.listViewDepartmentType.HideSelection = false;
            this.listViewDepartmentType.Location = new System.Drawing.Point(28, 47);
            this.listViewDepartmentType.Name = "listViewDepartmentType";
            this.listViewDepartmentType.Size = new System.Drawing.Size(637, 356);
            this.listViewDepartmentType.TabIndex = 25;
            this.listViewDepartmentType.UseCompatibleStateImageBehavior = false;
            this.listViewDepartmentType.View = System.Windows.Forms.View.Details;
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
            // FormAgePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeletePerson);
            this.Controls.Add(this.buttonChangePerson);
            this.Controls.Add(this.listViewDepartmentType);
            this.Name = "FormAgePersonnel";
            this.Text = "나이별";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeletePerson;
        private System.Windows.Forms.Button buttonChangePerson;
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