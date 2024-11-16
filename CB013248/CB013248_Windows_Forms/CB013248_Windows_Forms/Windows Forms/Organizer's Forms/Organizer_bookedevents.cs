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
    public partial class Organizer_bookedevents : Form
    {
        public Organizer_bookedevents()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loggeddusername = User.Loggedinuser;
            Organizer sc = new Organizer();
            sc.ViewBooking(loggeddusername, dataGridView1);
        }
    }
}
