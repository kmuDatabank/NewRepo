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
using 다음주소api;

namespace FinalProj_personnel
{
    public partial class FormPersonnel : Form
    {
        string strConn = "Server=49.50.174.201;Database=databank;Uid=databank;Pwd=dbdb;Charset=utf8";
        private bool loadCompleted_ = false;

        string backupname = ""; //부서등록에서 사원이름으로 받아올때 필요한 변수
        string position = ""; //강등시킬때?
        String name="";
        bool[] place = new bool[2]; //삭제할때 필요
        public FormPersonnel()
        {
            InitializeComponent();
            InitVariable();
        }

        public FormPersonnel(String name)
        {
            InitializeComponent();
            InitVariable();
            this.name = name;
        }



        //사원 성별
        private void InitVariable()
        {
            comboBoxMemberGender.Items.Clear();
            comboBoxMemberGender.Items.Add("남자");
            comboBoxMemberGender.Items.Add("여자");

            //직급
            comboBoxPosition.Items.Clear();
            comboBoxPosition.Items.Add("일반 사원");
            comboBoxPosition.Items.Add("부서장");
            comboBoxPosition.Items.Add("사장");

            //소속부서
            comboBoxDepartment.Items.Clear();
            comboBoxDepartment.Items.Add("인사부서");
            comboBoxDepartment.Items.Add("개발부서");
            comboBoxDepartment.Items.Add("관리부서");

            //사원검색 부분
            comboBoxDepartmentType.Items.Clear();
            comboBoxDepartmentType.Items.Add("부서별");
            comboBoxDepartmentType.Items.Add("이름별");
            comboBoxDepartmentType.Items.Add("나이별");

            /*
            //임의로 3개 생성하였음
            comboBoxDepartmentName.Items.Clear();
            comboBoxDepartmentName.Items.Add("인사부서");
            comboBoxDepartmentName.Items.Add("개발부서");
            comboBoxDepartmentName.Items.Add("관리부서");
            comboBoxDepartmentName.SelectedIndex = 0;
            */

            //부서등록 부서장
            comboBoxheadDepartment.Items.Clear();
            int per_n = DBM.GetDBMinstance().personnel_n(); //부서장 등록할때 사원이 몇명있는지
            string[] per_info = DBM.GetDBMinstance().personnelinfo(per_n); //사원들 이름
            
            for(int i = 0; i < per_n; i++)
            {
                comboBoxheadDepartment.Items.Add(per_info[i]);
            }
            int a_n = DBM.GetDBMinstance().departinfo_n();
            string[,] a = DBM.GetDBMinstance().departinfo(a_n);
            for (int i = 0; i < a_n; i++) 
            {
                ListViewItem item = new ListViewItem();
                for (int j = 0; j < 2; j++)
                {
                    if(j == 0)
                    {
                        item.Text = a[i, j];
                    }
                    else
                    {
                        item.SubItems.Add(a[i, j]);
                    }
                }
                listViewShow.Items.Add(item);
            }

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
            PersonInfo personInfo = new PersonInfo();
            personInfo.name = textBoxMemberName.Text;
            personInfo.gender = comboBoxMemberGender.SelectedItem.ToString();
            personInfo.age = textBoxMemberAge.Text;
            personInfo.position = comboBoxPosition.SelectedItem.ToString();
            personInfo.department = comboBoxDepartment.SelectedItem.ToString();
            personInfo.date = textBoxDate.Text;
            personInfo.phoneNum = textBoxPhoneNum.Text;
            personInfo.address = textBoxAddress.Text;

            
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = "INSERT INTO Personnel(name, gender, age,position, department, date , phoneNum, address) VALUES('" + personInfo.name + "' , '" + personInfo.gender + "', '" + personInfo.age + "', " 
                    +"'"+ personInfo.position + "','" + personInfo.department + "','" + personInfo.date + "','" + personInfo.phoneNum + "','" + personInfo.address + "');";
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();             
               
                MessageBox.Show("등록되었습니다.");
            }
         
        }


        //사원 검색부분에서 콤보박스랑 텍스트박스 변수
        String text1 = ""; //콤보박스
        String text2 = ""; //빈박스 

       //사원검색 부분
        private void buttonSearchDepartmentType_Click(object sender, EventArgs e) //부서별 검색
        {
            if (comboBoxDepartmentType.SelectedIndex == 0) //부서별
            {
                FormDepartmentPersonnel form = new FormDepartmentPersonnel(text1, text2);
                form.SetDepartText("부서별 검색");
                form.SetComboDepartText(comboBoxDepartmentType.Text);
                form.Show();
               
            }
            if (comboBoxDepartmentType.SelectedIndex == 1) //나이별
            {
                FormNamePersonnel form = new FormNamePersonnel(text1,text2);
                form.SetNameText("나이별 검색");
                form.Show();

            }
            if (comboBoxDepartmentType.SelectedIndex == 2) //이름별
            {
                FormAgePersonnel form = new FormAgePersonnel(text1,text2);
                form.SetAgeText("이름별 검색");
                form.Show();
            }                 
        }



        #region 부서등록 부분 -> 등록, 수정, 삭제

        //리스트뷰 사원 선택시 옆 텍스트박스에 정보 띄우기
        private void listViewShow_Click(object sender, EventArgs e)
        {
            if (listViewShow.SelectedIndices.Count > 0)
            {
                textBoxDepartmentName.Text = listViewShow.SelectedItems[0].SubItems[0].Text;
                comboBoxheadDepartment.Text = listViewShow.SelectedItems[0].SubItems[1].Text;

                backupname = listViewShow.SelectedItems[0].SubItems[0].Text;
            }
        }
        private void buttonSaveDepartment_Click(object sender, EventArgs e) //등록
        {
            String departmentName = "";
            String headDepartment = "";
            String temp = "";
           
            departmentName = textBoxDepartmentName.Text;
            headDepartment = comboBoxheadDepartment.SelectedItem.ToString();          
           
            string[] strs = new string[] { departmentName, headDepartment.ToString() };         
            ListViewItem lvi = new ListViewItem(strs);
            lvi.Text = departmentName;

            //중복제거
            int a = 0;
            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM Department";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    temp = rdr["departmentName"].ToString();

                    if (temp == departmentName)
                    {
                        MessageBox.Show("부서가 중복됩니다.");
                        a = 1;
                        return;                     
                    }
                   
                }              
            }
            
            if (a == 0)
            {
                listViewShow.Items.Add(lvi);
                DBM.GetDBMinstance().department_enroll(departmentName, headDepartment);
                DBM.GetDBMinstance().upgrade(headDepartment,departmentName);
            }

        }
      
        private void buttonChangeDepartment_Click(object sender, EventArgs e) //수정
        {
            PersonInfo personInfo = new PersonInfo();
            personInfo.departmentName= textBoxDepartmentName.Text;
        
            string departmentName = textBoxDepartmentName.Text; // 텍스트박스 부서명
            string headDepartment = comboBoxheadDepartment.SelectedItem.ToString(); // 콤보박스 사원명

            // 기존 부서장 이름 따오기
            string ori_name = DBM.GetDBMinstance().ori_depart(departmentName);
            // 기존 부서장 강등
            DBM.GetDBMinstance().original(ori_name);
            // department 변경
            DBM.GetDBMinstance().department_change(departmentName,headDepartment);
            // 새로운 부서장 등록
            DBM.GetDBMinstance().upgrade(headDepartment,departmentName);
            MessageBox.Show("부서장 수정되었습니다.");
           
            listViewShow.Items.Clear();
            int a_n = DBM.GetDBMinstance().departinfo_n();
            string[,] a = DBM.GetDBMinstance().departinfo(a_n);
            for (int i = 0; i < a_n; i++)
            {
                ListViewItem item = new ListViewItem();
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        item.Text = a[i, j];
                    }
                    else
                    {
                        item.SubItems.Add(a[i, j]);
                    }
                }
              
                listViewShow.Items.Add(item);
            }

        }
       
        private void buttonDeleteDepartment_Click(object sender, EventArgs e) //삭제
        {        
            string department = listViewShow.FocusedItem.Text;
            string departmentName = textBoxDepartmentName.Text;
            string headDepartment = comboBoxheadDepartment.Text;    
            
            place[1] = false;

            int index = listViewShow.FocusedItem.Index;//열 좌표
            string d = listViewShow.Items[index].SubItems[0].Text; //선택된 열의 이름으로 삭제

            listViewShow.Items.Remove(listViewShow.Items[index]);

            DBM.GetDBMinstance().original(headDepartment); //일반 사원으로 강등
            DBM.GetDBMinstance().department_delete(department); //부서 삭제


            MessageBox.Show("삭제되었습니다.");
         
   
        }
        #endregion

        private void FormPersonnel_Load(object sender, EventArgs e)
        {

        }

        //출근부 버튼 클릭시
        private void buttonTimeCard_Click_1(object sender, EventArgs e)
        {
            FormTimeCardPesonnel form = new FormTimeCardPesonnel(name);

            form.Show();
        }

        private void button_addresssearch_Click(object sender, EventArgs e)//
        {
            frmSearchZip frm = new frmSearchZip();
            frm.Show();
        }

        private void 급여내역서확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPayViewer form = new FormPayViewer();
            form.Show();
        }
    }
}
