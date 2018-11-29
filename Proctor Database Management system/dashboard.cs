using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proctor_Database_Management_system
{
    public partial class dashboard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
       
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        static public String fid;
        public dashboard()
        {
            InitializeComponent();
            IsSideExpanded = true;

        }
        public dashboard(String id)
        {
            InitializeComponent();
            fid = id;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity<1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                login_timer.Stop();
            }
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            login_timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        bool IsSideExpanded;
        const int MaxWidth = 153;
        const int MinWidth = 57;

        private void toggle_Click(object sender, EventArgs e)
        {
            side_panel_timer.Start();
        }

        private void side_panel_timer_Tick(object sender, EventArgs e)
        {
            if(IsSideExpanded)
            {
                side_panel.Width -= 10;

                if(side_panel.Width<=MinWidth)
                {
                    IsSideExpanded = false;
                    side_panel_timer.Stop();
                    this.Refresh();
                }
            }
            else
            {
                side_panel.Width += 10;
                if (side_panel.Width >= MaxWidth)
                {
                    IsSideExpanded = true;
                    side_panel_timer.Stop();
                    this.Refresh();
                }
            }
        }

        private void Account_Click(object sender, EventArgs e)
        {
            if (!dashboard_panel.Controls.Contains(Account_UserControl.Instance))
            {
                dashboard_panel.Controls.Add(Account_UserControl.Instance);
                Account_UserControl.Instance.Dock = DockStyle.Fill;
                Account_UserControl.Instance.BringToFront();
            }
            else
            {
                Account_UserControl.Instance.BringToFront();
            }
        }

        private void Pgroup_Click(object sender, EventArgs e)
        {
            if (!dashboard_panel.Controls.Contains(PGroup_UserControl.Instance))
            {
                dashboard_panel.Controls.Add(PGroup_UserControl.Instance);
                PGroup_UserControl.Instance.Dock = DockStyle.Fill;
                PGroup_UserControl.Instance.BringToFront();
            }
            else
            {
                PGroup_UserControl.Instance.BringToFront();
            }
        }

        private void Announcements_Click(object sender, EventArgs e)
        {
            if (!dashboard_panel.Controls.Contains(Announce_UserControl.Instance))
            {
                dashboard_panel.Controls.Add(Announce_UserControl.Instance);
                Announce_UserControl.Instance.Dock = DockStyle.Fill;
                Announce_UserControl.Instance.BringToFront();
            }
            else
            {
                Announce_UserControl.Instance.BringToFront();
            }
        }

        private void PDiary_Click(object sender, EventArgs e)
        {
            if (!dashboard_panel.Controls.Contains(Diary_UserControl.Instance))
            {
                dashboard_panel.Controls.Add(Diary_UserControl.Instance);
                Diary_UserControl.Instance.Dock = DockStyle.Fill;
                Diary_UserControl.Instance.BringToFront();
            }
            else
            {
                Diary_UserControl.Instance.BringToFront();
            }
        }

        private void Results_Click(object sender, EventArgs e)
        {
            if (!dashboard_panel.Controls.Contains(Results_UserControl.Instance))
            {
                dashboard_panel.Controls.Add(Results_UserControl.Instance);
                Results_UserControl.Instance.Dock = DockStyle.Fill;
                Results_UserControl.Instance.BringToFront();
            }
            else
            {
                Results_UserControl.Instance.BringToFront();
            }
        }

        private void dashboard_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void side_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
