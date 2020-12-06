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

namespace FinalProj_personnel
{

    public partial class FormMailMenu : Form
    {
        string name = "";
        public FormMailMenu()
        {
            InitializeComponent();
        }

        public FormMailMenu(string name)
        {
            InitializeComponent();
            this.name = name;
            checkunread(name);
        }


        private void ButtonSendMail_Click(object sender, EventArgs e)
        {
            FormSendMail form = new FormSendMail(name);
            form.Show();
        }

        private void ButtonReceivedMail_Click(object sender, EventArgs e)
        {
            rcvdmail form = new rcvdmail(name);
            form.Show();
        }

        private void ButtonTransmittedMail_Click(object sender, EventArgs e)
        {
            FormTransmittedMail form = new FormTransmittedMail(name);
            form.Show();
        }


        public void checkunread(String name)
        {
            using (DBM.Getinstance())
            {
                DBM.Getinstance().Open();
                String query = "SELECT * FROM RMails WHERE WHO=" + "\"" + name + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());

                MySqlDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read()){

                    if (rdr["readed"].ToString() == "0")
                    {
                        MessageBox.Show("안읽은 메일이 존재합니다!");
                        return;

                    }


                }


            }



        }










    }
}
