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
    public partial class FormAgePersonnel : Form
    {
        private string text;
        public FormAgePersonnel()
        {
            InitializeComponent();
            InitVariables();
        }
        private void InitVariables()
        {

        }
        public void SetAgeText(string text)
        {
            this.text = text;
        }
     
    }
}
