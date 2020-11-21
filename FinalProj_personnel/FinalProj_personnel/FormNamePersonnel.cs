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
    public partial class FormNamePersonnel : Form
    {
        private string text;
        public FormNamePersonnel()
        {
            InitializeComponent();
            InitVariables();
        }
        private void InitVariables()
        {

        }
        public void SetNameText(string text)
        {
            this.text = text;
        }

        private void buttonDeletePerson_Click(object sender, EventArgs e)
        {
            
        }
    }
}
