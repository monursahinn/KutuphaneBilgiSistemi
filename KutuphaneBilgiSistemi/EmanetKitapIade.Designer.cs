namespace KutuphaneBilgiSistemi
{
    partial class EmanetKitapIade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetKitapIade));
            label9 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ımageList1 = new ImageList(components);
            button2 = new Button();
            txtBarkodAra = new TextBox();
            label1 = new Label();
            txtTCAra = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(357, 25);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(324, 37);
            label9.TabIndex = 46;
            label9.Text = "Emanet Kitap Iade";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Green;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(396, 144);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(573, 363);
            dataGridView1.TabIndex = 47;
            // 
            // button1
            // 
            button1.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageKey = "iade.png";
            button1.ImageList = ımageList1;
            button1.Location = new Point(698, 529);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(138, 36);
            button1.TabIndex = 48;
            button1.Text = "Teslim Al";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "iade.png");
            ımageList1.Images.SetKeyName(1, "png-transparent-abort-delete-cancel-icon-cross-no-access-denied-thumbnail.png");
            // 
            // button2
            // 
            button2.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageKey = "png-transparent-abort-delete-cancel-icon-cross-no-access-denied-thumbnail.png";
            button2.ImageList = ımageList1;
            button2.Location = new Point(857, 529);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(113, 36);
            button2.TabIndex = 49;
            button2.Text = "İptal";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtBarkodAra
            // 
            txtBarkodAra.Location = new Point(809, 96);
            txtBarkodAra.Margin = new Padding(2, 3, 2, 3);
            txtBarkodAra.Name = "txtBarkodAra";
            txtBarkodAra.Size = new Size(160, 23);
            txtBarkodAra.TabIndex = 50;
            txtBarkodAra.TextChanged += txtBarkodAra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(708, 99);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 51;
            label1.Text = "Barkod No";
            label1.Click += label1_Click;
            // 
            // txtTCAra
            // 
            txtTCAra.Location = new Point(523, 96);
            txtTCAra.Margin = new Padding(2, 3, 2, 3);
            txtTCAra.Name = "txtTCAra";
            txtTCAra.Size = new Size(153, 23);
            txtTCAra.TabIndex = 52;
            txtTCAra.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(395, 99);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 53;
            label2.Text = "TC Kimlik No";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, 144);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 363);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // EmanetKitapIade
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1039, 595);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtTCAra);
            Controls.Add(label1);
            Controls.Add(txtBarkodAra);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "EmanetKitapIade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emanet Kitap Iade";
            Load += EmanetKitapIade_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private ImageList ımageList1;
        private TextBox txtBarkodAra;
        private Label label1;
        private TextBox txtTCAra;
        private Label label2;
        private PictureBox pictureBox1;
    }
}