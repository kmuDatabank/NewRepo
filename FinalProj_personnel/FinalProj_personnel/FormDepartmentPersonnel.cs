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
     

        private void FormDepartmentPersonnel_Load(object sender, EventArgs e)
        {
            //DBM.GetDBMinstance().personnelSearch();
        }

      //public FormDepartmentPersonnel(String text)

        private void buttonDepartSearch_Click(object sender, EventArgs e) //검색
        {
            string text = textBoxInput.Text;
            foreach (ListViewItem lvi in listViewDepartmentType.Items)
            {
                if(text == lvi.SubItems[0].Text)
                {
                    comboBoxDepartment.Text = text; //소속부서
                    textBoxMemberName.Text = lvi.SubItems[1].Text; //이름  -> 사실 이것도 빈텍스트값에 있는 값들을 받아오는거 아닌가... 그래서 이것도  =text;해야하는거 아닌가...
                    numericUpDownAge.Value = decimal.Parse(lvi.SubItems[2].Text); //나이
                    comboBoxMemberGender.Text = lvi.SubItems[3].Text; //성별                  
                    comboBoxPosition.Text = lvi.SubItems[4].Text;                
                    textBoxDate.Text = lvi.SubItems[5].Text;
                    textBoxPhoneNum.Text = lvi.SubItems[6].Text;
                    textBoxAddress.Text = lvi.SubItems[7].Text;
                    return;
                }
            }
            MessageBox.Show("관련되지 않은 텍스트입니다.");
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

