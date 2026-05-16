using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LibraryDesktop
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDATION
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show(
                        "Please fill all fields.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // USER OBJECT
                var user = new
                {
                    Name = txtName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                };

                // CONVERT TO JSON
                string json =
                    JsonConvert.SerializeObject(user);

                using (HttpClient client = new HttpClient())
                {
                    // API URL
                    client.BaseAddress =
                        new Uri("https://localhost:7151/");

                    // JSON CONTENT
                    StringContent content =
                        new StringContent(
                            json,
                            Encoding.UTF8,
                            "application/json"
                        );

                    // SEND TO API
                    HttpResponseMessage response =
                      await client.PostAsync(
                         "api/auth/register-admin",content
                      );

                    // GET RESPONSE
                    string result =
                        await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(
                            result,
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        // CLEAR FIELDS
                        txtName.Clear();
                        txtEmail.Clear();
                        txtPassword.Clear();

                        // OPTIONAL:
                        frmLogin login = new frmLogin();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            result,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "System Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


    }
}
