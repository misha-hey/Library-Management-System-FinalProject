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
        bool sidebarexpand = true;
        private void sidetransition_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                side.Width -= 15;
                if (side.Width <= 0)
                {
                    sidebarexpand = false;
                    sidetransition.Stop();
                }
            }
            else
            {
                side.Width += 15;
                if (side.Width >= 140)
                {
                    sidebarexpand = true;
                    sidetransition.Stop();
                }

            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidetransition.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Hide();
        }
        private void btnBooks_Click_1(object sender, EventArgs e)
        {
            frmBooks books = new frmBooks();
            books.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
