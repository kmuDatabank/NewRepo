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
    public partial class mastertask : Form
    {
        String name = "";
        public mastertask()
        {
            InitializeComponent();
        }
        public mastertask(String name)
        {
            InitializeComponent();
            initvariables();
            this.name = name;

        }

        private void initvariables()//초기화 ~ 콤보박스 아이템추가같은거~
        {
            freshlist();
        }


        public void freshlist()//db에서 각기 대중소카테고리를 들고와서 리스트에 올린다. 수정삭제등록이 이뤄진후 실행하게한다.
        {
            listView_large.Items.Clear();
            listView_middle.Items.Clear();
            listView_small.Items.Clear();
            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM large_cate";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listView_large.Items.Add(rdr["name"].ToString());

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
                    listView_middle.Items.Add(rdr["name"].ToString());

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
                    listView_small.Items.Add(rdr["name"].ToString());

                }

            }



        }




        private void button1_Click(object sender, EventArgs e)//추가버튼
        {
            String tempcategory = "";//large_cate, medium_cate, small_cate
            String contents = "";
            String temp = "";

            tempcategory = comboBox_add1.Text;
            contents = textBox_adder.Text;


            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM " + tempcategory + " WHERE name=" + "\"" + contents + "\"" ;
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    temp=rdr["name"].ToString();

                }
                if (temp != "")
                {
                    MessageBox.Show("중복된 업무가 존재합니다 다시입력해야합니다.");
                    return;
                }


            }



            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "INSERT INTO " + tempcategory +"(name)"+ " VALUES("+"\""+contents+ "\""+")";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                cmd.ExecuteNonQuery();


            }

            //("INSERT INTO Approval_log (Approval_name, Approval_writer, Approval_date_pre, Approval_date_mid) " +
            //"VALUES ('" + name + "','" + writer + "','" + now + "','" + now + "')", conn);




            freshlist();

        }





        private void button3_Click(object sender, EventArgs e)//대분류로수정폼호출
        {
            String selectcate = "large_cate";
            int selectedindex = listView_large.FocusedItem.Index;

            String contents = listView_large.Items[selectedindex].Text;
            String temp = "";

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM " + selectcate + " WHERE name=" + "\"" + contents + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    temp = rdr["ID"].ToString();

                }


            }

            TMmodform tmm = new TMmodform(selectcate,Convert.ToInt32(temp));

            tmm.Show();
            freshlist();
        }

        private void button_modM_Click(object sender, EventArgs e)//중분류로수정
        {
            String selectcate = "middle_cate";
            int selectedindex = listView_middle.FocusedItem.Index;

            String contents = listView_middle.Items[selectedindex].Text;
            String temp = "";

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM " + selectcate + " WHERE name=" + "\"" + contents + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    temp = rdr["ID"].ToString();

                }


            }

            TMmodform tmm = new TMmodform(selectcate, Convert.ToInt32(temp));

            tmm.Show();
            freshlist();
        }

        private void button_mods_Click(object sender, EventArgs e)//소분류로수정
        {
            String selectcate = "small_cate";
            int selectedindex = listView_small.FocusedItem.Index;

            String contents = listView_small.Items[selectedindex].Text;
            String temp = "";

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM " + selectcate + " WHERE name=" + "\"" + contents + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    temp = rdr["ID"].ToString();

                }


            }

            TMmodform tmm = new TMmodform(selectcate, Convert.ToInt32(temp));

            tmm.Show();
            freshlist();
        }

        private void button_rf_Click(object sender, EventArgs e)//
        {
            freshlist();
        }

        private void button_del_middle_Click(object sender, EventArgs e)//중삭
        {
            String selectcate = "middle_cate";
            int selectedindex = listView_middle.FocusedItem.Index;
            String contents = listView_middle.Items[selectedindex].Text;
            String temp = "";

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM " + selectcate + " WHERE name=" + "\"" + contents + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    temp = rdr["ID"].ToString();

                }


            }

            int index2 = Convert.ToInt32(temp);

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "DELETE FROM middle_cate WHERE ID= " + "\"" + index2.ToString() + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                cmd.ExecuteNonQuery();


            }
            freshlist();

        }
        //            String query = "DELETE FROM Personnel WHERE name = '" + name + "';";
        private void button_del_small_Click(object sender, EventArgs e)//소삭
        {
            String selectcate = "small_cate";
            int selectedindex = listView_small.FocusedItem.Index;
            String contents = listView_small.Items[selectedindex].Text;
            String temp = "";

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM " + selectcate + " WHERE name=" + "\"" + contents + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    temp = rdr["ID"].ToString();

                }


            }

            int index2 = Convert.ToInt32(temp);

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "DELETE FROM small_cate WHERE ID= " + "\"" + index2.ToString() + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                cmd.ExecuteNonQuery();


            }
            freshlist();

        }
        private void button_del_Click(object sender, EventArgs e)//대분류삭제버튼
        {

            String selectcate = "large_cate";
            int selectedindex = listView_large.FocusedItem.Index;
            String contents = listView_large.Items[selectedindex].Text;
            String temp = "";

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM " + selectcate + " WHERE name=" + "\"" + contents + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    temp = rdr["ID"].ToString();

                }


            }

            int index2 = Convert.ToInt32(temp);

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "DELETE FROM large_cate WHERE ID= " + "\"" + index2.ToString() + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                cmd.ExecuteNonQuery();


            }
            freshlist();
        }
    }
}
