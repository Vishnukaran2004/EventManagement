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
    public partial class ManageConcert : Form
    {
        public ManageConcert()
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
            string str = @"Data Source=LAPTOP-4GUBN0C2;Initial Catalog=EventManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();

            string sql = "INSERT INTO concertdetails(title,date,venue)VALUES(@title,@date,@venue)";
            SqlCommand com = new SqlCommand(sql, con);
            if (txttitle.Text == "" ||  txtvenue.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                
                    com.Parameters.AddWithValue("@title", txttitle.Text);
                    com.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                    com.Parameters.AddWithValue("@venue", txtvenue.Text);
                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Movie added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txttitle.Clear();
                        txtvenue.Clear();
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

        private void ManageConcert_Load(object sender, EventArgs e)
        {
            string str = @"Data Source=LAPTOP-4GUBN0C2;Initial Catalog=EventManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();

            string sql = "SELECT * FROM concertdetails";
            SqlCommand com = new SqlCommand(sql, con);

            //data adapter
            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }
    }
}
