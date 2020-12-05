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
    public partial class FormSendMail : Form
    {
        string strConn = "Server=49.50.174.201;Database=databank;Uid=databank;Pwd=dbdb;Charset=utf8";

        FormTransmittedMail mail;
        string name = "";



        public FormSendMail()
        {
            InitializeComponent();
        }
        public FormSendMail(String name)
        {
            InitializeComponent();
            this.name = name;
            addcombo();




        }


        public FormSendMail(string name, FormTransmittedMail form)
        {
            InitializeComponent();
            this.name = name;
            mail = form;
        }


        public void addcombo()
        {
            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM Personnel";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ComboBoxTo.Items.Add(rdr["name"].ToString());
                    
                   


                }



            }




        }






        private void ButtonSendMail_Click(object sender, EventArgs e)//전송
        {
            string title = this.TextBoxTitle.Text.Trim();
            string message = this.TextBoxMessage.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("메세지 제목를 입력해주세요!");

                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("메세지 내용를 입력해주세요!");

                return;
            }
            if (MessageBox.Show("정말로 전송하시겠습니까?", "쪽지 전송 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DateTime date = DateTime.Now;
                string sd = date.ToString("yyyy-MM-dd-HH-mm");
                //mail.ListViewTransmitted.Items.Add(ComboBoxTo.SelectedItem, TextBoxTitle.Text, TextBoxMessage.Text, DateTime.Now);

                string a = ComboBoxTo.Text, b = TextBoxTitle.Text, c = TextBoxMessage.Text, d = sd;
                //a는 받는이
                using (DBM.Getinstance())
                {
                    DBM.Getinstance().Open();
                    String query = "INSERT INTO RMails (WHO,TITLE,CONTENT,DATE,BYMAN)" +
                        " VALUES ("+"\"" + a + "\"," + "\"" + b + "\"," + "\"" + c + "\"," + "\"" + d + "\"," + "\"" + name + "\""+")";
                    MySqlCommand cmd1 = new MySqlCommand(query, DBM.Getinstance());
                    cmd1.ExecuteNonQuery();


                     query="INSERT INTO TMails (WHO, TITLE, CONTENT, DATE,SENDED)"+
                       " VALUES (" + "\"" + name + "\"," + "\"" + b + "\"," + "\"" + c + "\"," + "\"" + d + "\"," + "\"" + a + "\""+")";
                    MySqlCommand cmd2 = new MySqlCommand(query, DBM.Getinstance());
                    cmd2.ExecuteNonQuery();
                }


                MessageBox.Show("전송 완료");
            }
            else
            {
                MessageBox.Show("전송실패");
            }
        }
    }
}
