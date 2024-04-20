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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int numara;


        SqlConnection baglanti = new SqlConnection("Data Source =SUEDA\\SQLEXPRESS; Initial Catalog = finansal_takip_uygulamasi; Integrated Security = True");
        private void Form2_Load(object sender, EventArgs e)
        {

            object[] katagoriler = new object[] { "Ev", "Araç", "Giyim", "Eğlence", "Eğitim", "Yeme-İçme", "Tatil", "Faturalar", "Kira", "Banka İşlemleri", "Diğer" };
            comboBox1.Items.AddRange(katagoriler);

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();

                
                int giderMiktari = Convert.ToInt32(textBox1.Text);
                DateTime giderTarihi = dateTimePicker2.Value;
                string giderKategorisi = comboBox1.SelectedItem.ToString();

                string hebele = "INSERT INTO gider (uye_numarasi, gider_miktari, gider_tarih, gider_kategorisi) VALUES (@uye_numarasi, @giderMiktari, @giderTarihi, @giderKategorisi)";

                using (SqlCommand komut = new SqlCommand(hebele, baglanti))
                {
                    komut.Parameters.AddWithValue("@uye_numarasi", numara);
                    komut.Parameters.AddWithValue("@giderMiktari", giderMiktari);
                    komut.Parameters.AddWithValue("@giderTarihi", giderTarihi);
                    komut.Parameters.AddWithValue("@giderKategorisi", giderKategorisi);
                    

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