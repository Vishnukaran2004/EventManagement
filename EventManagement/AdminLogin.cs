using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagement
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home= new Home();
            home.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtadmin.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (txtadmin.Text != "admin" || txtpass.Text != "admin123")
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                }
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
