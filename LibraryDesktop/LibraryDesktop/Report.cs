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
using System.Windows.Forms.DataVisualization.Charting;

namespace LibraryDesktop
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private readonly string baseApi = "https://localhost:7151/api/";


        private async Task LoadSummary()
        {
            using (HttpClient client = new HttpClient())
            {
                var json = await client.GetStringAsync(baseApi + "reports/summary");
                dynamic data = JsonConvert.DeserializeObject(json);

                lblBooks.Text = data.totalBooks.ToString();
                lblUsers.Text = data.totalUsers.ToString();
                lblBorrowed.Text = data.borrowed.ToString();
                lblReturned.Text = data.returned.ToString();
            }
        }

        // =========================
        // 📈 CHART (PER DAY)
        // =========================
        private async Task LoadBorrowPerDayChart()
        {
            using (HttpClient client = new HttpClient())
            {
                var json = await client.GetStringAsync(baseApi + "reports/borrow-per-day");
                var data = JsonConvert.DeserializeObject<List<dynamic>>(json);

                chartBorrow.Series.Clear();
                chartBorrow.Titles.Clear();

                chartBorrow.Titles.Add("Borrow Activity Per Day");

                var series = chartBorrow.Series.Add("Borrows");
                series.ChartType = SeriesChartType.Column;
                chartBorrow.ChartAreas[0].AxisY.Interval = 1;
                chartBorrow.ChartAreas[0].AxisY.Minimum = 0;

                foreach (var item in data)
                {
                    DateTime date = Convert.ToDateTime(item.date);
                    int count = item.count;

                    series.Points.AddXY(date.ToString("MMM dd"), count);
                }
            }
        }

        // =========================
        // 📋 LOAD TABLE (REUSABLE)
        // =========================
        private async Task LoadTable(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                dgvReports.DataSource = null;

                var json =
                    await client.GetStringAsync(url);

                var data =
                    JsonConvert.DeserializeObject<List<dynamic>>(json);

                dgvReports.DataSource = data;

                dgvReports.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                // HIDE IMAGEPATH
                if (dgvReports.Columns["ImagePath"] != null)
                {
                    dgvReports.Columns["ImagePath"].Visible = false;
                }

                // HIDE aLREADYBORROWED
                if (dgvReports.Columns["alreadyBorrowed"] != null)
                {
                    dgvReports.Columns["alreadyBorrowed"].Visible = false;
                }
            }
        }
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadSummary();
            await LoadBorrowPerDayChart();
        }

        private async void frmReport_Load(object sender, EventArgs e)
        {
            await LoadSummary();
            await LoadBorrowPerDayChart();
            dgvReports.ColumnHeadersVisible = true;

            dgvReports.EnableHeadersVisualStyles = false;

            dgvReports.ColumnHeadersHeight = 40;

            dgvReports.ColumnHeadersDefaultCellStyle.BackColor =
                 Color.FromArgb(100, 88, 255);

            dgvReports.ColumnHeadersDefaultCellStyle.ForeColor =
             Color.White;

            dgvReports.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard=new frmDashboard();      
            dashboard.Show();
            this.Hide();
        }

        private async void linklblBooks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await LoadTable(baseApi + "books");
        }

        private async void linklblUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await LoadTable(baseApi + "users");
        }

        private async void linklblBorrowed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await LoadTable(baseApi +"borrow");
        }

        private async void linklblReturned_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await LoadTable(baseApi + "return");
        }

       
    }
}
