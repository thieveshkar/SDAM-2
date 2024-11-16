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
    public partial class Manage_Participants : Form
    {
        public Manage_Participants()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            string username = textBox1.Text;
            string loggedinuser = User.Loggedinuser;

            Admin callmethod = new Admin();
            callmethod.Removeparticipants(loggedinuser, username);

            Admin callmethod1 = new Admin();
            callmethod1.ShowParticipants(dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin callmethod = new Admin();
            callmethod.ShowParticipants(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Manage_Participants_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                this.Close();
                Admin_Dashboard screen = new Admin_Dashboard();
                screen.Show();
            
        }
    }
}
