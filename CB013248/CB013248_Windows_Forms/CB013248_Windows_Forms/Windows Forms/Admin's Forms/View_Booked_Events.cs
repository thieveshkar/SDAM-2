using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CB013248_Windows_Forms.Classes;

namespace CB013248_Windows_Forms
{
    public partial class View_Booked_Events : Form
    {
        public View_Booked_Events()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loggeddusername = User.Loggedinuser;
            Admin admin = new Admin();
            admin.ViewBooking(loggeddusername, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Close();
            Admin_Dashboard screen = new Admin_Dashboard();
            screen.Show();
            
        }

        private void View_Booked_Events_Load(object sender, EventArgs e)
        {

        }
    }
}
