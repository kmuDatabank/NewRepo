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
        public FormTransmittedMail()
        {
            InitializeComponent();
        }

        private void ButtonOpenMail_Click(object sender, EventArgs e)
        {
            FormReadTransmitted form = new FormReadTransmitted();
            form.Show();
        }
    }
}
