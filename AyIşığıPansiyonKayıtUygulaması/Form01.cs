using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Reflection.Emit;



namespace AyIşığıPansiyonKayıtUygulaması
{
    public partial class FrmAdminGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-M1F4IS3\\SQLEXPRESS01;Initial Catalog=AyısıgıPansiyon;Integrated Security=True");

        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select*from AdminGiris where KullaniciAdi=@KullaniciAdi and Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi", TxtKullanici.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();

                }
                FrmAdminGiris frm = new FrmAdminGiris();
                this.Hide();


            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş!");
            }

        }
    }
}