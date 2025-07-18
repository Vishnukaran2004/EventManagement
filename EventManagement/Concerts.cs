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
    public partial class Concerts : Form
    {
        public Concerts()
        {
            InitializeComponent();
        }

        private void btnva_Click(object sender, EventArgs e)
        {
            this.Hide();
            Concertbooking concertBookingForm = new Concertbooking("VIBE ANTONY");
            concertBookingForm.Show();
        }

        private void btnmenike_Click(object sender, EventArgs e)
        {
            this.Hide();
            Concertbooking concertBookingForm = new Concertbooking("MENIKE");
            concertBookingForm.Show();
        }

        private void btnrod_Click(object sender, EventArgs e)
        {
            this.Hide();
            Concertbooking concertBookingForm = new Concertbooking("RETURN OF DRAGON");
            concertBookingForm.Show();
        }

        private void btnslb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Concertbooking concertBookingForm = new Concertbooking("SL vs BAN");
            concertBookingForm.Show();
        }

        private void btnrugby_Click(object sender, EventArgs e)
        {
            this.Hide();    
            Concertbooking concertBookingForm = new Concertbooking("RUGBY");
            concertBookingForm.Show();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
