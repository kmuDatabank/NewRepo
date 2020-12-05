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
        ListViewItem item1=new ListViewItem();
        public FormReadTransmitted()
        {
            InitializeComponent();
        }
        public FormReadTransmitted(String name, ListViewItem item)
        {
            InitializeComponent();
            this.name = name;
            this.item1 = item;
            setting();


        }
        public void setting()
        {
            TextBoxWho.Text = item1.Text;
            TextBoxTitle.Text= item1.SubItems[1].Text;
            TextBoxContent.Text = item1.SubItems[2].Text;
            MessageBox.Show(item1.SubItems[3].Text);

        }
        
        








    }
}
