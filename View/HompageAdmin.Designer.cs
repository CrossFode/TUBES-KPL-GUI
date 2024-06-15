namespace View
{
    partial class HompageAdmin
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
            lihatTabel = new Button();
            buttonDelete = new Button();
            buttonSearch = new Button();
            buttonAdd = new Button();
            labelHomepage = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lihatTabel);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(labelHomepage);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 490);
            panel1.TabIndex = 0;
            // 
            // lihatTabel
            // 
            lihatTabel.Location = new Point(299, 188);
            lihatTabel.Name = "lihatTabel";
            lihatTabel.Size = new Size(143, 57);
            lihatTabel.TabIndex = 16;
            lihatTabel.Text = "Lihat Tabel Barang";
            lihatTabel.UseVisualStyleBackColor = true;
            lihatTabel.Click += lihatTabel_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(299, 316);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(143, 57);
            buttonDelete.TabIndex = 15;
            buttonDelete.Text = "Delete Barang";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(38, 316);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(143, 57);
            buttonSearch.TabIndex = 14;
            buttonSearch.Text = "Search Barang";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(38, 188);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(143, 57);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add Barang";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelHomepage
            // 
            labelHomepage.AutoSize = true;
            labelHomepage.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHomepage.Location = new Point(54, 70);
            labelHomepage.Name = "labelHomepage";
            labelHomepage.Size = new Size(376, 51);
            labelHomepage.TabIndex = 12;
            labelHomepage.Text = "Homepage Gudang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 121);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 11;
            // 
            // HompageAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 489);
            Controls.Add(panel1);
            Name = "HompageAdmin";
            Text = "HompageAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button lihatTabel;
        private Button buttonDelete;
        private Button buttonSearch;
        private Button buttonAdd;
        private Label labelHomepage;
        private Label label1;
    }
}