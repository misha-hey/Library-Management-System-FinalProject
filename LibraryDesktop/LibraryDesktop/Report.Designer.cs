namespace LibraryDesktop
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblReturned = new System.Windows.Forms.Label();
            this.chartBorrow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            this.guna2CustomGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 6;
            this.guna2CustomGradientPanel1.BorderThickness = 1;
            this.guna2CustomGradientPanel1.Controls.Add(this.lblUsers);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Chocolate;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.DarkOrange;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(283, 40);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(194, 193);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 6;
            this.guna2CustomGradientPanel2.BorderThickness = 1;
            this.guna2CustomGradientPanel2.Controls.Add(this.lblBooks);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Chocolate;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.DarkOrange;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(43, 40);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(201, 194);
            this.guna2CustomGradientPanel2.TabIndex = 1;
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.AutoSize = true;
            this.lblBorrowed.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed.Location = new System.Drawing.Point(12, 80);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(169, 26);
            this.lblBorrowed.TabIndex = 2;
            this.lblBorrowed.Text = "lblBorrowed";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(33, 80);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(118, 26);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "lblUsers";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooks.Location = new System.Drawing.Point(30, 80);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(122, 26);
            this.lblBooks.TabIndex = 0;
            this.lblBooks.Text = "lblBooks";
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderRadius = 6;
            this.guna2CustomGradientPanel3.BorderThickness = 1;
            this.guna2CustomGradientPanel3.Controls.Add(this.lblBorrowed);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Chocolate;
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.DarkOrange;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(521, 40);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(193, 193);
            this.guna2CustomGradientPanel3.TabIndex = 1;
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.BorderRadius = 6;
            this.guna2CustomGradientPanel4.BorderThickness = 1;
            this.guna2CustomGradientPanel4.Controls.Add(this.lblReturned);
            this.guna2CustomGradientPanel4.FillColor = System.Drawing.Color.Chocolate;
            this.guna2CustomGradientPanel4.FillColor2 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel4.FillColor3 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel4.FillColor4 = System.Drawing.Color.DarkOrange;
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(753, 40);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(199, 193);
            this.guna2CustomGradientPanel4.TabIndex = 1;
            // 
            // lblReturned
            // 
            this.lblReturned.AutoSize = true;
            this.lblReturned.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturned.Location = new System.Drawing.Point(17, 80);
            this.lblReturned.Name = "lblReturned";
            this.lblReturned.Size = new System.Drawing.Size(164, 26);
            this.lblReturned.TabIndex = 3;
            this.lblReturned.Text = "lblReturned";
            // 
            // chartBorrow
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBorrow.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartBorrow.Legends.Add(legend2);
            this.chartBorrow.Location = new System.Drawing.Point(202, 263);
            this.chartBorrow.Name = "chartBorrow";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartBorrow.Series.Add(series2);
            this.chartBorrow.Size = new System.Drawing.Size(512, 401);
            this.chartBorrow.TabIndex = 2;
            this.chartBorrow.Text = "chart1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(840, 263);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 34);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 700);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chartBorrow);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Controls.Add(this.guna2CustomGradientPanel4);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            this.guna2CustomGradientPanel4.ResumeLayout(false);
            this.guna2CustomGradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblBooks;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private System.Windows.Forms.Label lblReturned;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBorrow;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}