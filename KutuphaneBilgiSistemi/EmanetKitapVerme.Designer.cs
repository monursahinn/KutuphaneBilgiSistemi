namespace KutuphaneBilgiSistemi
{
    partial class EmanetKitapVerme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetKitapVerme));
            dataGridView1 = new DataGridView();
            grpUyeBilgileri = new GroupBox();
            labelEmail = new Label();
            labelTelefon = new Label();
            labelAdSoyad = new Label();
            labelTC = new Label();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTCKimlik = new TextBox();
            grpKitapBilgileri = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            dateTimePickerIade = new DateTimePicker();
            dateTimePickerTeslim = new DateTimePicker();
            label6 = new Label();
            txtStokMiktari = new TextBox();
            label5 = new Label();
            txtSayfaSayisi = new TextBox();
            label1 = new Label();
            txtYayinevi = new TextBox();
            label2 = new Label();
            txtBarkodNo = new TextBox();
            label3 = new Label();
            txtKitapAdi = new TextBox();
            labelBarkodNo = new Label();
            txtYazari = new TextBox();
            label9 = new Label();
            btnTeslimEt = new Button();
            ımageList1 = new ImageList(components);
            btnIptal = new Button();
            btnSil = new Button();
            lblKayitliKitap = new Label();
            lblKayitliKitapSayi = new Label();
            lblSepetKitap = new Label();
            lblSepetKitapSayi = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpUyeBilgileri.SuspendLayout();
            grpKitapBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Green;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(482, 136);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(789, 468);
            dataGridView1.TabIndex = 0;
            // 
            // grpUyeBilgileri
            // 
            grpUyeBilgileri.Controls.Add(labelEmail);
            grpUyeBilgileri.Controls.Add(labelTelefon);
            grpUyeBilgileri.Controls.Add(labelAdSoyad);
            grpUyeBilgileri.Controls.Add(labelTC);
            grpUyeBilgileri.Controls.Add(txtEmail);
            grpUyeBilgileri.Controls.Add(txtTelefon);
            grpUyeBilgileri.Controls.Add(txtAdSoyad);
            grpUyeBilgileri.Controls.Add(txtTCKimlik);
            grpUyeBilgileri.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            grpUyeBilgileri.Location = new Point(15, 77);
            grpUyeBilgileri.Margin = new Padding(4, 3, 4, 3);
            grpUyeBilgileri.Name = "grpUyeBilgileri";
            grpUyeBilgileri.Padding = new Padding(4, 3, 4, 3);
            grpUyeBilgileri.Size = new Size(436, 184);
            grpUyeBilgileri.TabIndex = 1;
            grpUyeBilgileri.TabStop = false;
            grpUyeBilgileri.Text = "Üye Bilgileri";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(22, 142);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(75, 19);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "E-Posta";
            // 
            // labelTelefon
            // 
            labelTelefon.AutoSize = true;
            labelTelefon.Location = new Point(22, 105);
            labelTelefon.Margin = new Padding(4, 0, 4, 0);
            labelTelefon.Name = "labelTelefon";
            labelTelefon.Size = new Size(101, 19);
            labelTelefon.TabIndex = 6;
            labelTelefon.Text = "Telefon No";
            // 
            // labelAdSoyad
            // 
            labelAdSoyad.AutoSize = true;
            labelAdSoyad.Location = new Point(22, 67);
            labelAdSoyad.Margin = new Padding(4, 0, 4, 0);
            labelAdSoyad.Name = "labelAdSoyad";
            labelAdSoyad.Size = new Size(101, 19);
            labelAdSoyad.TabIndex = 5;
            labelAdSoyad.Text = "Adı Soyadı";
            // 
            // labelTC
            // 
            labelTC.AutoSize = true;
            labelTC.Location = new Point(22, 36);
            labelTC.Margin = new Padding(4, 0, 4, 0);
            labelTC.Name = "labelTC";
            labelTC.Size = new Size(124, 19);
            labelTC.TabIndex = 4;
            labelTC.Text = "TC Kimlik No";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(197, 142);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(197, 105);
            txtTelefon.Margin = new Padding(4, 3, 4, 3);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(219, 27);
            txtTelefon.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(197, 67);
            txtAdSoyad.Margin = new Padding(4, 3, 4, 3);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(220, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtTCKimlik
            // 
            txtTCKimlik.Location = new Point(197, 30);
            txtTCKimlik.Margin = new Padding(4, 3, 4, 3);
            txtTCKimlik.Name = "txtTCKimlik";
            txtTCKimlik.Size = new Size(220, 27);
            txtTCKimlik.TabIndex = 0;
            txtTCKimlik.TextChanged += txtTCKimlik_TextChanged;
            // 
            // grpKitapBilgileri
            // 
            grpKitapBilgileri.Controls.Add(label8);
            grpKitapBilgileri.Controls.Add(label7);
            grpKitapBilgileri.Controls.Add(dateTimePickerIade);
            grpKitapBilgileri.Controls.Add(dateTimePickerTeslim);
            grpKitapBilgileri.Controls.Add(label6);
            grpKitapBilgileri.Controls.Add(txtStokMiktari);
            grpKitapBilgileri.Controls.Add(label5);
            grpKitapBilgileri.Controls.Add(txtSayfaSayisi);
            grpKitapBilgileri.Controls.Add(label1);
            grpKitapBilgileri.Controls.Add(txtYayinevi);
            grpKitapBilgileri.Controls.Add(label2);
            grpKitapBilgileri.Controls.Add(txtBarkodNo);
            grpKitapBilgileri.Controls.Add(label3);
            grpKitapBilgileri.Controls.Add(txtKitapAdi);
            grpKitapBilgileri.Controls.Add(labelBarkodNo);
            grpKitapBilgileri.Controls.Add(txtYazari);
            grpKitapBilgileri.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            grpKitapBilgileri.Location = new Point(13, 277);
            grpKitapBilgileri.Margin = new Padding(4, 3, 4, 3);
            grpKitapBilgileri.Name = "grpKitapBilgileri";
            grpKitapBilgileri.Padding = new Padding(4, 3, 4, 3);
            grpKitapBilgileri.Size = new Size(438, 327);
            grpKitapBilgileri.TabIndex = 2;
            grpKitapBilgileri.TabStop = false;
            grpKitapBilgileri.Text = "Kitap Bilgileri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 289);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 19);
            label8.TabIndex = 23;
            label8.Text = "İade Tarihi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 252);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(122, 19);
            label7.TabIndex = 22;
            label7.Text = "Teslim Tarihi";
            // 
            // dateTimePickerIade
            // 
            dateTimePickerIade.Format = DateTimePickerFormat.Short;
            dateTimePickerIade.Location = new Point(193, 287);
            dateTimePickerIade.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerIade.Name = "dateTimePickerIade";
            dateTimePickerIade.Size = new Size(221, 27);
            dateTimePickerIade.TabIndex = 21;
            // 
            // dateTimePickerTeslim
            // 
            dateTimePickerTeslim.Format = DateTimePickerFormat.Short;
            dateTimePickerTeslim.Location = new Point(193, 250);
            dateTimePickerTeslim.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerTeslim.Name = "dateTimePickerTeslim";
            dateTimePickerTeslim.Size = new Size(223, 27);
            dateTimePickerTeslim.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 215);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(123, 19);
            label6.TabIndex = 19;
            label6.Text = "Stok Miktarı";
            // 
            // txtStokMiktari
            // 
            txtStokMiktari.Location = new Point(193, 212);
            txtStokMiktari.Margin = new Padding(4, 3, 4, 3);
            txtStokMiktari.Name = "txtStokMiktari";
            txtStokMiktari.Size = new Size(223, 27);
            txtStokMiktari.TabIndex = 18;
            txtStokMiktari.TextChanged += txtStokMiktari_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 177);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 19);
            label5.TabIndex = 17;
            label5.Text = "Sayfa Sayısı";
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(193, 175);
            txtSayfaSayisi.Margin = new Padding(4, 3, 4, 3);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(223, 27);
            txtSayfaSayisi.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 140);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 15;
            label1.Text = "Yayınevi";
            // 
            // txtYayinevi
            // 
            txtYayinevi.Location = new Point(193, 138);
            txtYayinevi.Margin = new Padding(4, 3, 4, 3);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(223, 27);
            txtYayinevi.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 102);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 14;
            label2.Text = "Yazarı";
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(194, 25);
            txtBarkodNo.Margin = new Padding(4, 3, 4, 3);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(223, 27);
            txtBarkodNo.TabIndex = 8;
            txtBarkodNo.TextChanged += txtBarkodNo_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 65);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 13;
            label3.Text = "Kitap Adı";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(193, 63);
            txtKitapAdi.Margin = new Padding(4, 3, 4, 3);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(223, 27);
            txtKitapAdi.TabIndex = 9;
            // 
            // labelBarkodNo
            // 
            labelBarkodNo.AutoSize = true;
            labelBarkodNo.Location = new Point(21, 29);
            labelBarkodNo.Margin = new Padding(4, 0, 4, 0);
            labelBarkodNo.Name = "labelBarkodNo";
            labelBarkodNo.Size = new Size(97, 19);
            labelBarkodNo.TabIndex = 12;
            labelBarkodNo.Text = "Barkod No";
            // 
            // txtYazari
            // 
            txtYazari.Location = new Point(193, 100);
            txtYazari.Margin = new Padding(4, 3, 4, 3);
            txtYazari.Name = "txtYazari";
            txtYazari.Size = new Size(223, 27);
            txtYazari.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(467, 15);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(354, 37);
            label9.TabIndex = 44;
            label9.Text = "Emanet Kitap Verme";
            // 
            // btnTeslimEt
            // 
            btnTeslimEt.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTeslimEt.ImageAlign = ContentAlignment.MiddleLeft;
            btnTeslimEt.ImageKey = "teslim.png";
            btnTeslimEt.ImageList = ımageList1;
            btnTeslimEt.Location = new Point(975, 610);
            btnTeslimEt.Margin = new Padding(4, 3, 4, 3);
            btnTeslimEt.Name = "btnTeslimEt";
            btnTeslimEt.Size = new Size(139, 45);
            btnTeslimEt.TabIndex = 46;
            btnTeslimEt.Text = "Teslim Et";
            btnTeslimEt.TextAlign = ContentAlignment.MiddleRight;
            btnTeslimEt.UseVisualStyleBackColor = true;
            btnTeslimEt.Click += btnTeslimEt_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "iade.png");
            ımageList1.Images.SetKeyName(1, "icons8-box-512.png");
            ımageList1.Images.SetKeyName(2, "png-transparent-abort-delete-cancel-icon-cross-no-access-denied-thumbnail.png");
            ımageList1.Images.SetKeyName(3, "teslim.png");
            ımageList1.Images.SetKeyName(4, "png-transparent-delete-key-logo-button-text-rectangle-logo.png");
            // 
            // btnIptal
            // 
            btnIptal.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIptal.ImageAlign = ContentAlignment.MiddleLeft;
            btnIptal.ImageKey = "png-transparent-abort-delete-cancel-icon-cross-no-access-denied-thumbnail.png";
            btnIptal.ImageList = ımageList1;
            btnIptal.Location = new Point(1149, 610);
            btnIptal.Margin = new Padding(4, 3, 4, 3);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(122, 45);
            btnIptal.TabIndex = 47;
            btnIptal.Text = "İptal";
            btnIptal.TextAlign = ContentAlignment.MiddleRight;
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageKey = "png-transparent-delete-key-logo-button-text-rectangle-logo.png";
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(1167, 70);
            btnSil.Margin = new Padding(4, 3, 4, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(104, 45);
            btnSil.TabIndex = 48;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lblKayitliKitap
            // 
            lblKayitliKitap.AutoSize = true;
            lblKayitliKitap.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblKayitliKitap.Location = new Point(535, 70);
            lblKayitliKitap.Margin = new Padding(4, 0, 4, 0);
            lblKayitliKitap.Name = "lblKayitliKitap";
            lblKayitliKitap.Size = new Size(185, 19);
            lblKayitliKitap.TabIndex = 24;
            lblKayitliKitap.Text = "Kayıtlı Kitap Sayısı";
            // 
            // lblKayitliKitapSayi
            // 
            lblKayitliKitapSayi.AutoSize = true;
            lblKayitliKitapSayi.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblKayitliKitapSayi.Location = new Point(629, 103);
            lblKayitliKitapSayi.Margin = new Padding(4, 0, 4, 0);
            lblKayitliKitapSayi.Name = "lblKayitliKitapSayi";
            lblKayitliKitapSayi.Size = new Size(0, 19);
            lblKayitliKitapSayi.TabIndex = 49;
            // 
            // lblSepetKitap
            // 
            lblSepetKitap.AutoSize = true;
            lblSepetKitap.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSepetKitap.Location = new Point(842, 70);
            lblSepetKitap.Margin = new Padding(4, 0, 4, 0);
            lblSepetKitap.Name = "lblSepetKitap";
            lblSepetKitap.Size = new Size(207, 19);
            lblSepetKitap.TabIndex = 50;
            lblSepetKitap.Text = "Sepetteki Kitap Sayısı";
            // 
            // lblSepetKitapSayi
            // 
            lblSepetKitapSayi.AutoSize = true;
            lblSepetKitapSayi.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSepetKitapSayi.Location = new Point(957, 103);
            lblSepetKitapSayi.Margin = new Padding(4, 0, 4, 0);
            lblSepetKitapSayi.Name = "lblSepetKitapSayi";
            lblSepetKitapSayi.Size = new Size(0, 19);
            lblSepetKitapSayi.TabIndex = 51;
            // 
            // button1
            // 
            button1.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageKey = "iade.png";
            button1.ImageList = ımageList1;
            button1.Location = new Point(327, 610);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(124, 45);
            button1.TabIndex = 52;
            button1.Text = "Ekle";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EmanetKitapVerme
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1305, 667);
            Controls.Add(button1);
            Controls.Add(lblSepetKitapSayi);
            Controls.Add(lblSepetKitap);
            Controls.Add(lblKayitliKitapSayi);
            Controls.Add(lblKayitliKitap);
            Controls.Add(btnSil);
            Controls.Add(btnIptal);
            Controls.Add(btnTeslimEt);
            Controls.Add(label9);
            Controls.Add(grpKitapBilgileri);
            Controls.Add(grpUyeBilgileri);
            Controls.Add(dataGridView1);
            Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EmanetKitapVerme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emanet Kitap Verme";
            Load += EmanetKitapVerme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpUyeBilgileri.ResumeLayout(false);
            grpUyeBilgileri.PerformLayout();
            grpKitapBilgileri.ResumeLayout(false);
            grpKitapBilgileri.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox grpUyeBilgileri;
        private GroupBox grpKitapBilgileri;
        private Label labelEmail;
        private Label labelTelefon;
        private Label labelAdSoyad;
        private Label labelTC;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTCKimlik;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePickerIade;
        private DateTimePicker dateTimePickerTeslim;
        private Label label6;
        private TextBox txtStokMiktari;
        private Label label5;
        private TextBox txtSayfaSayisi;
        private Label label1;
        private TextBox txtYayinevi;
        private Label label2;
        private TextBox txtBarkodNo;
        private Label label3;
        private TextBox txtKitapAdi;
        private Label labelBarkodNo;
        private TextBox txtYazari;
        private Label label9;
        private Button btnTeslimEt;
        private Button btnIptal;
        private Button btnSil;
        private Label lblKayitliKitap;
        private Label lblKayitliKitapSayi;
        private Label lblSepetKitap;
        private Label lblSepetKitapSayi;
        private Button button1;
        private ImageList ımageList1;
    }
}