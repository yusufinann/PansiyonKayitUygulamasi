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
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace AyIşığıPansiyonKayıtUygulaması
{
    public partial class FrmMusteriMesaj : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M1F4IS3\\SQLEXPRESS01;Initial Catalog=AyısıgıPansiyon;Integrated Security=True");

        public FrmMusteriMesaj()
        {
            InitializeComponent();
        }

        private void BtnMesajGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar(AdSoyad,Mesaj) values('" + TxtAdSoyad.Text + "','" + TxtMesaj.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            TxtAdSoyad.Clear();
            TxtMesaj.Clear();

            verilergoster();



        }

        private void verilergoster()
        {
            // Sqldeki Mesajlar tablosunu listview'e çekelim:

            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT*FROM Mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())   //oku komutu çalıştığı sürece
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
               


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmMusteriMesaj_Load(object sender, EventArgs e)
        {
            verilergoster();
        }


        
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
       


        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        int id = 0;
        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdSoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtMesaj.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
