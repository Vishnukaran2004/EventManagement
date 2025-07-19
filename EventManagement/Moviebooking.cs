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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventManagement
{
    public partial class Moviebooking : Form
    {
       
        private void LoadMovies()
        {
            string connStr = "Data Source=LAPTOP-4GUBN0C2;Initial Catalog=EventManagement;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT title FROM moviedetails";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbtitle.DisplayMember = "title";
                cbtitle.ValueMember = "title"; // both are Title
                cbtitle.DataSource = dt;
            }
        }
        public Moviebooking(String title)
        {
            InitializeComponent();
            LoadMovies();
            int index = cbtitle.FindStringExact(title);
            if (index >= 0)
            {
                cbtitle.SelectedIndex = index;
            }
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Moviebooking_Load(object sender, EventArgs e)
        {
           // LoadMovies();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movies movies = new Movies();
            movies.Show();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void cbtitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "Data Source=LAPTOP-4GUBN0C2;Initial Catalog=EventManagement;Integrated Security=True";
            string selectedTitle = cbtitle.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT genre FROM moviedetails WHERE title = @title";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", selectedTitle);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtgenere.Text = reader["genre"].ToString();
                }
                reader.Close();
            }
        }
    }
}
