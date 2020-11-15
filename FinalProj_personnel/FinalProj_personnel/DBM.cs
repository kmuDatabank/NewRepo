using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Authentication;

namespace FinalProj_personnel
{
    class DBM
    {
        private static String strconn = "Server=49.50.174.201;Database=databank;Uid=databank;Pwd=dbdb;Charset=utf8";
        private static MySqlConnection conn = new MySqlConnection(strconn);
        private static DBM db = new DBM();//클래스의 객체 싱글톤 가능? 
        public static MySqlConnection Getinstance()//using 에 넣을것 
        {
            return conn;
        }
        public static DBM GetDBMinstance()
        {
            return db;
        }

        public String checkauth(String id, String pw)//계정 확인 
        {
            
            String tempid = "";
            String temppw = "";
            String result = "";
            String tempname = "";
            String suc = "0";



            using (DBM.Getinstance())//
            {
                String query = "SELECT * FROM account";
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    tempid = (String)rdr["USER_ID"];
                    temppw = (String)rdr["USER_PW"];
                    tempname = (String)rdr["name"];


                    if (tempid == id && pw == temppw)//계정 맞음 
                    {
                        result = tempname;
                        suc = "1";//로그인 성공 여부
                        FormMain form = new FormMain();
                        form.Show();

                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            if (result == "")
            {
                MessageBox.Show("where is your ID?");
            }

            if (suc == "1")//맞으면 recent 추가하여 오토로드때 활용 
            {
                using (DBM.Getinstance())
                {
                    String query4 = "UPDATE " + "account" + " SET recently=" + "\'" + suc + "\'" + " WHERE NAME =" + "\'" + result + "\'";
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query4, conn);
                    cmd.ExecuteNonQuery();

                }
            }


            return result;
        }//end of checkauth




        public String autoload()
        {

            String tempid="";
            String temppw="";
            String result="";
            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM account WHERE  recently=" + "1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read() == true)
                {
                    tempid=rdr["USER_ID"].ToString();
                    temppw=rdr["USER_PW"].ToString();
                }


            }
            result = tempid + ","+ temppw;

            return result;






        }

    }




















}
