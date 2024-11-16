namespace CB013248_Windows_Forms
{
    partial class Organizer_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organizer_Screen));
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(220, 146, 21);
            label1.Font = new Font("SF Pro Text", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(700, 83);
            label1.Name = "label1";
            label1.Size = new Size(519, 75);
            label1.TabIndex = 0;
            label1.Text = "Organizer Screen";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Image = (Image)resources.GetObject("linkLabel1.Image");
            linkLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(139, 388);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(315, 59);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Event";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.Image = (Image)resources.GetObject("linkLabel2.Image");
            linkLabel2.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(515, 391);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(324, 55);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Remove Event";
            linkLabel2.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel3.Image = (Image)resources.GetObject("linkLabel3.Image");
            linkLabel3.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(901, 390);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(420, 59);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Manage Participants";
            linkLabel3.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel4.Image = (Image)resources.GetObject("linkLabel4.Image");
            linkLabel4.ImageAlign = ContentAlignment.BottomLeft;
            linkLabel4.LinkColor = Color.White;
            linkLabel4.Location = new Point(1369, 400);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(385, 49);
            linkLabel4.TabIndex = 4;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "View Booked Events";
            linkLabel4.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(220, 146, 21);
            button1.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(872, 622);
            button1.Name = "button1";
            button1.Size = new Size(160, 66);
            button1.TabIndex = 5;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Organizer_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1860, 828);
            Controls.Add(button1);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Organizer_Screen";
            Text = "Organizer_Screen";
            Load += Organizer_Screen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private Button button1;
    }
}