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
    public partial class Partcicpant_Form : Form
    {
        public Partcicpant_Form()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register_Events openregisterevent = new Register_Events();
            openregisterevent.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisteredEventList_AndUnregisterEvent screen = new RegisteredEventList_AndUnregisterEvent();
            screen.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.logout(this);
        }
    }
}
