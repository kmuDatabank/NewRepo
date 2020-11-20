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
    public partial class FormMain : Form
    {
        String name = "";
        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(String name1)
        {
            InitializeComponent();
            this.name = name1;
            label_name.Text = name;
        }

        private void buttonPersonnel_Click(object sender, EventArgs e)
        {
            FormPersonnel form = new FormPersonnel();
            form.Show();
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {

        }

        private void buttonApproval_Click(object sender, EventArgs e)
        {
            FormApproval form = new FormApproval();
            form.setname(name);
            form.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
