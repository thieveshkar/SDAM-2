namespace CB013248_Windows_Forms
{
    partial class Create_Event
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(220, 146, 21);
            label1.Font = new Font("SF Pro Text", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(838, 42);
            label1.Name = "label1";
            label1.Size = new Size(257, 44);
            label1.TabIndex = 0;
            label1.Text = "Create Event";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(660, 193);
            label2.Name = "label2";
            label2.Size = new Size(200, 33);
            label2.TabIndex = 1;
            label2.Text = "Event Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(660, 353);
            label3.Name = "label3";
            label3.Size = new Size(120, 33);
            label3.TabIndex = 2;
            label3.Text = "Venue :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(660, 270);
            label4.Name = "label4";
            label4.Size = new Size(185, 33);
            label4.TabIndex = 3;
            label4.Text = "Event Date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(660, 423);
            label5.Name = "label5";
            label5.Size = new Size(349, 33);
            label5.TabIndex = 4;
            label5.Text = "Maximum Participants :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1090, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1090, 355);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1090, 423);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 27);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1090, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(220, 146, 21);
            button1.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(873, 615);
            button1.Name = "button1";
            button1.Size = new Size(222, 73);
            button1.TabIndex = 14;
            button1.Text = "Create Event";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("SF Pro Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(220, 146, 21);
            linkLabel1.Location = new Point(28, 745);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 27);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Create_Event
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1879, 808);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Create_Event";
            Text = "Create Event";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}