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
            dateTimePicker1.CustomFormat = "yyyy년MM월";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }
        private void InitVariables()
        {
            ListViewItem item = new ListViewItem();
        }
        public void SetPayText(string text)
        {
            this.text = text;
        }

        //기본급
        private void buttonMoney_Click(object sender, EventArgs e)
        {
            int per_n = DBM.GetDBMinstance().personnel_n();
            string[] per_info = DBM.GetDBMinstance().personnelinfo(per_n);
            for (int i = 0; i < per_n; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = per_info[i];
                DateTime dt = dateTimePicker1.Value;
                string str1 = Convert.ToString(dt.Year);
                string str2 = Convert.ToString(dt.Month);
                string str = str1 + "-" + str2 + "-";
                // 검색할 월 검색
                listViewMoney.Items.Add(item);
            }
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
