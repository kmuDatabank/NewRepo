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

        public void initlistview()//날짜검색?
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

                    listView_search.Items.Add(item);

                }

            }



        }

        public void daysearch()//datetimepicker기반 검색임 텍스트박스를 가져와서 라이크로 다시조정해야함 날짜검색임
        {
            listView_search.Items.Clear();
            String tempdate = dateTimePicker1.Value.ToString();//?
            tempdate = tempdate.Substring(0, 10);

            int k = 0;

            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM Tasktable WHERE  date LIKE " + "\"" + tempdate + "%\"";
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

        }

        private void button1_Click(object sender, EventArgs e)//선택한 후 수정버튼
        {

        }

        private void button_listdel_Click(object sender, EventArgs e)//선택한 후 삭제버튼
        {

        }

        private void button_mod_Click(object sender, EventArgs e)//수정 창에서 실제 DB고치는 기능 id값을 가져와서 한다.
        {




        }
    }




}

