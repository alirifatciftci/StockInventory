using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace StockInventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button showPasswordButton = new Button();
            showPasswordButton.Text = "Göster";
            showPasswordButton.Size = new Size(80, txtSifre.Height); // Butonun genişliğini artırdım
            showPasswordButton.Location = new Point(txtSifre.Right + 5, txtSifre.Top);
            showPasswordButton.FlatStyle = FlatStyle.Flat;
            showPasswordButton.BackColor = Color.LightGray;
            showPasswordButton.Cursor = Cursors.Hand;

            grsPanel.Controls.Add(showPasswordButton);

            showPasswordButton.Click += (s, ev) =>
            {
                if (txtSifre.UseSystemPasswordChar)
                {
                    txtSifre.UseSystemPasswordChar = false;
                    showPasswordButton.Text = "Gizle";
                }
                else
                {
                    txtSifre.UseSystemPasswordChar = true;
                    showPasswordButton.Text = "Göster";
                }
            };

            txtSifre.UseSystemPasswordChar = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void grsBtn_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            // App.config dosyasındaki bağlantı dizesini okuma
            string connectionString = ConfigurationManager.ConnectionStrings["StokTakipDBConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Kullanıcı adı ve şifreyi sorgulama
                    string query = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string rol = reader["Rol"].ToString();

                        // Rolüne göre ilgili formu açma
                        if (rol == "Yonetici")
                        {
                            YöneticiFormu yoneticiFormu = new YöneticiFormu();
                            yoneticiFormu.Show();
                            this.Hide(); // Giriş formunu gizle
                        }
                        else if (rol == "DepoSorumlusu")
                        {
                            DepoSorumlusuFormu depoFormu = new DepoSorumlusuFormu();
                            depoFormu.Show();
                            this.Hide(); // Giriş formunu gizle
                        }
                        else if (rol == "Calisan")
                        {
                            CalisanFormu calisanFormu = new CalisanFormu();
                            calisanFormu.Show();
                            this.Hide(); // Giriş formunu gizle
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
                }
            }

        }
    }
}
