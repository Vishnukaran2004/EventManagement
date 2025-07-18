using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Moviebooking(String title)
        {
            InitializeComponent();
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
    }
}
