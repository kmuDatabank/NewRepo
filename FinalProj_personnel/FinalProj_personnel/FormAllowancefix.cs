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
    public partial class FormAllowancefix : Form
    {
        public FormAllowancefix()
        {
            InitializeComponent();
            InitVariable();
        }
        public void InitVariable()
        {
            dateTimePicker1.CustomFormat = "yyyy년MM월";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            DateTime dt = dateTimePicker1.Value;
            string str1 = Convert.ToString(dt.Year);
            string str2 = Convert.ToString(dt.Month);
            string str = str1 + "-" + str2 + "-";
            string name = textBoxn.Text;
            int num = DBM.GetDBMinstance().fir_allowance_n(name, str);
            string[,] allowance = DBM.GetDBMinstance().fir_allowance(name, str, num);
            for(int i = 0; i < num; i++)
            {
                ListViewItem item = new ListViewItem();
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                        item.Text = allowance[i, j];
                    else
                        item.SubItems.Add(allowance[i, j]);
                }
                listView1.Items.Add(item);
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label3.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBoxh.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBoxnw.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
            catch
            {

            }
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            string date = label3.Text;
            string holi = textBoxh.Text;
            string nig = textBoxnw.Text;

            DBM.GetDBMinstance().update_allowance(date, holi, nig);

            listView1.Items.Clear();
            DateTime dt = dateTimePicker1.Value;
            string str1 = Convert.ToString(dt.Year);
            string str2 = Convert.ToString(dt.Month);
            string str = str1 + "-" + str2 + "-";
            string name = textBoxn.Text;
            int num = DBM.GetDBMinstance().fir_allowance_n(name, str);
            string[,] allowance = DBM.GetDBMinstance().fir_allowance(name, str, num);
            for (int i = 0; i < num; i++)
            {
                ListViewItem item = new ListViewItem();
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                        item.Text = allowance[i, j];
                    else
                        item.SubItems.Add(allowance[i, j]);
                }
                listView1.Items.Add(item);
            }
        }
    }
}
