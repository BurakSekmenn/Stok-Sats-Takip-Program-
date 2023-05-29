
namespace ErkamAbiyeStok
{
    partial class FrmFirmalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirmalar));
            this.MskCep2 = new System.Windows.Forms.MaskedTextBox();
            this.MskCep1 = new System.Windows.Forms.MaskedTextBox();
            this.TxtFmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtFyet = new System.Windows.Forms.TextBox();
            this.TxtFad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // TxtFmail
            // 
            this.TxtFmail.Location = new System.Drawing.Point(166, 268);
            this.TxtFmail.Name = "TxtFmail";
            this.TxtFmail.Size = new System.Drawing.Size(162, 20);
            this.TxtFmail.TabIndex = 6;
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
            this.btnguncelle.Appearance.Options.UseFont = true;
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(134, 377);
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
            this.btnsil.Location = new System.Drawing.Point(207, 321);
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
            this.btnkaydet.Appearance.Options.UseFont = true;
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(53, 321);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnkaydet.Size = new System.Drawing.Size(132, 43);
            this.btnkaydet.TabIndex = 8;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtFyet
            // 
            this.txtFyet.Location = new System.Drawing.Point(166, 125);
            this.txtFyet.Name = "txtFyet";
            this.txtFyet.Size = new System.Drawing.Size(162, 20);
            this.txtFyet.TabIndex = 3;
            // 
            // TxtFad
            // 
            this.TxtFad.Location = new System.Drawing.Point(166, 78);
            this.TxtFad.Name = "TxtFad";
            this.TxtFad.Size = new System.Drawing.Size(162, 20);
            this.TxtFad.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yetkili Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yetkili Cep 2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yetkili Cep 1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Firma Yetkili :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firma Adı :";
            // 
            // txtFid
            // 
            this.txtFid.Enabled = false;
            this.txtFid.Location = new System.Drawing.Point(166, 25);
            this.txtFid.Name = "txtFid";
            this.txtFid.Size = new System.Drawing.Size(162, 20);
            this.txtFid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fİrma Sırası :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MskCep2);
            this.groupBox1.Controls.Add(this.MskCep1);
            this.groupBox1.Controls.Add(this.TxtFmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.txtFyet);
            this.groupBox1.Controls.Add(this.TxtFad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(942, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 534);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(934, 534);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmFirmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmFirmalar";
            this.Text = "Firma Bilgileri";
            this.Load += new System.EventHandler(this.FrmFirmalar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MskCep2;
        private System.Windows.Forms.MaskedTextBox MskCep1;
        private System.Windows.Forms.TextBox TxtFmail;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private System.Windows.Forms.TextBox txtFyet;
        private System.Windows.Forms.TextBox TxtFad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}