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
        public FormTransmittedMail()
        {
            InitializeComponent();
        }
        public FormTransmittedMail(string name, FormReadTransmitted form)
        {
            InitializeComponent();
            this.name = name;
            mail = form;

            string strqry = "select * from databank.TMails where not WHO=" + name;

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strqry, conn);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader R = cmd.ExecuteReader();

                if (R.HasRows)
                {
                    while (R.Read())
                    {
                        ListViewItem lvt = new ListViewItem();
                        lvt.SubItems.Add(R.GetString(0));
                        lvt.SubItems.Add(R.GetString(1));
                        lvt.SubItems.Add(R.GetString(2));
                        lvt.SubItems.Add(R.GetString(3));
                        ListViewTransmitted.Items.Add(lvt);
                    }
                }
                else
                {
                    MessageBox.Show("데이터가 없습니다");
                }
            }
        }
        private void ButtonOpenMail_Click(object sender, EventArgs e)
        {
            FormReadTransmitted form = new FormReadTransmitted();

            if (ListViewTransmitted.SelectedItems.Count != 0)
            {
                int SelectRow = ListViewTransmitted.SelectedItems[0].Index;

                string who = ListViewTransmitted.Items[SelectRow].SubItems[0].Text;
                string title = ListViewTransmitted.Items[SelectRow].SubItems[1].Text;
                string content = ListViewTransmitted.Items[SelectRow].SubItems[2].Text;

                mail.TextBoxWho.Text = who;
                mail.TextBoxTitle.Text = title;
                mail.TextBoxContent.Text = content;
            }

            form.Show();
        }
    }
}
