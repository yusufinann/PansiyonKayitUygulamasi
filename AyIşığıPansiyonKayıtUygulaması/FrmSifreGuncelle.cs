using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;


namespace AyIşığıPansiyonKayıtUygulaması
{
    public partial class FrmSifreGuncelle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M1F4IS3\\SQLEXPRESS01;Initial Catalog=AyısıgıPansiyon;Integrated Security=True");

        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }

       
        private void FrmSifreGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set KullaniciAdi='" + TxtKullanici.Text + "',Sifre='" + TxtSifre.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Admin Giriş Bilgileriniz Güncellendi");
        }
    }
}
