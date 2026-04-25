using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDesktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            string url = "https://localhost:7151/api/auth/login";

            var loginData = new
            {
                Email = username,   // bisan username ang textbox name
                Password = password
            };

            var json = JsonConvert.SerializeObject(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.PostAsync(url, content);

                string result = await response.Content.ReadAsStringAsync();
              

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Login failed: " + result);
                    return;
                }

                var user = JsonConvert.DeserializeObject<User>(result);

                if (user != null && user.Role == "Admin")
                {
                    MessageBox.Show("Login Successfully!");
                    frmDashboard home = new frmDashboard();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Access denied. Admin only.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
