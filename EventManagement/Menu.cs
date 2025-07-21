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
    public partial class Menu : Form
    {
        string str = @"Data Source=MSI;Initial Catalog=EventManagement;Integrated Security=True";

        public Menu()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string sql = "SELECT * FROM userdetails WHERE email=@email";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@email", Usercred.Email);
            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            this.labelname.Text = "Welcome " + ds.Tables[0].Rows[0][1].ToString();
            con.Close();
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

        private void btncon1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Concertbooking concertBookingForm = new Concertbooking("VIBE ANTONY");
            concertBookingForm.Show();
        }

        private void btncon2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Concertbooking concertBookingForm = new Concertbooking("MENIKE");
            concertBookingForm.Show();
        }

        private void btncon3_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Concertbooking concertBookingForm = new Concertbooking("SL vs BAN");
            concertBookingForm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
