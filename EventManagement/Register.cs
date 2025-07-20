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

namespace EventManagement
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homeForm = new Home();
            homeForm.Show();
        }

        private void RegLoginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void RegOkbtn_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=LAPTOP-4GUBN0C2;Initial Catalog=EventManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();

            string sql = "INSERT INTO userdetails(email,name,pnumber,password)VALUES(@email,@name,@pnumber,@password)";
            SqlCommand com = new SqlCommand(sql, con);
            
           
            if (txtname.Text == "" || txtmail.Text == "" || txtnum.Text == "" || txtpass.Text == "" || txtconpass.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (txtpass.Text != txtconpass.Text)
                {
                    MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Clear();
                    txtconpass.Clear();
                    return;
                }
                else
                {
                    // Here you can add code to save the registration details to a database or file
                    com.Parameters.AddWithValue("@email", this.txtmail.Text);
                    com.Parameters.AddWithValue("@name", this.txtname.Text);
                    com.Parameters.AddWithValue("@pnumber", this.txtnum.Text);
                    com.Parameters.AddWithValue("@password", this.txtpass.Text);

                    int ret = com.ExecuteNonQuery();
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login loginForm = new Login();
                    loginForm.Show();
                }
            }
            con.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
