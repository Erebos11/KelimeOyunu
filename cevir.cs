using System;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace final_ingilizce_sözlük
{
    public partial class cevir : Form
    {
        public cevir()
        {
            InitializeComponent();

        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6CBVI98\\SQLEXPRESS;Initial Catalog=kullanici;Integrated Security=True");

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            //if (radioButton1.Checked)
            //{
            //    CevirVeKaydet("tr", "en", metin);
            //}
            //else if (radioButton2.Checked) 
            //{
            //    CevirVeKaydet("en", "tr", metin);
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen bir çeviri yönü seçin.");
            //}

           string cevirilmisMetin = "";
           bool sonuc = false;



            connection.Open();

            SqlCommand komut = new SqlCommand("SELECT * FROM Kelimeler WHERE Metin = @p1", connection);
            komut.Parameters.AddWithValue("@p1", metin);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                cevirilmisMetin = dr["CevrilmisMetin"].ToString();
                label2.Text = cevirilmisMetin;
                sonuc = true;
            }
            connection.Close();



            if (sonuc)
            {
                sonuc = false;
            }
            else
            {
                MessageBox.Show("Hatalı bir kelime girdiniz veya aradğınız kelime sözlüğümüzde bulunmamaktadır!", " Hatalı Kelime Girişi ");
                DialogResult result = MessageBox.Show("Sözlükte Olmayan Kelimeyi Admine Bildirmek İster Misiniz?", "Admine Mesaj Gönder", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                 
                 mesajgonder mesajgonder = new mesajgonder();
                 mesajgonder.Show();
                }
              

            }



        }

      




    }
}



