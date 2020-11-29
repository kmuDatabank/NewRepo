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
        FormTransmittedMail mail;
        string name = "";
        public FormSendMail()
        {
            InitializeComponent();

            ComboBoxTo.Items.Clear();
            ComboBoxTo.Items.Add("");
        }

        public FormSendMail(string name, FormTransmittedMail form)
        {
            InitializeComponent();
            this.name = name;
            mail = form;
        }

        private void ButtonSendMail_Click(object sender, EventArgs e)
        {
            string title = this.TextBoxTitle.Text.Trim();
            string message = this.TextBoxMessage.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("메세지 내용를 입력해주세요!");

                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("메세지 내용를 입력해주세요!");

                return;
            }
            if (MessageBox.Show("정말로 전송하시겠습니까?", "쪽지 전송 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                mail.ListViewTransmitted.Items.Add(ComboBoxTo.SelectedItem, TextBoxTitle.Text, TextBoxMessage.Text, DateTime.Now);
                MessageBox.Show("전송 완료");
            }
            else
            {

            }
        }
    }
}
