using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace AyIşığıPansiyonKayıtUygulaması
{
    public partial class FrmGelirGider : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M1F4IS3\\SQLEXPRESS01;Initial Catalog=AyısıgıPansiyon;Integrated Security=True");
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //Kasadaki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //LblAlınanürünler1 labeline Gida fiyatları toplamını yazdıralım:
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gida) as toplam1 from AlinanUrunler ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlinanürünler1.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();

            // Lblalinanürünler2 labeline Icecek fiyatlarını toplamını yazdıralım:
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(Icecekler) as toplam2 from AlinanUrunler ", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlinanürünler2.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();

            //   Lblalinanürünler3 labeline Cerezler fiyatlarını toplamını yazdıralım:

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as toplam3 from AlinanUrunler ", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblAlinanürünler3.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            //Elektrik

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Elektrik) as toplam4 from Faturalar ", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblElektrik.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();

            //su

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su) as toplam5 from Faturalar ", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                LblSu.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();

            //İnternet

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(Internet) as toplam6 from Faturalar ", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                LblInternet.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();



        }





        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void TxtHesapla_Click(object sender, EventArgs e)
        {
            //Stokların Giderleri !!!!!
            int personel;
            if (int.TryParse(textBox1.Text, out personel))
            {
                // Conversion succeeded, continue with the rest of the code
                LblPersonelMaas.Text = (personel * 12000).ToString();
            }
            else
            {
                // Display an error message or take appropriate action
                MessageBox.Show("Invalid input. Please enter a valid integer value in the textbox.");
            }

            int sonuc = 0;

            sonuc = Convert.ToInt32(LblKasaToplam.Text) - (Convert.ToInt32(LblPersonelMaas.Text) + Convert.ToInt32(LblAlinanürünler1.Text) + Convert.ToInt32(LblAlinanürünler2.Text) + Convert.ToInt32(LblAlinanürünler3.Text) + Convert.ToInt32(LblElektrik.Text) + Convert.ToInt32(LblSu.Text) + Convert.ToInt32(LblInternet.Text));


            LblSonuc.Text = sonuc.ToString();
        }
    }
}
