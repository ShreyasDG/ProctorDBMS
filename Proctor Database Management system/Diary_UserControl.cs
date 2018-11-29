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
    public partial class Diary_UserControl : UserControl
    {
        public Diary_UserControl()
        {
            InitializeComponent();
        }
        private static Diary_UserControl _instance;
        public static Diary_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Diary_UserControl();
                }
                return _instance;
            }
        }
        private void Diary_UserControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String val = sid_textBox.Text;
            int sid;
            try
            {
                sid = Int32.Parse(val);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Invalid sid");
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            SqlDataReader dr;
            SqlCommand cmd;
            con.Open();
            String syntax = "select fname,lname,email,sphnum from STUDENT where sid=" + sid;
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            try {
                string s = dr[0].ToString();
            }
             catch(Exception exce)
            {
                MessageBox.Show("Invalid sid");
                return;
            }
            //this.Hide();
            diary_view obj = new diary_view(val);
            obj.Show();
        }

        private void sid_label_Click(object sender, EventArgs e)
        {

        }
    }
}
