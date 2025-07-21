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
    public partial class Payment : Form
    {
        int amount;

        public Payment()
        {
            InitializeComponent();
        }
        public Payment(int price)
        {
            InitializeComponent();
            this.amount = price;
            
            finamount();
            
        }

        public void finamount()
        {
            if (cmbadd.Text == "SNACKS")
            {
                amount = amount + 250;
            }
            else if (cmbadd.Text == "SOFT DRINKS")
            {
                amount = amount + 150;
            }
            else if (cmbadd.Text == "SHORT - EATS")
            {
                amount = amount + 200;
            }
            else if (cmbadd.Text == "POPCORNS")
            {
                amount = amount + 300;
            }
            txtamount.Text = amount.ToString();
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtmail.Text = Usercred.Email;
            txtevent.Text = Usercred.title;
            finamount();

        }

        private void cmbadd_SelectedIndexChanged(object sender, EventArgs e)
        {
            finamount();
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            if (txtmail.Text == "" || txtevent.Text == "" || txtamount.Text == ""||cmbadd.Text==""||(rbcard.Checked==false&&rbcash.Checked==false))
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Payment successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
        }
    }
}
