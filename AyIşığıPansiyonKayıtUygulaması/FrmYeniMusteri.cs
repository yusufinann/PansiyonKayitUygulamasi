﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace AyIşığıPansiyonKayıtUygulaması
{
    public partial class FrmYeniMusteri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M1F4IS3\\SQLEXPRESS01;Initial Catalog=AyısıgıPansiyon;Integrated Security=True");
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + comboBox1.Text + "','" + MskTxtBoxTelefon.Text + "','" + TxtMail.Text + "','" + TxtKimlikNo.Text + "','" + TxtOdaNo.Text + "','" + TxtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void TxtOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void TxtOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void TxtOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void TxtOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void TxtOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

        private void TxtOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void TxtOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void TxtOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109 (Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void TxtUcret_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;
            label11.Text = Sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 1000;
            TxtUcret.Text = ucret.ToString();

        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            //Oda101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select*from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();



            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }




            //Oda102

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select*from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }



            //Oda103

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select*from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                BtnOda101.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();


            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }




            //
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select*from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }


            //Oda105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select*from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }


            //Oda106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select*from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }




            //Oda107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select*from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.Enabled = false;
            }



            //Oda108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select*from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda108.Text != "108")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda108.Enabled = false;
            }


            //Oda109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select*from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.Enabled = false;
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli odalar dolu odaları göstermektedir.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli odalar boş odaları göstermektedir.");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            
        }
    }
}
