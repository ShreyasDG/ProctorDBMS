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
    public partial class Results_UserControl : UserControl
    {
        public Results_UserControl()
        {
            InitializeComponent();
        }
        private static Results_UserControl _instance;
        public static Results_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Results_UserControl();
                }
                return _instance;
            }
        }
        private void refresh_data_grid_view()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            SqlDataReader dr;
            SqlCommand cmd;

            con.Open();
            cmd = new SqlCommand("view_results", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fid", Int32.Parse(dashboard.fid));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("SQL ERROR");
            }
            con.Close();
            result_dataGrid.DataSource = ds.Tables[0];
        }
        private void Results_UserControl_Load(object sender, EventArgs e)
        {
            refresh_data_grid_view();
        }

        private void cgpa_check_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            SqlDataReader dr;
            SqlCommand cmd;

            try {
                float res = float.Parse(cgpa.Text);
                if (res < 0 || res>10)
                    throw new Exception();
            }
            catch(Exception exce)
            {
                MessageBox.Show("Invalid cgpa");
                return;
            }
            con.Open();
            cmd = new SqlCommand("cgpa_check", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fid", Int32.Parse(dashboard.fid));
            cmd.Parameters.AddWithValue("@cgpa", float.Parse(cgpa.Text));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL ERROR");
            }
            con.Close();
            result_dataGrid.DataSource = ds.Tables[0];
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refresh_data_grid_view();
            cgpa.Text = null;
        }

        private void fail_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            SqlDataReader dr;
            SqlCommand cmd;

            con.Open();
            cmd = new SqlCommand("fail_check", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fid", Int32.Parse(dashboard.fid));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show("SQL ERROR");
            }
            con.Close();
            result_dataGrid.DataSource = ds.Tables[0];
        }
    }
}
