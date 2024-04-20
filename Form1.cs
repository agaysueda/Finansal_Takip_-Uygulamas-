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
using System.Collections;
using System.Security.Policy;

namespace Finansal_Takip__Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uye_ol_Click(object sender, EventArgs e)
        {
            uye_ol uye_Ol = new uye_ol();
            uye_Ol.Show();
        }
        SqlConnection baglanti = new SqlConnection("Data Source =SUEDA\\SQLEXPRESS; Initial Catalog = finansal_takip_uygulamasi; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            string uye_mail = textBox1.Text;
            string uye_sifre = textBox2.Text;

            if (string.IsNullOrEmpty(uye_mail) || string.IsNullOrEmpty(uye_mail))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanları boş olamaz!");
                return;
            }
            string sorgu = "SELECT COUNT(*) FROM uyelik_bilgileri WHERE uye_mail = @uye_mail AND uye_sifre = @uye_sifre";

               using (SqlCommand command = new SqlCommand(sorgu, baglanti))
                {
                    
                    command.Parameters.AddWithValue("@uye_mail", uye_mail);
                    command.Parameters.AddWithValue("uye_sifre", uye_sifre);

                    try
                    {
                        baglanti.Open();
                        int kullaniciSayisi = (int)command.ExecuteScalar();

                        if (kullaniciSayisi > 0)
                        {
                            
                            MessageBox.Show("Giriş başarılı!");
                            ana_sayfa ana_Sayfa = new ana_sayfa();
                            ana_Sayfa.kullaniciMail = uye_mail;
                            ana_Sayfa.Show();
                            this.Hide();


                    }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }
    }

    

