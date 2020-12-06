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
    public partial class FormApprovallist : Form
    {
        public string name = "";
        public string rank = "";
        // 결재 로그
        // 결재 승인, 반려

        // 부서장이 결재 작성할경우 결재자 1이 없어짐
        // 결재 생성시간 ==> 결재자 1
        public void Setinfo(string user, string user_rank)
        {
            this.name = user;
            this.rank = user_rank;
        }
        public FormApprovallist()
        {
            InitializeComponent();
            InitVariables();
        }
        public FormApprovallist(string u_name, string u_rank)
        {
            this.name = u_name;
            this.rank = u_rank;
            InitializeComponent();
            InitVariables();
        }
        public void InitVariables()
        {
            //내가 등록한 결재 진행 사항
            int num = DBM.GetDBMinstance().MyApproval_c(name);
            string[,] myappr = DBM.GetDBMinstance().MyApproval(name, num);
            for (int i = 0; i < num; i++)
            {
                ListViewItem item = new ListViewItem();
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        item.Text = myappr[i, j];
                    }
                    else
                    {
                        item.SubItems.Add(myappr[i, j]);
                    }
                }
                listViewMyappr.Items.Add(item);
            }

            //결재중 내역
            num = DBM.GetDBMinstance().MyApproval_ing_c(name);
            string[] myapp = DBM.GetDBMinstance().MyApproval_ing(name, num);
            listBoxing.Items.Clear();
            for (int i = 0; i < num; i++)
            {
                listBoxing.Items.Add(myapp[i]);
            }
            //결재 완료 내역
            //결재 승인
            num = DBM.GetDBMinstance().MyApproval_approval_c(name);
            string[] app = DBM.GetDBMinstance().MyApproval_approval(name, num);
            listBoxapp.Items.Clear();
            for(int i =0; i < num; i++)
            {
                listBoxapp.Items.Add(app[i]);
            }
            //결재 반려
            num = DBM.GetDBMinstance().MyApproval_return_c(name);
            string[] ret = DBM.GetDBMinstance().MyApproval_return(name, num);
            listBoxret.Items.Clear();
            for (int i = 0; i < num; i++)
            {
                listBoxret.Items.Add(ret[i]);
            }

            //내가 해야할 업무 리스트
            num = DBM.GetDBMinstance().MyApproval_work_c(rank);
            string[] work = DBM.GetDBMinstance().MyApproval_work(rank, num);
            listBoxwork.Items.Clear();
            for (int i = 0; i < num; i++)
            {
                listBoxwork.Items.Add(work[i]);
            }

        }
        private void listBoxret_SelectedIndexChanged(object sender, EventArgs e) // 반려 리스트박스 선택시
        {
            string ret = listBoxret.SelectedItem.ToString();
            string ret_com = DBM.GetDBMinstance().Approval_returncomment(ret);
            MessageBox.Show(ret_com);
        }
        private void listBoxwork_SelectedIndexChanged(object sender, EventArgs e) // 결재 해야할 업무 선택시
        {
            try
            {
                string name = listBoxwork.SelectedItem.ToString();
                //결재 제목로 업무, 텍스트, 코멘트를 가져옴
                string[] app_info = DBM.GetDBMinstance().Approval_info(name);
                labelname.Text = name;
                labelwork.Text = app_info[0];
                textBoxapptext.Text = app_info[1];
                labelcomment.Text = app_info[2];
            }
            catch
            {
                MessageBox.Show("결제제목을 선택해 주세요");
            }
            
        }
        private void buttonappr_Click(object sender, EventArgs e) // 승인버튼 클릭시
        {
            string now = DateTime.Now.ToString();
            if (rank.Equals("부서장") || rank.Equals("사장"))
            {
                string name = labelname.Text;
                DBM.GetDBMinstance().Approval_approval(rank,name);
                if (rank.Equals("부서장"))
                {
                    DBM.GetDBMinstance().Approval_approval_log(name, now);
                }
                else
                {
                    DBM.GetDBMinstance().Approval_approval_log_rank(name, now);
                }
            }
            else
            {
                MessageBox.Show("권한이 없습니다.");
            }
            int num = DBM.GetDBMinstance().MyApproval_work_c(rank);
            string[] work = DBM.GetDBMinstance().MyApproval_work(rank, num);
            listBoxwork.Items.Clear();
            for (int i = 0; i < num; i++)
            {
                listBoxwork.Items.Add(work[i]);
            }
        }

        private void buttonreturn_Click(object sender, EventArgs e) // 반려버튼 클릭시
        {
            string now = DateTime.Now.ToString();
            if (rank.Equals("부서장") || rank.Equals("사장"))
            {
                string name = labelname.Text;
                string comment = textBoxreturn.Text;
                DBM.GetDBMinstance().Approval_return(name, comment);
                DBM.GetDBMinstance().Approval_return_log(name, now);
            }
            else
            {
                MessageBox.Show("권한이 없습니다.");
            }
            int num = DBM.GetDBMinstance().MyApproval_work_c(rank);
            string[] work = DBM.GetDBMinstance().MyApproval_work(rank, num);
            listBoxwork.Items.Clear();
            for (int i = 0; i < num; i++)
            {
                listBoxwork.Items.Add(work[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormApprovallog form = new FormApprovallog();
            form.Show();
        }
    }
}
