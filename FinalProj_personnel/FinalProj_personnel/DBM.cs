using System;
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


        public void newApproval(string name,string writer, string work, string text, string comment) // 신규 결재 작성
        {
            using (DBM.Getinstance())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Approval (Approval_name,Approval_writer, Approval_work, Approval_text, " +
                    "Approval_comment, Approval_rank) VALUES ('" + name + "','"+writer+"','" + work + "','" + text + "','" + comment + "'," +
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
                MySqlCommand cmd = new MySqlCommand("UPDATE Approval SET Approval_rank = '"+result+"' " +
                    "WHERE Approval_name = '"+name+"'", conn);
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
        #region 사원검색(부서별/ 이름별/ 나이별) 검색
        public string[,] Search() 
        {
            string[,] a = new string[3, 8];
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
        #endregion



        #region 사원검색(부서별/ 이름별/ 나이별) 수정


        #endregion



        #region 사원검색(부서별/ 이름별/ 나이별) 삭제


        #endregion


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
        public void PersonnelDelete(String id) //사원삭제
        {
            String query = "DELETE FROM Personnel WHERE id = '" + id + "';";
            using (DBM.Getinstance())
            {
                conn.Open();



                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();

            }
        }

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
