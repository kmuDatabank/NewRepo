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
    public partial class FormTimeCardPesonnel : Form
    {
        private string text;
        public FormTimeCardPesonnel()
        {
            InitializeComponent();
            InitVariables();
        }
        private void InitVariables()
        {

        }
        public void SetTimeCardText(string text)
        {
            this.text = text;
        }
       
    }
}
