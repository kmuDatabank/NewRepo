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
            ListViewItem item = new ListViewItem();
            item.Text = "홍길동";
            item.SubItems.Add("150000");
            listViewMoney.Items.Add(item);
        }
        public void SetPayText(string text)
        {
            this.text = text;
        }

        //기본금
        private void buttonMoney_Click(object sender, EventArgs e)
        {

        }

        //수당
        private void buttonAllowance_Click(object sender, EventArgs e)
        {

        }

        //공제
        private void buttonDeduction_Click(object sender, EventArgs e)
        {

        }

        //최종 임금
        private void buttonFinalWage_Click(object sender, EventArgs e)
        {

        }

      
    }
}
