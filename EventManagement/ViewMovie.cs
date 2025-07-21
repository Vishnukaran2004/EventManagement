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
    public partial class frmViewMovie : Form
    {
        public frmViewMovie()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();  
            adminMenu.Show();
        }

        private void frmViewMovie_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
        }
    }
}
