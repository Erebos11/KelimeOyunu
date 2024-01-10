using System;
using System.Windows.Forms;

namespace final_ingilizce_sözlük
{
    public partial class adminislem : Form
    {
        public adminislem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kelimeEkle kelimeEkle = new kelimeEkle();
            kelimeEkle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mesajgoruntule mesajgoruntule = new mesajgoruntule();
            mesajgoruntule.ShowDialog();

        }
    }
}
