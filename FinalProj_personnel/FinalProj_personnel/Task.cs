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
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Authentication;

namespace FinalProj_personnel
{
    public partial class Task : Form
    {
        String name = "";
        public Task(String name)
        {
            InitializeComponent();
            this.name = name;
            label_stable.Text = name;
            initv();

        }

        public void initv()
        {

            comboBox_large.Items.Clear();
            comboBox_middle.Items.Clear();
            comboBox_small.Items.Clear();

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM large_cate";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    comboBox_large.Items.Add(rdr["name"].ToString());
                }
            }

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM middle_cate";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    comboBox_middle.Items.Add(rdr["name"].ToString());
                }
            }

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM small_cate";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    comboBox_small.Items.Add(rdr["name"].ToString());
                }
            }

        }






        private void master_Click(object sender, EventArgs e)//업무마스터 클릭
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



        private void button2_Click_1(object sender, EventArgs e)//시작시간에 현재시간 넣기
        {


            textBox_startT.Text = dateTimePicker1.Text;
        }

        private void button3_Click_2(object sender, EventArgs e)//종료시간에 현재시간 넣기
        {
            textBox_endT.Text = dateTimePicker1.Text;
        }

        private void button1_Click(object sender, EventArgs e)//등록버튼 ~ 시간이 겹치면 안된다.즉 시간확인함수를 만든다?
        {
            String inputET = textBox_endT.Text;
            String inputST = textBox_startT.Text;

            String findET = "";
            String findST = "";

            String tempdate = dateTimePicker1.Text;
            tempdate=tempdate.Substring(0, 10);//부분추출


            int[] clock = new int[24];
            Array.Clear(clock, 0, clock.Length);



            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM Tasktable WHERE  date LIKE " + "\""+tempdate+"%\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    findST=rdr["stime"].ToString();
                    findET=rdr["etime"].ToString();

                    findET = findET.Substring(14,2);
                    findST = findST.Substring(14,2);//시간만따서


                        clock[Convert.ToInt32(findET)] = 1;
                        clock[Convert.ToInt32(findST)] = 1;

                }
            }

            String tempET = "";
            String tempST = "";

            tempET = inputET.Substring(14,2);
            tempST = inputST.Substring(14,2);


            if(clock[Convert.ToInt32(tempET)]== 0 && clock[Convert.ToInt32(tempST)] == 0)
            {
            }
            else
            {
                MessageBox.Show("시간이 겹칩니다 다시설정하세요!");
                return;


            }


                using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "INSERT INTO Tasktable (name,date,large_cate,middle_cate,small_cate,stime,etime)" +
                    " VALUES (" + "\"" + name + "\"," + "\"" + dateTimePicker1.Text + "\"," + "\"" + comboBox_large.Text + "\"," + "\"" + comboBox_middle.Text + "\","
                    + "\"" + comboBox_small.Text + "\"," + "\"" + inputST + "\"," + "\"" + inputET + "\""+")";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                cmd.ExecuteNonQuery();
            }



            //"INSERT INTO Approval_log (Approval_name, Approval_writer, Approval_date_pre, Approval_date_mid) " +
           // "VALUES ('" + name + "','" + writer + "','" + now + "','" + now + "')", conn);













        }

        private void button_refresh_Click(object sender, EventArgs e)//콤보박스 정렬 재실행?
        {
            initv();
        }
    }
}

  
























    

