namespace trial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            button5 = new Button();
            dataGridView3 = new DataGridView();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button6 = new Button();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Cyan;
            dataGridView1.Location = new Point(328, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 175);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(444, 272);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "list";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(187, 85);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 38);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "name";
            // 
            // button3
            // 
            button3.Location = new Point(187, 179);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(345, 272);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "edit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 132);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 8;
            label2.Text = "id";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 0, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.GridColor = Color.Red;
            dataGridView2.Location = new Point(587, 82);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(240, 175);
            dataGridView2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 64);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 10;
            label3.Text = "list";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(659, 64);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 11;
            label4.Text = "archive list";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(482, 15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 23);
            textBox3.TabIndex = 12;
            // 
            // button5
            // 
            button5.Location = new Point(728, 15);
            button5.Name = "button5";
            button5.Size = new Size(59, 23);
            button5.TabIndex = 13;
            button5.Text = "search";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.BackgroundColor = Color.WhiteSmoke;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.GridColor = SystemColors.ActiveCaptionText;
            dataGridView3.Location = new Point(328, 83);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(240, 174);
            dataGridView3.TabIndex = 14;
            dataGridView3.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(587, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 23);
            comboBox1.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(96, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(96, 248);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 17;
            // 
            // button6
            // 
            button6.Location = new Point(30, 344);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 18;
            button6.Text = "log in";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(96, 299);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 255, 255);
            pictureBox1.Location = new Point(12, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 168);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 222);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 21;
            label5.Text = "user name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 251);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 22;
            label6.Text = "password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 302);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 23;
            label7.Text = "position";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 379);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(button6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView3);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Button button5;
        private DataGridView dataGridView3;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button6;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}