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
    public partial class FormAgePersonnel : Form
    {
        string text1 = "";
        string text2 = "";

        public FormAgePersonnel()
        {
            InitializeComponent();
            InitVariables();
        }

        public void SetAgeText(string text)
        {
            this.text1 = text;
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


            string[,] aa = new string[3, 8];
            aa = DBM.GetDBMinstance().Search();

            for (int i = 0; i < 3; i++)
            {
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

        }

        private void buttonDepartSearch_Click(object sender, EventArgs e) //검색
        {
            string text = textBoxInput.Text;
            foreach (ListViewItem lvi in listViewDepartmentType.Items)
            {
                if (text == lvi.SubItems[0].Text)
                {
                    textBoxMemberName.Text = lvi.SubItems[0].Text;//이름으로 검색                   
                    comboBoxMemberGender.Text = lvi.SubItems[1].Text; //성별
                    numericUpDownAge.Value = decimal.Parse(lvi.SubItems[2].Text); //나이
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

     
        private void buttonDeletePerson_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in listViewDepartmentType.SelectedItems)
            {
                listViewDepartmentType.Items.Remove(lv); //일단 리스트뷰에서는 삭제됌.
            }
        }

        private void listViewDepartmentType_MouseDown(object sender, MouseEventArgs e) //리스트뷰 우클릭
        {
            if (e.Button == MouseButtons.Right)
            {
                EventHandler eh = new EventHandler(MenuClick);
                MenuItem[] ami =
                {
                    new MenuItem("수정", eh),
                    new MenuItem("삭제", eh)
                };
                ContextMenu = new System.Windows.Forms.ContextMenu(ami);
            }
        }
        void MenuClick(object obj, EventArgs ea)
        {
            MenuItem mi = (MenuItem)obj;
            String str = mi.Text;
            if (str == "수정")
                MessageBox.Show("수정을 선택하였습니다.");

            if (str == "삭제")
                MessageBox.Show("삭제를 선택하였습니다.");

        }

    }
}
