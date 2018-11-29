namespace Proctor_Database_Management_system
{
    partial class dashboard
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
            this.login_timer = new System.Windows.Forms.Timer(this.components);
            this.titlebar = new System.Windows.Forms.Panel();
            this.side_panel_timer = new System.Windows.Forms.Timer(this.components);
            this.dashboard_panel = new System.Windows.Forms.Panel();
            this.side_panel = new System.Windows.Forms.Panel();
            this.Account = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.Button();
            this.PDiary = new System.Windows.Forms.Button();
            this.Announcements = new System.Windows.Forms.Button();
            this.Pgroup = new System.Windows.Forms.Button();
            this.toggle = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.titlebar.SuspendLayout();
            this.side_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_timer
            // 
            this.login_timer.Interval = 8;
            this.login_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.CadetBlue;
            this.titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.titlebar.Controls.Add(this.logout);
            this.titlebar.Controls.Add(this.minimize);
            this.titlebar.Controls.Add(this.close);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(800, 35);
            this.titlebar.TabIndex = 0;
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // side_panel_timer
            // 
            this.side_panel_timer.Interval = 5;
            this.side_panel_timer.Tick += new System.EventHandler(this.side_panel_timer_Tick);
            // 
            // dashboard_panel
            // 
            this.dashboard_panel.BackColor = System.Drawing.Color.SkyBlue;
            this.dashboard_panel.BackgroundImage = global::Proctor_Database_Management_system.Properties.Resources.login5;
            this.dashboard_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboard_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dashboard_panel.Location = new System.Drawing.Point(152, 35);
            this.dashboard_panel.Name = "dashboard_panel";
            this.dashboard_panel.Size = new System.Drawing.Size(648, 415);
            this.dashboard_panel.TabIndex = 2;
            this.dashboard_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboard_panel_Paint);
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.Transparent;
            this.side_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.side_panel.Controls.Add(this.Account);
            this.side_panel.Controls.Add(this.Results);
            this.side_panel.Controls.Add(this.PDiary);
            this.side_panel.Controls.Add(this.Announcements);
            this.side_panel.Controls.Add(this.Pgroup);
            this.side_panel.Controls.Add(this.toggle);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 35);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(153, 415);
            this.side_panel.TabIndex = 1;
            this.side_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.side_panel_Paint);
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.Color.Transparent;
            this.Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Account.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Account.FlatAppearance.BorderSize = 3;
            this.Account.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Account.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.ForeColor = System.Drawing.Color.Black;
            this.Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Account.ImageKey = "(none)";
            this.Account.Location = new System.Drawing.Point(0, 50);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(153, 43);
            this.Account.TabIndex = 3;
            this.Account.Text = "Account";
            this.Account.UseVisualStyleBackColor = false;
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.Transparent;
            this.Results.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Results.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Results.FlatAppearance.BorderSize = 3;
            this.Results.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Results.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Results.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Results.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.ForeColor = System.Drawing.Color.Black;
            this.Results.Location = new System.Drawing.Point(0, 246);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(153, 43);
            this.Results.TabIndex = 4;
            this.Results.Text = "Results";
            this.Results.UseVisualStyleBackColor = false;
            this.Results.Click += new System.EventHandler(this.Results_Click);
            // 
            // PDiary
            // 
            this.PDiary.BackColor = System.Drawing.Color.Transparent;
            this.PDiary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PDiary.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.PDiary.FlatAppearance.BorderSize = 3;
            this.PDiary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.PDiary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.PDiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PDiary.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDiary.ForeColor = System.Drawing.Color.Black;
            this.PDiary.Location = new System.Drawing.Point(0, 197);
            this.PDiary.Name = "PDiary";
            this.PDiary.Size = new System.Drawing.Size(153, 43);
            this.PDiary.TabIndex = 3;
            this.PDiary.Text = "Diary";
            this.PDiary.UseVisualStyleBackColor = false;
            this.PDiary.Click += new System.EventHandler(this.PDiary_Click);
            // 
            // Announcements
            // 
            this.Announcements.BackColor = System.Drawing.Color.Transparent;
            this.Announcements.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Announcements.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Announcements.FlatAppearance.BorderSize = 3;
            this.Announcements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Announcements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Announcements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Announcements.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Announcements.ForeColor = System.Drawing.Color.Black;
            this.Announcements.Location = new System.Drawing.Point(0, 148);
            this.Announcements.Name = "Announcements";
            this.Announcements.Size = new System.Drawing.Size(153, 43);
            this.Announcements.TabIndex = 3;
            this.Announcements.Text = "Announcements";
            this.Announcements.UseVisualStyleBackColor = false;
            this.Announcements.Click += new System.EventHandler(this.Announcements_Click);
            // 
            // Pgroup
            // 
            this.Pgroup.BackColor = System.Drawing.Color.Transparent;
            this.Pgroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pgroup.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Pgroup.FlatAppearance.BorderSize = 3;
            this.Pgroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Pgroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Pgroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pgroup.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pgroup.ForeColor = System.Drawing.Color.Black;
            this.Pgroup.Location = new System.Drawing.Point(0, 99);
            this.Pgroup.Name = "Pgroup";
            this.Pgroup.Size = new System.Drawing.Size(153, 43);
            this.Pgroup.TabIndex = 3;
            this.Pgroup.Text = "PGroup";
            this.Pgroup.UseVisualStyleBackColor = false;
            this.Pgroup.Click += new System.EventHandler(this.Pgroup_Click);
            // 
            // toggle
            // 
            this.toggle.BackColor = System.Drawing.Color.Transparent;
            this.toggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toggle.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.toggle.FlatAppearance.BorderSize = 3;
            this.toggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.toggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggle.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggle.ForeColor = System.Drawing.Color.Black;
            this.toggle.Location = new System.Drawing.Point(0, 0);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(153, 43);
            this.toggle.TabIndex = 2;
            this.toggle.Text = "toggle";
            this.toggle.UseVisualStyleBackColor = false;
            this.toggle.Click += new System.EventHandler(this.toggle_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.CadetBlue;
            this.logout.BackgroundImage = global::Proctor_Database_Management_system.Properties.Resources.logout;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.ForeColor = System.Drawing.Color.CadetBlue;
            this.logout.Location = new System.Drawing.Point(702, 6);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(24, 24);
            this.logout.TabIndex = 2;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.button3_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.CadetBlue;
            this.minimize.BackgroundImage = global::Proctor_Database_Management_system.Properties.Resources.minimize;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.Color.CadetBlue;
            this.minimize.Location = new System.Drawing.Point(732, 6);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 23);
            this.minimize.TabIndex = 1;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.button2_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.CadetBlue;
            this.close.BackgroundImage = global::Proctor_Database_Management_system.Properties.Resources.close;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.CadetBlue;
            this.close.Location = new System.Drawing.Point(763, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 23);
            this.close.TabIndex = 0;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button1_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Proctor_Database_Management_system.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dashboard_panel);
            this.Controls.Add(this.side_panel);
            this.Controls.Add(this.titlebar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.titlebar.ResumeLayout(false);
            this.side_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer login_timer;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Button PDiary;
        private System.Windows.Forms.Button Announcements;
        private System.Windows.Forms.Button Pgroup;
        private System.Windows.Forms.Button toggle;
        private System.Windows.Forms.Timer side_panel_timer;
        private System.Windows.Forms.Button Results;
        private System.Windows.Forms.Button Account;
        private System.Windows.Forms.Panel dashboard_panel;
    }
}