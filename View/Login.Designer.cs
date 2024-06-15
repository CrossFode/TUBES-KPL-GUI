namespace View
{
    partial class Login
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
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(241, 286);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 37;
            label5.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(241, 309);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(275, 27);
            textBox3.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(215, 132);
            label4.Name = "label4";
            label4.Size = new Size(329, 54);
            label4.TabIndex = 35;
            label4.Text = "Register Account";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 228);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 33;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 251);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 27);
            textBox1.TabIndex = 31;
            // 
            // button2
            // 
            button2.Location = new Point(416, 377);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 30;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 281);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 29;
            // 
            // button1
            // 
            button1.Location = new Point(241, 377);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 38;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 614);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private Button button1;
    }
}