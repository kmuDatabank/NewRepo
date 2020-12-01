using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Authentication;

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


            this.name=named(name);
            label_name.Text = name;
            String ran = DBM.GetDBMinstance().checkrank(name);
            setrank(ran);
        }
        public void setrank(String rank)
        {
            this.rank = rank;
            label_rank.Text = rank;
        }

        public String named(String P_ID)
        {

            String result = "";

            using (DBM.Getinstance())
            {
                String query = "SELECT * FROM Personnel WHERE ID= "+"\""+P_ID+"\"";
                DBM.Getinstance().Open();
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result = rdr["name"].ToString();

                }

            }


                return result;
        }




        private void buttonPersonnel_Click(object sender, EventArgs e) // 인사 버튼
        {
            FormPersonnel form = new FormPersonnel(name);
            form.Show();
        }

        private void buttonWork_Click(object sender, EventArgs e) // 업무 버튼
        {
            Task a = new Task(name);
            a.Show();
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

        private void buttonMail_Click(object sender, EventArgs e)
        {
            FormMailMenu form = new FormMailMenu(name);
            form.Show();
        }
    }
}
