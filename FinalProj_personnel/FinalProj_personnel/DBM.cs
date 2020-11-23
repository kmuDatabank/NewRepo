﻿using System;
using System.Collections.Generic;
using System.IO;
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
                FormMain form = new FormMain(result);//분리
                form.Show();

                using (DBM.Getinstance())//다른 계정일 경우 rectently값을 이전시킨다.
                {
                    String query4 = "UPDATE " + "account" + " SET recently=" + "\'" + 0 + "\'" + " WHERE recently =" + "\'" + 1 + "\'";
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query4, conn);
                    cmd.ExecuteNonQuery();

                }




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




        public String autoload()//로그인 오토 로드기능
        {

            String tempid = "";
            String temppw = "";
            String result = "";
            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM account WHERE  recently=" + "1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read() == true)
                {
                    tempid = rdr["USER_ID"].ToString();
                    temppw = rdr["USER_PW"].ToString();
                }
                rdr.Close();

            }
            result = tempid + "," + temppw;

            return result;






        }

        public String checkrank(String name) // 이름으로 직급 검색
        {
            String rank = "";
            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                string sql = "SELECT * FROM Personnel";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    String str = String.Format("{0}",rdr["name"]);
                    if (str.Equals(name))
                    {
                        rank = String.Format("{0}", rdr["position"]);
                    }
                }
                rdr.Close();
            }
            return rank;
        }


        public void newApproval(string name, string work, string text, string comment) // 신규 결제 작성
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Approval (Approval_name, Approval_work, Approval_text, " +
                    "Approval_comment, Approval_rank) VALUES ('" + name + "','" + work + "','" + text + "','" + comment + "', 0)", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public void Approsearch_make(string writer, string name, string approver1, string approver2) // Approval_search테이블 작성
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Approval_search (Approval_writer, Approval_name, Approval_approver1," +
                    " Approval_approver2) VALUES ('" + writer + "','" + name + "','" + approver1 + "','" + approver2 + "')", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public int Approsearch_name_n(string name) // 결재 제목검색 갯수
        {
            int i = 0;
            using (DBM.Getinstance())
            {
                using (DBM.Getinstance())
                {
                    conn.Open();
                    string sql = "SELECT * FROM Approval_search WHERE Approval_name LIKE '" + name + "%'"; //검색된 이름으로 시작하는
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        string str = string.Format("{0}", rdr["Approval_name"]); // 결재 이름 가져옴
                        i++;
                    }
                    rdr.Close();
                }
            }
            return i;
        }
        public string[] Approsearch_name(string name, int num) // 결재 제목검색
        {
            string[] st = new string[num];
            int i = 0;
            using (DBM.Getinstance())
            {
                using (DBM.Getinstance())
                {
                    conn.Open();
                    string sql = "SELECT * FROM Approval_search WHERE Approval_name LIKE '" + name + "%'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        string str = string.Format("{0}", rdr["Approval_name"]);
                        st[i] = str;
                        i++;
                    }
                    rdr.Close();
                }
            }
            return st;
        }

        public int file_rd()
        {
            StreamReader sr = new StreamReader(new FileStream("check.dat", FileMode.OpenOrCreate));
            int a = sr.Read();
            sr.Close();
            return a;

        }


        public void file_write(String text)
        {
            StreamWriter sw = new StreamWriter(new FileStream("check.dat", FileMode.OpenOrCreate));
            sw.Write(text);
            sw.Close();



        }




        public void memberPersonnel(string name, string gender, string age, string position, string department, string date, string phoneNum, string address) // 사원등록
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Personnel (name, gender, age,position, department, date , phoneNum, address " +
                    "Approval_comment, Approval_rank) VALUES ('" + name + "','" + gender + "','" + age + "','" + position + "','" + department + "','" + date + "','" + phoneNum + "','" + address + "', 0)", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void departPersonnel(string name, string head)
        {
            string departmentName = "";
            string headDepartment = "";

            using (DBM.Getinstance())//
            {
                String query = "UPDATE Department SET headDepartment = ' ' ";
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();



            }

        }
        /*
        public String personnelSearch(string text1, string text2) //(소속)부서로 사원검색
        {
            
            String comboDepartment = text1; //콤보박스
            String textInputSearch = text2; //텍스트박스

            if(text2 == "")
            {
                using (DBM.Getinstance())
                {
                    DBM.Getinstance().Open();
                    string sql = "SELECT * FROM Personnel Group by department";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        String str = String.Format("{5}", rdr["department"]);
                        if (str.Equals(""))
                        {

                        }
                    }
                    rdr.Close();

                }
            }

        }
        */

        public void delete(String d) //인사부서의 삭제기능
        {
            String query = "delete from Department where headDepartment=" + "\'" + d + "\'";
           
            using (DBM.Getinstance())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();

            }
        }


    }


}
