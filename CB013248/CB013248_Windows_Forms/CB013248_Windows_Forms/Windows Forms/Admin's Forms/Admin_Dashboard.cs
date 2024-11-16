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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();

        }
        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin openmanageeventscreen = new Admin();
            openmanageeventscreen.open_manage_event();
            this.Hide();

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Manage_Organizer screenen=new Manage_Organizer();
            screenen.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            View_Booked_Events viewevents = new View_Booked_Events();
            viewevents.Show();
            this.Hide();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Manage_Participants screen = new Manage_Participants();  
            screen.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.logout(this);
        }
    }

}
