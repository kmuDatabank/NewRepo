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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Loginform_Load(object sender, EventArgs e)//남은것은 체크가 된 정보를 어떻게 저장할지가,, 파일입출력? DB?
        {
            String check="";

           int judge=DBM.GetDBMinstance().file_rd();

            if (judge == 48)
            {
                checkBox_autoload.Checked =false;
            }
            else if (judge == 49)
            {
                checkBox_autoload.Checked = true;
            }





            if (checkBox_autoload.Checked)
            {
                check = DBM.GetDBMinstance().autoload();
            }
           

            if (check == "")//결과값 없음 
            {

            }
            else if (check != "")//최근 접속한 아이디가 존재
            {
                var a=check.Split(',');
                textBox_ID.Text = a[0];
                textBox_pw.Text = a[1];
            }
            






        }

        private void button1_Click(object sender, EventArgs e)//login button
        {
            String checkname = "";



            checkname=DBM.GetDBMinstance().checkauth(textBox_ID.Text, textBox_pw.Text);//사용자의 이름을 받음
            
            


        }

        private void checkBox_autoload_CheckedChanged(object sender, EventArgs e)//파일입출력으로 파일참조하여 오토로드 기능활성화
        {
            if (checkBox_autoload.Checked == true){
                DBM.GetDBMinstance().file_write("1");
            }
            else if (checkBox_autoload.Checked == false)
            {
                DBM.GetDBMinstance().file_write("0");
            }




        }
    }
}
