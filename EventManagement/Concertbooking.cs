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
    public partial class Concertbooking : Form
    {
        public Concertbooking(string concert)
        {
            InitializeComponent();
            int index = cbcon.FindStringExact(concert);
            if (index >= 0)
            {
                cbcon.SelectedIndex = index;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}
