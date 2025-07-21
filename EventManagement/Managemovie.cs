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

namespace EventManagement
{
    
    public partial class Managemovie : Form
    {
        private string str = @"Data Source=MSI;Initial Catalog=EventManagement;Integrated Security=True";
        public Managemovie()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();

            string sql = "INSERT INTO moviedetails(title,genre,year)VALUES(@title,@genre,@year)";
            SqlCommand com = new SqlCommand(sql, con);
            if (txttitle.Text == "" || txtgenre.Text == "" || txtyear.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                com.Parameters.AddWithValue("@title", txttitle.Text);
                com.Parameters.AddWithValue("@genre", txtgenre.Text);
                com.Parameters.AddWithValue("@year", txtyear.Text);
                try
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show("Movie added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttitle.Clear();
                    txtgenre.Clear();
                    txtyear.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Managemovie_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();

            string sql = "SELECT * FROM moviedetails";
            SqlCommand com = new SqlCommand(sql, con);

            //data adapter
            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure it's not the header row
            if (e.RowIndex >= 0)
            {
                // Get the entire row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Get values from specific cells
                txttitle.Text= row.Cells["title"].Value.ToString();         // using column name
                txtgenre.Text= row.Cells[1].Value.ToString();               // or by column index
                txtyear.Text=row.Cells["year"].Value.ToString();  // convert to int

               

            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            string title= txttitle.Text;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this movie?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();
                    string query = "DELETE FROM moviedetails WHERE title = @title";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", title);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Movie deleted successfully!");
                    else
                        MessageBox.Show("No movie found with that Title.");
                }
            }
        }
    }
}
