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
    public partial class View_announcements : UserControl
    {
        public View_announcements()
        {
            InitializeComponent();
        }
        private static View_announcements _instance2;
        public static View_announcements Instance2
        {
            get
            {
                if (_instance2 == null)
                {
                    _instance2 = new View_announcements();
                }
                return _instance2;
            }
        }
        private void refresh_dataGrid_view()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            SqlDataReader dr;
            SqlCommand cmd;

            con.Open();
            cmd = new SqlCommand("View_announcements", con);
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
            Announcements.DataSource = ds.Tables[0];
            this.Announcements.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Announcements.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Announcements.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Announcements.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void Announcements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            refresh_dataGrid_view();
        }

        private void View_announcements_Load(object sender, EventArgs e)
        {
            refresh_dataGrid_view();
        }
    }
}
