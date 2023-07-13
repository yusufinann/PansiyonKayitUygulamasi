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
    public partial class FrmMusteriler : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M1F4IS3\\SQLEXPRESS01;Initial Catalog=AyısıgıPansiyon;Integrated Security=True");
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        private void verilergoster()
        {
            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT*FROM MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())   //oku komutu çalıştığı sürece
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void BtnVerileriGoster_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            verilergoster();
        }


        //listview double click olayını yapalım:
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtBoxTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (TxtOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("DELETE FROM Oda101", baglanti);//FrmMusteriler formundaki silme butonu iie Odalar ve yenimüşteri ekleme formundaki dolu ve boş odaları gösteren butonlarda silme işlemi için komut.
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("DELETE FROM Oda102", baglanti);//FrmMusteriler formundaki silme butonu iie Odalar ve yenimüşteri ekleme formundaki dolu ve boş odaları gösteren butonlarda silme işlemi için komut.
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            if (TxtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("DELETE FROM Oda103", baglanti);//FrmMusteriler formundaki silme butonu iie Odalar ve yenimüşteri ekleme formundaki dolu ve boş odaları gösteren butonlarda silme işlemi için komut.
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            if (TxtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("DELETE FROM Oda104", baglanti);//FrmMusteriler formundaki silme butonu iie Odalar ve yenimüşteri ekleme formundaki dolu ve boş odaları gösteren butonlarda silme işlemi için komut.
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            if (TxtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("DELETE FROM Oda105", baglanti);//FrmMusteriler formundaki silme butonu iie Odalar ve yenimüşteri ekleme formundaki dolu ve boş odaları gösteren butonlarda silme işlemi için komut.
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            if (TxtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("DELETE FROM Oda106", baglanti);//FrmMusteriler formundaki silme butonu iie Odalar ve yenimüşteri ekleme formundaki dolu ve boş odaları gösteren butonlarda silme işlemi için komut.
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            if (TxtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("DELETE FROM Oda107", baglanti);//FrmMusteriler formundaki silme butonu iie Odalar ve yenimüşteri ekleme formundaki dolu ve boş odaları gösteren butonlarda silme işlemi için komut.
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            if (TxtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("DELETE FROM Oda108", baglanti);//FrmMusteriler formundaki silme butonu iie Odalar ve yenimüşteri ekleme formundaki dolu ve boş odaları gösteren butonlarda silme işlemi için komut.
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
            if (TxtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("DELETE FROM Oda109", baglanti);//FrmMusteriler formundaki silme butonu iie Odalar ve yenimüşteri ekleme formundaki dolu ve boş odaları gösteren butonlarda silme işlemi için komut.
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("DELETE FROM MusteriEkle where Musteriid =(" + id + ")", baglanti);//FrmMusteriler formundaki silme butonu için komut.
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MskTxtBoxTelefon.Text = "";
            TxtMail.Clear();
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + MskTxtBoxTelefon.Text + "',Mail='" + TxtMail.Text + "', TC='" + TxtKimlikNo.Text + "',OdaNo='" + TxtOdaNo.Text + "',Ucret='" + TxtUcret.Text + "',GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "'  where Musteriid = (" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT*FROM MusteriEkle WHERE Adi like '%" + TxtAra.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())   //oku komutu çalıştığı sürece
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
    }
}
