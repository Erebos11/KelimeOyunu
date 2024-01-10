using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace final_ingilizce_sözlük
{
    public partial class kelimeEkle : Form
    {
        public kelimeEkle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6CBVI98\\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string turkce = textBox1.Text;
            string ingilizce = textBox2.Text;
            SqlCommand komut = new SqlCommand ("insert into Kelimeler (KaynakDil,HedefDil,Metin,CevrilmisMetin) values ('tr','en',@p1,@p2)", con);
            komut.Parameters.AddWithValue("@p1", ingilizce);
            komut.Parameters.AddWithValue("@p2", turkce);

            if (turkce == "" || ingilizce == "")
            {
                MessageBox.Show("Gerekli Yerleri Doldurunuz!");
            }
            else 
            {
                con.Open();

                int sonuc = komut.ExecuteNonQuery();
                con.Close();    

                if (sonuc == 1)
                {
                     MessageBox.Show("Yeni kelime eklendi!");
                }
                else
                {
                    MessageBox.Show("Bir Sorun meydana geldi");
                }
            }
           
            textBox1.Text ="";
            textBox2.Text ="";
        }
    }
}
