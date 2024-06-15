namespace View
{
    partial class CreateBarang
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
            label4 = new Label();
            button1 = new Button();
            label2 = new Label();
            inputHargaBarang = new TextBox();
            label3 = new Label();
            inputJumlahBarang = new TextBox();
            label1 = new Label();
            inputKodeBarang = new TextBox();
            labelNamabarang = new Label();
            buttonBack = new Button();
            inputNamaBarang = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(inputHargaBarang);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(inputJumlahBarang);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(inputKodeBarang);
            panel1.Controls.Add(labelNamabarang);
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(inputNamaBarang);
            panel1.Location = new Point(-1, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 458);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(108, 30);
            label4.Name = "label4";
            label4.Size = new Size(155, 32);
            label4.TabIndex = 21;
            label4.Text = "Add Barang";
            // 
            // button1
            // 
            button1.Location = new Point(15, 407);
            button1.Name = "button1";
            button1.Size = new Size(248, 29);
            button1.TabIndex = 20;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 326);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 19;
            label2.Text = "Harga Barang";
            // 
            // inputHargaBarang
            // 
            inputHargaBarang.Location = new Point(15, 359);
            inputHargaBarang.Name = "inputHargaBarang";
            inputHargaBarang.Size = new Size(248, 27);
            inputHargaBarang.TabIndex = 18;
            inputHargaBarang.TextChanged += inputHargaBarang_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 243);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 17;
            label3.Text = "Jumlah Barang";
            // 
            // inputJumlahBarang
            // 
            inputJumlahBarang.Location = new Point(15, 276);
            inputJumlahBarang.Name = "inputJumlahBarang";
            inputJumlahBarang.Size = new Size(248, 27);
            inputJumlahBarang.TabIndex = 16;
            inputJumlahBarang.TextChanged += inputJumlahBarang_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 164);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 15;
            label1.Text = "Kode Barang";
            // 
            // inputKodeBarang
            // 
            inputKodeBarang.Location = new Point(15, 197);
            inputKodeBarang.Name = "inputKodeBarang";
            inputKodeBarang.Size = new Size(248, 27);
            inputKodeBarang.TabIndex = 14;
            inputKodeBarang.TextChanged += inputKodeBarang_TextChanged;
            // 
            // labelNamabarang
            // 
            labelNamabarang.AutoSize = true;
            labelNamabarang.Location = new Point(15, 81);
            labelNamabarang.Name = "labelNamabarang";
            labelNamabarang.Size = new Size(100, 20);
            labelNamabarang.TabIndex = 13;
            labelNamabarang.Text = "Nama Barang";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(325, 30);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(76, 29);
            buttonBack.TabIndex = 12;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // inputNamaBarang
            // 
            inputNamaBarang.Location = new Point(15, 114);
            inputNamaBarang.Name = "inputNamaBarang";
            inputNamaBarang.Size = new Size(248, 27);
            inputNamaBarang.TabIndex = 11;
            inputNamaBarang.TextChanged += inputNamaBarang_TextChanged;
            // 
            // CreateBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Controls.Add(panel1);
            Name = "CreateBarang";
            Text = "CreateBarang";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button button1;
        private Label label2;
        private TextBox inputHargaBarang;
        private Label label3;
        private TextBox inputJumlahBarang;
        private Label label1;
        private TextBox inputKodeBarang;
        private Label labelNamabarang;
        private Button buttonBack;
        private TextBox inputNamaBarang;
    }
}