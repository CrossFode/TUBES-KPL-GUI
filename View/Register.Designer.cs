namespace View
{
    partial class Register
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
            button1 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 453);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(15, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 29;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 205);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 28;
            label5.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(73, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(275, 27);
            textBox3.TabIndex = 27;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(47, 51);
            label4.Name = "label4";
            label4.Size = new Size(329, 54);
            label4.TabIndex = 26;
            label4.Text = "Register Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 258);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 25;
            label3.Text = "Re-Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 147);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 24;
            label2.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(73, 281);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(275, 27);
            textBox2.TabIndex = 23;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 27);
            textBox1.TabIndex = 22;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(164, 351);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 21;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 200);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 20;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 450);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private Button button1;
    }
}