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
using MySql.Data.MySqlClient.Authentication;

namespace FinalProj_personnel
{
    public partial class TMmodform : Form
    {
        String selcategory = "";
        int selindex = 0;
        public TMmodform()
        {
            InitializeComponent();
        }

        public TMmodform(String cate,int index)
        {
            InitializeComponent();

            this.selcategory = cate;
            this.selindex = index;//db의 인덱스임.

            comboBox_modbefore.Text = cate;
            comboBox_modafter.Text = cate;
            //내용이름 가져오기
            using (DBM.Getinstance()) {
                int index2 = index;
                DBM.Getinstance().Open();
                String query = "SELECT * FROM " + cate + " WHERE ID=" + "\""+ index2 + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    textBox_modbefore.Text = rdr["name"].ToString();

                }
            }





            



        }

        private void button_mod_Click(object sender, EventArgs e)//수정실행
        {
 


            using (DBM.Getinstance())
            {
                int index2 = selindex ;
                DBM.Getinstance().Open();
                String query = "UPDATE " + selcategory  + " SET " + "name=" + "\"" + textBox_modafter.Text + "\"" + " WHERE ID= " + "\"" + index2.ToString() + "\"";
                MySqlCommand cmd = new MySqlCommand(query, DBM.Getinstance());
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    textBox_modbefore.Text = rdr["name"].ToString();

                }
            }


            MessageBox.Show("수정완료");

            this.Close();
            
        }









        





    }
}
