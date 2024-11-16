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
    public partial class Remove_An_Event : Form
    {
        public Remove_An_Event()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eventclass.displaycontentindatabase(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int RemoveeventID = Convert.ToInt32(textBox1.Text);





            Organizer.removeanevent(RemoveeventID);
            Eventclass.displaycontentindatabase(dataGridView1);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Organizer_Screen screen = new Organizer_Screen();
            screen.Show();
        }
    }
}
