using CB013248_Windows_Forms.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CB013248_Windows_Forms
{
    public partial class Create_Event : Form
    {
        public Create_Event()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string Eventname = textBox1.Text;
                DateTime Eventdate = dateTimePicker1.Value;
                string Venue = textBox3.Text;
                int Maxparticipants = Convert.ToInt32(textBox5.Text);
                int Registeredcount = 0;
                string organizerusername = User.Loggedinuser;
                string EVENTSTATUS = "Pending";



                Eventclass NEW = new Eventclass(Eventname, Eventdate, Venue, Maxparticipants, Registeredcount, organizerusername, EVENTSTATUS);

                Organizer.CreateEvent(NEW);
                MessageBox.Show("Event Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ran into an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Organizer_Screen screen = new Organizer_Screen();   
            screen.Show();
        }
    }
}

