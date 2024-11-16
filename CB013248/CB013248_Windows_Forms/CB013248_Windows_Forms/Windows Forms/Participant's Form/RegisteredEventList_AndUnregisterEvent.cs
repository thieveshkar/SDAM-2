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
    public partial class RegisteredEventList_AndUnregisterEvent : Form
    {
        public RegisteredEventList_AndUnregisterEvent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loggeddusername = User.Loggedinuser;

            Participant callmethod = new Participant();

            callmethod.ViewRegisteredEvents(loggeddusername, dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Eventname = textBox1.Text;
            string updatedEventname = Eventname.Trim();

            Participant.UnregisterEvents(updatedEventname);



            string loggeddusername = User.Loggedinuser;

            Participant callmethod = new Participant();

            callmethod.ViewRegisteredEvents(loggeddusername, dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Partcicpant_Form screen = new Partcicpant_Form();   
            screen.Show();
        }
    }
}
