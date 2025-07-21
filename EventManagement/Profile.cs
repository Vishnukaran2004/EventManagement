using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventManagement
{
    public partial class frmProfile : Form
    {
        string str = @"Data Source=MSI;Initial Catalog=EventManagement;Integrated Security=True";

        public frmProfile()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string sql = "SELECT * FROM userdetails WHERE email=@email";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@email",Usercred.Email);
            SqlDataReader reader = com.ExecuteReader();

            if (reader.Read())
            {
                txtemail.Text = reader["email"].ToString();
                txtname.Text= reader["name"].ToString();
                txtpnum.Text= reader["pnumber"].ToString();
            }
            reader.Close();
            con.Close();

        }


        private void ProfBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string name=txtname.Text;
            string email = txtemail.Text;
            int tpno = int.Parse(txtpnum.Text);
            string pass = txtpass.Text;
            string conpass = txtconpass.Text;

            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "UPDATE userdetails SET name= @name , pnumber=@pnumber ,password=@password WHERE email = @email";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@pnumber", tpno);
                if (pass == conpass)
                {
                    cmd.Parameters.AddWithValue("@password", pass);
                }
                else
                {
                    MessageBox.Show("Password doesn't match","Error");
                }
                int rows = cmd.ExecuteNonQuery(); // returns number of rows affected

                if (rows > 0)
                    MessageBox.Show("Profile updated successfully!");
                else
                    MessageBox.Show("No user found with that ID.");
            }
        }
    }
}
