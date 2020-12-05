using System;
using System.Windows.Forms;
using System.Security.Permissions; // 브라우저 컨트롤용

namespace 다음주소api
{
    // 웹브라우저컨트롤을 위해서..
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class frmSearchZip : Form
    {
        /// <summary>
        /// 반환할 우편코드와 주소
        /// </summary>
        public string gstrZipCode = "";
        public string gstrAddress1 = "";

        public frmSearchZip()
        {
            InitializeComponent();

            WebBrowser wb = new WebBrowser();
            String url=Environment.CurrentDirectory + "\\"+"index.html";
            wb.Navigate(url);
            wb.ObjectForScripting = this; // 제일 중요
        }
        /// <summary>
        /// 해당 브라우저에 있는 javascript 함수 명 호출
        /// </summary>
        /// <param name="sZipCode"></param>
        /// <param name="sAddress1"></param>
        public void CallForm(object sZipCode, object sAddress1)
        {
            try
            {
                gstrZipCode = (string)sZipCode;
                gstrAddress1 = (string)sAddress1;

                MessageBox.Show(gstrZipCode);
                MessageBox.Show(gstrZipCode);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            frmSearchZip frm = new frmSearchZip();


            frm.ShowDialog();
            // 창이 닫히면 반환값을 반환한다.
            if (this.gstrZipCode != "")
            {


            }

            frm = null;




        }
    } // end class
} // end namespace