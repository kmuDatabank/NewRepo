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
    public partial class FormMain : Form
    {
        String name = "";
        String rank = "";
        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(String name1)
        {
            InitializeComponent();
            this.name = name1;
            label_name.Text = name;
            //String ran = DBM.GetDBMinstance().checkrank(name1);
            //setrank(ran);
        }
        public void setrank(String rank)
        {
            this.rank = rank;
            label_rank.Text = rank;
        }

        private void buttonPersonnel_Click(object sender, EventArgs e) // 인사 버튼
        {
            FormPersonnel form = new FormPersonnel();
            form.Show();
        }

        private void buttonWork_Click(object sender, EventArgs e) // 업무 버튼
        {

        }

        private void buttonApproval_Click(object sender, EventArgs e) // 결재 버튼
        {
            FormApproval form = new FormApproval();
            form.setname(name);
            form.Show();
        }

        private void button_logout_Click(object sender, EventArgs e) // 로그아웃 버튼
        {
            this.Close();
        }
    }
}
