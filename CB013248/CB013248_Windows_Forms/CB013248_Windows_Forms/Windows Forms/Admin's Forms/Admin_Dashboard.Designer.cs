namespace CB013248_Windows_Forms
{
    partial class Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            label1 = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(220, 146, 21);
            label1.Font = new Font("SF Pro Text", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(795, 62);
            label1.Name = "label1";
            label1.Size = new Size(444, 56);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            label1.Click += label1_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.Image = (Image)resources.GetObject("linkLabel2.Image");
            linkLabel2.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(68, 360);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(308, 65);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Manage Events";
            linkLabel2.TextAlign = ContentAlignment.MiddleRight;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.BackColor = Color.Transparent;
            linkLabel3.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel3.Image = (Image)resources.GetObject("linkLabel3.Image");
            linkLabel3.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(930, 350);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(377, 97);
            linkLabel3.TabIndex = 4;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Manage Participants";
            linkLabel3.TextAlign = ContentAlignment.MiddleRight;
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.BackColor = Color.Transparent;
            linkLabel4.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel4.Image = (Image)resources.GetObject("linkLabel4.Image");
            linkLabel4.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel4.LinkColor = Color.White;
            linkLabel4.Location = new Point(1404, 360);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(349, 84);
            linkLabel4.TabIndex = 5;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "View Booked Events";
            linkLabel4.TextAlign = ContentAlignment.MiddleRight;
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel5
            // 
            linkLabel5.BackColor = Color.Transparent;
            linkLabel5.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel5.Image = (Image)resources.GetObject("linkLabel5.Image");
            linkLabel5.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel5.LinkColor = Color.White;
            linkLabel5.Location = new Point(509, 374);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(362, 51);
            linkLabel5.TabIndex = 6;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Manage Organzers";
            linkLabel5.TextAlign = ContentAlignment.MiddleRight;
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(220, 146, 21);
            button1.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(911, 701);
            button1.Name = "button1";
            button1.Size = new Size(177, 66);
            button1.TabIndex = 7;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1872, 837);
            Controls.Add(button1);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Admin_Dashboard";
            Text = "Admin Dashboard";
            Load += Admin_Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private Button button1;
    }
}