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
    public partial class FormReadReceived : Form
    {
        String name = "";
        public FormReadReceived()
        {
            InitializeComponent();
            
        }
        public FormReadReceived(String name)
        {
            InitializeComponent();
            this.name = name;

        }
    }
}
