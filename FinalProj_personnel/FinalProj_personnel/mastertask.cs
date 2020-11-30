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
    public partial class mastertask : Form
    {
        String name = "";
        public mastertask()
        {
            InitializeComponent();
        }
        public mastertask(String name)
        {
            InitializeComponent();
            this.Name = name;
        }

        private void button1_Click(object sender, EventArgs e)//추가버튼
        {

        }

        private void button_mod_Click(object sender, EventArgs e)//수정버튼
        {

        }

        private void button_del_Click(object sender, EventArgs e)//삭제버튼
        {

        }
    }
}
