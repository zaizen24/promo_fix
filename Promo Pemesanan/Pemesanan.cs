using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promo_Pemesanan
{
    public partial class Pemesanan : Form
    {
        public Pemesanan()
        {
            InitializeComponent();
        }

        public string promodigunakan { get; set; }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int textBoxValue))
            {
                Promo form1 = new Promo();
                form1.tiketdipesan = textBoxValue; // Mengatur nilai properti tiketdipesan di Form 
                form1.ShowDialog(); // Menampilkan Form2 sebagai dialog
                this.Hide(); // Menyembunyikan Form1
            }
        
        }

        private void Pemesanan_Load(object sender, EventArgs e)
        {
            label4.Text = promodigunakan;
        }
    }
}
