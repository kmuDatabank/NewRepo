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

        string backupname = ""; //사원 수정시 이름으로 받아올때 필요한 변수
        String text1= ""; //콤보박스
        String text2 = ""; //빈 텍스트박스


        public FormDepartmentPersonnel()
        {
            InitializeComponent();
            InitVariables();
        }

        public FormDepartmentPersonnel(String text1,String text2)
        {
            InitializeComponent();
            InitVariables();
            this.text1 = text1;
            this.text2 = text2;
        }




        public void SetComboDepartText(string text) //콤보박스
        {
            this.text1 = text;
        }
        public void SetDepartText(string text) //빈 텍스트박스 
        {
            this.text2 = text;
        }
        private void InitVariables()
        {
            //성별
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


            string[,] aa = new string[13, 8];
            aa = DBM.GetDBMinstance().Search();





            for (int i = 0; i < 13; i++)
            {
                if (aa[i,0] == null)
                {
                    break;
                }
                ListViewItem item = new ListViewItem();
                for (int j = 0; j < 8; j++)
                {
                    if (j == 0)
                    {
                        item.Text = aa[i, j];
                    }
                    else
                    {
                        item.SubItems.Add(aa[i, j]);
                    }
                }
                listViewDepartmentType.Items.Add(item);
            }
            textBoxInput.Text = text2;


        }

      

        private void buttonDepartSearch_Click(object sender, EventArgs e) //검색
        {
            string text = textBoxInput.Text;
            String[,] save = new String[13, 8];
            int k = 0;

            foreach (ListViewItem lvi in listViewDepartmentType.Items)
            {
                if (text == lvi.SubItems[4].Text)//검색조건 일치시
                {

                    save[k,0] = lvi.SubItems[0].Text;//이름으로 검색                   
                    save[k,1] = lvi.SubItems[1].Text; //성별
                    save[k,2] = decimal.Parse(lvi.SubItems[2].Text).ToString(); ; //나이
                    save[k,3] = lvi.SubItems[3].Text; //직급
                    save[k,4] = lvi.SubItems[4].Text; //소속부서
                    save[k,5] = lvi.SubItems[5].Text;//입사일
                    save[k,6] = lvi.SubItems[6].Text;//연락처
                    save[k,7] = lvi.SubItems[7].Text;//주소
                    k++;


                }

            }

            listViewDepartmentType.Items.Clear();

            for (int i = 0; i < 13; i++)
            {
                if (save[i, 0] == null)
                {
                    break;
                }
                ListViewItem item = new ListViewItem();
                for (int j = 0; j < 8; j++)
                {
                    if (j == 0)
                    {
                        item.Text = save[i, j];
                    }
                    else
                    {
                        item.SubItems.Add(save[i, j]);
                    }
                }
                listViewDepartmentType.Items.Add(item);
            }

        }


        private void listViewDepartmentType_MouseDown(object sender, MouseEventArgs e) //리스트뷰에서 우클릭
        {
            if (e.Button == MouseButtons.Right)
            {
                EventHandler eh = new EventHandler(MenuClick);
                MenuItem[] ami =
                {                
                    new MenuItem("삭제", eh)
                };
                ContextMenu = new System.Windows.Forms.ContextMenu(ami);
            }

        }
        void MenuClick(object obj, EventArgs ea)
        {
            MenuItem mi = (MenuItem)obj;
            String str = mi.Text;

            if (str == "삭제")
            {
                //한줄만 삭제        
                int index = listViewDepartmentType.FocusedItem.Index;//열 좌표
                string d = listViewDepartmentType.Items[index].SubItems[0].Text; //선택된 열의 이름으로 삭제

                DBM.GetDBMinstance().PersonnelDelete(d); //삭제


                //listViewDepartmentType.Items.Remove(listViewDepartmentType.SelectedItems[index]);
                listViewDepartmentType.Items.Remove(listViewDepartmentType.Items[index]);
                MessageBox.Show(d + "삭제하였습니다.");
                

                /*          
                //선택한 Line 다중 삭제
                foreach(ListViewItem lv in listViewDepartmentType.SelectedItems)
                {
                    listViewDepartmentType.Items.Remove(lv);
                }
                listViewDepartmentType.Update();
                */
            }

        }
      
  
     
        //리스트뷰에서 사원 클릭시 옆에 텍스트박스로 정보 띄우기
        private void listViewDepartmentType_Click(object sender, EventArgs e)
        {
            if (listViewDepartmentType.SelectedIndices.Count > 0)
            {
                textBoxMemberName.Text = listViewDepartmentType.SelectedItems[0].SubItems[0].Text;
                comboBoxMemberGender.Text = listViewDepartmentType.SelectedItems[0].SubItems[1].Text;
                numericUpDownAge.Text = listViewDepartmentType.SelectedItems[0].SubItems[2].Text;
                comboBoxPosition.Text = listViewDepartmentType.SelectedItems[0].SubItems[3].Text;
                comboBoxDepartment.Text = listViewDepartmentType.SelectedItems[0].SubItems[4].Text;
                textBoxDate.Text = listViewDepartmentType.SelectedItems[0].SubItems[5].Text;
                textBoxPhoneNum.Text = listViewDepartmentType.SelectedItems[0].SubItems[6].Text;
                textBoxAddress.Text = listViewDepartmentType.SelectedItems[0].SubItems[7].Text;
            }

            backupname= listViewDepartmentType.SelectedItems[0].SubItems[0].Text;
        }

        //사원 수정완료 버튼
        private void buttonFixComplete_Click(object sender, EventArgs e)
        {
            bool selected = listViewDepartmentType.SelectedItems.Count > 0;
            if (selected == false)
            {
                throw new ApplicationException(
                         "선택 항목이 없는데 수정 요청하였습니다.");
            }
            ListViewItem lvi = listViewDepartmentType.SelectedItems[0];
            string name = textBoxMemberName.Text;
            string gender = comboBoxMemberGender.Text;
            decimal age = numericUpDownAge.Value;
            string position = comboBoxPosition.Text;
            string department = comboBoxDepartment.Text;
            string date = textBoxDate.Text;
            string phoneNum = textBoxPhoneNum.Text;
            string address = textBoxAddress.Text;

            lvi.SubItems[0].Text = name;
            lvi.SubItems[1].Text = gender.ToString();
            lvi.SubItems[2].Text = age.ToString();
            lvi.SubItems[3].Text = position.ToString();
            lvi.SubItems[4].Text = department.ToString();
            lvi.SubItems[5].Text = date;
            lvi.SubItems[6].Text = phoneNum;
            lvi.SubItems[7].Text = address;


            string age1 = numericUpDownAge.Value.ToString();

            DBM.GetDBMinstance().personnel_change(backupname,name, gender, position, department, date, phoneNum, address, age1);
            MessageBox.Show("수정되었습니다.");
        }
    }
}
 

