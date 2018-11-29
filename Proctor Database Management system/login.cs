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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;
        String uname, upass;

        private bool getData(String name,String pass)
        {
            
            con.Open();
            String syntax = "select user_id,password from SYSLOG where user_id = '"+name+"' and password = '"+pass+"'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            
            if (dr.HasRows)
            {
                uname = dr[0].ToString();
                upass = dr[1].ToString();
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String name, pass;
            name = textBox2.Text;
            pass = textBox1.Text;

            if (getData(name,pass))
            {
                label4.Hide();
                dashboard obj = new dashboard(uname);
                this.Hide();
                obj.Show();
            }
            else
            {
                
                label4.Show();
                label4.ForeColor = System.Drawing.Color.DarkRed;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
