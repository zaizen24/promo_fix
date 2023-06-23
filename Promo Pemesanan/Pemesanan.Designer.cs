namespace Promo_Pemesanan
{
    partial class Pemesanan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pemesanan));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label4 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label4);
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 664);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(604, 361);
            label4.Name = "label4";
            label4.Size = new Size(250, 25);
            label4.TabIndex = 5;
            label4.Text = "__________________________________";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(709, 303);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(134, 37);
            guna2Button1.TabIndex = 4;
            guna2Button1.Text = "Cari Promo";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(513, 303);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 361);
            label3.Name = "label3";
            label3.Size = new Size(207, 25);
            label3.TabIndex = 2;
            label3.Text = "Promo yang digunakan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 306);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "Jumlah tiket :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Thin Black", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(474, 141);
            label1.Name = "label1";
            label1.Size = new Size(356, 77);
            label1.TabIndex = 0;
            label1.Text = "Pembelian";
            // 
            // Pemesanan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(panel1);
            Name = "Pemesanan";
            Text = "Pemesanan";
            Load += Pemesanan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}