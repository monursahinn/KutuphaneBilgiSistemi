namespace KutuphaneBilgiSistemi
{
    partial class Siralama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siralama));
            label9 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(444, 24);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(160, 37);
            label9.TabIndex = 47;
            label9.Text = "Sıralama";
            label9.Click += label9_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Green;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 142);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(634, 337);
            dataGridView1.TabIndex = 46;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 93);
            label1.Name = "label1";
            label1.Size = new Size(153, 17);
            label1.TabIndex = 48;
            label1.Text = "En Çok Kitap Okuyan";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 93);
            label2.Name = "label2";
            label2.Size = new Size(146, 17);
            label2.TabIndex = 49;
            label2.Text = "En Az Kitap Okuyan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 120);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 120);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 120);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 93);
            label6.Name = "label6";
            label6.Size = new Size(157, 17);
            label6.TabIndex = 52;
            label6.Text = "Okuduğu Kitap Sayısı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(586, 120);
            label7.Name = "label7";
            label7.Size = new Size(0, 17);
            label7.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(512, 93);
            label8.Name = "label8";
            label8.Size = new Size(157, 17);
            label8.TabIndex = 54;
            label8.Text = "Okuduğu Kitap Sayısı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(675, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 337);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // Siralama
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1029, 510);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Siralama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sıralama";
            Load += Siralama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
    }
}