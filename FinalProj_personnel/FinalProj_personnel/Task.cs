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
using task;

namespace FinalProj_personnel
{
    public partial class Task : Form
    {
        String name = "";
        public Task(String name)
        {
            InitializeComponent();
            this.name = name;


        }

        private void master_Click(object sender, EventArgs e)
        {
            mastertask mt = new mastertask(name);
            mt.Show();



        }

        private void button2_Click(object sender, EventArgs e)//날짜검색
        {
            tasksearcher ts = new tasksearcher(name,"0");
            ts.Show();
        }

        private void button3_Click(object sender, EventArgs e)//등록자검색
        {
            tasksearcher ts = new tasksearcher(name,"1");
            ts.Show();
        }

        private void button_keyword_Click(object sender, EventArgs e)//업무키워드 검색
        {
            tasksearcher ts = new tasksearcher(name,"2");
            ts.Show();
        }
    }
}

  
























    

