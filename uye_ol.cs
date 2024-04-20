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

namespace Finansal_Takip__Uygulaması
{
    public partial class uye_ol : Form
    {
        public uye_ol()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uye_adi = textBox1.Text;
            string uye_soyadi = textBox2.Text;
            string uye_mail = textBox3.Text;
            string uye_sifre = textBox4.Text;

            using (SqlConnection baglanti = new SqlConnection("Data Source =SUEDA\\SQLEXPRESS; Initial Catalog = finansal_takip_uygulamasi; Integrated Security = True"))
            {
                try
                {
                    baglanti.Open();


                    string kontrolQuery = "SELECT COUNT(*) FROM uyelik_bilgileri WHERE uye_mail = @mail";
                    using (SqlCommand kontrolKomut = new SqlCommand(kontrolQuery, baglanti))
                    {
                        kontrolKomut.Parameters.AddWithValue("@mail", uye_mail);
                        int kayitSayisi = (int)kontrolKomut.ExecuteScalar();


                        if (kayitSayisi > 0)
                        {
                            MessageBox.Show("Bu e-posta adresi zaten kayıtlı!");
                            return;
                        }
                    }


                    string query = "INSERT INTO uyelik_bilgileri (uye_adi, uye_soyadi, uye_mail, uye_sifre) VALUES (@adi, @soyadi, @mail, @sifre)";
                    using (SqlCommand komut = new SqlCommand(query, baglanti))
                    {
                        komut.Parameters.AddWithValue("@adi", uye_adi);
                        komut.Parameters.AddWithValue("@soyadi", uye_soyadi);
                        komut.Parameters.AddWithValue("@mail", uye_mail);
                        komut.Parameters.AddWithValue("@sifre", uye_sifre);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarıyla eklendi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt eklenirken bir hata oluştu: " + ex.Message);
                }
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uye_ol_Load(object sender, EventArgs e)
        {

        }
    }
}
