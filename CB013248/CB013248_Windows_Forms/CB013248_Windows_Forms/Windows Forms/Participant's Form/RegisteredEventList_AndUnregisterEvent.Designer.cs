namespace CB013248_Windows_Forms
{
    partial class RegisteredEventList_AndUnregisterEvent
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
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1809, 439);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(220, 146, 21);
            label1.Font = new Font("SF Pro Text", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(552, 34);
            label1.Name = "label1";
            label1.Size = new Size(895, 48);
            label1.TabIndex = 1;
            label1.Text = "Registered Event list and Unregister Screen";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(220, 146, 21);
            button1.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(850, 559);
            button1.Name = "button1";
            button1.Size = new Size(279, 54);
            button1.TabIndex = 2;
            button1.Text = "Get registered events";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Pro Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(220, 146, 21);
            label2.Location = new Point(140, 657);
            label2.Name = "label2";
            label2.Size = new Size(728, 33);
            label2.TabIndex = 3;
            label2.Text = "Enter the Event name to Unregister from an Event :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1261, 663);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(220, 146, 21);
            button2.Font = new Font("SF Pro Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(890, 733);
            button2.Name = "button2";
            button2.Size = new Size(213, 54);
            button2.TabIndex = 5;
            button2.Text = "Unregister Event";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("SF Pro Text", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(220, 146, 21);
            linkLabel1.Location = new Point(28, 799);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 27);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // RegisteredEventList_AndUnregisterEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1865, 835);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RegisteredEventList_AndUnregisterEvent";
            Text = "Registered Event list and Unregister Screen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private LinkLabel linkLabel1;
    }
}