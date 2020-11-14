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
    public partial class FormPayViewer : Form
    {
        private string text;
        public FormPayViewer()
        {
            InitializeComponent();
            InitVariables();
        }
        private void InitVariables()
        {

        }
        public void SetPayText(string text)
        {
            this.text = text;
        }
    }
}
