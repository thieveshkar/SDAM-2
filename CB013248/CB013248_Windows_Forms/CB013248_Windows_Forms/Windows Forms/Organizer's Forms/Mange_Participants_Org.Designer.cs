namespace CB013248_Windows_Forms
{
    partial class Mange_Participants_Org
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1837, 403);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(220, 146, 21);
            label1.Font = new Font("SF Pro Text", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(672, 9);
            label1.Name = "label1";
            label1.Size = new Size(648, 56);
            label1.TabIndex = 2;
            label1.Text = "Manage Paticipant Screen ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(220, 146, 21);
            label2.Location = new Point(134, 602);
            label2.Name = "label2";
            label2.Size = new Size(949, 33);
            label2.TabIndex = 5;
            label2.Text = "Enter the Username of the Participant whom you wish to Remove : ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("SF Pro Text", 13.2000008F, FontStyle.Bold);
            linkLabel1.LinkColor = Color.FromArgb(220, 146, 21);
            linkLabel1.Location = new Point(12, 764);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 27);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(220, 146, 21);
            button1.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            button1.Location = new Point(878, 500);
            button1.Name = "button1";
            button1.Size = new Size(205, 61);
            button1.TabIndex = 7;
            button1.Text = "Show Participants";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(220, 146, 21);
            button2.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            button2.Location = new Point(861, 693);
            button2.Name = "button2";
            button2.Size = new Size(240, 35);
            button2.TabIndex = 8;
            button2.Text = "Remove Participant";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1232, 608);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Mange_Participants_Org
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1872, 809);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Mange_Participants_Org";
            Text = "Mange_Participants_Org";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
    }
}