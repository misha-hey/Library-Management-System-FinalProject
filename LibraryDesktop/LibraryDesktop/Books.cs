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
using static Guna.UI2.Native.WinApi;

namespace LibraryDesktop
{
    public partial class frmBooks : Form
    {
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
                quantity = (int)numericUpDown1.Value
            };

            var handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => true
            };

            using (HttpClient client = new HttpClient(handler))
            {
                var content = new StringContent(
                    JsonConvert.SerializeObject(book),
                    Encoding.UTF8,
                    "application/json"
                );

                var response = await client.PostAsync("https://localhost:7151/api/books", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Book added successfully!");
                    await LoadBooks();

                    txtTitle.Clear();
                    txtAuthor.Clear();
                    cmbCategory.SelectedIndex = -1;
                    numericUpDown1.Value = 0;
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

            int BookId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BookId"].Value);

            var updatedBook = new
            {
                title = txtTitle.Text,
                author = txtAuthor.Text,
                category = cmbCategory.Text,
                quantity = (int)numericUpDown1.Value
            };

            var handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => true
            };

            using (HttpClient client = new HttpClient(handler))
            {
                var content = new StringContent(
                    JsonConvert.SerializeObject(updatedBook),
                    Encoding.UTF8,
                    "application/json"
                );
                var response = await client.PutAsync($"https://localhost:7151/api/books/{BookId}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Book updated successfully!");
                    txtTitle.Clear();
                    txtAuthor.Clear();
                    cmbCategory.SelectedIndex = -1;
                    await LoadBooks();
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

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this book?",
                                         "Confirm Delete",
                                         MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes) return;

            var handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => true
            };

            using (HttpClient client = new HttpClient(handler))
            {
                var response = await client.DeleteAsync($"https://localhost:7151/api/books/{id}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Book deleted successfully!");
                    await LoadBooks();
                }
                else
                {
                    MessageBox.Show("Failed to delete book");
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {         
            if (dataGridView1.CurrentRow != null)
            {
                txtTitle.Text = dataGridView1.CurrentRow.Cells["Title"].Value.ToString();
                txtAuthor.Text = dataGridView1.CurrentRow.Cells["Author"].Value.ToString();
                cmbCategory.Text = dataGridView1.CurrentRow.Cells["Category"].Value.ToString();
                numericUpDown1.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Quantity"].Value);
            }
        }
    }
}
