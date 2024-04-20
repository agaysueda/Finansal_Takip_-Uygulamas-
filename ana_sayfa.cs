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

namespace Finansal_Takip__Uygulaması
{
    public partial class ana_sayfa : Form
    {
        public ana_sayfa()
        {
            InitializeComponent();
            GetList();


            chart1.Titles.Add("Pie Chart");

            chart1.Series["gelir_gider"].Points.AddXY("Ev", ev);
            chart1.Series["gelir_gider"].Points.AddXY("Araç", arac);
            chart1.Series["gelir_gider"].Points.AddXY("Eğlence", eglence);
            chart1.Series["gelir_gider"].Points.AddXY("Eğitim", egitim);
            chart1.Series["gelir_gider"].Points.AddXY("Yeme-İçme", yeme_icme);
            chart1.Series["gelir_gider"].Points.AddXY("Giyim",giyim);
            chart1.Series["gelir_gider"].Points.AddXY("Tatil", tatil);
            chart1.Series["gelir_gider"].Points.AddXY("Fatura", fatura);
            chart1.Series["gelir_gider"].Points.AddXY("Kira", kira);
            chart1.Series["gelir_gider"].Points.AddXY("Diğer", diger);
            chart1.Series["gelir_gider"].Points.AddXY("Banka İşlemleri", bankaislemleri);

        }

        public string ev = "15";
        public string arac = "3";
        public string eglence = "5";
        public string egitim = "3";
        public string yeme_icme = "4";
        public string giyim = "6";
        public string tatil = "2";
        public string fatura = "7";
        public string kira = "30";
        public string diger = "7";
        public string bankaislemleri = "10";





        public string kullaniciMail;
        public int kullaniciNumara;
        SqlConnection baglanti = new SqlConnection("Data Source =SUEDA\\SQLEXPRESS; Initial Catalog = finansal_takip_uygulamasi; Integrated Security = True");
        SqlCommandBuilder commandBuilder;
        DataTable tbl = new DataTable();
        SqlDataAdapter adtr;


        private void ana_sayfa_Load(object sender, EventArgs e)
        {
            
            this.giderTableAdapter.Fill(this.finansal_takip_uygulamasiDataSet.gider);
            try
            { 
                baglanti.Open();

                SqlCommand komut = new SqlCommand("SELECT * FROM uyelik_bilgileri WHERE uye_mail = @uye_mail", baglanti);
                komut.Parameters.AddWithValue("@uye_mail", kullaniciMail);

                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read()) 
                {
                    string kullanici_no = reader["uye_numarasi"].ToString();
                    kullaniciNumara = Convert.ToInt32(kullanici_no);



                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı!"); 
                }

                reader.Close(); 
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Hata oluştu: " + ex.Message); 
            }
            finally
            {
                baglanti.Close(); 
            }

            refreshtable();

        }

        void refreshtable()
        {
            string sqlQuery = "SELECT * FROM gider WHERE uye_numarasi = '" + kullaniciNumara.ToString() + "'";

            string connectionString = "Data Source =SUEDA\\SQLEXPRESS; Initial Catalog = finansal_takip_uygulamasi; Integrated Security = True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                            Console.WriteLine("keremali");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.Refresh();
        }

        DataTable GetList()
        {
            adtr = new SqlDataAdapter("SELECT * FROM gider WHERE uye_numarasi = '" +kullaniciNumara.ToString()+"'", baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            return tbl;
        }


        private void Gider_Click(object sender, EventArgs e)
        {
            Form2 gider_ekle = new Form2();
            gider_ekle.numara = kullaniciNumara;
            gider_ekle.Show();
            refreshtable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gelir_ekle gelirEkle = new gelir_ekle();
            gelirEkle.numara = kullaniciNumara;
            gelirEkle.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            string query = "SELECT * FROM Giderler(gider_miktari,gider_kategorisi,gider_tarih)"; 

            
                baglanti.Open();
                SqlCommand command = new SqlCommand(query, baglanti);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                
                dataGridView1.DataSource = dataTable;
            
        }
    }
}
