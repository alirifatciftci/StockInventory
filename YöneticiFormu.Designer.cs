namespace StockInventory
{
    partial class YöneticiFormu
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
            menuStrip1 = new MenuStrip();
            kullanıcıYönetimiToolStripMenuItem = new ToolStripMenuItem();
            firmaAyarlarıToolStripMenuItem = new ToolStripMenuItem();
            stokRaporlarıToolStripMenuItem = new ToolStripMenuItem();
            groupKullaniciYonetimi = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnYeniKullaniciEkle = new Button();
            cmbRol = new ComboBox();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            dgvKullanicilar = new DataGridView();
            groupFirmaAyarları = new GroupBox();
            label5 = new Label();
            dgvTedarikciler = new DataGridView();
            btnTedarikciEkle = new Button();
            txtTedarikciAdi = new TextBox();
            label4 = new Label();
            dgvBolumler = new DataGridView();
            btnBolumEkle = new Button();
            txtBolumAdi = new TextBox();
            groupStokRaporlari = new GroupBox();
            btnStokRaporYenile = new Button();
            dgvStokRaporlari = new DataGridView();
            menuStrip1.SuspendLayout();
            groupKullaniciYonetimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            groupFirmaAyarları.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTedarikciler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBolumler).BeginInit();
            groupStokRaporlari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStokRaporlari).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { kullanıcıYönetimiToolStripMenuItem, firmaAyarlarıToolStripMenuItem, stokRaporlarıToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(306, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıYönetimiToolStripMenuItem
            // 
            kullanıcıYönetimiToolStripMenuItem.Name = "kullanıcıYönetimiToolStripMenuItem";
            kullanıcıYönetimiToolStripMenuItem.Size = new Size(114, 20);
            kullanıcıYönetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            kullanıcıYönetimiToolStripMenuItem.Click += kullanıcıYönetimiToolStripMenuItem_Click;
            // 
            // firmaAyarlarıToolStripMenuItem
            // 
            firmaAyarlarıToolStripMenuItem.Name = "firmaAyarlarıToolStripMenuItem";
            firmaAyarlarıToolStripMenuItem.Size = new Size(92, 20);
            firmaAyarlarıToolStripMenuItem.Text = "Firma Ayarları";
            firmaAyarlarıToolStripMenuItem.Click += firmaAyarlarıToolStripMenuItem_Click;
            // 
            // stokRaporlarıToolStripMenuItem
            // 
            stokRaporlarıToolStripMenuItem.Name = "stokRaporlarıToolStripMenuItem";
            stokRaporlarıToolStripMenuItem.Size = new Size(92, 20);
            stokRaporlarıToolStripMenuItem.Text = "Stok Raporları";
            stokRaporlarıToolStripMenuItem.Click += stokRaporlarıToolStripMenuItem_Click;
            // 
            // groupKullaniciYonetimi
            // 
            groupKullaniciYonetimi.Controls.Add(label3);
            groupKullaniciYonetimi.Controls.Add(label2);
            groupKullaniciYonetimi.Controls.Add(label1);
            groupKullaniciYonetimi.Controls.Add(btnYeniKullaniciEkle);
            groupKullaniciYonetimi.Controls.Add(cmbRol);
            groupKullaniciYonetimi.Controls.Add(txtSifre);
            groupKullaniciYonetimi.Controls.Add(txtKullaniciAdi);
            groupKullaniciYonetimi.Controls.Add(dgvKullanicilar);
            groupKullaniciYonetimi.Location = new Point(22, 63);
            groupKullaniciYonetimi.Name = "groupKullaniciYonetimi";
            groupKullaniciYonetimi.Size = new Size(442, 561);
            groupKullaniciYonetimi.TabIndex = 1;
            groupKullaniciYonetimi.TabStop = false;
            groupKullaniciYonetimi.Text = "Kullanici Yonetimi";
            groupKullaniciYonetimi.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 392);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "Rol Seciniz : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 346);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Sifre : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 320);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 5;
            label1.Text = "Kullanici Adi : ";
            // 
            // btnYeniKullaniciEkle
            // 
            btnYeniKullaniciEkle.BackColor = Color.PaleGreen;
            btnYeniKullaniciEkle.ForeColor = Color.Black;
            btnYeniKullaniciEkle.Location = new Point(107, 428);
            btnYeniKullaniciEkle.Name = "btnYeniKullaniciEkle";
            btnYeniKullaniciEkle.Size = new Size(121, 23);
            btnYeniKullaniciEkle.TabIndex = 4;
            btnYeniKullaniciEkle.Text = "Yeni Kullanici Ekle";
            btnYeniKullaniciEkle.UseVisualStyleBackColor = false;
            btnYeniKullaniciEkle.Click += btnYeniKullaniciEkle_Click;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "DepoSorumlusu", "Calisan", "Yonetici" });
            cmbRol.Location = new Point(107, 389);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(107, 346);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 2;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(107, 317);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(100, 23);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // dgvKullanicilar
            // 
            dgvKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilar.Location = new Point(14, 32);
            dgvKullanicilar.Name = "dgvKullanicilar";
            dgvKullanicilar.Size = new Size(307, 242);
            dgvKullanicilar.TabIndex = 0;
            // 
            // groupFirmaAyarları
            // 
            groupFirmaAyarları.Controls.Add(label5);
            groupFirmaAyarları.Controls.Add(dgvTedarikciler);
            groupFirmaAyarları.Controls.Add(btnTedarikciEkle);
            groupFirmaAyarları.Controls.Add(txtTedarikciAdi);
            groupFirmaAyarları.Controls.Add(label4);
            groupFirmaAyarları.Controls.Add(dgvBolumler);
            groupFirmaAyarları.Controls.Add(btnBolumEkle);
            groupFirmaAyarları.Controls.Add(txtBolumAdi);
            groupFirmaAyarları.Location = new Point(500, 63);
            groupFirmaAyarları.Name = "groupFirmaAyarları";
            groupFirmaAyarları.Size = new Size(431, 561);
            groupFirmaAyarları.TabIndex = 2;
            groupFirmaAyarları.TabStop = false;
            groupFirmaAyarları.Text = "Firma Ayarları";
            groupFirmaAyarları.Enter += groupFirmaAyarları_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 35);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 8;
            label5.Text = "Bölüm Adi :";
            // 
            // dgvTedarikciler
            // 
            dgvTedarikciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTedarikciler.Location = new Point(6, 349);
            dgvTedarikciler.Name = "dgvTedarikciler";
            dgvTedarikciler.Size = new Size(388, 143);
            dgvTedarikciler.TabIndex = 7;
            // 
            // btnTedarikciEkle
            // 
            btnTedarikciEkle.BackColor = Color.FromArgb(128, 255, 128);
            btnTedarikciEkle.Location = new Point(114, 300);
            btnTedarikciEkle.Name = "btnTedarikciEkle";
            btnTedarikciEkle.Size = new Size(100, 23);
            btnTedarikciEkle.TabIndex = 6;
            btnTedarikciEkle.Text = "Tedarikçi Ekle";
            btnTedarikciEkle.UseVisualStyleBackColor = false;
            btnTedarikciEkle.Click += btnTedarikciEkle_Click;
            // 
            // txtTedarikciAdi
            // 
            txtTedarikciAdi.Location = new Point(114, 251);
            txtTedarikciAdi.Name = "txtTedarikciAdi";
            txtTedarikciAdi.Size = new Size(100, 23);
            txtTedarikciAdi.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 254);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 4;
            label4.Text = "Tedarikçi Adı : ";
            // 
            // dgvBolumler
            // 
            dgvBolumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBolumler.Location = new Point(6, 115);
            dgvBolumler.Name = "dgvBolumler";
            dgvBolumler.Size = new Size(388, 106);
            dgvBolumler.TabIndex = 2;
            // 
            // btnBolumEkle
            // 
            btnBolumEkle.BackColor = Color.FromArgb(128, 255, 128);
            btnBolumEkle.Location = new Point(114, 75);
            btnBolumEkle.Name = "btnBolumEkle";
            btnBolumEkle.Size = new Size(100, 23);
            btnBolumEkle.TabIndex = 1;
            btnBolumEkle.Text = "Bölüm Ekle";
            btnBolumEkle.UseVisualStyleBackColor = false;
            btnBolumEkle.Click += btnBolumEkle_Click;
            // 
            // txtBolumAdi
            // 
            txtBolumAdi.Location = new Point(114, 32);
            txtBolumAdi.Name = "txtBolumAdi";
            txtBolumAdi.Size = new Size(100, 23);
            txtBolumAdi.TabIndex = 0;
            // 
            // groupStokRaporlari
            // 
            groupStokRaporlari.Controls.Add(btnStokRaporYenile);
            groupStokRaporlari.Controls.Add(dgvStokRaporlari);
            groupStokRaporlari.Location = new Point(985, 63);
            groupStokRaporlari.Name = "groupStokRaporlari";
            groupStokRaporlari.Size = new Size(473, 550);
            groupStokRaporlari.TabIndex = 3;
            groupStokRaporlari.TabStop = false;
            groupStokRaporlari.Text = "Stok Raporları";
            groupStokRaporlari.Enter += groupStokRaporlari_Enter;
            // 
            // btnStokRaporYenile
            // 
            btnStokRaporYenile.BackColor = Color.FromArgb(128, 255, 128);
            btnStokRaporYenile.Location = new Point(79, 396);
            btnStokRaporYenile.Name = "btnStokRaporYenile";
            btnStokRaporYenile.Size = new Size(216, 23);
            btnStokRaporYenile.TabIndex = 8;
            btnStokRaporYenile.Text = "Stok Rapor Yenile";
            btnStokRaporYenile.UseVisualStyleBackColor = false;
            // 
            // dgvStokRaporlari
            // 
            dgvStokRaporlari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStokRaporlari.Location = new Point(79, 52);
            dgvStokRaporlari.Name = "dgvStokRaporlari";
            dgvStokRaporlari.Size = new Size(307, 317);
            dgvStokRaporlari.TabIndex = 8;
            // 
            // YöneticiFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1533, 675);
            Controls.Add(groupFirmaAyarları);
            Controls.Add(groupStokRaporlari);
            Controls.Add(menuStrip1);
            Controls.Add(groupKullaniciYonetimi);
            MainMenuStrip = menuStrip1;
            Name = "YöneticiFormu";
            Text = "YöneticiFormu";
            Load += YöneticiFormu_Load_1;
            Click += YöneticiFormu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupKullaniciYonetimi.ResumeLayout(false);
            groupKullaniciYonetimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            groupFirmaAyarları.ResumeLayout(false);
            groupFirmaAyarları.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTedarikciler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBolumler).EndInit();
            groupStokRaporlari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStokRaporlari).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kullanıcıYönetimiToolStripMenuItem;
        private ToolStripMenuItem firmaAyarlarıToolStripMenuItem;
        private ToolStripMenuItem stokRaporlarıToolStripMenuItem;
        private GroupBox groupKullaniciYonetimi;
        private ComboBox cmbRol;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private DataGridView dgvKullanicilar;
        private Button btnYeniKullaniciEkle;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupFirmaAyarları;
        private GroupBox groupStokRaporlari;
        private Label label5;
        private DataGridView dgvBolumler;
        private Button btnBolumEkle;
        private TextBox txtBolumAdi;
        private DataGridView dgvTedarikciler;
        private Button btnTedarikciEkle;
        private TextBox txtTedarikciAdi;
        private Label label4;
        private Button btnStokRaporYenile;
        private DataGridView dgvStokRaporlari;
    }
}