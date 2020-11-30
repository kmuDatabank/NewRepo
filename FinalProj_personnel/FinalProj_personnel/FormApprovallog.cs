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
    public partial class FormApprovallog : Form
    {
        public FormApprovallog()
        {
            InitializeComponent();
            InitVariable();
        }

        public void InitVariable()
        {
            this.dataGridViewappr_log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 그리드뷰의 빈 공간이 없게 출력
            DataTable dt = DBM.GetDBMinstance().Approval_log();
            dataGridViewappr_log.DataSource = dt;
        }
    }
}
