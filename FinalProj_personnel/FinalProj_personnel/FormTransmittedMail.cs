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
    public partial class FormTransmittedMail : Form
    {
        string strConn = "Server=49.50.174.201;Database=databank;Uid=databank;Pwd=dbdb;Charset=utf8";

        FormReadTransmitted mail;
        string name = "";
        String tempid = "";
        public FormTransmittedMail()
        {
            InitializeComponent();
        }
        public FormTransmittedMail(String name)//송신 정보
        {
            InitializeComponent();

            this.name = name;

            setting();



        }
        public void setting()
        {
            ListViewTransmitted.Items.Clear();
            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM TMails WHERE WHO= " + "\"" + name + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                MySqlDataReader rdr = cmd.ExecuteReader();
                //받는사람 제목 내용 전송날짜 ~리스트뷰 칼럼
                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem();


                    item.Text = rdr["SENDED"].ToString();
                    item.SubItems.Add(rdr["TITLE"].ToString());
                    item.SubItems.Add(rdr["CONTENT"].ToString());
                    item.SubItems.Add(rdr["DATE"].ToString());
                    item.SubItems.Add(rdr["readed"].ToString());
                    item.SubItems.Add(rdr["ID"].ToString());


                    ListViewTransmitted.Items.Add(item);

                }





            }



        }

        private void ButtonOpenMail_Click(object sender, EventArgs e)//수정요망
        {
            tempid=ListViewTransmitted.FocusedItem.SubItems[5].Text;

            ListViewItem item=ListViewTransmitted.FocusedItem;
            FormReadTransmitted form = new FormReadTransmitted(name, item);
            form.Show();




            setting();
        }
    }
}
