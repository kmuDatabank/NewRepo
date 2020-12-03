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
    public partial class tasksearcher : Form
    {
        String name = "";
        String checker = "";//0=날씨 1= 등록자 2= 키워드기반검색
        public tasksearcher()
        {
            InitializeComponent();
        }

        public tasksearcher(String name, String checker)
        {
            InitializeComponent();
            this.name = name;
            this.checker = checker;
            comboBox_searchkeyword.Text = comboBox_searchkeyword.Items[Convert.ToInt32(checker)].ToString();

            initlistview();
            
        }
        //날짜별 검색 등록자별 검색 업무키워드별 검색 where name like "%name%" 의 형식 큰따옴표는 지정해줘야함

        public void initlistview()//
        {
            listView_search.Items.Clear();
            String tempdate = dateTimePicker1.Value.ToString();//?
            tempdate = tempdate.Substring(0,10);

            int k = 0;

            //listViewDepartmentType.Items.Add(item);

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM Tasktable";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    ListViewItem item = new ListViewItem();

                    item.Text=rdr["name"].ToString();
                    item.SubItems.Add(rdr["date"].ToString());
                    item.SubItems.Add(rdr["large_cate"].ToString());
                    item.SubItems.Add(rdr["middle_cate"].ToString());
                    item.SubItems.Add(rdr["small_cate"].ToString());
                    item.SubItems.Add(rdr["stime"].ToString());
                    item.SubItems.Add(rdr["etime"].ToString());
                    item.SubItems.Add(rdr["ID"].ToString());

                    listView_search.Items.Add(item);

                }

            }



        }

        public void daysearch(String tempdate)//d
        {
            listView_search.Items.Clear();
            //String tempdate = dateTimePicker1.Value.ToString();//?
            //tempdate = tempdate.Substring(0, 10);//포맷 유지할경우만 사용

            int k = 0;

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM Tasktable WHERE  date LIKE " + "\"%" + tempdate + "%\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    ListViewItem item = new ListViewItem();

                    item.Text = rdr["name"].ToString();
                    item.SubItems.Add(rdr["date"].ToString());
                    item.SubItems.Add(rdr["large_cate"].ToString());
                    item.SubItems.Add(rdr["middle_cate"].ToString());
                    item.SubItems.Add(rdr["small_cate"].ToString());
                    item.SubItems.Add(rdr["stime"].ToString());
                    item.SubItems.Add(rdr["etime"].ToString());
                    item.SubItems.Add(rdr["ID"].ToString());

                    listView_search.Items.Add(item);

                }

            }


        }
        public void mansearch(String man)
        {
            listView_search.Items.Clear();
            //String tempdate = dateTimePicker1.Value.ToString();//?
            

            int k = 0;

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM Tasktable WHERE  name LIKE " + "\"%" + man + "%\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    ListViewItem item = new ListViewItem();

                    item.Text = rdr["name"].ToString();
                    item.SubItems.Add(rdr["date"].ToString());
                    item.SubItems.Add(rdr["large_cate"].ToString());
                    item.SubItems.Add(rdr["middle_cate"].ToString());
                    item.SubItems.Add(rdr["small_cate"].ToString());
                    item.SubItems.Add(rdr["stime"].ToString());
                    item.SubItems.Add(rdr["etime"].ToString());
                    item.SubItems.Add(rdr["ID"].ToString());

                    listView_search.Items.Add(item);

                }

            }



        }














            private void button_ref_Click(object sender, EventArgs e)
        {
            initlistview();
        }
        //등록자기반은 이름값을 조건으로 텍스트박스 사용 단 %문자열%로 하여 편리성 증강 업무 키워드검색은 그냥 포함하면 나오게 
        private void button_search_Click(object sender, EventArgs e)//검색버튼 클릭시 날짜는 textbox받아와서 하되 라이크사용 
            
        {
            String searchkey = "";
            searchkey = textBox_searchtext.Text;





            if(comboBox_searchkeyword.Text== "날짜기반검색")
            {
                daysearch(searchkey);
                return;

            }

            else if(comboBox_searchkeyword.Text== "사용자기반검색")
            {
                mansearch(searchkey);

            }

            else if(comboBox_searchkeyword.Text== "업무키워드기반검색")
            {
                listView_search.Items.Clear();
                //String tempdate = dateTimePicker1.Value.ToString();//?

                if(searchkey==" ")
                {
                    initlistview();
                    return;
                }
                int k = 0;

                using (DBM.Getinstance())
                {
                    DBM.Getinstance().Open();
                    String query = "SELECT * FROM Tasktable WHERE  large_cate LIKE " + "\"%" + searchkey + "%\"";
                    MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        ListViewItem item = new ListViewItem();

                        item.Text = rdr["name"].ToString();
                        item.SubItems.Add(rdr["date"].ToString());
                        item.SubItems.Add(rdr["large_cate"].ToString());
                        item.SubItems.Add(rdr["middle_cate"].ToString());
                        item.SubItems.Add(rdr["small_cate"].ToString());
                        item.SubItems.Add(rdr["stime"].ToString());
                        item.SubItems.Add(rdr["etime"].ToString());
                        item.SubItems.Add(rdr["ID"].ToString());

                        listView_search.Items.Add(item);

                    }

                }


                using (DBM.Getinstance())
                {
                    DBM.Getinstance().Open();
                    String query = "SELECT * FROM Tasktable WHERE  middle_cate LIKE " + "\"%" + searchkey + "%\"";
                    MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        ListViewItem item = new ListViewItem();

                        item.Text = rdr["name"].ToString();
                        item.SubItems.Add(rdr["date"].ToString());
                        item.SubItems.Add(rdr["large_cate"].ToString());
                        item.SubItems.Add(rdr["middle_cate"].ToString());
                        item.SubItems.Add(rdr["small_cate"].ToString());
                        item.SubItems.Add(rdr["stime"].ToString());
                        item.SubItems.Add(rdr["etime"].ToString());
                        item.SubItems.Add(rdr["ID"].ToString());

                        listView_search.Items.Add(item);

                    }

                }


                using (DBM.Getinstance())
                {
                    DBM.Getinstance().Open();
                    String query = "SELECT * FROM Tasktable WHERE  small_cate LIKE " + "\"%" + searchkey + "%\"";
                    MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        ListViewItem item = new ListViewItem();

                        item.Text = rdr["name"].ToString();
                        item.SubItems.Add(rdr["date"].ToString());
                        item.SubItems.Add(rdr["large_cate"].ToString());
                        item.SubItems.Add(rdr["middle_cate"].ToString());
                        item.SubItems.Add(rdr["small_cate"].ToString());
                        item.SubItems.Add(rdr["stime"].ToString());
                        item.SubItems.Add(rdr["etime"].ToString());
                        item.SubItems.Add(rdr["ID"].ToString());

                        listView_search.Items.Add(item);

                    }

                }
            }

            else
            {
                initlistview();

            }



        }



        private void button_listdel_Click(object sender, EventArgs e)//선택한 후 삭제버튼
        {

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "DELETE FROM Tasktable WHERE ID= " + "\""+textBox_idvalue.Text +"\"";

                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                cmd.ExecuteNonQuery();



            }

            initlistview();









        }

        private void button_mod_Click(object sender, EventArgs e)//수정 창에서 실제 DB고치는 기능 id값을 가져와서 한다.
        {
            String[] backup = new string[8];
            String[] after = new string[7];
            int k = 0;

            backup[0] = textBox_mnamebefore.Text;
            backup[1] = textBox_madate_before.Text;
            backup[2] = comboBox_mlarge_before.Text;
            backup[3] = comboBox_mmiddle_before.Text;
            backup[4] = comboBox_msmall_before.Text;
            backup[5] =textBox_beforestime.Text;
            backup[6] =textBox_before_etime.Text;
            backup[7] = textBox_idvalue.Text;

            after[0] = textBox_mafter_name.Text;
            after[1] = textBox_mafter_date.Text;
            after[2] = comboBox_mafter_largecate.Text;
            after[3] = comboBox_mafter_middlecate_.Text;
            after[4] = comboBox_mafter_smallcate.Text;
            after[5] = textBox_afterstime.Text;
            after[6] = textBox_afteretime.Text;




            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "UPDATE Tasktable SET name= "+"\""+after[0]+"\","+"date= "+"\""+after[1]+"\","+
                    "large_cate= "+"\""+ after[2]+"\","+"middle_cate= "+"\""+ after[3]+"\","+"small_cate="+ "\""+ after[4]+"\","+
                    "stime= "+"\""+after[5]+"\","+"etime= "+"\""+ after[6]+"\""+" WHERE ID= "+"\""+ backup[7]+"\"";

                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                cmd.ExecuteNonQuery();



            }


            initlistview();


        }

        private void listView_search_Click(object sender, EventArgs e)//선택되면 바로 옮겨지게
        {
            textBox_mnamebefore.Text= listView_search.SelectedItems[0].SubItems[0].Text;
            textBox_madate_before.Text= listView_search.SelectedItems[0].SubItems[1].Text;
           comboBox_mlarge_before.Text = listView_search.SelectedItems[0].SubItems[2].Text;
            comboBox_mmiddle_before.Text= listView_search.SelectedItems[0].SubItems[3].Text;
            comboBox_msmall_before.Text= listView_search.SelectedItems[0].SubItems[4].Text;
            textBox_beforestime.Text= listView_search.SelectedItems[0].SubItems[5].Text;
            textBox_before_etime.Text= listView_search.SelectedItems[0].SubItems[6].Text;
            textBox_idvalue.Text = listView_search.SelectedItems[0].SubItems[7].Text;


        }

        private void button1_Click(object sender, EventArgs e)//날짜붙여넣기
        {
            textBox_searchtext.Text = dateTimePicker1.Text;
        }

        private void button2_Click(object sender, EventArgs e)//name>>
        {
            textBox_mafter_name.Text=textBox_mnamebefore.Text;
        }

        private void button3_Click(object sender, EventArgs e)//date>>
        {
            textBox_mafter_date.Text =textBox_madate_before.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox_mafter_largecate.Text=comboBox_mlarge_before.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox_mafter_middlecate_.Text = comboBox_mmiddle_before.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox_mafter_smallcate.Text=comboBox_msmall_before.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_afterstime.Text = textBox_beforestime.Text;



        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_afteretime.Text=textBox_before_etime.Text;
        }
    }




}

