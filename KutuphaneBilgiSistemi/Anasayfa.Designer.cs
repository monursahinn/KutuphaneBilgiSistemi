namespace KutuphaneBilgiSistemi
{
    partial class Anasayfa
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            groupBox1 = new GroupBox();
            btnUyeListele = new Button();
            ımageList1 = new ImageList(components);
            btnUyeEkle = new Button();
            groupBox2 = new GroupBox();
            btnKitapEkle = new Button();
            btnKitapListele = new Button();
            groupBox3 = new GroupBox();
            btnEmanetIade = new Button();
            btnEmanetKitap = new Button();
            btnEmanetListe = new Button();
            groupBox4 = new GroupBox();
            btnGrafikler = new Button();
            btnSiralama = new Button();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Desktop;
            groupBox1.Controls.Add(btnUyeListele);
            groupBox1.Controls.Add(btnUyeEkle);
            groupBox1.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(39, 88);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(367, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye İşlemleri";
            // 
            // btnUyeListele
            // 
            btnUyeListele.ImageAlign = ContentAlignment.MiddleLeft;
            btnUyeListele.ImageKey = "libcard-ohio-sabbath-72.jpg";
            btnUyeListele.ImageList = ımageList1;
            btnUyeListele.Location = new Point(20, 129);
            btnUyeListele.Margin = new Padding(4, 3, 4, 3);
            btnUyeListele.Name = "btnUyeListele";
            btnUyeListele.Size = new Size(315, 73);
            btnUyeListele.TabIndex = 1;
            btnUyeListele.Text = "Üye Listeleme";
            btnUyeListele.TextAlign = ContentAlignment.MiddleRight;
            btnUyeListele.UseVisualStyleBackColor = true;
            btnUyeListele.Click += btnUyeListele_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-box-512.png");
            ımageList1.Images.SetKeyName(1, "icons8-lock-512.png");
            ımageList1.Images.SetKeyName(2, "icons8-user-male-512.png");
            ımageList1.Images.SetKeyName(3, "images.jpg");
            ımageList1.Images.SetKeyName(4, "indir (1).jpg");
            ımageList1.Images.SetKeyName(5, "libcard-ohio-sabbath-72.jpg");
            ımageList1.Images.SetKeyName(6, "YeniYeni.png");
            ımageList1.Images.SetKeyName(7, "image2.jpeg");
            ımageList1.Images.SetKeyName(8, "image5.png");
            ımageList1.Images.SetKeyName(9, "4 A.jpg");
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnUyeEkle.ImageKey = "icons8-user-male-512.png";
            btnUyeEkle.ImageList = ımageList1;
            btnUyeEkle.Location = new Point(20, 29);
            btnUyeEkle.Margin = new Padding(4, 3, 4, 3);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(315, 79);
            btnUyeEkle.TabIndex = 0;
            btnUyeEkle.Text = "Üye  Ekleme";
            btnUyeEkle.TextAlign = ContentAlignment.MiddleRight;
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnKitapEkle);
            groupBox2.Controls.Add(btnKitapListele);
            groupBox2.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(456, 88);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(368, 219);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnKitapEkle.ImageKey = "image2.jpeg";
            btnKitapEkle.ImageList = ımageList1;
            btnKitapEkle.Location = new Point(19, 37);
            btnKitapEkle.Margin = new Padding(4, 3, 4, 3);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(315, 71);
            btnKitapEkle.TabIndex = 3;
            btnKitapEkle.Text = "Kitap Ekleme";
            btnKitapEkle.TextAlign = ContentAlignment.MiddleRight;
            btnKitapEkle.UseVisualStyleBackColor = true;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // btnKitapListele
            // 
            btnKitapListele.ImageAlign = ContentAlignment.MiddleLeft;
            btnKitapListele.ImageKey = "YeniYeni.png";
            btnKitapListele.ImageList = ımageList1;
            btnKitapListele.Location = new Point(19, 129);
            btnKitapListele.Margin = new Padding(4, 3, 4, 3);
            btnKitapListele.Name = "btnKitapListele";
            btnKitapListele.Size = new Size(315, 73);
            btnKitapListele.TabIndex = 2;
            btnKitapListele.Text = "Kitap Listeleme";
            btnKitapListele.TextAlign = ContentAlignment.MiddleRight;
            btnKitapListele.UseVisualStyleBackColor = true;
            btnKitapListele.Click += btnKitapListele_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEmanetIade);
            groupBox3.Controls.Add(btnEmanetKitap);
            groupBox3.Controls.Add(btnEmanetListe);
            groupBox3.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(39, 314);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(367, 271);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // btnEmanetIade
            // 
            btnEmanetIade.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmanetIade.ImageKey = "4 A.jpg";
            btnEmanetIade.ImageList = ımageList1;
            btnEmanetIade.Location = new Point(20, 185);
            btnEmanetIade.Margin = new Padding(4, 3, 4, 3);
            btnEmanetIade.Name = "btnEmanetIade";
            btnEmanetIade.Size = new Size(315, 66);
            btnEmanetIade.TabIndex = 7;
            btnEmanetIade.Text = "Emanet Kitap İade";
            btnEmanetIade.TextAlign = ContentAlignment.MiddleRight;
            btnEmanetIade.UseVisualStyleBackColor = true;
            btnEmanetIade.Click += btnEmanetIade_Click;
            // 
            // btnEmanetKitap
            // 
            btnEmanetKitap.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmanetKitap.ImageKey = "icons8-lock-512.png";
            btnEmanetKitap.ImageList = ımageList1;
            btnEmanetKitap.Location = new Point(20, 26);
            btnEmanetKitap.Margin = new Padding(4, 3, 4, 3);
            btnEmanetKitap.Name = "btnEmanetKitap";
            btnEmanetKitap.Size = new Size(315, 73);
            btnEmanetKitap.TabIndex = 5;
            btnEmanetKitap.Text = "Emanet Kitap Verme";
            btnEmanetKitap.TextAlign = ContentAlignment.MiddleRight;
            btnEmanetKitap.UseVisualStyleBackColor = true;
            btnEmanetKitap.Click += btnEmanetKitap_Click;
            // 
            // btnEmanetListe
            // 
            btnEmanetListe.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmanetListe.ImageKey = "images.jpg";
            btnEmanetListe.ImageList = ımageList1;
            btnEmanetListe.Location = new Point(20, 106);
            btnEmanetListe.Margin = new Padding(4, 3, 4, 3);
            btnEmanetListe.Name = "btnEmanetListe";
            btnEmanetListe.Size = new Size(315, 73);
            btnEmanetListe.TabIndex = 4;
            btnEmanetListe.Text = "Emanet Kitap Listeleme";
            btnEmanetListe.TextAlign = ContentAlignment.MiddleRight;
            btnEmanetListe.UseVisualStyleBackColor = true;
            btnEmanetListe.Click += btnEmanetListe_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnGrafikler);
            groupBox4.Controls.Add(btnSiralama);
            groupBox4.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(456, 314);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(368, 271);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sıralama ve Grafikler";
            // 
            // btnGrafikler
            // 
            btnGrafikler.ImageAlign = ContentAlignment.MiddleLeft;
            btnGrafikler.ImageKey = "indir (1).jpg";
            btnGrafikler.ImageList = ımageList1;
            btnGrafikler.Location = new Point(19, 155);
            btnGrafikler.Margin = new Padding(4, 3, 4, 3);
            btnGrafikler.Name = "btnGrafikler";
            btnGrafikler.Size = new Size(315, 73);
            btnGrafikler.TabIndex = 7;
            btnGrafikler.Text = "Grafikler";
            btnGrafikler.TextAlign = ContentAlignment.MiddleRight;
            btnGrafikler.UseVisualStyleBackColor = true;
            btnGrafikler.Click += btnGrafikler_Click;
            // 
            // btnSiralama
            // 
            btnSiralama.ImageAlign = ContentAlignment.MiddleLeft;
            btnSiralama.ImageKey = "image5.png";
            btnSiralama.ImageList = ımageList1;
            btnSiralama.Location = new Point(19, 52);
            btnSiralama.Margin = new Padding(4, 3, 4, 3);
            btnSiralama.Name = "btnSiralama";
            btnSiralama.Size = new Size(315, 73);
            btnSiralama.TabIndex = 6;
            btnSiralama.Text = "Sıralama";
            btnSiralama.TextAlign = ContentAlignment.MiddleRight;
            btnSiralama.UseVisualStyleBackColor = true;
            btnSiralama.Click += btnSiralama_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(228, 29);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(420, 37);
            label9.TabIndex = 43;
            label9.Text = "Kütüphane Bilgi Sistemi";
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(882, 609);
            Controls.Add(label9);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Anasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Bilgi Sistemi";
            Load += Anasayfa_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUyeListele;
        private Button btnUyeEkle;
        private GroupBox groupBox2;
        private Button btnKitapEkle;
        private Button btnKitapListele;
        private GroupBox groupBox3;
        private Button btnEmanetIade;
        private Button btnEmanetKitap;
        private Button btnEmanetListe;
        private GroupBox groupBox4;
        private Button btnGrafikler;
        private Button btnSiralama;
        private Label label9;
        private ImageList ımageList1;
    }
}