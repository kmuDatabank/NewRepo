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
            listViewMoney.Items.Clear();
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
                //이름 , 월 로 검색-> 출근부에서 기본급 전부 더함
                int nor = (DBM.GetDBMinstance().pay_normal(per_info[i], str))*10000;
                item.SubItems.Add(Convert.ToString(nor));
                listViewMoney.Items.Add(item);
            }
        }

        //수당
        private void buttonAllowance_Click(object sender, EventArgs e)
        {
            listViewAllowance.Items.Clear();
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
                //이름 , 월 로 검색-> 출근부에서 기본급 전부 더함
                //연장근로수당-주간
                int wn = DBM.GetDBMinstance().weekadd_n(per_info[i], str);
                string[,] weekadd = DBM.GetDBMinstance().weekadd(per_info[i], str, wn);
                int[] fi_week = new int[7]; // 1, 2, 3, 4, 5, 6,7
                int[] se_week = new int[7]; // 8, 9, 10, 11, 12, 13, 14
                int[] th_week = new int[7]; // 15, 16, 17, 18, 19, 20, 21
                int[] fo_week = new int[7]; // 22, 23, 24, 25, 26, 27, 28
                for (int m = 0; m < wn; m++)
                {
                    string da = weekadd[m, 0][8].ToString() + weekadd[m, 0][9].ToString();
                    int day = Convert.ToInt32(da);
                    if (day <= 7)
                    {
                        fi_week[day - 1] = Convert.ToInt32(weekadd[m, 1]);
                    }
                    else if (day <= 14)
                    {
                        day = day - 7;
                        se_week[day - 1] = Convert.ToInt32(weekadd[m, 1]);
                    }
                    else if (day <= 21)
                    {
                        day = day - 14;
                        th_week[day - 1] = Convert.ToInt32(weekadd[m, 1]);
                    }
                    else if (day <= 28)
                    {
                        day = day - 21;
                        fo_week[day - 1] = Convert.ToInt32(weekadd[m, 1]);
                    }
                }
                int f = 0;
                int s = 0;
                int t = 0;
                int fo = 0;
                int weekadd_p = 0;
                
                for (int m = 0; m < 7; m++)
                {
                    f += fi_week[m];
                    s += se_week[m];
                    t += th_week[m];
                    fo += fo_week[m];
                    
                }
                if(f >= 40)
                {
                    weekadd_p = f - 40;

                }
                if (s >= 40)
                {
                    weekadd_p = s - 40;
                }
                if (t >= 40)
                {
                    weekadd_p = t - 40;
                }
                if (fo >= 40)
                {
                    weekadd_p = fo - 40;
                }

                //야근, 휴일, 연장 수당
                int plus = (DBM.GetDBMinstance().pay_plus(per_info[i], str))*5000;
                plus += (weekadd_p) * 5000;
                item.SubItems.Add(Convert.ToString(plus));
                listViewAllowance.Items.Add(item);
            }
        }

        //공제
        private void buttonDeduction_Click(object sender, EventArgs e)
        {
            listViewDeduction.Items.Clear();
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
                //이름 , 월 로 검색-> 출근부에서 기본급 전부 더함
                int wn = DBM.GetDBMinstance().weekadd_n(per_info[i], str);
                string[,] weekadd = DBM.GetDBMinstance().weekadd(per_info[i], str, wn);
                int[] fi_week = new int[7]; // 1, 2, 3, 4, 5, 6,7
                int[] se_week = new int[7]; // 8, 9, 10, 11, 12, 13, 14
                int[] th_week = new int[7]; // 15, 16, 17, 18, 19, 20, 21
                int[] fo_week = new int[7]; // 22, 23, 24, 25, 26, 27, 28
                for (int m = 0; m < wn; m++)
                {
                    string da = weekadd[m, 0][8].ToString() + weekadd[m, 0][9].ToString();
                    int day = Convert.ToInt32(da);
                    if (day <= 7)
                    {
                        fi_week[day - 1] = Convert.ToInt32(weekadd[m, 1]);
                    }
                    else if (day <= 14)
                    {
                        day = day - 7;
                        se_week[day - 1] = Convert.ToInt32(weekadd[m, 1]);
                    }
                    else if (day <= 21)
                    {
                        day = day - 14;
                        th_week[day - 1] = Convert.ToInt32(weekadd[m, 1]);
                    }
                    else if (day <= 28)
                    {
                        day = day - 21;
                        fo_week[day - 1] = Convert.ToInt32(weekadd[m, 1]);
                    }
                }
                int f = 0;
                int s = 0;
                int t = 0;
                int fo = 0;
                int weekadd_p = 0;

                for (int m = 0; m < 7; m++)
                {
                    f += fi_week[m];
                    s += se_week[m];
                    t += th_week[m];
                    fo += fo_week[m];

                }
                if (f >= 40)
                {
                    weekadd_p = f - 40;

                }
                if (s >= 40)
                {
                    weekadd_p = s - 40;
                }
                if (t >= 40)
                {
                    weekadd_p = t - 40;
                }
                if (fo >= 40)
                {
                    weekadd_p = fo - 40;
                }
                int nor = (DBM.GetDBMinstance().pay_normal(per_info[i], str)) * 10000; // 기본급
                int plus = (DBM.GetDBMinstance().pay_plus(per_info[i], str)) * 5000; // 일일 연장근무, 야간, 휴일수당
                plus += (weekadd_p) * 5000; // 주간 연장 수당
                int pay = nor + plus;
                int a = 0; // 연금 보험료 9%
                if (pay < 320000)
                {
                    a = 28800;
                }
                else
                {
                    a = (pay * 45 / 1000) * 2;
                    a = a / 10;
                    a = a * 10;
                }
                int b = 0; // 고용 보험료 1.85%
                b = pay * 185 / 10000;
                b = b / 10;
                b = b * 10;
                int c = 0; // 국민건강보험(건강보험) 6.67%
                c = pay * 667 / 10000;
                c = c / 10;
                c = c * 10;
                int d = 0; // 국민겅강보험 (장기요양보험) 건강보험의 10.25%
                d = c * 1025 / 10000;
                d = d / 10;
                d = d * 10;
                int deduction = a + b + c + d;
                item.SubItems.Add(Convert.ToString(deduction));
                listViewDeduction.Items.Add(item);
            }
        }

        //최종 임금
        private void buttonFinalWage_Click(object sender, EventArgs e) 
        {
            listViewFinalWage.Items.Clear();
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
                //이름 , 월 로 검색-> 출근부에서 기본급 전부 더함
                int wn = DBM.GetDBMinstance().weekadd_n(per_info[i], str);
                string[,] weekadd = DBM.GetDBMinstance().weekadd(per_info[i], str, wn);
                int[] fi_week = new int[7]; // 1, 2, 3, 4, 5, 6,7
                int[] se_week = new int[7]; // 8, 9, 10, 11, 12, 13, 14
                int[] th_week = new int[7]; // 15, 16, 17, 18, 19, 20, 21
                int[] fo_week = new int[7]; // 22, 23, 24, 25, 26, 27, 28
                for (int m = 0; m < wn; m++)
                {
                    string da = weekadd[m, 0][8].ToString() + weekadd[m, 0][9].ToString();
                    int day = Convert.ToInt32(da);
                    if (day <= 7)
                    {
                        fi_week[day - 1] = Convert.ToInt32(weekadd[m, 1]);
                    }
                    else if (day <= 14)
                    {
                        day = day - 7;
                        se_week[day - 1] = Convert.ToInt32(weekadd[m, 1]);
                    }
                    else if (day <= 21)
                    {
                        day = day - 14;
                        th_week[day - 1] = Convert.ToInt32(weekadd[m, 1]);
                    }
                    else if (day <= 28)
                    {
                        day = day - 21;
                        fo_week[day - 1] = Convert.ToInt32(weekadd[m, 1]);
                    }
                }
                int f = 0;
                int s = 0;
                int t = 0;
                int fo = 0;
                int weekadd_p = 0;

                for (int m = 0; m < 7; m++)
                {
                    f += fi_week[m];
                    s += se_week[m];
                    t += th_week[m];
                    fo += fo_week[m];

                }
                if (f >= 40)
                {
                    weekadd_p = f - 40;

                }
                if (s >= 40)
                {
                    weekadd_p = s - 40;
                }
                if (t >= 40)
                {
                    weekadd_p = t - 40;
                }
                if (fo >= 40)
                {
                    weekadd_p = fo - 40;
                }
                int nor = (DBM.GetDBMinstance().pay_normal(per_info[i], str)) * 10000;
                int plus = (DBM.GetDBMinstance().pay_plus(per_info[i], str)) * 5000;
                plus += (weekadd_p) * 5000;
                int pay = nor + plus;
                int a = 0; // 연금 보험료 9%
                //a = pay * 9 / 100;
                if (pay < 320000)
                {
                    a = 28800;
                }
                else
                {
                    a = (pay * 45 / 1000) * 2;
                    a = a / 10;
                    a = a * 10;
                }
                int b = 0; // 고용 보험료 1.85%
                b = pay * 185 / 10000;
                b = b / 10;
                b = b * 10;
                int c = 0; // 국민건강보험(건강보험) 6.67%
                c = pay * 667 / 10000;
                c = c / 10;
                c = c * 10;
                int d = 0; // 국민겅강보험 (장기요양보험) 건강보험의 10.25%
                d = c * 1025 / 10000;
                d = d / 10;
                d = d * 10;
                int deduction = a + b + c + d;
                int wage = pay - deduction;
                item.SubItems.Add(Convert.ToString(wage));
                listViewFinalWage.Items.Add(item);
            }
        }

        // 수당 수정
        private void buttonpayfix_Click(object sender, EventArgs e)
        {
            FormAllowancefix form = new FormAllowancefix();
            form.Show();
        }
    }
}
