using System;
using System.Windows.Forms;

namespace final_ingilizce_sözlük
{
    public partial class kullaniciislem : Form
    {
        public kullaniciislem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cevir cevir = new cevir();
            cevir.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kelimeoyunu kelimeoyunu = new kelimeoyunu();    
            kelimeoyunu.ShowDialog();
        }
    }
}
