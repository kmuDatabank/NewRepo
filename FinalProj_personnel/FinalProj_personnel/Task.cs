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




        string strConn = "Server = 49.50.174.201;database=databank;Uid=databank;Pwd=dbdb;Charset=utf8";
        private void tasksave_Click(object sender, EventArgs e)
        {
            string name4 = todaytaskinput.Text;
            string name2 = todaytaskinput2.Text;
            string name3 = todaytaskinput3.Text;

            todaytask sinfo = new todaytask(name4);
            todaytask sinfo1 = new todaytask(name2);
            todaytask sinfo2 = new todaytask(name3);


            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1 && comboBox3.SelectedIndex == 2)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = "INSERT INTO task(large,medium,small,date,name) values ('" + name4 + "','" + name2 + "','" + name3 + "',now(),'" + name + "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                }

            }
            /*
            if (comboBox1.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = "INSERT INTO medium_cate(name) values ('" + name + "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = "INSERT INTO medium_cate(name) values ('" + name + "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            */

            /*using (MySqlConnection conn =new MySqlConnection(strConn))
            {
                conn.Open();
                string query = "INSERT INTO large_cate(name) values ('" + name + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }*/

        }

        public void comboBox_init()
        {
            string[] data2 = { "대분류", "중분류", "소분류" };
            comboBox4.Items.AddRange(data2);

            string[] data3 = { "등록", "수정", "삭제" };
            comboBox9.Items.AddRange(data3);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            string[] data = { "대분류", "중분류", "소분류" };
            comboBox1.Items.AddRange(data);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cate_save_Click(object sender, EventArgs e)
        {

            string cate = cate_input.Text;
            string num1 = cate_input.Text;
            string nu = numbox.Text;

            string name3 = todaytaskinput3.Text;

            todaytask sinfo4 = new todaytask(num1);

           /* //리스트뷰
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string query10 = " SELECT num,name FROM medium_cate WHERE name LIKE '" + "%" + todaytask + "'";
                MySqlCommand cmd = new MySqlCommand(query10, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);

                list.DataSource = dt;
                rdr.Close();
            }*/

            if (comboBox4.SelectedIndex == 0 && comboBox9.SelectedIndex == 0)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = "INSERT INTO large_cate(name) values ('" + cate + "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }

            if (comboBox4.SelectedIndex == 0 && comboBox9.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = " UPDATE large_cate SET name= '" + cate + "' WHERE Num='" + nu + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(rdr);

                    list.DataSource = dt;
                    rdr.Close();

                }
            }

            if (comboBox4.SelectedIndex == 0 && comboBox9.SelectedIndex == 2)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query3 = " DELETE large_cate WHERE num = '" + num1 + "' ";
                    MySqlCommand cmd = new MySqlCommand(query3, conn);
                    cmd.ExecuteNonQuery();
                }
            }

            if (comboBox4.SelectedIndex == 1 && comboBox9.SelectedIndex == 0)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query5 = "INSERT INTO medium_cate(name) values ('" + cate + "')";
                    MySqlCommand cmd = new MySqlCommand(query5, conn);
                    cmd.ExecuteNonQuery();
                }
            }

            if (comboBox4.SelectedIndex == 1 && comboBox9.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = " UPDATE medium_cate SET name= '" + cate + "' WHERE Num= '" + nu + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }

            if (comboBox4.SelectedIndex == 1 && comboBox9.SelectedIndex == 2)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query3 = " DELETE medium_cate WHERE num = '" + num1 + "' ";
                    MySqlCommand cmd = new MySqlCommand(query3, conn);
                    cmd.ExecuteNonQuery();
                }
            }

            if (comboBox4.SelectedIndex == 2 && comboBox9.SelectedIndex == 0)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query5 = "INSERT INTO small_cate(name) values ('" + cate + "')";
                    MySqlCommand cmd = new MySqlCommand(query5, conn);
                    cmd.ExecuteNonQuery();
                }
            }

            if (comboBox4.SelectedIndex == 2 && comboBox9.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = " UPDATE samll_cate SET name= '" + cate + "' WHERE Num= '" + nu + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }

            if (comboBox4.SelectedIndex == 2 && comboBox9.SelectedIndex == 2)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query3 = " DELETE small_cate WHERE num = '" + num1 + "' ";
                    MySqlCommand cmd = new MySqlCommand(query3, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string todaytask = taskbox.Text;
            string num2 = taskbox.Text;
            string nu = time.Text;

            if (comboBox8.SelectedIndex == 1 && comboBox5.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = " UPDATE medium_cate SET name= '" + todaytask + "' WHERE Num= '" + nu + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }

            if (comboBox8.SelectedIndex == 2 && comboBox5.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query15 = " DELETE medium_cate WHERE num = '" + num2 + "' ";
                    MySqlCommand cmd = new MySqlCommand(query15, conn);
                    cmd.ExecuteNonQuery();
                }
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void road_Click(object sender, EventArgs e)
        {

            string todaytask = taskbox.Text;
            string dte = taskbox.Text;


            //업무 검색
            if (comboBox8.SelectedIndex == 0 && comboBox5.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query10 = " SELECT num,name FROM medium_cate WHERE name LIKE '" + "%" + todaytask + "'";
                    MySqlCommand cmd = new MySqlCommand(query10, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(rdr);

                    list.DataSource = dt;
                    rdr.Close();
                }
            }


            //날짜 검색

            if (comboBox8.SelectedIndex == 0 && comboBox5.SelectedIndex == 0)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query10 = " SELECT num,id,large,medium,small,date FROM task WHERE DATE(date) = '" + dte + "'";
                    MySqlCommand cmd = new MySqlCommand(query10, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(rdr);

                    list.DataSource = dt;
                    rdr.Close();
                }
            }

            //등록자기반

            if (comboBox8.SelectedIndex == 0 && comboBox5.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query10 = " SELECT num,id,large,medium,small,start_time,finish_time,date FROM task WHERE name LIKE '" + name + "'";
                    MySqlCommand cmd = new MySqlCommand(query10, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(rdr);

                    list.DataSource = dt;
                    rdr.Close();
                }
            }
        }

        private void list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Task_Load(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            string time = start.Text;
            string time2 = finish.Text;
            string str = time;

            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = "INSERT INTO task(start_time,finish_time) values ('" + time + "','" + time2 + "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    if (str.Contains(time))
                    {
                        MessageBox.Show("중복입니다.");
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num1 = cate_input.Text;

            if (comboBox4.SelectedIndex == 0 && comboBox9.SelectedIndex == 2)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query3 = " DELETE large_cate WHERE num = '" + num1 + "' ";
                    MySqlCommand cmd = new MySqlCommand(query3, conn);
                    cmd.ExecuteNonQuery();
                }
            }


            if (comboBox4.SelectedIndex == 1 && comboBox9.SelectedIndex == 2)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query3 = " DELETE medium_cate WHERE num = '" + num1 + "' ";
                    MySqlCommand cmd = new MySqlCommand(query3, conn);
                    cmd.ExecuteNonQuery();
                }
            }

            if (comboBox4.SelectedIndex == 2 && comboBox9.SelectedIndex == 2)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query3 = " DELETE small_cate WHERE num = '" + num1 + "' ";
                    MySqlCommand cmd = new MySqlCommand(query3, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cate = cate_input.Text;
            string nu = numbox.Text;

            if (comboBox4.SelectedIndex == 0)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = " UPDATE large_table SET  ";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(rdr);

                    list2.DataSource = dt;
                    rdr.Close();

                }
            }

            if (comboBox4.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = " SELECT * from medium_cate";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(rdr);

                    list2.DataSource = dt;
                    rdr.Close();
                }
            }

            if (comboBox4.SelectedIndex == 2 && comboBox9.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = " SELECT * from small_cate";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(rdr);

                    list2.DataSource = dt;
                    rdr.Close();
                }
            }
        }
    }
}
 


























    

