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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventManagement
{
    public partial class Moviebooking : Form
    {
       private string connStr = "Data Source=LAPTOP-4GUBN0C2;Initial Catalog=EventManagement;Integrated Security=True";

        private void LoadMovies()
        {
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
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string sql = "INSERT INTO moviebooking(email,title,date,show,seattype,seats,price)VALUES(@email,@title,@date,@show,@seattype,@seats,@price)";
            SqlCommand com = new SqlCommand(sql, con);


            if (string.IsNullOrEmpty(cbtime.Text) || string.IsNullOrEmpty(cbtitle.Text) || string.IsNullOrEmpty(txtgenere.Text) || numseat.Value == 0 || (rbodc.Checked == false && rbbalcony.Checked == false && rblux.Checked == false))
            {
                MessageBox.Show("Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                    // Here you can add code to save the registration details to a database or file
                    com.Parameters.AddWithValue("@email", Usercred.Email);
                    com.Parameters.AddWithValue("@title", this.cbtitle.Text);
                    com.Parameters.AddWithValue("@date", this.datebk.Value.Date);
                    com.Parameters.AddWithValue("@show", this.cbtime.Text);
                    com.Parameters.AddWithValue("@seattype", this.rbodc.Checked ? "ODC" : this.rbbalcony.Checked ? "Balcony" : "Luxury");
                    com.Parameters.AddWithValue("@seats", this.numseat.Value);
                    com.Parameters.AddWithValue("@price", this.txtprice.Text);
                // Execute the command

                    int ret = com.ExecuteNonQuery();
                MessageBox.Show("Booking Successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Usercred.title = cbtitle.Text;
                int amount = int.Parse(txtprice.Text);
                this.Hide();
                Payment payment = new Payment(amount);
                payment.Show();
                return;
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
