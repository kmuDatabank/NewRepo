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

namespace FinalProj_personnel
{
    public partial class rcvdmail : Form
    {
        string strConn = "Server=49.50.174.201;Database=databank;Uid=databank;Pwd=dbdb;Charset=utf8";

        string name = "";
        String tempid = "";

        public rcvdmail()
        {
            InitializeComponent();
        }
        public rcvdmail(String name)
        {
            InitializeComponent();
            this.name = name;
            setting();
        }

        public void setting()
        {
            ListViewReceived.Items.Clear();
            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM RMails WHERE WHO= " + "\"" + name + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                MySqlDataReader rdr = cmd.ExecuteReader();
                //받는사람 제목 내용 전송날짜 ~리스트뷰 칼럼
                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem();


                    item.Text = rdr["WHO"].ToString();
                    item.SubItems.Add(rdr["TITLE"].ToString());
                    item.SubItems.Add(rdr["CONTENT"].ToString());
                    item.SubItems.Add(rdr["DATE"].ToString());
                    item.SubItems.Add(rdr["ID"].ToString());
                    item.SubItems.Add(rdr["readed"].ToString());
                    item.SubItems.Add(rdr["BYMAN"].ToString());


                    ListViewReceived.Items.Add(item);

                }





            }
        }

        private void ButtonOpenMail_Click(object sender, EventArgs e)
        {

            ListViewItem aaa = ListViewReceived.FocusedItem;

            tempid=aaa.SubItems[4].Text;


            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "UPDATE RMails   SET readed="+"1"+" WHERE ID= "+tempid;
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                cmd.ExecuteNonQuery();



            }




                FormReadReceived aa = new FormReadReceived(name, aaa);
            aa.Show();
            setting();


        }

        private void button_search_Click(object sender, EventArgs e)//검색 버튼 누를시
        {

            if (comboBox_search.Text == "보낸사람")
            {
                
                    ListViewReceived.Items.Clear();
                    using (DBM.Getinstance())
                    {
                        DBM.Getinstance().Open();
                        String query = "SELECT * FROM RMails WHERE WHO= " + "\"" + name + "\""+ " AND BYMAN= "+"\""+ textBox_search.Text+"\"";
                        MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                        MySqlDataReader rdr = cmd.ExecuteReader();
                        //받는사람 제목 내용 전송날짜 ~리스트뷰 칼럼
                        while (rdr.Read())
                        {
                            ListViewItem item = new ListViewItem();


                            item.Text = rdr["WHO"].ToString();
                            item.SubItems.Add(rdr["TITLE"].ToString());
                            item.SubItems.Add(rdr["CONTENT"].ToString());
                            item.SubItems.Add(rdr["DATE"].ToString());
                            item.SubItems.Add(rdr["ID"].ToString());
                            item.SubItems.Add(rdr["readed"].ToString());
                            item.SubItems.Add(rdr["BYMAN"].ToString());
                        ListViewReceived.Items.Add(item);

                        }

                    }

            }


            else if (comboBox_search.Text == "제목")
            {

                ListViewReceived.Items.Clear();
                using (DBM.Getinstance())
                {
                    DBM.Getinstance().Open();
                    String query = "SELECT * FROM RMails WHERE WHO= " + "\"" + name + "\"" + "AND  TITLE LIKE " + "\"%" + textBox_search.Text + "%\"";
                    MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    //받는사람 제목 내용 전송날짜 ~리스트뷰 칼럼
                    while (rdr.Read())
                    {
                        ListViewItem item = new ListViewItem();


                        item.Text = rdr["WHO"].ToString();
                        item.SubItems.Add(rdr["TITLE"].ToString());
                        item.SubItems.Add(rdr["CONTENT"].ToString());
                        item.SubItems.Add(rdr["DATE"].ToString());
                        item.SubItems.Add(rdr["ID"].ToString());
                        item.SubItems.Add(rdr["readed"].ToString());
                        item.SubItems.Add(rdr["BYMAN"].ToString());
                        ListViewReceived.Items.Add(item);

                    }

                }

            }




            else if (comboBox_search.Text == "내용")
            {

                ListViewReceived.Items.Clear();
                using (DBM.Getinstance())
                {
                    DBM.Getinstance().Open();
                    String query = "SELECT * FROM RMails WHERE WHO= " + "\"" + name + "\"" + "AND CONTENT LIKE " + "\"%" + textBox_search.Text + "%\"";
                    MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    //받는사람 제목 내용 전송날짜 ~리스트뷰 칼럼
                    while (rdr.Read())
                    {
                        ListViewItem item = new ListViewItem();


                        item.Text = rdr["WHO"].ToString();
                        item.SubItems.Add(rdr["TITLE"].ToString());
                        item.SubItems.Add(rdr["CONTENT"].ToString());
                        item.SubItems.Add(rdr["DATE"].ToString());
                        item.SubItems.Add(rdr["ID"].ToString());
                        item.SubItems.Add(rdr["readed"].ToString());
                        item.SubItems.Add(rdr["BYMAN"].ToString());
                        ListViewReceived.Items.Add(item);

                    }

                }

            }





        }
    }
}



