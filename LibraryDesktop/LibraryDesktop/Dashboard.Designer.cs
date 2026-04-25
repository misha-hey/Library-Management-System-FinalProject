namespace LibraryDesktop
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.side = new System.Windows.Forms.Panel();
            this.btnBooks = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.sidetransition = new System.Windows.Forms.Timer(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.side.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btnMenu);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnExit);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.DarkOrange;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Moccasin;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.DarkOrange;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, -1);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(963, 47);
            this.guna2CustomGradientPanel1.TabIndex = 23;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::LibraryDesktop.Properties.Resources.icons8_menu_50;
            this.btnMenu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(66, 44);
            this.btnMenu.TabIndex = 20;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::LibraryDesktop.Properties.Resources.icons8_exit_30;
            this.btnExit.Location = new System.Drawing.Point(906, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 34);
            this.btnExit.TabIndex = 18;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // side
            // 
            this.side.BackColor = System.Drawing.Color.DarkOrange;
            this.side.Controls.Add(this.btnBooks);
            this.side.Controls.Add(this.btnLogout);
            this.side.Controls.Add(this.btnReports);
            this.side.Controls.Add(this.btnUsers);
            this.side.Location = new System.Drawing.Point(-3, 43);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(226, 615);
            this.side.TabIndex = 24;
            // 
            // btnBooks
            // 
            this.btnBooks.BorderRadius = 5;
            this.btnBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBooks.FillColor = System.Drawing.Color.MintCream;
            this.btnBooks.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.Black;
            this.btnBooks.Location = new System.Drawing.Point(13, 53);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(194, 59);
            this.btnBooks.TabIndex = 4;
            this.btnBooks.Text = "Manage Books";
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 5;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.MintCream;
            this.btnLogout.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(13, 429);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(194, 52);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReports
            // 
            this.btnReports.BorderRadius = 5;
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReports.FillColor = System.Drawing.Color.MintCream;
            this.btnReports.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Black;
            this.btnReports.Location = new System.Drawing.Point(13, 309);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(194, 52);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            // 
            // btnUsers
            // 
            this.btnUsers.BorderRadius = 5;
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.MintCream;
            this.btnUsers.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.Location = new System.Drawing.Point(13, 187);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(194, 52);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Manage Users";
            // 
            // sidetransition
            // 
            this.sidetransition.Tick += new System.EventHandler(this.sidetransition_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryDesktop.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 598);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.side);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.side.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel side;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private System.Windows.Forms.Timer sidetransition;
        private Guna.UI2.WinForms.Guna2Button btnBooks;
    }
}