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
    public partial class PGroup_UserControl : UserControl
    {
        public PGroup_UserControl()
        {
            InitializeComponent();
        }
        private static PGroup_UserControl _instance;
        public static PGroup_UserControl Instance
        {
            get {

                if(_instance == null)
                {
                    _instance = new PGroup_UserControl();
                }
                return _instance;
            }
        }
        private void PGroup_UserControl_Load(object sender, EventArgs e)
        {
            refresh_data_grid_view();
        }

        private void refresh_data_grid_view()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            SqlDataReader dr;
            SqlCommand cmd;

            con.Open();
            cmd = new SqlCommand("view_members", con);
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
            member_dataGrid.DataSource = ds.Tables[0];
            this.member_dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.member_dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.member_dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void member_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
