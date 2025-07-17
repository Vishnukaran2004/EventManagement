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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void movieBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Moviebooking movieBooking = new Moviebooking();
            movieBooking.ShowDialog();
        }

        private void concertBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Concertbooking concertBooking = new Concertbooking();
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

        private void paymentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentDetail paymentDetails = new PaymentDetail();
            paymentDetails.Show();
        }
    }
}
