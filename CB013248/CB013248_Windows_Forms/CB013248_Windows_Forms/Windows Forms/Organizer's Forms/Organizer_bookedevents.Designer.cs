namespace CB013248_Windows_Forms
{
    partial class Organizer_bookedevents
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
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1830, 401);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(220, 146, 21);
            label1.Font = new Font("SF Pro Text", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(719, 27);
            label1.Name = "label1";
            label1.Size = new Size(467, 48);
            label1.TabIndex = 3;
            label1.Text = "Booked Events Screen";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("SF Pro Text", 13.2000008F, FontStyle.Bold);
            linkLabel1.LinkColor = Color.FromArgb(220, 146, 21);
            linkLabel1.Location = new Point(12, 774);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 27);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go Back";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(220, 146, 21);
            button1.Font = new Font("SF Pro Text", 12F, FontStyle.Bold);
            button1.Location = new Point(860, 556);
            button1.Name = "button1";
            button1.Size = new Size(204, 65);
            button1.TabIndex = 6;
            button1.Text = "Show Booked Events";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Organizer_bookedevents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1854, 810);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Organizer_bookedevents";
            Text = "Booked Event Screen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}