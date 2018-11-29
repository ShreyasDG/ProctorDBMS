using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proctor_Database_Management_system
{
    public partial class Announce_UserControl : UserControl
    {
        public Announce_UserControl()
        {
            InitializeComponent();
        }
        private static Announce_UserControl _instance;
        public static Announce_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Announce_UserControl();
                }
                return _instance;
            }
        }
        private void announce_Load(object sender, EventArgs e)
        {

        }

        private void see_announcements_Click(object sender, EventArgs e)
        {
            if (!announce_panel.Controls.Contains(View_announcements.Instance2))
            {
                this.announce_panel.Controls.Add(View_announcements.Instance2);
                View_announcements.Instance2.Dock = DockStyle.Fill;
                View_announcements.Instance2.BringToFront();
            }
            else
            {
                View_announcements.Instance2.BringToFront();
            }
        }

        private void announce_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void make_announcements_Click(object sender, EventArgs e)
        {
            if (!announce_panel.Controls.Contains(make_announcements_userControl.Instance))
            {
                announce_panel.Controls.Add(make_announcements_userControl.Instance);
                make_announcements_userControl.Instance.Dock = DockStyle.Fill;
                make_announcements_userControl.Instance.BringToFront();
            }
            else
            {
                make_announcements_userControl.Instance.BringToFront();
            }
        }
    }
}
