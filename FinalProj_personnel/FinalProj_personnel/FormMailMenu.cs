﻿using System;
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

    public partial class FormMailMenu : Form
    {
        string name = "";
        public FormMailMenu()
        {
            InitializeComponent();
        }

        public FormMailMenu(string name)
        {
            InitializeComponent();
            this.name = name;
        }


        private void ButtonSendMail_Click(object sender, EventArgs e)
        {
            FormSendMail form = new FormSendMail(name);
            form.Show();
        }

        private void ButtonReceivedMail_Click(object sender, EventArgs e)
        {
            FormReceivedMail form = new FormReceivedMail(name);
            form.Show();
        }

        private void ButtonTransmittedMail_Click(object sender, EventArgs e)
        {
            FormTransmittedMail form = new FormTransmittedMail(name);
            form.Show();
        }
    }
}
