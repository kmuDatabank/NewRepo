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

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//loginb button
        {

            DBM.GetDBMinstance().checkauth(textBox_ID.Text, textBox_pw.Text);




        }


    }
}
