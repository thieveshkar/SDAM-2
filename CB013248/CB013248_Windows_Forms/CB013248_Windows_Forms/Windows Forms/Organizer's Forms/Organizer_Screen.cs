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
    public partial class Organizer_Screen : Form
    {
        public Organizer_Screen()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Mange_Participants_Org manage_Participants = new Mange_Participants_Org();
            manage_Participants.Show();
            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Create_Event newevent = new Create_Event();
            newevent.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Remove_An_Event removemoveeventscreen = new Remove_An_Event();
            removemoveeventscreen.Show();
            this.Close();
        }

        private void Organizer_Screen_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            View_Booked_Events sc = new View_Booked_Events();
            sc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.logout(this);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Manage_Participants manage_Participants = new Manage_Participants();
            manage_Participants.Show();
            this.Close();
        }

        
    }
}
