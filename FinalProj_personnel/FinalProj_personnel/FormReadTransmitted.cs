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

    public partial class FormReadTransmitted : Form
    {
        String name = "";
        public FormReadTransmitted()
        {
            InitializeComponent();
        }
        public FormReadTransmitted(String name)
        {
            InitializeComponent();
            this.name = name;
        }
    }
}
