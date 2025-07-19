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

        
        public frmProfile()
        {
            InitializeComponent();
            string str = @"Data Source=LAPTOP-4GUBN0C2;Initial Catalog=EventManagement;Integrated Security=True";
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
                txtpass.Text= reader["password"].ToString();
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
    }
}
