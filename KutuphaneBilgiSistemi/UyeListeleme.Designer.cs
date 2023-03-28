namespace KutuphaneBilgiSistemi
{
    partial class UyeListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeListeleme));
            dataGridView1 = new DataGridView();
            label9 = new Label();
            btnIptal = new Button();
            ımageList1 = new ImageList(components);
            btnGuncelle = new Button();
            comboCinsiyet = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtOKS = new TextBox();
            txtEmail = new TextBox();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            txtYas = new TextBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            label10 = new Label();
            txtAra = new TextBox();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Green;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(528, 165);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(639, 337);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(441, 29);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(250, 37);
            label9.TabIndex = 42;
            label9.Text = "Üye Listeleme";
            // 
            // btnIptal
            // 
            btnIptal.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIptal.ImageAlign = ContentAlignment.MiddleLeft;
            btnIptal.ImageKey = "png-transparent-abort-delete-cancel-icon-cross-no-access-denied-thumbnail.png";
            btnIptal.ImageList = ımageList1;
            btnIptal.Location = new Point(379, 443);
            btnIptal.Margin = new Padding(4, 3, 4, 3);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(119, 45);
            btnIptal.TabIndex = 41;
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
            ımageList1.Images.SetKeyName(0, "icons8-user-male-512.png");
            ımageList1.Images.SetKeyName(1, "png-transparent-abort-delete-cancel-icon-cross-no-access-denied-thumbnail.png");
            ımageList1.Images.SetKeyName(2, "png-transparent-delete-key-logo-button-text-rectangle-logo.png");
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.ImageKey = "icons8-user-male-512.png";
            btnGuncelle.ImageList = ımageList1;
            btnGuncelle.Location = new Point(229, 443);
            btnGuncelle.Margin = new Padding(4, 3, 4, 3);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(132, 45);
            btnGuncelle.TabIndex = 40;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.TextAlign = ContentAlignment.MiddleRight;
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // comboCinsiyet
            // 
            comboCinsiyet.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboCinsiyet.FormattingEnabled = true;
            comboCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboCinsiyet.Location = new Point(229, 259);
            comboCinsiyet.Margin = new Padding(4, 3, 4, 3);
            comboCinsiyet.Name = "comboCinsiyet";
            comboCinsiyet.Size = new Size(269, 25);
            comboCinsiyet.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(37, 391);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(184, 19);
            label8.TabIndex = 38;
            label8.Text = "Okunan Kitap Sayısı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(37, 358);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 19);
            label7.TabIndex = 37;
            label7.Text = "E-Posta Adresi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 325);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 36;
            label6.Text = "Adres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(37, 292);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 35;
            label5.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 260);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 34;
            label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 227);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 33;
            label3.Text = "Yaş";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 194);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 32;
            label2.Text = "Adı Soyadı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 164);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 31;
            label1.Text = "TC Kimlik No";
            // 
            // txtOKS
            // 
            txtOKS.Location = new Point(229, 391);
            txtOKS.Margin = new Padding(4, 3, 4, 3);
            txtOKS.Name = "txtOKS";
            txtOKS.Size = new Size(269, 23);
            txtOKS.TabIndex = 30;
            txtOKS.Text = "0";
            txtOKS.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(229, 358);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 23);
            txtEmail.TabIndex = 29;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(229, 325);
            txtAdres.Margin = new Padding(4, 3, 4, 3);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(269, 23);
            txtAdres.TabIndex = 28;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(229, 292);
            txtTelefon.Margin = new Padding(4, 3, 4, 3);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(269, 23);
            txtTelefon.TabIndex = 27;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(229, 227);
            txtYas.Margin = new Padding(4, 3, 4, 3);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(269, 23);
            txtYas.TabIndex = 26;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(229, 194);
            txtAdSoyad.Margin = new Padding(4, 3, 4, 3);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(269, 23);
            txtAdSoyad.TabIndex = 25;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(229, 161);
            txtTC.Margin = new Padding(4, 3, 4, 3);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(269, 23);
            txtTC.TabIndex = 24;
            txtTC.TextChanged += txtTC_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Snap ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(693, 125);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(40, 19);
            label10.TabIndex = 44;
            label10.Text = "Ara";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(752, 125);
            txtAra.Margin = new Padding(4, 3, 4, 3);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(241, 23);
            txtAra.TabIndex = 43;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Snap ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageKey = "png-transparent-delete-key-logo-button-text-rectangle-logo.png";
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(1063, 114);
            btnSil.Margin = new Padding(4, 3, 4, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(104, 45);
            btnSil.TabIndex = 45;
            btnSil.Text = "Sil";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // UyeListeleme
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1198, 532);
            Controls.Add(btnSil);
            Controls.Add(label10);
            Controls.Add(txtAra);
            Controls.Add(label9);
            Controls.Add(btnIptal);
            Controls.Add(btnGuncelle);
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
            Controls.Add(dataGridView1);
            Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "UyeListeleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Listeleme";
            Load += UyeListeleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label9;
        private Button btnIptal;
        private Button btnGuncelle;
        private ComboBox comboCinsiyet;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtOKS;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private TextBox txtYas;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private Label label10;
        private TextBox txtAra;
        private Button btnSil;
        private ImageList ımageList1;
    }
}