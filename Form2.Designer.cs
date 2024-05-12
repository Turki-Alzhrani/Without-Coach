namespace Without_Coach
{
    partial class Form2
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
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 649);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Yu Gothic UI Semilight", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(-4, 333);
            label5.Name = "label5";
            label5.Size = new Size(343, 40);
            label5.TabIndex = 1;
            label5.Text = "Please chooce your desier";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.the_original_photo_of_without_removebg_preview;
            pictureBox1.Location = new Point(0, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(comboBox3);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(comboBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(339, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(793, 649);
            panel3.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(213, 524);
            button1.Name = "button1";
            button1.Size = new Size(164, 59);
            button1.TabIndex = 6;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(41, 357);
            label3.Name = "label3";
            label3.Size = new Size(275, 35);
            label3.TabIndex = 5;
            label3.Text = "Where do you workout:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(54, 247);
            label2.Name = "label2";
            label2.Size = new Size(246, 35);
            label2.TabIndex = 4;
            label2.Text = "Level of the workout:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(54, 129);
            label1.Name = "label1";
            label1.Size = new Size(244, 35);
            label1.TabIndex = 3;
            label1.Text = "Days of the workout:";
            // 
            // comboBox3
            // 
            comboBox3.Cursor = Cursors.Hand;
            comboBox3.Font = new Font("Segoe UI", 10F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Home", "Gym" });
            comboBox3.Location = new Point(322, 364);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 31);
            comboBox3.TabIndex = 2;
            comboBox3.Text = "Place";
            comboBox3.KeyDown += comboBox3_KeyDown;
            // 
            // comboBox2
            // 
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.Font = new Font("Segoe UI", 10F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "easy", "mediume", "hard" });
            comboBox2.Location = new Point(322, 254);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 31);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "Level";
            comboBox2.DragEnter += comboBox2_DragEnter;
            comboBox2.KeyDown += comboBox2_KeyDown;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "3", "4", "5", "6" });
            comboBox1.Location = new Point(322, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 31);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Days";
            comboBox1.KeyDown += comboBox1_KeyDown;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 649);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
    }
}