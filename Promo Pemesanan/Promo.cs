using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Promo_Pemesanan
{
    public partial class Promo: Form
    {
        private Size formOriginalSize; //menyimpan ukuran asli dari form sebelum ada perubahan
        private Rectangle recpanel1;

        private Rectangle recguna2Panel1;
        private Rectangle recguna2PictureBox1;
        private Rectangle reclabel1;
        private Rectangle reclabel2;
        private Rectangle reclabel3;
        private Rectangle reclabel4;
        private Rectangle recbtnpromo1;

        private Rectangle recguna2Panel2;
        private Rectangle recguna2PictureBox2;
        private Rectangle reclabel5;
        private Rectangle reclabel6;
        private Rectangle reclabel7;
        private Rectangle reclabel8;
        private Rectangle recbtnpromo2;

        private Rectangle recguna2Panel3;
        private Rectangle recguna2PictureBox3;
        private Rectangle reclabel9;
        private Rectangle reclabel10;
        private Rectangle reclabel11;
        private Rectangle reclabel12;
        private Rectangle recbtnpromo3;


        public Promo()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;

            recpanel1 = new Rectangle(panel1.Location, panel1.Size);

            recguna2Panel1 = new Rectangle(guna2Panel1.Location, guna2Panel1.Size);
            recguna2PictureBox1 = new Rectangle(guna2PictureBox1.Location, guna2PictureBox1.Size);
            reclabel1 = new Rectangle(label1.Location, label1.Size);
            reclabel2 = new Rectangle(label2.Location, label2.Size);
            reclabel3 = new Rectangle(label3.Location, label3.Size);
            reclabel4 = new Rectangle(label4.Location, label4.Size);
            recbtnpromo1 = new Rectangle(btnpromo1.Location, btnpromo1.Size);

            recguna2Panel2 = new Rectangle(guna2Panel2.Location, guna2Panel2.Size);
            recguna2PictureBox2 = new Rectangle(guna2PictureBox2.Location, guna2PictureBox2.Size);
            reclabel5 = new Rectangle(label5.Location, label5.Size);
            reclabel6 = new Rectangle(label6.Location, label6.Size);
            reclabel7 = new Rectangle(label7.Location, label7.Size);
            reclabel8 = new Rectangle(label8.Location, label8.Size);
            recbtnpromo2 = new Rectangle(btnpromo2.Location, btnpromo2.Size);

            recguna2Panel3 = new Rectangle(guna2Panel3.Location, guna2Panel3.Size);
            recguna2PictureBox3 = new Rectangle(guna2PictureBox2.Location, guna2PictureBox2.Size);
            reclabel9 = new Rectangle(label9.Location, label9.Size);
            reclabel10 = new Rectangle(label10.Location, label10.Size);
            reclabel11 = new Rectangle(label11.Location, label11.Size);
            reclabel12 = new Rectangle(label12.Location, label12.Size);
            recbtnpromo3 = new Rectangle(btnpromo3.Location, btnpromo3.Size);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(panel1, recpanel1);

            resize_Control(guna2Panel1, recguna2Panel1);
            resize_Control(guna2PictureBox1, recguna2PictureBox1);
            resize_Control(label1, reclabel1);
            resize_Control(label2, reclabel2);
            resize_Control(label3, reclabel3);
            resize_Control(label4, reclabel4);
            resize_Control(btnpromo1, recbtnpromo1);

            resize_Control(guna2Panel2, recguna2Panel2);
            resize_Control(guna2PictureBox2, recguna2PictureBox2);
            resize_Control(label5, reclabel5);
            resize_Control(label6, reclabel6);
            resize_Control(label7, reclabel7);
            resize_Control(label8, reclabel8);
            resize_Control(btnpromo2, recbtnpromo2);

            resize_Control(guna2Panel3, recguna2Panel3);
            resize_Control(guna2PictureBox3, recguna2PictureBox3);
            resize_Control(label9, reclabel9);
            resize_Control(label10, reclabel10);
            resize_Control(label11, reclabel11);
            resize_Control(label12, reclabel12);
            resize_Control(btnpromo3, recbtnpromo3);
        }
        private void resize_Control(Control c, Rectangle r) //menyesuaikan posisi dan ukuran objek kontrol berdasarkan perubahan ukuran form
        {
            //menghitung rasio antara ukuran lebar dan tinggi form saat ini dengan form awal
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            //menghitung posisi X dan Y
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            //menghitung lebar tinggi
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            //mengatur ulang posisi dan ukuran
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private bool guna2Button1MouseClick = false;
        private bool guna2Button2MouseClick = false;
        private bool guna2Button3MouseClick = false;

        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (guna2Button1MouseClick)
            {
                btnpromo1.Text = "Gunakan";
                btnpromo1.ForeColor = Color.White;
                btnpromo1.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button1MouseClick = false;
            }
            else
            {
                btnpromo1.Text = "Digunakan";
                btnpromo1.ForeColor = Color.WhiteSmoke;
                btnpromo1.FillColor = Color.FromArgb(102, 98, 98);
                DialogResult result = MessageBox.Show("Apakah Anda ingin menggunakan promo ini?", "Konfirmasi", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Tindakan jika pengguna memilih "Ya"
                    Pemesanan pemesanan = new Pemesanan();
                    pemesanan.promodigunakan = label2.Text;
                    this.Hide();
                    pemesanan.Show();
                }
                else if (result == DialogResult.No)
                {
                    btnpromo1.Text = "Gunakan";
                    btnpromo1.ForeColor = Color.White;
                    btnpromo1.FillColor = Color.FromArgb(8, 102, 255);
                }
                //MessageBox.Show("Promo Berhasil Digunakan!");

                guna2Button1MouseClick = true;
            }
            if (guna2Button2MouseClick)
            {
                btnpromo2.Text = "Gunakan";
                btnpromo2.ForeColor = Color.White;
                btnpromo2.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button2MouseClick = false;
            }
            else if (guna2Button3MouseClick)
            {
                btnpromo3.Text = "Gunakan";
                btnpromo3.ForeColor = Color.White;
                btnpromo3.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button3MouseClick = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2Button2MouseClick)
            {
                btnpromo2.Text = "Gunakan";
                btnpromo2.ForeColor = Color.White;
                btnpromo2.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button2MouseClick = false;
            }
            else
            {
                btnpromo2.Text = "Digunakan";
                btnpromo2.ForeColor = Color.WhiteSmoke;
                btnpromo2.FillColor = Color.FromArgb(102, 98, 98);
                DialogResult result = MessageBox.Show("Apakah Anda ingin menggunakan promo ini?", "Konfirmasi", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Tindakan jika pengguna memilih "Ya"
                    Pemesanan pemesanan = new Pemesanan();
                    pemesanan.promodigunakan = label7.Text;
                    this.Hide();
                    pemesanan.Show();
                }
                else if (result == DialogResult.No)
                {
                    btnpromo2.Text = "Gunakan";
                    btnpromo2.ForeColor = Color.White;
                    btnpromo2.FillColor = Color.FromArgb(8, 102, 255);
                }
                //MessageBox.Show("Promo Berhasil Digunakan!");

                guna2Button2MouseClick = true;
            }
            if (guna2Button1MouseClick)
            {
                btnpromo1.Text = "Gunakan";
                btnpromo1.ForeColor = Color.White;
                btnpromo1.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button1MouseClick = false;
            }
            else if (guna2Button3MouseClick)
            {
                btnpromo3.Text = "Gunakan";
                btnpromo3.ForeColor = Color.White;
                btnpromo3.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button3MouseClick = false;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2Button3MouseClick)
            {
                btnpromo3.Text = "Gunakan";
                btnpromo3.ForeColor = Color.White;
                btnpromo3.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button3MouseClick = false;
            }
            else
            {
                btnpromo3.Text = "Digunakan";
                btnpromo3.ForeColor = Color.WhiteSmoke;
                btnpromo3.FillColor = Color.FromArgb(102, 98, 98);
                DialogResult result = MessageBox.Show("Apakah Anda ingin menggunakan promo ini?", "Konfirmasi", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Tindakan jika pengguna memilih "Ya"
                    Pemesanan pemesanan = new Pemesanan();
                    pemesanan.promodigunakan = label11.Text;
                    this.Hide();
                    pemesanan.Show();
                }
                else if (result == DialogResult.No)
                {
                    btnpromo3.Text = "Gunakan";
                    btnpromo3.ForeColor = Color.White;
                    btnpromo3.FillColor = Color.FromArgb(8, 102, 255);
                }
                //MessageBox.Show("Promo Berhasil Digunakan!");

                guna2Button3MouseClick = true;
            }
            if (guna2Button1MouseClick)
            {
                btnpromo1.Text = "Gunakan";
                btnpromo1.ForeColor = Color.White;
                btnpromo1.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button1MouseClick = false;
            }
            else if (guna2Button3MouseClick)
            {
                btnpromo2.Text = "Gunakan";
                btnpromo2.ForeColor = Color.White;
                btnpromo2.FillColor = Color.FromArgb(8, 102, 255);
                guna2Button2MouseClick = false;
            }
        }


        //Pemrograman:
        public int tiketdipesan { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            promo();
        }
        private void promo()
        {
            int syarat_tiket;
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password=Anggun28_;");
            con.Open();
            NpgsqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT nama_voucher, tanggal_berakhir, min_pembelian FROM voucher");
            cmd.ExecuteNonQuery();
            NpgsqlDataReader reader = cmd.ExecuteReader();
            DateTime tanggal_sekarang = DateTime.Now;


            if (reader.Read())
            {
                label2.Text = reader["nama_voucher"].ToString();
                DateTime tanggal_berakhir = (DateTime)reader["tanggal_berakhir"];
                label3.Text = tanggal_berakhir.ToString("yyyy-mm-dd");
                syarat_tiket = reader.GetInt32(reader.GetOrdinal("min_pembelian"));

                if (tiketdipesan < syarat_tiket || tanggal_sekarang > tanggal_berakhir)
                {
                    btnpromo1.Enabled = false;
                    btnpromo1.ForeColor = Color.FromArgb(102, 98, 98);
                }
            }
            if (reader.Read())
            {
                label7.Text = reader["nama_voucher"].ToString();
                DateTime tanggal_berakhir = (DateTime)reader["tanggal_berakhir"];
                label6.Text = tanggal_berakhir.ToString("yyyy-mm-dd");
                syarat_tiket = reader.GetInt32(reader.GetOrdinal("min_pembelian"));

                if (tiketdipesan < syarat_tiket || tanggal_sekarang > tanggal_berakhir)
                {
                    btnpromo2.Enabled = false;
                    btnpromo2.ForeColor = Color.FromArgb(102, 98, 98);
                }
            }
            if (reader.Read())
            {
                label11.Text = reader["nama_voucher"].ToString();
                DateTime tanggal_berakhir = (DateTime)reader["tanggal_berakhir"];
                label10.Text = tanggal_berakhir.ToString("yyyy-mm-dd");
                syarat_tiket = reader.GetInt32(reader.GetOrdinal("min_pembelian"));

                if (tiketdipesan < syarat_tiket || tanggal_sekarang > tanggal_berakhir)
                {
                    btnpromo3.Enabled = false;
                    btnpromo3.ForeColor = Color.FromArgb(102, 98, 98);
                }
            }
            cmd.Dispose();
            con.Close();
        }
    }
}