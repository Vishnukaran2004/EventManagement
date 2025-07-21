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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace EventManagement
{
    public partial class Concertbooking : Form
    {
        private string connStr = "Data Source=MSI;Initial Catalog=EventManagement;Integrated Security=True";

        private void LoadConcert()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT title FROM concertdetails";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbtitle.DisplayMember = "title";
                cbtitle.ValueMember = "title"; // both are Title
                cbtitle.DataSource = dt;
                conn.Close();
            }
        }
        public int getprice()
        {
            int price = 0;
            if (rbgen.Checked)
            {
                price = 5000;
            }
            else if (rbvip.Checked)
            {
                price = 10000;
            }
            else if (rbvvip.Checked)
            {
                price = 20000;
            }
            price = price * (int)numseat.Value;
            return price;
        }
        public Concertbooking(string concert)
        {
            InitializeComponent();
            LoadConcert();
            int index = cbtitle.FindStringExact(concert);
            if (index >= 0)
            {
                cbtitle.SelectedIndex = index;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int price = getprice();
            txtprice.Text = price.ToString();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Concerts concerts = new Concerts();
            concerts.Show();
        }

        private void btnbook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string sql = "INSERT INTO concertbooking(email,title,seats,type,price)VALUES(@email,@title,@seats,@type,@price)";
            SqlCommand com = new SqlCommand(sql, con);


            if (string.IsNullOrEmpty(cbtitle.Text) || string.IsNullOrEmpty(txtvenue.Text) || numseat.Value == 0 || (rbgen.Checked == false && rbvip.Checked == false && rbvvip.Checked == false))
            {
                MessageBox.Show("Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Here you can add code to save the registration details to a database or file
                com.Parameters.AddWithValue("@email", Usercred.Email);
                com.Parameters.AddWithValue("@title", this.cbtitle.Text);
                com.Parameters.AddWithValue("@seats", this.numseat.Value);
                com.Parameters.AddWithValue("@type", this.rbgen.Checked ? "General" : this.rbvip.Checked ? "VIP" : "VVIP");
                com.Parameters.AddWithValue("@price", this.txtprice.Text);
                // Execute the command

                int ret = com.ExecuteNonQuery();
                MessageBox.Show("Booking Successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Usercred.title = cbtitle.Text;
                int amount= int.Parse(txtprice.Text);
                this.Hide();
                Payment payment = new Payment(amount);
                payment.Show();
                return;
            }
        }

        private void Concertbooking_Load(object sender, EventArgs e)
        {
            int price = getprice();
            txtprice.Text = price.ToString();
        }

        private void numseat_ValueChanged(object sender, EventArgs e)
        {
            int price = getprice();
            txtprice.Text = price.ToString();
        }

        private void rbgen_CheckedChanged(object sender, EventArgs e)
        {
            int price = getprice();
            txtprice.Text = price.ToString();
        }

        private void rbvvip_CheckedChanged(object sender, EventArgs e)
        {
            int price = getprice();
            txtprice.Text = price.ToString();
        }

        private void cbtitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTitle = cbtitle.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT venue,date FROM concertdetails WHERE title = @title";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", selectedTitle);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    DateTime dbDate = Convert.ToDateTime(reader["date"]);
                    datetymcon.Value = dbDate.Date;
                    txtvenue.Text = reader["venue"].ToString();
                }
                reader.Close();
                conn.Close();
            }
        }
    }
}
