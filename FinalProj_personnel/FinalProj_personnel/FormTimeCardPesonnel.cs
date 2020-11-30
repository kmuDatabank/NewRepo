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
    public partial class FormTimeCardPesonnel : Form
    {

        String name="";
        String rank="";

        public FormTimeCardPesonnel()
        {
            InitializeComponent();
            InitVariables();
        }

        public FormTimeCardPesonnel(String name,String rank)
        {
            this.name = name;
            this.rank = rank;
            InitializeComponent();
            InitVariables();

        }
        public FormTimeCardPesonnel(String name)
        {
            this.name = name;
            InitializeComponent();
            InitVariables();
        }


        private void InitVariables()
        {

        }

        private void buttonStartThis_Click(object sender, EventArgs e)//출근시간에 타임피커호출
        {
            textBoxStartTime.Text = dateTimePicker1.Text;

        }

        private void buttonEndThis_Click(object sender, EventArgs e)//퇴근시간에 타임피커 호출
        {
            textBoxEndTime.Text = dateTimePicker1.Text;

        }

        private void buttonStartMemory_Click(object sender, EventArgs e)//출근기록 저장
        {


            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "INSERT INTO GoTowork (name,intime,date) VALUES("+"\""+name+"\","
                    +"\""+textBoxStartTime.Text+"\","+"\""+dateTimePicker1.Text+"\""+")";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                cmd.ExecuteNonQuery();
            }
        }

        private void buttonEndMemory_Click(object sender, EventArgs e)//퇴근기록저장
        {

            String time = textBoxEndTime.Text;
            String checkholi = "";
            String checknight = "";

            String day=dateTimePicker1.Value.ToString("dddd");

            checkholi = checkSDholi(day);//요일판단
            checknight = checkSDnight(time);//시간판단
            if (radioButton_holiday.Checked)
            {
                checkholi = "1";
            }


            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();

                String query = "UPDATE GoTowork SET outtime= " + "\"" + time + "\"," + "holidaywork= " + "\"" + checkholi + "\"," +
                    "nightwork=" + "\"" + checknight + "\"" + "WHERE name="+"\""+name+"\""+ "AND "+"outtime= 0";

                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                cmd.ExecuteNonQuery();
            }





        }

        private void buttonGotoWorkShow_Click(object sender, EventArgs e)//출근부 보기 버튼
        {



            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM GoTowork ";//where 절로 date구분

                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable a = new DataTable();
                a.Load(rdr);
                dataGridViewGotoWork.DataSource = a;


            }


        }

        private String checkSDholi(String time)//요일 인자.
        {
            String result = "0";


            if(time=="토요일" || time== "일요일"){
                result = "1";
            }


            return result;

        }


        private String checkSDnight(String time)//시간 인자
        {
            String a = time;
            String result = "0";
            String temp = a[14].ToString() + a[15].ToString();

            int ct = Convert.ToInt32(temp);
            if (ct > 20 )
            {
                int aa =   ct-20;
                result = aa.ToString();
            }
            if (ct < 8)
            {
                int b = 4 + ct;
                result = b.ToString();

            }

            return result;
        }


    }
}
