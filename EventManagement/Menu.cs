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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movies movies = new Movies();
            movies.Show();
        }

        private void concertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Concerts concerts = new Concerts(); 
            concerts.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Payment payment = new Payment();
            payment.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProfile profile = new frmProfile();
            profile.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProfile profile = new frmProfile();  
            profile.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncam_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moviebooking movieBookingForm = new Moviebooking("CAMATHAAR");
            movieBookingForm.Show();
        }

        private void btncyum_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moviebooking movieBookingForm = new Moviebooking("SHI - YAM");
            movieBookingForm.Show();
        }

        private void btnmushroom_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moviebooking movieBookingForm = new Moviebooking("MUSHROOM");
            movieBookingForm.Show();
        }
    }
}
