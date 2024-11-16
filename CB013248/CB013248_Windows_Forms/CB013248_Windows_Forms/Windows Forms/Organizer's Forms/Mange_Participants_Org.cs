using CB013248_Windows_Forms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CB013248_Windows_Forms
{
    public partial class Mange_Participants_Org : Form
    {
        public Mange_Participants_Org()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Organizer callmethod = new Organizer();
            callmethod.ShowParticipants(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string loggedinuser = User.Loggedinuser;

            Organizer callmethod = new Organizer();
            callmethod.Removeparticipants(loggedinuser, username);

            Organizer callmethod1 = new Organizer();
            callmethod1.ShowParticipants(dataGridView1);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Organizer_Screen screen = new Organizer_Screen();
            screen.Show();
        }
    }
}
