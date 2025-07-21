using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagement
{
    public partial class Login : Form
    {
        string str = @"Data Source=MSI;Initial Catalog=EventManagement;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegister register = new frmRegister();
            register.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();

            string sql = "SELECT * FROM userdetails WHERE email=@Email AND password=@Password";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@Email", txtemal.Text);
            com.Parameters.AddWithValue("@Password", txtpw.Text);

            SqlDataReader reader = com.ExecuteReader();

            if (txtemal.Text == "" || txtpw.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    string name = reader["name"].ToString();
                    MessageBox.Show("Login successful! " , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Usercred.Email = reader["email"].ToString(); // Store email for later use
                    Menu menu = new Menu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemal.Clear();
                    txtpw.Clear();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
