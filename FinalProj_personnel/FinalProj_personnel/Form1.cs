using MySql.Data.MySqlClient;
using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    public partial class 업무 : Form
    {
        public 업무()
        {
            InitializeComponent();
            comboBox_init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        string strConn = "Server = 49.50.174.201;database=databank;Uid=databank;Pwd=dbdb;Charset=utf8";
        private void tasksave_Click(object sender, EventArgs e)
        {
            string name = todaytaskinput.Text;
            string name2 = todaytaskinput2.Text;
            string name3 = todaytaskinput3.Text;

            todaytask sinfo = new todaytask(name);
            todaytask sinfo1 = new todaytask(name2);
            todaytask sinfo2 = new todaytask(name3);

            
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1 && comboBox3.SelectedIndex == 2)
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = "INSERT INTO task(large,medium,small) values ('" + name + "','" + name2 + "','" + name3 + "')";
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

            string name3 = todaytaskinput3.Text;

            todaytask sinfo4 = new todaytask(num1);


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
                    string query = " UPDATE large_cate SET name= '"+cate+"' WHERE Num=1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
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
                    string query = " UPDATE medium_cate SET name= '" + cate + "' WHERE Num=11";
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
                    string query = " UPDATE samll_cate SET name= '" + cate + "' WHERE Num=11";
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
    }
}
 