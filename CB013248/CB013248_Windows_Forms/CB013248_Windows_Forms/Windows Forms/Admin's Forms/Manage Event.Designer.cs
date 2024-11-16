namespace CB013248_Windows_Forms
{
    partial class Manage_Events
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
            Admin_DatabaseTable = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Admin_DatabaseTable).BeginInit();
            SuspendLayout();
            // 
            // Admin_DatabaseTable
            // 
            Admin_DatabaseTable.AccessibleName = "Admin_DatabaseTable";
            Admin_DatabaseTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Admin_DatabaseTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Admin_DatabaseTable.BackgroundColor = Color.FromArgb(224, 224, 224);
            Admin_DatabaseTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Admin_DatabaseTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Admin_DatabaseTable.Location = new Point(25, 74);
            Admin_DatabaseTable.Margin = new Padding(4, 3, 4, 3);
            Admin_DatabaseTable.Name = "Admin_DatabaseTable";
            Admin_DatabaseTable.RowHeadersWidth = 51;
            Admin_DatabaseTable.Size = new Size(1826, 341);
            Admin_DatabaseTable.TabIndex = 0;
            Admin_DatabaseTable.CellContentClick += Admin_DatabaseTable_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1089, 569);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(220, 146, 21);
            label2.Location = new Point(677, 563);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(231, 33);
            label2.TabIndex = 3;
            label2.Text = "Enter Event ID :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(220, 146, 21);
            button1.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(830, 669);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(133, 65);
            button1.TabIndex = 4;
            button1.Text = "Approve Event";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(220, 146, 21);
            button2.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1027, 669);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(128, 65);
            button2.TabIndex = 7;
            button2.Text = "Disapprove Event";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(220, 146, 21);
            button4.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(873, 429);
            button4.Margin = new Padding(1, 3, 1, 3);
            button4.Name = "button4";
            button4.Size = new Size(200, 57);
            button4.TabIndex = 10;
            button4.Text = "Get Data";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("SF Pro Text", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(220, 146, 21);
            linkLabel1.Location = new Point(29, 759);
            linkLabel1.Margin = new Padding(1, 0, 1, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 27);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(220, 146, 21);
            label1.Font = new Font("SF Pro Text", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(775, 9);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(380, 56);
            label1.TabIndex = 12;
            label1.Text = "Manage Events";
            // 
            // Manage_Events
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1864, 810);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(Admin_DatabaseTable);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.FromArgb(48, 48, 48);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Manage_Events";
            Text = "Manage Event";
            Load += Manage_Events_Load;
            ((System.ComponentModel.ISupportInitialize)Admin_DatabaseTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Admin_DatabaseTable;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button4;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}