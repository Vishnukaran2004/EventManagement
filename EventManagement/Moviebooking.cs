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
        public int getprice()
        {
            int price = 0;
            if (rbodc.Checked)
            {
                price = 500;
            }
            else if (rbbalcony.Checked)
            {
                price = 1000;
            }
            else if (rblux.Checked)
            {
                price = 2000;
            }
            price = price * (int)numseat.Value;
            return price;
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
            int price = getprice(); 
            txtprice.Text=price.ToString();
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

        private void btnbook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbtime.Text) || string.IsNullOrEmpty(cbtitle.Text) ||string.IsNullOrEmpty(txtgenere.Text)||numseat.Value==0||( rbodc.Checked == false && rbbalcony.Checked == false && rblux.Checked == false))
            {
                MessageBox.Show("Please fill all the fields.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {

            }
        }

        private void numseat_ValueChanged(object sender, EventArgs e)
        {
            int price = getprice();
            txtprice.Text = price.ToString();
        }

        private void rbodc_CheckedChanged(object sender, EventArgs e)
        {
            int price = getprice();
            txtprice.Text = price.ToString();
        }

        private void rbbalcony_CheckedChanged(object sender, EventArgs e)
        {
            int price = getprice();
            txtprice.Text = price.ToString();
        }

        private void rblux_CheckedChanged(object sender, EventArgs e)
        {
            int price = getprice();
            txtprice.Text = price.ToString();
        }
    }
}
