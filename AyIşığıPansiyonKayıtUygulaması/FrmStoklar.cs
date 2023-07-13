using System;
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


namespace AyIşığıPansiyonKayıtUygulaması
{

    public partial class FrmStoklar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M1F4IS3\\SQLEXPRESS01;Initial Catalog=AyısıgıPansiyon;Integrated Security=True");

        public FrmStoklar()
        {
            InitializeComponent();
        }

        private void verilergoster()
        {
            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT*FROM AlinanUrunler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())   //oku komutu çalıştığı sürece
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["Icecekler"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void verilergoster2()
        {

            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select*from Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["Internet"].ToString());

                listView2.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            verilergoster();   //Stoklar(Alınan ürünler) için

            verilergoster2(); //Faturalar için

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AlinanUrunler(Gida,Icecekler,Cerezler) values('" + TxtGida.Text + "','" + TxtIcecek.Text + "','" + TxtIcecek.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            verilergoster();
        }

        private void BtnVerileriGoster_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Faturalar(Elektrik,Su,Internet) values('" + TxtElektrik.Text + "','" + TxtSu.Text + "','" + TxtInternet.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            verilergoster2(); //insert işleminden sonra tablom yeni insert edilmiş  haliyle gözüksün.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtGida.Clear();
            TxtIcecek.Clear();
            TxtCerez.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtElektrik.Clear();
            TxtSu.Clear();
            TxtInternet.Clear();
        }
    }
}
