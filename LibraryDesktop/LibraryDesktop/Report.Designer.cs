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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel6 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.linklblUsers = new System.Windows.Forms.LinkLabel();
            this.lblUsers = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel5 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.linklblBooks = new System.Windows.Forms.LinkLabel();
            this.lblBooks = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel7 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.linklblBorrowed = new System.Windows.Forms.LinkLabel();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel8 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.linklblReturned = new System.Windows.Forms.LinkLabel();
            this.lblReturned = new System.Windows.Forms.Label();
            this.chartBorrow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel9 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dgvReports = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel6.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel5.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            this.guna2CustomGradientPanel7.SuspendLayout();
            this.guna2CustomGradientPanel4.SuspendLayout();
            this.guna2CustomGradientPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBorrow)).BeginInit();
            this.guna2CustomGradientPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 6;
            this.guna2CustomGradientPanel1.BorderThickness = 1;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CustomGradientPanel6);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Chocolate;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.DarkOrange;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(69, 200);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(199, 135);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel6
            // 
            this.guna2CustomGradientPanel6.Controls.Add(this.linklblUsers);
            this.guna2CustomGradientPanel6.Controls.Add(this.lblUsers);
            this.guna2CustomGradientPanel6.Location = new System.Drawing.Point(20, 19);
            this.guna2CustomGradientPanel6.Name = "guna2CustomGradientPanel6";
            this.guna2CustomGradientPanel6.Size = new System.Drawing.Size(155, 98);
            this.guna2CustomGradientPanel6.TabIndex = 3;
            // 
            // linklblUsers
            // 
            this.linklblUsers.ActiveLinkColor = System.Drawing.Color.Black;
            this.linklblUsers.AutoSize = true;
            this.linklblUsers.BackColor = System.Drawing.Color.Snow;
            this.linklblUsers.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblUsers.LinkColor = System.Drawing.Color.Black;
            this.linklblUsers.Location = new System.Drawing.Point(42, 19);
            this.linklblUsers.Name = "linklblUsers";
            this.linklblUsers.Size = new System.Drawing.Size(79, 26);
            this.linklblUsers.TabIndex = 2;
            this.linklblUsers.TabStop = true;
            this.linklblUsers.Text = "USERS";
            this.linklblUsers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblUsers_LinkClicked);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.BackColor = System.Drawing.Color.Snow;
            this.lblUsers.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(63, 57);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(25, 26);
            this.lblUsers.TabIndex = 0;
            this.lblUsers.Text = "0";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 6;
            this.guna2CustomGradientPanel2.BorderThickness = 1;
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2CustomGradientPanel5);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Chocolate;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.DarkOrange;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(69, 19);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(201, 143);
            this.guna2CustomGradientPanel2.TabIndex = 1;
            // 
            // guna2CustomGradientPanel5
            // 
            this.guna2CustomGradientPanel5.Controls.Add(this.linklblBooks);
            this.guna2CustomGradientPanel5.Controls.Add(this.lblBooks);
            this.guna2CustomGradientPanel5.Location = new System.Drawing.Point(23, 26);
            this.guna2CustomGradientPanel5.Name = "guna2CustomGradientPanel5";
            this.guna2CustomGradientPanel5.Size = new System.Drawing.Size(155, 87);
            this.guna2CustomGradientPanel5.TabIndex = 2;
            // 
            // linklblBooks
            // 
            this.linklblBooks.ActiveLinkColor = System.Drawing.Color.Black;
            this.linklblBooks.AutoSize = true;
            this.linklblBooks.BackColor = System.Drawing.Color.Snow;
            this.linklblBooks.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblBooks.LinkColor = System.Drawing.Color.Black;
            this.linklblBooks.Location = new System.Drawing.Point(38, 21);
            this.linklblBooks.Name = "linklblBooks";
            this.linklblBooks.Size = new System.Drawing.Size(83, 26);
            this.linklblBooks.TabIndex = 1;
            this.linklblBooks.TabStop = true;
            this.linklblBooks.Text = "BOOKS";
            this.linklblBooks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblBooks_LinkClicked);
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.BackColor = System.Drawing.Color.Snow;
            this.lblBooks.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooks.Location = new System.Drawing.Point(56, 47);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(25, 26);
            this.lblBooks.TabIndex = 0;
            this.lblBooks.Text = "0";
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderRadius = 6;
            this.guna2CustomGradientPanel3.BorderThickness = 1;
            this.guna2CustomGradientPanel3.Controls.Add(this.guna2CustomGradientPanel7);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Chocolate;
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.DarkOrange;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(69, 377);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(201, 193);
            this.guna2CustomGradientPanel3.TabIndex = 1;
            // 
            // guna2CustomGradientPanel7
            // 
            this.guna2CustomGradientPanel7.Controls.Add(this.linklblBorrowed);
            this.guna2CustomGradientPanel7.Controls.Add(this.lblBorrowed);
            this.guna2CustomGradientPanel7.Location = new System.Drawing.Point(20, 26);
            this.guna2CustomGradientPanel7.Name = "guna2CustomGradientPanel7";
            this.guna2CustomGradientPanel7.Size = new System.Drawing.Size(155, 147);
            this.guna2CustomGradientPanel7.TabIndex = 3;
            // 
            // linklblBorrowed
            // 
            this.linklblBorrowed.ActiveLinkColor = System.Drawing.Color.Black;
            this.linklblBorrowed.AutoSize = true;
            this.linklblBorrowed.BackColor = System.Drawing.Color.Snow;
            this.linklblBorrowed.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblBorrowed.LinkColor = System.Drawing.Color.Black;
            this.linklblBorrowed.Location = new System.Drawing.Point(15, 40);
            this.linklblBorrowed.Name = "linklblBorrowed";
            this.linklblBorrowed.Size = new System.Drawing.Size(130, 26);
            this.linklblBorrowed.TabIndex = 3;
            this.linklblBorrowed.TabStop = true;
            this.linklblBorrowed.Text = "BORROWED";
            this.linklblBorrowed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblBorrowed_LinkClicked);
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.AutoSize = true;
            this.lblBorrowed.BackColor = System.Drawing.Color.Snow;
            this.lblBorrowed.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed.Location = new System.Drawing.Point(60, 77);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(25, 26);
            this.lblBorrowed.TabIndex = 0;
            this.lblBorrowed.Text = "0";
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.BorderRadius = 6;
            this.guna2CustomGradientPanel4.BorderThickness = 1;
            this.guna2CustomGradientPanel4.Controls.Add(this.guna2CustomGradientPanel8);
            this.guna2CustomGradientPanel4.FillColor = System.Drawing.Color.Chocolate;
            this.guna2CustomGradientPanel4.FillColor2 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel4.FillColor3 = System.Drawing.Color.PeachPuff;
            this.guna2CustomGradientPanel4.FillColor4 = System.Drawing.Color.DarkOrange;
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(69, 715);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(199, 193);
            this.guna2CustomGradientPanel4.TabIndex = 1;
            // 
            // guna2CustomGradientPanel8
            // 
            this.guna2CustomGradientPanel8.Controls.Add(this.linklblReturned);
            this.guna2CustomGradientPanel8.Controls.Add(this.lblReturned);
            this.guna2CustomGradientPanel8.Location = new System.Drawing.Point(24, 26);
            this.guna2CustomGradientPanel8.Name = "guna2CustomGradientPanel8";
            this.guna2CustomGradientPanel8.Size = new System.Drawing.Size(155, 147);
            this.guna2CustomGradientPanel8.TabIndex = 3;
            // 
            // linklblReturned
            // 
            this.linklblReturned.ActiveLinkColor = System.Drawing.Color.Black;
            this.linklblReturned.AutoSize = true;
            this.linklblReturned.BackColor = System.Drawing.Color.Snow;
            this.linklblReturned.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblReturned.LinkColor = System.Drawing.Color.Black;
            this.linklblReturned.Location = new System.Drawing.Point(11, 38);
            this.linklblReturned.Name = "linklblReturned";
            this.linklblReturned.Size = new System.Drawing.Size(125, 26);
            this.linklblReturned.TabIndex = 3;
            this.linklblReturned.TabStop = true;
            this.linklblReturned.Text = "RETURNED";
            this.linklblReturned.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblReturned_LinkClicked);
            // 
            // lblReturned
            // 
            this.lblReturned.AutoSize = true;
            this.lblReturned.BackColor = System.Drawing.Color.Snow;
            this.lblReturned.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturned.Location = new System.Drawing.Point(58, 77);
            this.lblReturned.Name = "lblReturned";
            this.lblReturned.Size = new System.Drawing.Size(25, 26);
            this.lblReturned.TabIndex = 0;
            this.lblReturned.Text = "0";
            // 
            // chartBorrow
            // 
            chartArea5.Name = "ChartArea1";
            this.chartBorrow.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartBorrow.Legends.Add(legend5);
            this.chartBorrow.Location = new System.Drawing.Point(496, 40);
            this.chartBorrow.Name = "chartBorrow";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartBorrow.Series.Add(series5);
            this.chartBorrow.Size = new System.Drawing.Size(579, 352);
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
            this.btnRefresh.Location = new System.Drawing.Point(297, 72);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 34);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(297, 147);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 34);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2CustomGradientPanel9
            // 
            this.guna2CustomGradientPanel9.Controls.Add(this.btnBack);
            this.guna2CustomGradientPanel9.Controls.Add(this.guna2CustomGradientPanel2);
            this.guna2CustomGradientPanel9.Controls.Add(this.btnRefresh);
            this.guna2CustomGradientPanel9.Controls.Add(this.guna2CustomGradientPanel1);
            this.guna2CustomGradientPanel9.Controls.Add(this.guna2CustomGradientPanel3);
            this.guna2CustomGradientPanel9.Controls.Add(this.guna2CustomGradientPanel4);
            this.guna2CustomGradientPanel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel9.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel9.Name = "guna2CustomGradientPanel9";
            this.guna2CustomGradientPanel9.Size = new System.Drawing.Size(430, 950);
            this.guna2CustomGradientPanel9.TabIndex = 6;
            // 
            // dgvReports
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvReports.ColumnHeadersHeight = 4;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReports.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvReports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReports.Location = new System.Drawing.Point(496, 454);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.RowHeadersWidth = 62;
            this.dgvReports.RowTemplate.Height = 28;
            this.dgvReports.Size = new System.Drawing.Size(586, 429);
            this.dgvReports.TabIndex = 5;
            this.dgvReports.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReports.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReports.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReports.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReports.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReports.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReports.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReports.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvReports.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReports.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReports.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReports.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReports.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvReports.ThemeStyle.ReadOnly = false;
            this.dgvReports.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReports.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReports.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReports.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReports.ThemeStyle.RowsStyle.Height = 28;
            this.dgvReports.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReports.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1139, 950);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.chartBorrow);
            this.Controls.Add(this.guna2CustomGradientPanel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel6.ResumeLayout(false);
            this.guna2CustomGradientPanel6.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel5.ResumeLayout(false);
            this.guna2CustomGradientPanel5.PerformLayout();
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel7.ResumeLayout(false);
            this.guna2CustomGradientPanel7.PerformLayout();
            this.guna2CustomGradientPanel4.ResumeLayout(false);
            this.guna2CustomGradientPanel8.ResumeLayout(false);
            this.guna2CustomGradientPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBorrow)).EndInit();
            this.guna2CustomGradientPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label lblBooks;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBorrow;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel5;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel6;
        private System.Windows.Forms.Label lblUsers;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel7;
        private System.Windows.Forms.Label lblBorrowed;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel8;
        private System.Windows.Forms.Label lblReturned;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel9;
        private System.Windows.Forms.LinkLabel linklblUsers;
        private System.Windows.Forms.LinkLabel linklblBooks;
        private System.Windows.Forms.LinkLabel linklblBorrowed;
        private System.Windows.Forms.LinkLabel linklblReturned;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReports;
    }
}