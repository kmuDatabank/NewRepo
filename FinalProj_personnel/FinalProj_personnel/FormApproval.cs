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
    public partial class FormApproval : Form
    {
        String writer = "";
        String rank = "";
        public void setname(String name) {
            this.writer = name;
            labelapname.Text = name;
            setrank(DBM.GetDBMinstance().checkrank(name));
        }
        public void setrank(String rank)
        {
            this.rank = rank;
            labelaprank.Text = rank;
        }
        public FormApproval()
        {
            InitializeComponent();
            InitVariable();
        }

        public void InitVariable()
        {
            comboBoxnewappr_work.Items.Clear();
            comboBoxnewappr_work.Items.Add("1"); // 뭐 넣어야 될지 몰라서 1, 2 넣어둠.
            comboBoxnewappr_work.Items.Add("2");

            comboBoxappr1.Items.Clear();
            comboBoxappr1.Items.Add("3");
            comboBoxappr1.Items.Add("4");
            comboBoxappr2.Items.Clear();
            comboBoxappr2.Items.Add("5");
            comboBoxappr2.Items.Add("6");



        }

        private void buttonnewappr_Click(object sender, EventArgs e)
        {

            if(textBoxnewappr_name.Text == "") // 제목 빈칸
            {
                MessageBox.Show("결재 제목을 작성해 주세요");
            }
            if (comboBoxnewappr_work.SelectedIndex == -1) // 업무 미선택
            {
                MessageBox.Show("관련 업무을 선택해 주세요");
            }
            if (textBoxnewappr_text.Text == "") // 내용 빈칸
            {
                MessageBox.Show("결재 내용을 작성해 주세요");
            }
            if(comboBoxappr1.SelectedIndex == -1 || comboBoxappr2.SelectedIndex == -1)//결재자 미입력
            {
                MessageBox.Show("결재자를 선택해 주세요");
            }
            
            if (textBoxnewappr_name.Text != "" && comboBoxnewappr_work.SelectedIndex != -1 && textBoxnewappr_text.Text != ""
                && comboBoxappr1.SelectedIndex != -1 && comboBoxappr2.SelectedIndex != -1)
            {
                string name = textBoxnewappr_name.Text;
                string work = comboBoxnewappr_work.SelectedItem.ToString();
                string text = textBoxnewappr_text.Text;
                string comment = textBoxnewappr_comment.Text;
                string approver1 = comboBoxappr1.SelectedItem.ToString();
                string approver2 = comboBoxappr2.SelectedItem.ToString();


                DBM.GetDBMinstance().newApproval(name, work, text, comment);
                DBM.GetDBMinstance().Approsearch_make(writer, name, approver1, approver2);
            }
        }

        private void buttonsearchappr_Click(object sender, EventArgs e)
        {
            FormSearchApproval form = new FormSearchApproval();
            form.Show();
        }
    }
}
