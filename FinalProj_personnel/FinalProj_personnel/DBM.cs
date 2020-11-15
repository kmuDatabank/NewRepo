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
        private static String strconn = "Server=49.50.174.201;Database=s5414529;Uid=s5414529;Pwd=s5414529;Charset=utf8";
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
            String suc = "";



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

            if (suc == "1")
            {

            }






            return result;
        }
    }






















}
