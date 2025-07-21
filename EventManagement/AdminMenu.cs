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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }
        public void countuser()
        {
            int totalRows = 0;
            string connStr = "Data Source=MSI;Initial Catalog=EventManagement;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM userdetails"; // or your table name
                SqlCommand cmd = new SqlCommand(query, conn);

                totalRows = (int)cmd.ExecuteScalar(); // Get the single count value
                txtuser.Text = totalRows.ToString();
            }
        }

        public void countmovie()
        {
            int totalRows = 0;
            string connStr = "Data Source=MSI;Initial Catalog=EventManagement;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM moviedetails"; // or your table name
                SqlCommand cmd = new SqlCommand(query, conn);

                totalRows = (int)cmd.ExecuteScalar(); // Get the single count value
                txtmovie.Text = totalRows.ToString();
            }
        }
        public void countconcert()
        {
            int totalRows = 0;
            string connStr = "Data Source=MSI;Initial Catalog=EventManagement;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM concertdetails"; // or your table name
                SqlCommand cmd = new SqlCommand(query, conn);

                totalRows = (int)cmd.ExecuteScalar(); // Get the single count value
                txtconcert.Text = totalRows.ToString();
            }
        }
        public void countmbooking()
        {
            int totalRows = 0;
            string connStr = "Data Source=MSI;Initial Catalog=EventManagement;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM moviebooking"; // or your table name
                SqlCommand cmd = new SqlCommand(query, conn);

                totalRows = (int)cmd.ExecuteScalar(); // Get the single count value
                txtmbooking.Text = totalRows.ToString();
            }
        }

        public void countcbooking()
        {
            int totalRows = 0;
            string connStr = "Data Source=MSI;Initial Catalog=EventManagement;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM concertbooking"; // or your table name
                SqlCommand cmd = new SqlCommand(query, conn);

                totalRows = (int)cmd.ExecuteScalar(); // Get the single count value
                txtcbooking.Text = totalRows.ToString();
            }
        }

        private void movieBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewMovie movieBooking = new frmViewMovie();
            movieBooking.ShowDialog();
        }

        private void concertBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewConcert concertBooking = new frmViewConcert();
            concertBooking.ShowDialog();
        }

        private void movieManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Managemovie movieManage = new Managemovie();
            movieManage.ShowDialog();
        }

        private void concertManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageConcert concertManage = new ManageConcert();
            concertManage.Show();
        }

        

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            countuser();
            countmovie();
            countconcert(); 
            countmbooking();
            countcbooking();

            
        }
    }
}
