using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace final_ingilizce_sözlük
{
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6CBVI98\\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

           
            SqlCommand cmd = new SqlCommand("select * from Table_1 where telefon = @p2 email = @p4 ",con);
            cmd.Parameters.AddWithValue("@p2",textBox4.Text);
            cmd.Parameters.AddWithValue("@p4", textBox3.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Bu E-mail veya Telefon No'sunda bir kullanıcı bulunmaktadır!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )
                {
                    MessageBox.Show("Tüm Alanları Doldurun", "Müşteri Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    reader.Close();
                    SqlCommand cmd2 = new SqlCommand("insert into Table_1 (adSoyad,telefon,email,sifre) values (@p1,@p2,@p3,@p4)", con);

                    cmd2.Parameters.AddWithValue("@p1", textBox1.Text);
                    cmd2.Parameters.AddWithValue("@p2", textBox2.Text);
                    cmd2.Parameters.AddWithValue("@p3", textBox3.Text);
                    cmd2.Parameters.AddWithValue("@p4", textBox4.Text);

                    int sonuc = cmd2.ExecuteNonQuery();

                   if (sonuc == 1)
                    {
                        MessageBox.Show("Kaydınız Başarılı Bir Şekilde Oluşturulmuştur!", "Kayıt işlemi");
                    }
                   else
                    {
                        MessageBox.Show("Bir Hata Oluştu!", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }

            }
                    con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
           
        }
    }
}
