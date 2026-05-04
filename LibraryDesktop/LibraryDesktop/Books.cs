using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static Guna.UI2.Native.WinApi;

namespace LibraryDesktop
{   
    public partial class frmBooks : Form
    {
        private string selectedImageBase64 = "";
        public frmBooks()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmDashboard home = new frmDashboard();
            home.Show();
            this.Hide();
        }
        private async Task LoadBooks()
        {
            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetStringAsync("https://localhost:7151/api/books");
                var books = JsonConvert.DeserializeObject<List<Book>>(res);

                dataGridView1.DataSource = books;

                // optional: hide image path column
                if (dataGridView1.Columns.Contains("ImagePath"))
                    dataGridView1.Columns["ImagePath"].Visible = false;
            }
        }

        private async void frmBooks_Load(object sender, EventArgs e)
        {
            await LoadBooks();
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {

            var book = new
            {
                title = txtTitle.Text,
                author = txtAuthor.Text,
                category = cmbCategory.Text,
                quantity = (int)numericUpDown1.Value,
                imagePath = selectedImageBase64
            };

            var handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (a, b, c, d) => true
            };

            using (HttpClient client = new HttpClient(handler))
            {
                var content = new StringContent(JsonConvert.SerializeObject(book), Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://localhost:7151/api/books", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Book added successfully!");
                    await LoadBooks();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add book");
                }
            }
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a book first!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BookId"].Value);

            var updatedBook = new
            {
                title = txtTitle.Text,
                author = txtAuthor.Text,
                category = cmbCategory.Text,
                quantity = (int)numericUpDown1.Value,
                imagePath = selectedImageBase64
            };

            var handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (a, b, c, d) => true
            };

            using (HttpClient client = new HttpClient(handler))
            {
                var content = new StringContent(JsonConvert.SerializeObject(updatedBook), Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"https://localhost:7151/api/books/{id}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Book updated successfully!");
                    await LoadBooks();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to update book");
                }
            }
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a book first!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BookId"].Value);

            if (MessageBox.Show("Delete this book?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (a, b, c, d) => true
            };

            using (HttpClient client = new HttpClient(handler))
            {
                var response = await client.DeleteAsync($"https://localhost:7151/api/books/{id}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Deleted!");
                    await LoadBooks();
                }
                else
                {
                    MessageBox.Show("Failed to delete");
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.CurrentRow;

            if (row == null) return;

            txtTitle.Text = row.Cells["Title"].Value?.ToString();
            txtAuthor.Text = row.Cells["Author"].Value?.ToString();
            cmbCategory.Text = row.Cells["Category"].Value?.ToString();
            numericUpDown1.Value = Convert.ToInt32(row.Cells["Quantity"].Value);

            string imagePath = row.Cells["ImagePath"]?.Value?.ToString();

            if (!string.IsNullOrEmpty(imagePath))
            {
                pbxBooks.Load("https://localhost:7151" + imagePath);
            }
            else
            {
                pbxBooks.Image = null;
            }
        }
        private void ClearForm()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            cmbCategory.SelectedIndex = -1;
            numericUpDown1.Value = 0;

            pbxBooks.Image = null;
            selectedImageBase64 = "";
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;

                    // Load image safely (avoid file lock)
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        pbxBooks.Image = Image.FromStream(fs);
                    }

                    // Convert to base64
                    byte[] imageBytes = File.ReadAllBytes(filePath);
                    selectedImageBase64 = Convert.ToBase64String(imageBytes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
    }
}
