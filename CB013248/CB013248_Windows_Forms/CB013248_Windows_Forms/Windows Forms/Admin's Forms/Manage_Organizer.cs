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
    public partial class Manage_Organizer : Form
    {
        public Manage_Organizer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin callmethodd = new Admin();
            callmethodd.Showorganizer(dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string organizerusername = textBox1.Text;
            string loggedinuser = User.Loggedinuser;

            Admin admin = new Admin();
            admin.Removeorganizer(loggedinuser, organizerusername);

            Admin callmethodd3 = new Admin();
            callmethodd3.Showorganizer(dataGridView1);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Manage_Organizer_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Dashboard screenn = new Admin_Dashboard();
            screenn.Show();
            this.Close();
        }
    }
}
