using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StockInventory
{
    public partial class YöneticiFormu : Form
    {
        public YöneticiFormu()
        {
            InitializeComponent();
            // Form yüklendiğinde gerekli işlemleri başlatıyoruz
            this.Load += YöneticiFormu_Load;
        }

        private void YöneticiFormu_Load(object sender, EventArgs e)
        {
          
            // ComboBox'a roller ekleniyor
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Yonetici");
            cmbRol.Items.Add("DepoSorumlusu");
            cmbRol.Items.Add("Calisan");

            // Mevcut kullanıcıları DataGridView'e yüklüyoruz
            LoadKullanicilar();

            // Firma ayarları için (bölümler ve tedarikçiler) verileri yüklüyoruz
            LoadBolumler();
            LoadTedarikciler();

            // Stok raporları için verileri yüklüyoruz
            LoadStokRaporlari();

            // Başlangıçta sadece kullanıcı yönetimi görünür olsun
            groupKullaniciYonetimi.Visible = false;
            groupFirmaAyarları.Visible = false;
            groupStokRaporlari.Visible = false;
        }

        #region Kullanıcı Yönetimi

        private void btnYeniKullaniciEkle_Click(object sender, EventArgs e)
        {
            // Formdan verileri alıyoruz
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string rol = cmbRol.SelectedItem != null ? cmbRol.SelectedItem.ToString() : "";

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // App.config'den bağlantı dizesini alıyoruz
            string connectionString = ConfigurationManager.ConnectionStrings["StokTakipDBConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Rol) VALUES (@kAdi, @sifre, @rol)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kAdi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);
                        cmd.Parameters.AddWithValue("@rol", rol);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Yeni kullanıcı eklendi!");
                // İşlem sonrası DataGridView'i güncelliyoruz
                LoadKullanicilar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void LoadKullanicilar()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StokTakipDBConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Kullanicilar";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvKullanicilar.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcılar yüklenirken hata: " + ex.Message);
                }
            }
        }

        #endregion

        #region Firma Ayarları

        // Bölüm Yönetimi
        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            string bolumAdi = txtBolumAdi.Text.Trim(); // Doğru kontrolü kullanıyoruz
            if (string.IsNullOrEmpty(bolumAdi))
            {
                MessageBox.Show("Lütfen bölüm adını girin.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["StokTakipDBConnectionString"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Bolumler (BolumAdi) VALUES (@bolumAdi)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@bolumAdi", bolumAdi);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Bölüm eklendi!");
                txtBolumAdi.Clear(); // TextBox'ı temizle
                LoadBolumler(); // Bölümleri tekrar yükle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void LoadBolumler()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StokTakipDBConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Bolumler";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBolumler.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bölümler yüklenirken hata: " + ex.Message);
                }
            }
        }

        // Tedarikçi Yönetimi
        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            string tedarikciAdi = txtTedarikciAdi.Text.Trim();
            if (string.IsNullOrEmpty(tedarikciAdi))
            {
                MessageBox.Show("Lütfen tedarikçi adını girin.");
                return;
            }
            string connectionString = ConfigurationManager.ConnectionStrings["StokTakipDBConnectionString"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Tedarikciler (TedarikciAdi) VALUES (@tedarikciAdi)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tedarikciAdi", tedarikciAdi);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Tedarikçi eklendi!");
                LoadTedarikciler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void LoadTedarikciler()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StokTakipDBConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Tedarikciler";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTedarikciler.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tedarikçiler yüklenirken hata: " + ex.Message);
                }
            }
        }

        #endregion

        #region Stok Raporları

        private void btnStokRaporYenile_Click(object sender, EventArgs e)
        {
            LoadStokRaporlari();
        }

        private void LoadStokRaporlari()
        {
            // Malzemeler tablosundan stok bilgilerini çekiyoruz
            string connectionString = ConfigurationManager.ConnectionStrings["StokTakipDBConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Örneğin: MalzemeAdi, Miktar, Birim sütunları
                    string query = "SELECT MalzemeAdi, Miktar, Birim FROM Malzemeler";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvStokRaporlari.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Stok raporları yüklenirken hata: " + ex.Message);
                }
            }
        }

        #endregion

        #region Menü Seçimleri

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupKullaniciYonetimi.Visible = true;
            groupKullaniciYonetimi.Dock = DockStyle.Fill; // Ekranın tamamını kaplasın
            groupFirmaAyarları.Visible = false;
            groupStokRaporlari.Visible = false;    
        }

        private void firmaAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupFirmaAyarları.Visible = true;
            groupKullaniciYonetimi.Visible = false;
            groupStokRaporlari.Visible = false;
        }

        private void stokRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupStokRaporlari.Visible = true;
            groupFirmaAyarları.Visible = false;
            groupKullaniciYonetimi.Visible = false;
        }

        #endregion

        // Opsiyonel GroupBox Enter event'leri
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void groupFirmaAyarları_Enter(object sender, EventArgs e)
        {
        }

        private void groupStokRaporlari_Enter(object sender, EventArgs e)
        {
        }

        private void btnBolumEkle_Click_1(object sender, EventArgs e)
        {

        }

        private void YöneticiFormu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
