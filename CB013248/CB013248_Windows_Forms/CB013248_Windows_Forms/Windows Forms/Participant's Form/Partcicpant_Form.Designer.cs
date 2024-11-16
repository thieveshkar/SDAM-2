namespace CB013248_Windows_Forms
{
    partial class Partcicpant_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Partcicpant_Form));
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Image = (Image)resources.GetObject("linkLabel1.Image");
            linkLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(103, 348);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(872, 49);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "View Already Registered Events and Unregister ";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.Image = (Image)resources.GetObject("linkLabel2.Image");
            linkLabel2.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(1076, 346);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(736, 53);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "View Events that are available for register";
            linkLabel2.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(220, 146, 21);
            label1.Font = new Font("SF Pro Text", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(752, 82);
            label1.Name = "label1";
            label1.Size = new Size(459, 56);
            label1.TabIndex = 3;
            label1.Text = "Participant Screen";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(220, 146, 21);
            button1.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(925, 588);
            button1.Name = "button1";
            button1.Size = new Size(159, 69);
            button1.TabIndex = 4;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Partcicpant_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1883, 807);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            ForeColor = Color.FromArgb(220, 146, 21);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Partcicpant_Form";
            Text = "Participant Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label1;
        private Button button1;
    }
}