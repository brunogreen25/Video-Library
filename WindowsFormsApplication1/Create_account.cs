using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Create_account : Form
    {
        public Create_account()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("8903691-Popcorn-texture-Stock-Photo-popcorn.jpg");
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trazilica T = new Trazilica();
            Korisnik a = new Korisnik();
            a.Ime = textBox4.Text;
            a.Prezime = textBox3.Text;
            a.Lozinka = textBox2.Text;
            a.Username = textBox1.Text;
            a.Krediti = 100;

            T.label6.Text = a.Username;
          

            T.label7.Text = a.Lozinka;
            T.label7.BackColor = System.Drawing.Color.Transparent;
            T.label7.ForeColor = System.Drawing.Color.Transparent;

            T.label9.Text = a.Krediti.ToString();
            T.label10.Text = a.Ime;
            T.label10.BackColor = System.Drawing.Color.Transparent;
            T.label10.ForeColor = System.Drawing.Color.Transparent;

            T.label11.Text = a.Prezime;
            T.label11.BackColor = System.Drawing.Color.Transparent;
            T.label11.ForeColor = System.Drawing.Color.Transparent;


            Admin.UnosKorisnika(a.Ime,a.Prezime,a.Username,a.Lozinka,a.Krediti);
            
            
            
            
            
            this.Hide();
            T.Show();
            MessageBox.Show("Molimo Vas da se odjavite na 'Log out' u lijevom donjem kutu kada zavrsite s programom!");

        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pomoc1 P = new pomoc1();
            P.pictureBox1.Image = Image.FromFile(@"Pomoc2.png");
            P.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            P.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Log_in L = new Log_in();
            L.Show();
            this.Hide();
        }
    }
}
