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

        private readonly string baseUrl = "http://localhost:7151/api/reports/";



        // =========================
        // 📊 SUMMARY (LABELS)
        // =========================
        private async Task LoadSummary()
        {
            using (HttpClient client = new HttpClient())
            {
                var json = await client.GetStringAsync(baseUrl + "summary");
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
                var json = await client.GetStringAsync(baseUrl + "borrow-per-day");
                var data = JsonConvert.DeserializeObject<List<dynamic>>(json);

                chartBorrow.Series.Clear();
                chartBorrow.Titles.Clear();

                chartBorrow.Titles.Add("Borrow Activity Per Day");

                var series = chartBorrow.Series.Add("Borrows");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                foreach (var item in data)
                {
                    DateTime date = Convert.ToDateTime(item.date);
                    int count = item.count;

                    series.Points.AddXY(date.ToString("MMM dd"), count);
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
        }
    }
}
