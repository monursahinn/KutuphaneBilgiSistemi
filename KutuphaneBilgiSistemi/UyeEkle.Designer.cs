namespace KutuphaneBilgiSistemi
{
    partial class UyeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeEkle));
            txtTC = new TextBox();
            txtAdSoyad = new TextBox();
            txtYas = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            txtEmail = new TextBox();
            txtOKS = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboCinsiyet = new ComboBox();
            btnUyeEkle = new Button();
            ımageList1 = new ImageList(components);
            btnIptal = new Button();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTC
            // 
            txtTC.Location = new Point(224, 103);
            txtTC.Margin = new Padding(4, 3, 4, 3);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(257, 23);
            txtTC.TabIndex = 0;
            txtTC.TextChanged += txtTC_TextChanged;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(224, 136);
            txtAdSoyad.Margin = new Padding(4, 3, 4, 3);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(257, 23);
            txtAdSoyad.TabIndex = 1;
            txtAdSoyad.TextChanged += txtAdSoyad_TextChanged;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(224, 169);
            txtYas.Margin = new Padding(4, 3, 4, 3);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(257, 23);
            txtYas.TabIndex = 2;
            txtYas.TextChanged += txtYas_TextChanged;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(224, 235);
            txtTelefon.Margin = new Padding(4, 3, 4, 3);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(257, 23);
            txtTelefon.TabIndex = 4;
            txtTelefon.TextChanged += txtTelefon_TextChanged;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(224, 267);
            txtAdres.Margin = new Padding(4, 3, 4, 3);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(257, 23);
            txtAdres.TabIndex = 5;
            txtAdres.TextChanged += txtAdres_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(224, 300);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 23);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtOKS
            // 
            txtOKS.Location = new Point(224, 333);
            txtOKS.Margin = new Padding(4, 3, 4, 3);
            txtOKS.Name = "txtOKS";
            txtOKS.Size = new Size(257, 23);
            txtOKS.TabIndex = 7;
            txtOKS.TextAlign = HorizontalAlignment.Center;
            txtOKS.TextChanged += txtOKS_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 10;
            label1.Text = "TC Kimlik No";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 137);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 11;
            label2.Text = "Adı Soyadı";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 170);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 12;
            label3.Text = "Yaş";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 203);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 13;
            label4.Text = "Cinsiyet";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 236);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 14;
            label5.Text = "Telefon";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 269);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 15;
            label6.Text = "Adres";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(26, 301);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 19);
            label7.TabIndex = 16;
            label7.Text = "E-Posta Adresi";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(26, 334);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(184, 19);
            label8.TabIndex = 17;
            label8.Text = "Okunan Kitap Sayısı";
            label8.Click += label8_Click;
            // 
            // comboCinsiyet
            // 
            comboCinsiyet.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboCinsiyet.FormattingEnabled = true;
            comboCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboCinsiyet.Location = new Point(224, 202);
            comboCinsiyet.Margin = new Padding(4, 3, 4, 3);
            comboCinsiyet.Name = "comboCinsiyet";
            comboCinsiyet.Size = new Size(257, 25);
            comboCinsiyet.TabIndex = 20;
            comboCinsiyet.SelectedIndexChanged += comboCinsiyet_SelectedIndexChanged;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUyeEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnUyeEkle.ImageKey = "icons8-female-user-512.png";
            btnUyeEkle.ImageList = ımageList1;
            btnUyeEkle.Location = new Point(224, 385);
            btnUyeEkle.Margin = new Padding(4, 3, 4, 3);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(114, 45);
            btnUyeEkle.TabIndex = 21;
            btnUyeEkle.Text = "Ekle";
            btnUyeEkle.TextAlign = ContentAlignment.MiddleRight;
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-female-user-512.png");
            ımageList1.Images.SetKeyName(1, "png-transparent-abort-delete-cancel-icon-cross-no-access-denied-thumbnail.png");
            // 
            // btnIptal
            // 
            btnIptal.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIptal.ImageAlign = ContentAlignment.MiddleLeft;
            btnIptal.ImageKey = "png-transparent-abort-delete-cancel-icon-cross-no-access-denied-thumbnail.png";
            btnIptal.ImageList = ımageList1;
            btnIptal.Location = new Point(367, 385);
            btnIptal.Margin = new Padding(4, 3, 4, 3);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(114, 45);
            btnIptal.TabIndex = 22;
            btnIptal.Text = "İptal";
            btnIptal.TextAlign = ContentAlignment.MiddleRight;
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(317, 34);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(205, 37);
            label9.TabIndex = 23;
            label9.Text = "Üye Ekleme";
            label9.Click += label9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(517, 102);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // UyeEkle
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(830, 460);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(btnIptal);
            Controls.Add(btnUyeEkle);
            Controls.Add(comboCinsiyet);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOKS);
            Controls.Add(txtEmail);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtYas);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTC);
            Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "UyeEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Ekleme İşlemleri";
            Load += UyeEkle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTC;
        private TextBox txtAdSoyad;
        private TextBox txtYas;
        private TextBox txtTelefon;
        private TextBox txtAdres;
        private TextBox txtEmail;
        private TextBox txtOKS;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboCinsiyet;
        private Button btnUyeEkle;
        private Button btnIptal;
        private Label label9;
        private PictureBox pictureBox1;
        private ImageList ımageList1;
    }
}