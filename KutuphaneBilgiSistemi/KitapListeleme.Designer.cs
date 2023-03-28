namespace KutuphaneBilgiSistemi
{
    partial class KitapListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapListeleme));
            label10 = new Label();
            comboTuru = new ComboBox();
            btnIptal = new Button();
            ımageList1 = new ImageList(components);
            btnGuncelle = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtKitapAdi = new TextBox();
            txtYazari = new TextBox();
            txtYayinevi = new TextBox();
            txtSayfaSayisi = new TextBox();
            txtStokMiktari = new TextBox();
            txtRafNumarasi = new TextBox();
            txtAciklama = new TextBox();
            txtKBarkodNo = new TextBox();
            dataGridView1 = new DataGridView();
            btnSil = new Button();
            txtAra = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(441, 24);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(280, 37);
            label10.TabIndex = 45;
            label10.Text = "Kitap Listeleme";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += label10_Click;
            // 
            // comboTuru
            // 
            comboTuru.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboTuru.FormattingEnabled = true;
            comboTuru.Items.AddRange(new object[] { "Anı", "Bilgisayar", "Bilim-Kurgu", "Ders Kitapları", "Dilbilimi", "Gezi", "Hikaye", "Otobiyografi", "Roman", "Söyleşi-Röportaj", "Sözlük", "Şiir", "Tarih", "", "", "" });
            comboTuru.Location = new Point(191, 265);
            comboTuru.Margin = new Padding(4, 3, 4, 3);
            comboTuru.Name = "comboTuru";
            comboTuru.Size = new Size(262, 25);
            comboTuru.TabIndex = 65;
            // 
            // btnIptal
            // 
            btnIptal.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIptal.ImageAlign = ContentAlignment.MiddleLeft;
            btnIptal.ImageKey = "png-transparent-abort-delete-cancel-icon-cross-no-access-denied-thumbnail.png";
            btnIptal.ImageList = ımageList1;
            btnIptal.Location = new Point(331, 455);
            btnIptal.Margin = new Padding(4, 3, 4, 3);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(122, 45);
            btnIptal.TabIndex = 64;
            btnIptal.Text = "İptal";
            btnIptal.TextAlign = ContentAlignment.MiddleRight;
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "4 A.jpg");
            ımageList1.Images.SetKeyName(1, "png-transparent-abort-delete-cancel-icon-cross-no-access-denied-thumbnail.png");
            ımageList1.Images.SetKeyName(2, "png-transparent-delete-key-logo-button-text-rectangle-logo.png");
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.ImageKey = "4 A.jpg";
            btnGuncelle.ImageList = ımageList1;
            btnGuncelle.Location = new Point(191, 456);
            btnGuncelle.Margin = new Padding(4, 3, 4, 3);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(132, 45);
            btnGuncelle.TabIndex = 63;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.TextAlign = ContentAlignment.MiddleRight;
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(42, 397);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(84, 19);
            label9.TabIndex = 62;
            label9.Text = "Açıklama";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(42, 366);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(125, 19);
            label8.TabIndex = 61;
            label8.Text = "Raf Numarası";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(42, 331);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(123, 19);
            label7.TabIndex = 60;
            label7.Text = "Stok Miktarı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(42, 298);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 19);
            label6.TabIndex = 59;
            label6.Text = "Sayfa Sayısı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 265);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 58;
            label5.Text = "Türü";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 232);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 57;
            label4.Text = "Yayınevi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 205);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 56;
            label3.Text = "Yazarı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 172);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
            label2.TabIndex = 55;
            label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 139);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 54;
            label1.Text = "Barkod No";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(191, 167);
            txtKitapAdi.Margin = new Padding(4, 3, 4, 3);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(262, 23);
            txtKitapAdi.TabIndex = 53;
            // 
            // txtYazari
            // 
            txtYazari.Location = new Point(191, 199);
            txtYazari.Margin = new Padding(4, 3, 4, 3);
            txtYazari.Name = "txtYazari";
            txtYazari.Size = new Size(262, 23);
            txtYazari.TabIndex = 52;
            // 
            // txtYayinevi
            // 
            txtYayinevi.Location = new Point(191, 232);
            txtYayinevi.Margin = new Padding(4, 3, 4, 3);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(262, 23);
            txtYayinevi.TabIndex = 51;
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(191, 298);
            txtSayfaSayisi.Margin = new Padding(4, 3, 4, 3);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(262, 23);
            txtSayfaSayisi.TabIndex = 50;
            // 
            // txtStokMiktari
            // 
            txtStokMiktari.Location = new Point(191, 331);
            txtStokMiktari.Margin = new Padding(4, 3, 4, 3);
            txtStokMiktari.Name = "txtStokMiktari";
            txtStokMiktari.Size = new Size(262, 23);
            txtStokMiktari.TabIndex = 49;
            // 
            // txtRafNumarasi
            // 
            txtRafNumarasi.Location = new Point(191, 364);
            txtRafNumarasi.Margin = new Padding(4, 3, 4, 3);
            txtRafNumarasi.Name = "txtRafNumarasi";
            txtRafNumarasi.Size = new Size(262, 23);
            txtRafNumarasi.TabIndex = 48;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(191, 397);
            txtAciklama.Margin = new Padding(4, 3, 4, 3);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(262, 52);
            txtAciklama.TabIndex = 47;
            // 
            // txtKBarkodNo
            // 
            txtKBarkodNo.Location = new Point(191, 134);
            txtKBarkodNo.Margin = new Padding(4, 3, 4, 3);
            txtKBarkodNo.Name = "txtKBarkodNo";
            txtKBarkodNo.Size = new Size(262, 23);
            txtKBarkodNo.TabIndex = 46;
            txtKBarkodNo.TextChanged += txtKBarkodNo_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.ForestGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(481, 139);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(615, 361);
            dataGridView1.TabIndex = 66;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageKey = "png-transparent-delete-key-logo-button-text-rectangle-logo.png";
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(983, 93);
            btnSil.Margin = new Padding(4, 3, 4, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(113, 40);
            btnSil.TabIndex = 67;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(688, 97);
            txtAra.Margin = new Padding(4, 3, 4, 3);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(261, 23);
            txtAra.TabIndex = 68;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(629, 101);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(40, 19);
            label11.TabIndex = 69;
            label11.Text = "Ara";
            label11.Click += label11_Click;
            // 
            // KitapListeleme
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1133, 529);
            Controls.Add(label11);
            Controls.Add(txtAra);
            Controls.Add(btnSil);
            Controls.Add(dataGridView1);
            Controls.Add(comboTuru);
            Controls.Add(btnIptal);
            Controls.Add(btnGuncelle);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKitapAdi);
            Controls.Add(txtYazari);
            Controls.Add(txtYayinevi);
            Controls.Add(txtSayfaSayisi);
            Controls.Add(txtStokMiktari);
            Controls.Add(txtRafNumarasi);
            Controls.Add(txtAciklama);
            Controls.Add(txtKBarkodNo);
            Controls.Add(label10);
            Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "KitapListeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Listeleme";
            Load += KitapListeleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private ComboBox comboTuru;
        private Button btnIptal;
        private Button btnGuncelle;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtKitapAdi;
        private TextBox txtYazari;
        private TextBox txtYayinevi;
        private TextBox txtSayfaSayisi;
        private TextBox txtStokMiktari;
        private TextBox txtRafNumarasi;
        private TextBox txtAciklama;
        private TextBox txtKBarkodNo;
        private DataGridView dataGridView1;
        private Button btnSil;
        private TextBox txtAra;
        private Label label11;
        private ImageList ımageList1;
    }
}