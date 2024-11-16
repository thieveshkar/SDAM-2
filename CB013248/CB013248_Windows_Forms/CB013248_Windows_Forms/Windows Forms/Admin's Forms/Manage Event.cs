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
using MySql.Data.MySqlClient;

namespace CB013248_Windows_Forms
{
    public partial class Manage_Events : Form
    {
        public Manage_Events()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Admin_DatabaseTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eventclass.displaycontentindatabase(Admin_DatabaseTable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ApproveEventID = Convert.ToInt32(textBox1.Text);

            Admin.Approve_event(ApproveEventID);
            Eventclass.displaycontentindatabase(Admin_DatabaseTable);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int DisapproveEventID = Convert.ToInt32(textBox1.Text);

            Admin.Disapprove_event(DisapproveEventID);
            Eventclass.displaycontentindatabase(Admin_DatabaseTable);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Admin_Dashboard screen = new Admin_Dashboard();
            screen.Show();


        }

        private void Manage_Events_Load(object sender, EventArgs e)
        {

        }
    }
}
