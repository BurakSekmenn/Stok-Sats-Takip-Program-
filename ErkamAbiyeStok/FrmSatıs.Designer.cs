
namespace ErkamAbiyeStok
{
    partial class FrmSatıs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatıs));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsatısadsoyad = new System.Windows.Forms.TextBox();
            this.txtsatanid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.label17 = new System.Windows.Forms.Label();
            this.txtsatishesapla = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtsatıstutarı = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txttür = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsatistip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txturunktg = new System.Windows.Forms.TextBox();
            this.txturunrenk = new System.Windows.Forms.TextBox();
            this.txturunbdn = new System.Windows.Forms.TextBox();
            this.txturunkod = new System.Windows.Forms.TextBox();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uruntoplamfiyat = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Lblgizli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(780, 534);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsatısadsoyad);
            this.groupBox1.Controls.Add(this.txtsatanid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(798, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satan Kişi Bilgileri";
            // 
            // txtsatısadsoyad
            // 
            this.txtsatısadsoyad.Location = new System.Drawing.Point(147, 60);
            this.txtsatısadsoyad.Name = "txtsatısadsoyad";
            this.txtsatısadsoyad.Size = new System.Drawing.Size(141, 20);
            this.txtsatısadsoyad.TabIndex = 3;
            // 
            // txtsatanid
            // 
            this.txtsatanid.Location = new System.Drawing.Point(147, 17);
            this.txtsatanid.Name = "txtsatanid";
            this.txtsatanid.Size = new System.Drawing.Size(141, 20);
            this.txtsatanid.TabIndex = 2;
            this.txtsatanid.TextChanged += new System.EventHandler(this.txtsatisid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satış Yapan Adı Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satış Yapan Kişi No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.simpleButton5);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtsatishesapla);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.txtsatıstutarı);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txttür);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtsatistip);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txturunktg);
            this.groupBox2.Controls.Add(this.txturunrenk);
            this.groupBox2.Controls.Add(this.txturunbdn);
            this.groupBox2.Controls.Add(this.txturunkod);
            this.groupBox2.Controls.Add(this.txturunad);
            this.groupBox2.Controls.Add(this.txtbarkod);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(798, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 454);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 373);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 55;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 14, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 173);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(135, 326);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(161, 37);
            this.simpleButton5.TabIndex = 32;
            this.simpleButton5.Text = "Toplam Tutarı Hesapla";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(43, 278);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Satış Tutarı :";
            // 
            // txtsatishesapla
            // 
            this.txtsatishesapla.Location = new System.Drawing.Point(147, 277);
            this.txtsatishesapla.Name = "txtsatishesapla";
            this.txtsatishesapla.Size = new System.Drawing.Size(141, 20);
            this.txtsatishesapla.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 179);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Satış Miktari :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(20, 379);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(82, 13);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "Ürün Satış Tarih :";
            // 
            // txtsatıstutarı
            // 
            this.txtsatıstutarı.Enabled = false;
            this.txtsatıstutarı.Location = new System.Drawing.Point(147, 301);
            this.txtsatıstutarı.Name = "txtsatıstutarı";
            this.txtsatıstutarı.Size = new System.Drawing.Size(141, 20);
            this.txtsatıstutarı.TabIndex = 22;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(83, 413);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(169, 35);
            this.simpleButton1.TabIndex = 27;
            this.simpleButton1.Text = "Sepete Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(170, 396);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "*İlk Ay sonra gün sonra yıl";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Toplam Tutarı :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Satış Türü :";
            // 
            // txttür
            // 
            this.txttür.Location = new System.Drawing.Point(147, 253);
            this.txttür.Name = "txttür";
            this.txttür.Size = new System.Drawing.Size(141, 20);
            this.txttür.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(214, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "2= Kart";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(144, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "1= Peşin";
            // 
            // txtsatistip
            // 
            this.txtsatistip.Location = new System.Drawing.Point(147, 201);
            this.txtsatistip.MaxLength = 2;
            this.txtsatistip.Name = "txtsatistip";
            this.txtsatistip.Size = new System.Drawing.Size(141, 20);
            this.txtsatistip.TabIndex = 16;
            this.txtsatistip.TextChanged += new System.EventHandler(this.txtsatistip_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Satış Tipi :";
            // 
            // txturunktg
            // 
            this.txturunktg.Location = new System.Drawing.Point(147, 146);
            this.txturunktg.Name = "txturunktg";
            this.txturunktg.Size = new System.Drawing.Size(141, 20);
            this.txturunktg.TabIndex = 14;
            // 
            // txturunrenk
            // 
            this.txturunrenk.Location = new System.Drawing.Point(147, 118);
            this.txturunrenk.Name = "txturunrenk";
            this.txturunrenk.Size = new System.Drawing.Size(141, 20);
            this.txturunrenk.TabIndex = 11;
            // 
            // txturunbdn
            // 
            this.txturunbdn.Location = new System.Drawing.Point(147, 88);
            this.txturunbdn.Name = "txturunbdn";
            this.txturunbdn.Size = new System.Drawing.Size(141, 20);
            this.txturunbdn.TabIndex = 10;
            // 
            // txturunkod
            // 
            this.txturunkod.Location = new System.Drawing.Point(147, 62);
            this.txturunkod.Name = "txturunkod";
            this.txturunkod.Size = new System.Drawing.Size(141, 20);
            this.txturunkod.TabIndex = 9;
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(147, 36);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(141, 20);
            this.txturunad.TabIndex = 8;
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(147, 10);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(141, 20);
            this.txtbarkod.TabIndex = 4;
            this.txtbarkod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ürün Kategori :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ürün Renk :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ürün Beden :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ürün Kodu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ürün Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Barkod :";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(1162, 297);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton4.Size = new System.Drawing.Size(132, 42);
            this.simpleButton4.TabIndex = 2;
            this.simpleButton4.Text = "Siparişi Sil";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(1162, 237);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton3.Size = new System.Drawing.Size(132, 38);
            this.simpleButton3.TabIndex = 1;
            this.simpleButton3.Text = "Sepeti Sil";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(1148, 359);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(160, 40);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Siparişi Tamamla";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uruntoplamfiyat);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(1122, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(220, 174);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // uruntoplamfiyat
            // 
            this.uruntoplamfiyat.AutoSize = true;
            this.uruntoplamfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uruntoplamfiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uruntoplamfiyat.Location = new System.Drawing.Point(36, 67);
            this.uruntoplamfiyat.Name = "uruntoplamfiyat";
            this.uruntoplamfiyat.Size = new System.Drawing.Size(164, 20);
            this.uruntoplamfiyat.TabIndex = 1;
            this.uruntoplamfiyat.Text = "Toplam Satış Tutarı";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(53, 28);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Toplam Ürün Fiyat :";
            // 
            // Lblgizli
            // 
            this.Lblgizli.AutoSize = true;
            this.Lblgizli.Location = new System.Drawing.Point(1145, 461);
            this.Lblgizli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lblgizli.Name = "Lblgizli";
            this.Lblgizli.Size = new System.Drawing.Size(41, 13);
            this.Lblgizli.TabIndex = 5;
            this.Lblgizli.Text = "label18";
            this.Lblgizli.Visible = false;
            // 
            // FrmSatıs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 561);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.Lblgizli);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmSatıs";
            this.Text = "Satış Yap";
            this.Load += new System.EventHandler(this.FrmSatıs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsatısadsoyad;
        private System.Windows.Forms.TextBox txtsatanid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txturunktg;
        private System.Windows.Forms.TextBox txturunrenk;
        private System.Windows.Forms.TextBox txturunbdn;
        private System.Windows.Forms.TextBox txturunkod;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsatistip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttür;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtsatıstutarı;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label uruntoplamfiyat;
        private System.Windows.Forms.TextBox txtsatishesapla;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Lblgizli;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}