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
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moviebooking movieBookingForm = new Moviebooking("MUSHROOM");
            movieBookingForm.Show();
        }

        private void btncam_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moviebooking movieBookingForm = new Moviebooking("CAMATHAAR");
            movieBookingForm.Show();
        }

        private void btnshi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moviebooking movieBookingForm = new Moviebooking("SHI - YAM");
            movieBookingForm.Show();
        }

        private void btnmush_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moviebooking movieBookingForm = new Moviebooking("MUSHROOM");
            movieBookingForm.Show();
        }

        private void btnjan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moviebooking movieBookingForm = new Moviebooking("JANA NAYAKAYA");
            movieBookingForm.Show();
        }

        private void btnape_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moviebooking movieBookingForm = new Moviebooking("APE LANKA 2");
            movieBookingForm.Show();
        }

        private void btnkash_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moviebooking movieBookingForm = new Moviebooking("KASHMIRAA");
            movieBookingForm.Show();
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moviebooking movieBookingForm = new Moviebooking("LOCAL FROCK");
            movieBookingForm.Show();
        }

        private void btnmoon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moviebooking movieBookingForm = new Moviebooking("THE MOON");
            movieBookingForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
