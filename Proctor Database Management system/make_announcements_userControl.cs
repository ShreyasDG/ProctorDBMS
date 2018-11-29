using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proctor_Database_Management_system
{
    public partial class make_announcements_userControl : UserControl
    {
        public make_announcements_userControl()
        {
            InitializeComponent();
        }
        private static make_announcements_userControl _instance;
        public static make_announcements_userControl Instance
        {
            get
            {

                if (_instance == null)
                {
                    _instance = new make_announcements_userControl();
                }
                return _instance;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void make_announcements_userControl_Load(object sender, EventArgs e)
        {

        }

        private void submit_announcement_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            SqlDataReader dr;
            SqlCommand cmd;
            if(content_textBox.Text!="" && title_textBox.Text!="")
            {
                con.Open();

                String s1 = "select pgid from ANNOUNCEMENT where fid = " + dashboard.fid;

                cmd = new SqlCommand(s1, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                int pgid = Int32.Parse(dr[0].ToString());
                dr.Close();
                cmd = new SqlCommand("Make_announcements", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fid", Int32.Parse(dashboard.fid));
                cmd.Parameters.AddWithValue("@pgid", pgid);
                cmd.Parameters.AddWithValue("@content", content_textBox.Text);
                cmd.Parameters.AddWithValue("@title", title_textBox.Text);
                cmd.Parameters.AddWithValue("@attachments", link_tbox.Text);

                dr = cmd.ExecuteReader();
                dr.Read();
                MessageBox.Show("Success");
                con.Close();
            }
            else
            {
                MessageBox.Show("Enter reqd fields");
            }
            
        }
    }
}
