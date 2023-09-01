namespace MatematikHesaplamaları
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
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            textBox2 = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(130, 97);
            button1.Name = "button1";
            button1.Size = new Size(183, 50);
            button1.TabIndex = 0;
            button1.Text = "Kare";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(451, 97);
            button3.Name = "button3";
            button3.Size = new Size(184, 50);
            button3.TabIndex = 2;
            button3.Text = "Dikdörtgen";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(351, 184);
            label1.Name = "label1";
            label1.Size = new Size(73, 31);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 14);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 4;
            label2.Text = "Bir Kenarı Girin";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(168, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 34);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 195);
            label3.Name = "label3";
            label3.Size = new Size(76, 31);
            label3.TabIndex = 6;
            label3.Text = "Alan=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(120, 195);
            label4.Name = "label4";
            label4.Size = new Size(40, 31);
            label4.TabIndex = 7;
            label4.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 249);
            label5.Name = "label5";
            label5.Size = new Size(89, 31);
            label5.TabIndex = 8;
            label5.Text = "Çevre=";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(120, 249);
            label6.Name = "label6";
            label6.Size = new Size(40, 31);
            label6.TabIndex = 9;
            label6.Text = "00";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(27, 111);
            button4.Name = "button4";
            button4.Size = new Size(140, 50);
            button4.TabIndex = 10;
            button4.Text = "Hesapla";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(168, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 34);
            textBox2.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(27, 62);
            label7.Name = "label7";
            label7.Size = new Size(111, 25);
            label7.TabIndex = 11;
            label7.Text = "Uzun Kenar";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(162, 276);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 301);
            panel1.TabIndex = 13;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(190, 111);
            button2.Name = "button2";
            button2.Size = new Size(140, 50);
            button2.TabIndex = 13;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(846, 665);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button4;
        private TextBox textBox2;
        private Label label7;
        private Panel panel1;
        private Button button2;
    }
}