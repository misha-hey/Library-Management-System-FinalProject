using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDesktop
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {

            frmBooks books = new frmBooks();
            books.Show();
            
        }

        private void btnUsers_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.Show();

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Hide();
        }
    }
}
