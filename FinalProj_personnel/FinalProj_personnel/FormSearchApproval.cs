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
    public partial class FormSearchApproval : Form
    {
        public FormSearchApproval()
        {
            InitializeComponent();
        }

        private void buttonsearch_name_Click(object sender, EventArgs e) // 제목검색
        {
            if (textBoxsaerch_name.Text == "") // 제목 미작성
            {
                MessageBox.Show("결재 제목을 작성해주세요");
            }
            else
            {
                listBox1.Items.Clear();
                string s = textBoxappr_name.Text;

                int a = DBM.GetDBMinstance().Approsearch_name_n(s); // 검색된 제목의 갯수
                string[] st = new string[a];
                st = DBM.GetDBMinstance().Approsearch_name(s, a); // 제목 이름 가져옴
                for(int i =0; i < a; i++) // 갯수만큼
                {
                    listBox1.Items.Add(st[i]); // 제목 추가
                }

            }
        }
    }
}
