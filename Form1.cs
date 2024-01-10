using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace final_ingilizce_sözlük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6CBVI98\\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");
        public static string adSoyad = "";
        public static int kullaniciID;
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string parola = textBox2.Text;
            bool sonuc = false;


            if (radioButton1.Checked)
            {
                if (kullaniciAdi == "admin" && parola == "123")
                {
                    sonuc = false;
                    adminislem ki = new adminislem();
                    ki.Show();
                    this.Hide();    
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı ya da parola!");
                }
            }
            else
            {
                con.Open();

                SqlCommand komut = new SqlCommand("SELECT * FROM Table_1 WHERE adSoyad = @p1 AND sifre = @p2", con);
                komut.Parameters.AddWithValue("@p1", kullaniciAdi);
                komut.Parameters.AddWithValue("@p2", parola);

                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    adSoyad = dr["adSoyad"].ToString();
                    kullaniciID = int.Parse(dr["ID"].ToString());
                    sonuc = true;
                }

                con.Close();

                if (sonuc)
                {
                    sonuc = false;
                     kullaniciislem kullaniciislem = new kullaniciislem();
                    kullaniciislem.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adınız veya Parolanız Yanlış!","Hatalı Giriş Denemesi");
                }
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayitol kayitol = new kayitol();    
            kayitol.ShowDialog();


        }
    }
}
