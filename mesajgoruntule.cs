using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace final_ingilizce_sözlük
{
    public partial class mesajgoruntule : Form
    {
        public mesajgoruntule()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mesajgoruntule_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6CBVI98\\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");
            {  con.Open();

                string selectQuery = "SELECT KullaniciAdi, MesajIcerigi, Tarih FROM Mesajlar";

                using (SqlCommand command = new SqlCommand(selectQuery, con)) 
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string kullaniciAdi = reader["KullaniciAdi"].ToString();
                        string mesajIcerigi = reader["MesajIcerigi"].ToString();
                        DateTime tarih = Convert.ToDateTime(reader["Tarih"]);

                        dataGridView2.Rows.Add(kullaniciAdi, mesajIcerigi, tarih);
                    }
                    reader.Close();
                }
                con.Close();

            }
        }
    }
}
