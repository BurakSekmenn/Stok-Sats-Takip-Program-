
namespace ErkamAbiyeStok
{
    partial class FrmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MskCep2 = new System.Windows.Forms.MaskedTextBox();
            this.MskCep1 = new System.Windows.Forms.MaskedTextBox();
            this.TxtMmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rchMnot = new System.Windows.Forms.RichTextBox();
            this.TxtMsoyad = new System.Windows.Forms.TextBox();
            this.TxtMad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(934, 534);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MskCep2);
            this.groupBox1.Controls.Add(this.MskCep1);
            this.groupBox1.Controls.Add(this.TxtMmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.rchMnot);
            this.groupBox1.Controls.Add(this.TxtMsoyad);
            this.groupBox1.Controls.Add(this.TxtMad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(943, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 534);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müsteri Bilgileri";
            // 
            // MskCep2
            // 
            this.MskCep2.Location = new System.Drawing.Point(166, 222);
            this.MskCep2.Mask = "0000000000";
            this.MskCep2.Name = "MskCep2";
            this.MskCep2.Size = new System.Drawing.Size(162, 20);
            this.MskCep2.TabIndex = 5;
            // 
            // MskCep1
            // 
            this.MskCep1.Location = new System.Drawing.Point(166, 173);
            this.MskCep1.Mask = "0000000000";
            this.MskCep1.Name = "MskCep1";
            this.MskCep1.Size = new System.Drawing.Size(162, 20);
            this.MskCep1.TabIndex = 4;
            // 
            // TxtMmail
            // 
            this.TxtMmail.Location = new System.Drawing.Point(166, 268);
            this.TxtMmail.Name = "TxtMmail";
            this.TxtMmail.Size = new System.Drawing.Size(162, 20);
            this.TxtMmail.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Başında 0 olmadan giriniz";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnguncelle.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btnguncelle.Appearance.Options.UseFont = true;
            this.btnguncelle.Appearance.Options.UseForeColor = true;
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(130, 463);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnguncelle.Size = new System.Drawing.Size(152, 39);
            this.btnguncelle.TabIndex = 10;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(203, 407);
            this.btnsil.Name = "btnsil";
            this.btnsil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnsil.Size = new System.Drawing.Size(151, 43);
            this.btnsil.TabIndex = 9;
            this.btnsil.Text = "SİL";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnkaydet.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnkaydet.Appearance.Options.UseFont = true;
            this.btnkaydet.Appearance.Options.UseForeColor = true;
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(49, 407);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnkaydet.Size = new System.Drawing.Size(132, 43);
            this.btnkaydet.TabIndex = 8;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // rchMnot
            // 
            this.rchMnot.Location = new System.Drawing.Point(166, 320);
            this.rchMnot.Name = "rchMnot";
            this.rchMnot.Size = new System.Drawing.Size(162, 65);
            this.rchMnot.TabIndex = 7;
            this.rchMnot.Text = "";
            // 
            // TxtMsoyad
            // 
            this.TxtMsoyad.Location = new System.Drawing.Point(166, 125);
            this.TxtMsoyad.Name = "TxtMsoyad";
            this.TxtMsoyad.Size = new System.Drawing.Size(162, 20);
            this.TxtMsoyad.TabIndex = 3;
            // 
            // TxtMad
            // 
            this.TxtMad.Location = new System.Drawing.Point(166, 78);
            this.TxtMad.Name = "TxtMad";
            this.TxtMad.Size = new System.Drawing.Size(162, 20);
            this.TxtMad.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Musteri Notlar :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Musteri Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Musteri Cep2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Musteri Cep :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Musteri Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Musteri Adı :";
            // 
            // txtMid
            // 
            this.txtMid.Enabled = false;
            this.txtMid.Location = new System.Drawing.Point(166, 25);
            this.txtMid.Name = "txtMid";
            this.txtMid.Size = new System.Drawing.Size(162, 20);
            this.txtMid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Musteri Sırası :";
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMusteriler";
            this.Text = "Müşteri Bilgileri";
            this.Load += new System.EventHandler(this.FrmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMad;
        private System.Windows.Forms.RichTextBox rchMnot;
        private System.Windows.Forms.TextBox TxtMsoyad;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtMmail;
        private System.Windows.Forms.MaskedTextBox MskCep1;
        private System.Windows.Forms.MaskedTextBox MskCep2;
    }
}