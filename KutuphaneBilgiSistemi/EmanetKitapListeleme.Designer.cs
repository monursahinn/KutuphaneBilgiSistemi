namespace KutuphaneBilgiSistemi
{
    partial class EmanetKitapListeleme
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetKitapListeleme));
            dataGridView1 = new DataGridView();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            button2 = new Button();
            ımageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Green;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(379, 141);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(634, 337);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(613, 102);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 15;
            label2.Text = "Filtrele";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tüm Kitaplar", "Geciken Kitaplar", "Gecikmeyen Kitaplar" });
            comboBox1.Location = new Point(744, 97);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 25);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(297, 25);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(413, 37);
            label9.TabIndex = 45;
            label9.Text = "Emanet Kitap Listeleme";
            label9.Click += label9_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageKey = "png-transparent-abort-delete-cancel-icon-cross-no-access-denied-thumbnail.png";
            button2.ImageList = ımageList1;
            button2.Location = new Point(882, 505);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(131, 45);
            button2.TabIndex = 50;
            button2.Text = "Kapat";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "png-transparent-abort-delete-cancel-icon-cross-no-access-denied-thumbnail.png");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 141);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 337);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // EmanetKitapListeleme
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1029, 560);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "EmanetKitapListeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emanet Kitap Listeleme";
            Load += EmanetKitapListeleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label9;
        private Button button2;
        private PictureBox pictureBox1;
        private ImageList ımageList1;
    }
}