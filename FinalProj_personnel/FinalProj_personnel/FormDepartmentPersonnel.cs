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
    public partial class FormDepartmentPersonnel : Form
    {

        string text1 ="";
        string text2 ="";

        public FormDepartmentPersonnel()
        {
            InitializeComponent();
            InitVariables();
        }
        private void InitVariables()
        {

        }
        public void SetComboDepartText(string text)
        {
            this.text1 = text;
        }
        public void SetDepartText(string text)
        {
            this.text2 = text; 
        }
     

        private void FormDepartmentPersonnel_Load(object sender, EventArgs e)
        {
            DBM.GetDBMinstance().personnelSearch(text1,text2);
        }
    }
}
