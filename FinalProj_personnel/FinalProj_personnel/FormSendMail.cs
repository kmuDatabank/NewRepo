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

        /*
        void ComboBox()
        {
            ComboBoxTo.Items.Clear();
            ComboBoxTo.Items.Add("전체");
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                try
                {
                    string strqry = "SELECT name FROM databank.Personnel WHERE where not name=" + name;
                    MySqlCommand cmd = new MySqlCommand(strqry, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(strqry, conn);
                    DataSet cat = new DataSet();
                    foreach (DataRow dr in cat.Tables[1].Rows)
                    {
                        ComboBoxTo.Items.Add(dr["name"]);
                    }

                    ComboBoxTo.SelectedIndex = 0;
                }
                catch (Exception ex)
                {

                }
            }
        }
        */

        public FormSendMail()
        {
            InitializeComponent();
        }

        public FormSendMail(string name, FormTransmittedMail form)
        {
            InitializeComponent();
            this.name = name;
            mail = form;
        }

        private void FormSendMail_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                //var query = "SELECT name FROM databank.Personnel WHERE where not name=" + name;
                string query = "SELECT name FROM databank.Personnel WHERE where not name=" + name;
                try
                {
                    MySqlCommand mcd = new MySqlCommand(query, conn);
                    MySqlDataReader mdr = mcd.ExecuteReader();
                    while (mdr.Read())
                    {
                        ComboBoxTo.Items.Add(mdr.GetString("name"));
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void ButtonSendMail_Click(object sender, EventArgs e)
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

                string a = ComboBoxTo.SelectedText, b = TextBoxTitle.Text, c = TextBoxMessage.Text, d = sd;

                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand cmd1 = new MySqlCommand("INSERT INTO `databank`.`RMails` (`WHO`, `TITLE`, `CONTENT`, `DATE`) " +
                        "VALUES ('" + a + "', '" + b + "', '" + c + "', '" + d + "');", conn);
                    cmd1.ExecuteNonQuery();
                    MySqlCommand cmd2 = new MySqlCommand("INSERT INTO `databank`.`TMails` (`WHO`, `TITLE`, `CONTENT`, `DATE`) " +
                        "VALUES ('" + a + "', '" + b + "', '" + c + "', '" + d + "');", conn);
                    cmd2.ExecuteNonQuery();
                }

                //mail.ListViewTransmitted.Items.AddRange(a, b, c, d);
                MessageBox.Show("전송 완료");
            }
            else
            {

            }
        }
    }
}
