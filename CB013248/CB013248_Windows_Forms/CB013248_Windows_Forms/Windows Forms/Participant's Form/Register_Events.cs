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
    public partial class Register_Events : Form
    {
        public Register_Events()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1847, 295);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(220, 146, 21);
            label1.Font = new Font("SF Pro Text", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(754, 41);
            label1.Name = "label1";
            label1.Size = new Size(540, 48);
            label1.TabIndex = 1;
            label1.Text = "Event Registration Screen";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(220, 146, 21);
            button1.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(926, 435);
            button1.Name = "button1";
            button1.Size = new Size(210, 64);
            button1.TabIndex = 2;
            button1.Text = "Show available events";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(220, 146, 21);
            label2.Location = new Point(533, 583);
            label2.Name = "label2";
            label2.Size = new Size(447, 33);
            label2.TabIndex = 3;
            label2.Text = "Enter the Event ID to Register :";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1206, 584);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 38);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(220, 146, 21);
            button2.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(926, 699);
            button2.Name = "button2";
            button2.Size = new Size(215, 66);
            button2.TabIndex = 5;
            button2.Text = "Click here to register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("SF Pro Text", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(220, 146, 21);
            linkLabel1.Location = new Point(37, 773);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 27);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Register_Events
            // 
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1871, 819);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI Variable Text", 13.8F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Register_Events";
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private LinkLabel linkLabel1;
        private Label label1;

        private void button1_Click(object sender, EventArgs e)
        {
            Eventclass.displyaapprovedevents(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int eventID = Convert.ToInt32(textBox1.Text);

            string result = Participant.RegisterEvent(eventID);
            Eventclass.displyaapprovedevents(dataGridView1);
            MessageBox.Show(result);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Partcicpant_Form form = new Partcicpant_Form();
            form.Show();

        }
    }
}
