using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace final_ingilizce_sözlük
{
    public partial class mesajgonder : Form
    {
        public mesajgonder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string mesajIcerigi = textBox2.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6CBVI98\\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");
            {  con.Open();

                string insertQuery = "INSERT INTO Mesajlar (KullaniciAdi, MesajIcerigi) VALUES (@KullaniciAdi, @MesajIcerigi)";
                using (SqlCommand command = new SqlCommand(insertQuery, con))
                {
                    command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@MesajIcerigi", mesajIcerigi);

                    command.ExecuteNonQuery();

                }

                con.Close();

            }

            this.Close();
        }
        
    }
}
