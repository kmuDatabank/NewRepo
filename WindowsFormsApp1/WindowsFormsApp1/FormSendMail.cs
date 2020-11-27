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
        public FormSendMail()
        {
            InitializeComponent();

            ComboBoxTo.Items.Clear();
            ComboBoxTo.Items.Add("");
        }

        private void ButtonSendMail_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 전송하시겠습니까?", "쪽지 전송 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                MessageBox.Show("전송 완료");
            }
            else
            {

            }
        }
    }
}
