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
    public partial class FormDepartmentPersonnel : Form
    {

        string text1 ="";
        string text2 ="";

        public FormDepartmentPersonnel()
        {
            InitializeComponent();
            InitVariables();
        }
        private void InitVariables()
        {

        }
        public void SetComboDepartText(string text)
        {
            this.text1 = text;
        }
        public void SetDepartText(string text)
        {
            this.text2 = text; 
        }
     
        /*
        private void FormDepartmentPersonnel_Load(object sender, EventArgs e)
        {
            //DBM.GetDBMinstance().personnelSearch();
            int k = 1;
            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM Personnel ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
            }
        }
        */
       
       



            //public FormDepartmentPersonnel(String text)

            private void buttonDepartSearch_Click(object sender, EventArgs e) //검색
        {
            string text = textBoxInput.Text;
            foreach (ListViewItem lvi in listViewDepartmentType.Items)
            {
                if(text == lvi.SubItems[0].Text)
                {
                    textBoxMemberName.Text = text; //이름으로 검색
                    numericUpDownAge.Value = decimal.Parse(lvi.SubItems[1].Text); //아리
                    comboBoxMemberGender.Text = lvi.SubItems[2].Text; //성별
                    comboBoxPosition.Text = lvi.SubItems[3].Text; //직급
                    comboBoxDepartment.Text = lvi.SubItems[4].Text; //소속부서
                    textBoxDate.Text = lvi.SubItems[5].Text;//입사일
                    textBoxPhoneNum.Text = lvi.SubItems[6].Text;//연락처
                    textBoxAddress.Text = lvi.SubItems[7].Text;//주소
                    return;
                }
            }
            MessageBox.Show("이름으로 검색하여주세요.");
        }
        private void buttonDepartChange_Click_1(object sender, EventArgs e) //수정
        {
            bool selected = listViewDepartmentType.SelectedItems.Count > 0;
            if (selected == false)
            {
                throw new ApplicationException("선택항목이 없는데 수정을 요청하였습니다.");
            }
            ListViewItem lvi = listViewDepartmentType.SelectedItems[0];
            string department = comboBoxDepartment.Text;
            string name = textBoxMemberName.Text;
            decimal age = numericUpDownAge.Value;

            lvi.SubItems[1].Text = name;
            lvi.SubItems[2].Text = age.ToString();
            //ClearInputControl();


        }

        private void buttonDepartDelete_Click(object sender, EventArgs e) //삭제
        {

        }

        public string selectedlist; // listview에서 선택된 list를 알게해주는 변수
        private void listViewDepartmentType_MouseDown(object sender, MouseEventArgs e) //리스트뷰에서 우클릭 다시하기
        {
            if (e.Button == MouseButtons.Right)
            {
                selectedlist = listViewDepartmentType.GetItemAt(e.X, e.Y).Text;
              
            }
           
        }

        private void listViewDepartmentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }

