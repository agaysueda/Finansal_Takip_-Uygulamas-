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
    public partial class gelir_ekle : Form
    {
        public gelir_ekle()
        {
            InitializeComponent();
        }

        public int numara;


        SqlConnection baglanti = new SqlConnection("Data Source =SUEDA\\SQLEXPRESS; Initial Catalog = finansal_takip_uygulamasi; Integrated Security = True");


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gelir_ekle_Load(object sender, EventArgs e)
        {
            object[] katagoriler = new object[] { "Maaş", "Eğitim", "Kira", "Kumar", "Diğer" };
            comboBox1.Items.AddRange(katagoriler);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();


                int gelirMiktari = Convert.ToInt32(textBox1.Text);
                DateTime gelirTarihi = dateTimePicker1.Value;
                string gelirKategorisi = comboBox1.SelectedItem.ToString();

                string hebele = "INSERT INTO gelir (uye_numarasi, gelir_miktarı, gelir_tarih, gelir_kategorisi) VALUES (@uye_numarasi, @gelir_miktarı, @gelir_tarih, @gelir_kategorisi)";

                using (SqlCommand komut = new SqlCommand(hebele, baglanti))
                {
                    komut.Parameters.AddWithValue("@uye_numarasi", numara);
                    komut.Parameters.AddWithValue("@gelir_miktarı", gelirMiktari);
                    komut.Parameters.AddWithValue("@gelir_tarih", gelirTarihi);
                    komut.Parameters.AddWithValue("@gelir_kategorisi", gelirKategorisi);


                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla eklendi.");
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();

            }
        }
    }
}
