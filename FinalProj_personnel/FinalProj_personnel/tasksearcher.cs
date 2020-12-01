using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Authentication;

namespace FinalProj_personnel
{
    public partial class tasksearcher : Form
    {
        String name = "";
        String checker = "";
        public tasksearcher()
        {
            InitializeComponent();
        }

        public tasksearcher(String name, String checker)
        {
            InitializeComponent();
            this.name = name;
            this.checker = checker;
            
        }











    }




}

