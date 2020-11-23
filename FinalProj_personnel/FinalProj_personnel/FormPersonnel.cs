using MySql.Data.MySqlClient;
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
        string strConn = "Server=49.50.174.201;Database=databank;Uid=databank;Pwd=dbdb;Charset=utf8";
        private bool loadCompleted_ = false;

        bool[] place = new bool[2]; //삭제할때 필요
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

            //사원검색
            comboBoxDepartmentType.Items.Clear();          
            comboBoxDepartmentType.Items.Add("부서별");
            comboBoxDepartmentType.Items.Add("이름별");
            comboBoxDepartmentType.Items.Add("나이별");
           

            //임의로 3개 생성하였음 -> 교수님 word파일참고하세요
            comboBoxDepartmentName.Items.Clear();
            comboBoxDepartmentName.Items.Add("인사부서");
            comboBoxDepartmentName.Items.Add("개발부서");
            comboBoxDepartmentName.Items.Add("관리부서");
            comboBoxDepartmentName.SelectedIndex = 0;



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

            /*
            if (loadCompleted_ == false)
                return;
            */

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
        //이부분 로직 어떻게되지..? 검색 버튼은 불러오기로 하는데 정보는 어떻게 종류별로 나누지?
        private void buttonSearchDepartmentType_Click(object sender, EventArgs e) //부서별 검색
        {
            if (comboBoxDepartmentType.SelectedIndex == 0) //부서별
            {
                FormDepartmentPersonnel form = new FormDepartmentPersonnel();
                form.SetDepartText("부서별 검색");
                form.Show();

            }
            if (comboBoxDepartmentType.SelectedIndex == 1) //나이별
            {
                FormNamePersonnel form = new FormNamePersonnel();
                form.SetNameText("나이별 검색");
                form.Show();

            }
            if (comboBoxDepartmentType.SelectedIndex == 2) //이름별
            {
                FormAgePersonnel form = new FormAgePersonnel();
                form.SetAgeText("이름별 검색");
                form.Show();

            }
        
          


            /*
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
            */


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
          

            //DBM.GetDBMinstance();
        }
        private void buttonDeletePerson_Click(object sender, EventArgs e) //삭제
        {
            string temp = textBoxHeadDepartment.Text;
            textBoxHeadDepartment.Text = String.Empty;

            DBM.GetDBMinstance().delete(temp);

            MessageBox.Show("삭제되었습니다.");
        }
        #endregion



        #region 부서등록 부분 -> 등록, 수정, 삭제
        private void buttonSaveDepartment_Click(object sender, EventArgs e) //등록
        {
            PersonInfo personInfo = new PersonInfo();
            personInfo.departmentName = comboBoxDepartmentName.SelectedItem.ToString();
            personInfo.headDepartment = textBoxHeadDepartment.Text;

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = "INSERT INTO Department(departmentName, headDepartment ) VALUES('" + personInfo.departmentName + "' , '" + personInfo.headDepartment + "');";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("부서장 등록되었습니다.");
            }


        }
        private void buttonChangeDepartment_Click(object sender, EventArgs e) //수정
        {

        }
        private void buttonDeleteDepartment_Click(object sender, EventArgs e) //삭제
        {
           
            string temp = textBoxHeadDepartment.Text;
            textBoxHeadDepartment.Text = String.Empty;

            place[1] = false;

            DBM.GetDBMinstance().delete(temp);

            MessageBox.Show("삭제되었습니다.");
        }






        #endregion

        private void FormPersonnel_Load(object sender, EventArgs e)
        {

        }

        private void buttonTimeCard_Click_1(object sender, EventArgs e)
        {
            FormTimeCardPesonnel form = new FormTimeCardPesonnel();
            form.SetTimeCardText("출근부 화면");
            form.Show();
        }
    }
}
