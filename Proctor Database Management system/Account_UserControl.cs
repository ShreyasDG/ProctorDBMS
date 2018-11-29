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
    public partial class Account_UserControl : UserControl
    {
        public Account_UserControl()
        {
            InitializeComponent();
        }
        String fid;
        public Account_UserControl(String id)
        {
            InitializeComponent();
            fid = id;
        }
        private static Account_UserControl _instance;
        public static Account_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Account_UserControl();
                }
                return _instance;
            }
        }
       
        private void Account_UserControl_Load(object sender, EventArgs e)
        {
            fill_textBoxes();
        }
        private void fill_textBoxes()
        {
            
            fname_tbox.Text = null;
            lname_tbox.Text = null;
            email_tbox.Text = null;
            contact_tbox.Text = null;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            SqlDataReader dr;
            SqlCommand cmd;
            con.Open();
            String syntax = "select fname,lname,fmail,fphnum from FACULTY where fid=" + Int32.Parse(dashboard.fid);
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            
            fname_tbox.Text = dr[0].ToString();
            lname_tbox.Text = dr[1].ToString();
            email_tbox.Text = dr[2].ToString();
            contact_tbox.Text = dr[3].ToString();
            syntax = "commit";
            cmd = new SqlCommand(syntax, con);
            
            con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void update_btn_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            SqlDataReader dr;
            SqlCommand cmd;
            con.Open();
            cmd = new SqlCommand("update_faculty_details", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fid",Int32.Parse(dashboard.fid));
            cmd.Parameters.AddWithValue("@fname",fname_tbox.Text);
            cmd.Parameters.AddWithValue("@lname", lname_tbox.Text);
            cmd.Parameters.AddWithValue("@fmail", email_tbox.Text);
            cmd.Parameters.AddWithValue("@fphnum", contact_tbox.Text);

            

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL EXCEPTION :" + ex);
            }
            String syntax = "commit";
            cmd = new SqlCommand(syntax, con);
           // MessageBox.Show("Committed values");
            con.Close();
            //MessageBox.Show("Entering");
            fill_textBoxes();
            MessageBox.Show("Update successful");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
