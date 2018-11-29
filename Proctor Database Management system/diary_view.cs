using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proctor_Database_Management_system
{
    public partial class diary_view : Form
    {
        public diary_view()
        {
            InitializeComponent();
        }
        static public int sid;
        public diary_view(String s)
        {
            InitializeComponent();
            sid = Int32.Parse(s);
          
        }

        private void data_refresh()
        {
            fname_tbox.Text = null;
            lname_tbox.Text = null;
            email_tbox.Text = null;
            contact_tbox.Text = null;
            ac_tbox.Text = null;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            SqlDataReader dr;
            SqlCommand cmd;
            con.Open();
            String syntax = "select fname,lname,email,sphnum from STUDENT where sid=" + sid;
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            
            try
            {
                fname_tbox.Text = dr[0].ToString();
                lname_tbox.Text = dr[1].ToString();
                email_tbox.Text = dr[2].ToString();
                contact_tbox.Text = dr[3].ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show("Invalid sid");
                this.Hide();
            }
        }
        private void diary_view_Load(object sender, EventArgs e)
        {
            data_refresh();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            data_refresh();
        }
    }
}
