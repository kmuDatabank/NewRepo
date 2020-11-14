﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProj_personnel
{
    public partial class FormPersonnel : Form
    {
        string strConn = "Server=49.50.174.201;Database=databank;Uid=databank;Pwd=databank;Charset=utf8";
        private bool loadCompleted_ = false;
        public FormPersonnel()
        {
            InitializeComponent();
            InitVariable();
        }
        //사원 성별
        private void InitVariable()
        {
            comboBoxMemberGender.Items.Clear();
            comboBoxMemberGender.Items.Add("남자");
            comboBoxMemberGender.Items.Add("여자");

            comboBoxPosition.Items.Add("일반 사원");
            comboBoxPosition.Items.Add("부서장");
            comboBoxPosition.Items.Add("사장");

            comboBoxDepartment.Items.Add("부서별");
            comboBoxDepartment.Items.Add("이름별");
            comboBoxDepartment.Items.Add("나이별");

            comboBoxDepartmentType.Items.Add("부서별");
            comboBoxDepartmentType.Items.Add("이름별");
            comboBoxDepartmentType.Items.Add("나이별");

            comboBoxDepartmentName.Items.Add("인사부서");
            comboBoxDepartmentName.Items.Add("개발부서");
            comboBoxDepartmentName.Items.Add("관리부서");

        }



        //form1_FormPersonnel창 닫기
        private void FormPersonnel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "종료", MessageBoxButtons.OKCancel) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void buttonMemberSave_Click(object sender, EventArgs e)
        {

            if (loadCompleted_ == false)
                return;

            PersonInfo personInfo = new PersonInfo();
            personInfo.name = textBoxMemberName.Text;
            personInfo.gender = comboBoxMemberGender.SelectedItem.ToString();
            personInfo.age = textBoxMemberAge.Text;
            personInfo.position = comboBoxMemberGender.SelectedItem.ToString();
            personInfo.department = comboBoxDepartment.SelectedItem.ToString();
            personInfo.date = textBoxDate.Text;
            personInfo.phoneNum = textBoxPhoneNum.Text;
            personInfo.address = textBoxAddress.Text;

           
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = "INSERT INTO Personnel(name, gender, age,position, department, date , phoneNum, address) VALUES('" + personInfo.name + "' , " + personInfo.gender + ", '" + personInfo.age + ", '"
                    + personInfo.position + ", '" + personInfo.department + ", '" + personInfo.date + ", '" + personInfo.phoneNum + ", '" + personInfo.address + "');";
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();             
               
                MessageBox.Show("등록되었습니다.");
            }
        }

        #region 메뉴Strip부분 -> 기본급, 수당, 공제
        private void 기본급ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPayViewer form = new FormPayViewer();
            form.SetPayText("기본급");
            form.Show();
        }

        private void 수당ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPayViewer form = new FormPayViewer();
            form.SetPayText("수당");
            form.Show();
        }

        private void 공제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPayViewer form = new FormPayViewer();
            form.SetPayText("공제");
            form.Show();
        }
        #endregion

         
        #region 사원검색 부분 -> 검색, 출근부, 수정, 삭제
        private void buttonSearchDepartmentType_Click(object sender, EventArgs e) //부서별 검색
        {
            if (loadCompleted_ == false)
                return;

            PersonInfo personInfo = new PersonInfo();
            personInfo.departmentType = comboBoxDepartmentType.SelectedItem.ToString(); 
            personInfo.inputDepartment = textBoxInputDepartment.Text;
          

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = "INSERT INTO Personnel(departmentType, inputDepartment) VALUES('" + personInfo.departmentType + "' , " + personInfo.inputDepartment + "');";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("부서를 검색합니다.");
            }
        }
        private void comboBoxDepartmentType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBoxInputDepartment.Text = comboBoxDepartmentType.SelectedItem.ToString();

        }




        private void buttonTimeCard_Click(object sender, EventArgs e) //출근부
        {

        }

        private void buttonChangePerson_Click(object sender, EventArgs e) //수정
        {

        }
        private void buttonDeletePerson_Click(object sender, EventArgs e) //삭제
        {

        }
        #endregion



        #region 부서등록 부분 -> 등록, 수정, 삭제
        private void buttonSaveDepartment_Click(object sender, EventArgs e) //등록
        {

        }
        private void buttonChangeDepartment_Click(object sender, EventArgs e) //수정
        {

        }
        private void buttonDeleteDepartment_Click(object sender, EventArgs e) //삭제
        {

        }





        #endregion

     
    }
}
