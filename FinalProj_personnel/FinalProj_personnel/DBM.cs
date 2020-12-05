using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Authentication;
using System.Data;

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
            int result = 0;
            int tempname = 0;
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
                    tempname = (int)rdr["P_ID"];


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
            if (result == null)
            {
                MessageBox.Show("where is your ID?");
            }

            if (suc == "1")//맞으면 recent 추가하여 오토로드때 활용 
            {
                FormMain form = new FormMain(result.ToString());//분리
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
                    String query4 = "UPDATE " + "account" + " SET recently=" + "\'" + suc + "\'" + " WHERE P_ID =" + "\'" + result + "\'";
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query4, conn);
                    cmd.ExecuteNonQuery();

                }
            }


            return result.ToString();
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
                    String str = String.Format("{0}", rdr["name"]);
                    if (str.Equals(name))
                    {
                        rank = String.Format("{0}", rdr["position"]);
                    }
                }
                rdr.Close();
            }
            return rank;
        }
        public int weekadd_n(string name, string month)
        {
            int i = 0;
            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                string sql = "SELECT * FROM GoTowork WHERE date LIKE '" + month + "%'"; 
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str = string.Format("{0}", rdr["name"]);
                    if (str.Equals(name))
                    {
                        i++;
                    }
                }
                rdr.Close();
            }
            return i;
        }
        public string[,] weekadd(string name, string month, int num)
        {
            int i = 0;
            string[,] wa = new string[num,2];
            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                string sql = "SELECT * FROM GoTowork WHERE date LIKE '" + month + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str = string.Format("{0}", rdr["name"]);
                    if (str.Equals(name))
                    {
                        wa[i, 0] = string.Format("{0}", rdr["date"]);
                        wa[i, 1] = string.Format("{0}", rdr["normalwork"]);
                        i++;
                    }
                }
                rdr.Close();
            }
            return wa;
        }
        public int fir_allowance_n(string name, string month) // 수당 수정
        {
            int i = 0;
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM GoTowork WHERE date LIKE '" + month + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string na = string.Format("{0}", rdr["name"]);
                    if (name.Equals(na))
                    {
                        i++;
                    }
                }
                rdr.Close();
            }
            return i;
        }
        public string[,] fir_allowance(string name, string month, int num) // 수당 수정
        {
            string[,] str = new string[num, 4];
            int i = 0;
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM GoTowork WHERE date LIKE '" + month + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string na = string.Format("{0}", rdr["name"]);
                    if (name.Equals(na))
                    {
                        str[i, 0] = string.Format("{0}", rdr["date"]);
                        str[i, 1] = string.Format("{0}", rdr["holidaywork"]);
                        str[i, 2] = string.Format("{0}", rdr["nightwork"]);
                        str[i, 3] = string.Format("{0}", rdr["addwork"]);
                        i++;
                    }
                }
                rdr.Close();
            }
            return str;
        }
        public int checklarge_n() // 대분류 갯수
        {
            int i = 0;
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM large_cate";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                   i++;
                }
                rdr.Close();
            }
            return i;
        }
        public string[] checklarge(int num) // 대분류 이름
        {
            int i = 0;
            string[] large = new string[num];
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM large_cate";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    large[i] = string.Format("{0}", rdr["name"]);
                    i++;
                }
                rdr.Close();
            }
            return large;
        }
        public int checkmid_n() // 중분류 갯수
        {
            int i = 0;
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM middle_cate";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    i++;
                }
                rdr.Close();
            }
            return i;
        }
        public string[] checkmid(int num) // 중분류 이름
        {
            int i = 0;
            string[] large = new string[num];
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM middle_cate";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    large[i] = string.Format("{0}", rdr["name"]);
                    i++;
                }
                rdr.Close();
            }
            return large;
        }
        public int checksmall_n() // 소분류 갯수
        {
            int i = 0;
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM small_cate";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    i++;
                }
                rdr.Close();
            }
            return i;
        }
        public string[] checksmall(int num) // 소분류 이름
        {
            int i = 0;
            string[] large = new string[num];
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM small_cate";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    large[i] = string.Format("{0}", rdr["name"]);
                    i++;
                }
                rdr.Close();
            }
            return large;
        }
        public void update_allowance(string date, string holiday, string night, string add) // 수당수정
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE GoTowork SET holidaywork = '"+holiday+"' ,nightwork = '"+night+"'" +
                    " ,addwork = '"+add+"'WHERE date = '"+date+"'", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public int pay_normal(string name, string month)//월별 기본급을 가져옴
        {
            int nor = 0;
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM GoTowork WHERE intime LIKE '"+month+"%'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str = string.Format("{0}", rdr["name"]);
                    if (str.Equals(name))
                    {
                        string str1 = string.Format("{0}", rdr["normalwork"]);
                        nor += Convert.ToInt32(str1);
                    }
                }
                rdr.Close();
            }
            return nor;
        }
        public int pay_plus(string name, string month) // 추가수당계산
        {
            int plus = 0;
            string ho = "1";
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM GoTowork WHERE intime LIKE '" + month + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str = string.Format("{0}", rdr["name"]);
                    if (str.Equals(name))
                    {
                        string str1 = string.Format("{0}", rdr["holidaywork"]);
                        if (str1.Equals(ho))
                        {
                            string str2 = string.Format("{0}", rdr["normalwork"]);
                            plus += Convert.ToInt32(str2);
                        }
                        string str3 = string.Format("{0}", rdr["nightwork"]);
                        plus += Convert.ToInt32(str3);
                        str3 = string.Format("{0}", rdr["addwork"]);
                        plus += Convert.ToInt32(str3);
                    }
                }
                rdr.Close();
            }
            return plus;
        }
        public string checkintime(string name, string outtime)//출근시간 가져오는 함수
        {
            string a = "";
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM GoTowork";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str = string.Format("{0}", rdr["name"]);
                    if (str.Equals(name))
                    {
                        string str1 = string.Format("{0}", rdr["outtime"]);
                        if (str1.Equals(outtime))
                        {
                            a = string.Format("{0}", rdr["intime"]);
                        }
                    }
                }
                rdr.Close();
            }
            return a;
        }
        public int departinfo_n() // Departmet 테이블 갯수
        {
            int i = 0;
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Department";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    i++;
                }
                rdr.Close();
            }
            return i;
        }
        public string[,] departinfo(int n) //Department 부서명, 부서장 이름
        {
            string[,] a = new string[n, 2]; 
            int i = 0;
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Department";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    a[i, 0] = string.Format("{0}", rdr["departmentName"]);
                    a[i, 1] = string.Format("{0}", rdr["headDepartment"]);
                    i++;
                }
                rdr.Close();
            }
            return a;
        }
        public int personnel_n() // Personnel 사람수
        {
            int i = 0;
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Personnel";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    i++;
                }
                rdr.Close();
            }
            return i;
        }
        public string[] personnelinfo(int n) // Personnel의 name만 가져옴
        {
            int i = 0;
            string[] a = new string[n];
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Personnel";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    a[i] = string.Format("{0}", rdr["name"]);
                    i++;
                }
                rdr.Close();
            }
            return a;
        }
        public void newApproval_log(string name, string writer, string now) // 새로운 결재 생성시 로그
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Approval_log (Approval_name, Approval_writer, Approval_date_pre) " +
                    "VALUES ('"+name+ "','"+writer+ "','"+now+"')", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public void newApproval_log_rank(string name, string writer, string now)
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Approval_log (Approval_name, Approval_writer, Approval_date_pre, Approval_date_mid) " +
                    "VALUES ('" + name + "','" + writer + "','" + now + "','"+now+"')", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public void Approval_approval_log(string name, string now) // 부서장이 결재 승인시 로그
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Approval_log SET Approval_date_mid = '"+now+"' " +
                    "WHERE Approval_name = '"+name+"'", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public void Approval_approval_log_rank(string name, string now) // 사장이 최종 결재 승인시 로그
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Approval_log SET Approval_date_appr = '" + now + "' " +
                    "WHERE Approval_name = '" + name + "'", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public void Approval_return_log(string name, string now) // 결재 반려시 로그
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Approval_log SET Approval_date_ret = '" + now + "' " +
                    "WHERE Approval_name = '" + name + "'", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable Approval_log()
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Approval_log";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                rdr.Close();
                return dt;
            }
        }

        public void newApproval(string name, string writer, string work, string text, string comment) // 신규 결재 작성
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Approval (Approval_name,Approval_writer, Approval_work, Approval_text, " +
                    "Approval_comment, Approval_rank) VALUES ('" + name + "','" + writer + "','" + work + "','" + text + "','" + comment + "'," +
                    " '신규결재')", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public void newApproval_rank(string name, string writer, string work, string text, string comment)//부서장의 신규 결재
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Approval (Approval_name,Approval_writer, Approval_work, Approval_text, " +
                    "Approval_comment, Approval_rank) VALUES ('" + name + "','" + writer + "','" + work + "','" + text + "','" + comment + "'," +
                    " '최종대기')", conn);
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
        public void Approsearch_make_rank(string writer, string name, string approver2) // Approval_search테이블 작성(부서장)
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Approval_search (Approval_writer, Approval_name," +
                    " Approval_approver2) VALUES ('" + writer + "','" + name + "','" + approver2 + "')", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public int MyApproval_c(string name) //내가 등록한 결재 갯수
        {
            int i = 0;
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Approval";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str = string.Format("{0}", rdr["Approval_writer"]);
                    if (str.Equals(name))
                    {
                        i++;
                    }
                }
                rdr.Close();
            }
            return i;
        }
        public string[,] MyApproval(string name, int n) // 내가 등록한 결재
        {
            string[,] str = new string[n, 2];
            int i = 0;
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Approval";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str1 = string.Format("{0}", rdr["Approval_writer"]);
                    if (str1.Equals(name))
                    {
                        str[i, 0] = string.Format("{0}", rdr["Approval_name"]);
                        str[i, 1] = string.Format("{0}", rdr["Approval_rank"]);
                        i++;
                    }
                }
                rdr.Close();
            }
            return str;
        }
        public int MyApproval_ing_c(string name) // 결재중 내역 갯수
        {
            int i = 0;
            string state1 = "신규결재";
            string state2 = "최종대기";
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Approval";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str1 = string.Format("{0}", rdr["Approval_writer"]);
                    string str2 = string.Format("{0}", rdr["Approval_rank"]);
                    if (str1.Equals(name) && str2.Equals(state1) || str2.Equals(state2))
                    {
                        i++;
                    }
                }
                rdr.Close();
            }
            return i;
        }
        public string[] MyApproval_ing(string name, int num) // 결재중 내역
        {
            string[] str = new string[num];
            int i = 0;
            string state1 = "신규결재";
            string state2 = "최종대기";
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Approval";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str1 = string.Format("{0}", rdr["Approval_writer"]);
                    string str2 = string.Format("{0}", rdr["Approval_rank"]);
                    if (str1.Equals(name) && str2.Equals(state1) || str2.Equals(state2))
                    {
                        str[i] = string.Format("{0}", rdr["Approval_name"]);
                        i++;
                    }
                }
                rdr.Close();
            }
            return str;
        }
        public int MyApproval_approval_c(string name) // 결재 완료 내역 갯수
        {
            int i = 0;
            string state = "결재승인";
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Approval";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str1 = string.Format("{0}", rdr["Approval_writer"]);
                    string str2 = string.Format("{0}", rdr["Approval_rank"]);
                    if (str1.Equals(name) && str2.Equals(state))
                    {
                        i++;
                    }
                }
                rdr.Close();
            }
            return i;
        }
        public string[] MyApproval_approval(string name, int num) // 결재완료 내역
        {
            string[] str = new string[num];
            int i = 0;
            string state = "결재승인";
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Approval";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str1 = string.Format("{0}", rdr["Approval_writer"]);
                    string str2 = string.Format("{0}", rdr["Approval_rank"]);
                    if (str1.Equals(name) && str2.Equals(state))
                    {
                        str[i] = string.Format("{0}", rdr["Approval_name"]);
                        i++;
                    }
                }
                rdr.Close();
            }
            return str;
        }
        public int MyApproval_return_c(string name) // 결재 완료 내역 갯수
        {
            int i = 0;
            string state = "결재반려";
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Approval";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str1 = string.Format("{0}", rdr["Approval_writer"]);
                    string str2 = string.Format("{0}", rdr["Approval_rank"]);
                    if (str1.Equals(name) && str2.Equals(state))
                    {
                        i++;
                    }
                }
                rdr.Close();
            }
            return i;
        }
        public string[] MyApproval_return(string name, int num) // 결재완료 내역
        {
            string[] str = new string[num];
            int i = 0;
            string state = "결재반려";
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Approval";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str1 = string.Format("{0}", rdr["Approval_writer"]);
                    string str2 = string.Format("{0}", rdr["Approval_rank"]);
                    if (str1.Equals(name) && str2.Equals(state))
                    {
                        str[i] = string.Format("{0}", rdr["Approval_name"]);
                        i++;
                    }
                }
                rdr.Close();
            }
            return str;
        }
        public string Approval_returncomment(string name) // 반려코멘트
        {
            string ret_com = "";
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Approval";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str = string.Format("{0}", rdr["Approval_name"]);
                    if (str.Equals(name))
                    {
                        ret_com = string.Format("{0}", rdr["Approval_returncomment"]);
                    }
                }
                rdr.Close();
            }
            return ret_com;
        }

        public int MyApproval_work_c(string rank) // 결재 해야할 업무 갯수
        {
            int i = 0;
            string state = "";
            if (rank.Equals("부서장"))
            {
                state = "신규결재";
            }
            if (rank.Equals("사장"))
            {
                state = "최종대기";
            }
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Approval";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str = string.Format("{0}", rdr["Approval_rank"]);
                    if (str.Equals(state))
                    {
                        i++;
                    }
                }
                rdr.Close();
            }
            return i;
        }
        public string[] MyApproval_work(string rank, int num) // 결재 해야할 업무 갯수
        {
            int i = 0;
            string state = "";
            if (rank.Equals("부서장"))
            {
                state = "신규결재";
            }
            if (rank.Equals("사장"))
            {
                state = "최종대기";
            }

            string[] app = new string[num];
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Approval";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str = string.Format("{0}", rdr["Approval_rank"]);
                    if (str.Equals(state))
                    {
                        app[i] = string.Format("{0}", rdr["Approval_name"]);
                        i++;
                    }
                }
                rdr.Close();
            }
            return app;
        }
        public string[] Approval_info(string name)//결재 해야할 업무 선택시 정보를 가져옴
        {
            string[] info = new string[3];
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Approval";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str = string.Format("{0}", rdr["Approval_name"]);
                    if (name.Equals(str))
                    {
                        string str1 = string.Format("{0}", rdr["Approval_work"]);
                        info[0] = str1;
                        str1 = string.Format("{0}", rdr["Approval_text"]);
                        info[1] = str1;
                        str1 = string.Format("{0}", rdr["Approval_comment"]);
                        info[2] = str1;
                    }
                }
                rdr.Close();
            }
            return info;
        }
        public void Approval_approval(string rank, string name)
        {
            string result = "";
            if (rank.Equals("부서장"))
            {
                result = "최종대기";
            }
            if (rank.Equals("사장"))
            {
                result = "결재승인";
            }
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Approval SET Approval_rank = '" + result + "' " +
                    "WHERE Approval_name = '" + name + "'", conn);
                cmd.ExecuteNonQuery();
            }
        }
        public void Approval_return(string name, string comment)
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Approval SET Approval_rank = '결재반려' , Approval_returncomment = '" + comment + "'" +
                    "WHERE Approval_name = '" + name + "'", conn);
                cmd.ExecuteNonQuery();
            }
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

        //이거는 쓸모없어서 지워야할듯.
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
        //사원등록한 것 끌어오기
        public MySqlDataReader SELECT(string text)
        {
            string strConn = "Server=49.50.174.201;Database=databank;Uid=databank;Pwd=dbdb;Charset=utf8";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(text, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            return rdr;
        }

        // 사원검색(부서별/ 이름별/ 나이별) 검색
        public string[,] Search()
        {
            string[,] a = new string[13, 8];
            int i = 0;
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Personnel";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    a[i, 0] = string.Format("{0}", rdr["name"]);
                    a[i, 1] = string.Format("{0}", rdr["gender"]);
                    a[i, 2] = string.Format("{0}", rdr["age"]);
                    a[i, 3] = string.Format("{0}", rdr["position"]);
                    a[i, 4] = string.Format("{0}", rdr["department"]);
                    a[i, 5] = string.Format("{0}", rdr["date"]);
                    a[i, 6] = string.Format("{0}", rdr["phoneNum"]);
                    a[i, 7] = string.Format("{0}", rdr["address"]);
                    i++;
                }
                rdr.Close();
            }
            return a;
        }
        //사원 수정기능
        public void personnel_change(String backupname, string name, string gender, string position, string department, string date, string phoneNum, string address, string age)
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Personnel SET name =" + "\"" + name + "\"" + "," + "gender=" + "\"" + gender + "\"" + "," + "position=" + "\"" + position + "\"" + "," + "department=" + "\"" + department + "\"" +
                   "," + " date=" + "\"" + date + "\"" + "," + " phoneNum=" + "\"" + phoneNum + "\"" + "," + "address=" + "\"" + address + "\"" + "," + "age= " + "\"" + age + "\"" + "WHERE name=" + "\"" + backupname + "\"", conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void PersonnelDelete(String name) //사원삭제
        {
            String query = "DELETE FROM Personnel WHERE name = '" + name + "';";
            using (DBM.Getinstance())
            {
                conn.Open();

               MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }
        //갯수 반환하는 함수
        public int department_n()
        {
            int i = 0;
            using(DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Department";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    i++; //갯수 반환하게
                }
                rdr.Close();
            }
            return i;
        }

        //특정값 받아오는 함수
        public string[] departmentInfo(int n)
        {
            int i = 0;
            string[] a = new string[n]; //갯수를 파라미터로 받아와서 str[]에 저장
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Department";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    a[i] = string.Format("{0}", rdr["departmentName"]);
                    i++;
                }
                rdr.Close();
            }
            return a;
        }

        //부서등록
        public void department_enroll(string departmentName, string headDepartment)
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                string query = "INSERT INTO Department(departmentName, headDepartment) VALUES('" + departmentName + "' , '" + headDepartment + "');";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public string ori_depart(string department)
        {
            string str = "";
            using (DBM.Getinstance())
            {
                conn.Open();
                string sql = "SELECT * FROM Department";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str1 = string.Format("{0}", rdr["departmentName"]);
                    if (str1.Equals(department))
                    {
                        str = string.Format("{0}", rdr["headDepartment"]);
                    }
                }
                rdr.Close();
            }
            return str;
        }
        //부서 수정
        public void department_change(string departmentName, string headDepartment)
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Department SET headDepartment =" + "\"" + headDepartment + "\"" + "WHERE departmentName=" + "\"" + departmentName + "\"", conn);
                cmd.ExecuteNonQuery();
            }
        }

        //일반 사원으로 강등
        public void original(string name)
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Personnel SET position ='일반 사원' WHERE name=" + "\"" + name + "\"", conn);
               
                cmd.ExecuteNonQuery();
            }
        }
        //부서장으로 업데이트
        public void upgrade(string name)
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Personnel SET position ='부서장' WHERE name=" + "\"" + name + "\"", conn);
                cmd.ExecuteNonQuery();
            }
        }

      
        public void department_delete(string departmentName) //부서 삭제기능
        {
            String query = "DELETE FROM Department WHERE departmentName=" + "\'" + departmentName + "\'";

            using (DBM.Getinstance())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();

            }
        }
     

    }
}
