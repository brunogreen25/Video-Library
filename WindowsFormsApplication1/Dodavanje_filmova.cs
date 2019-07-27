using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Dodavanje_filmova : Form
    {
        public Dodavanje_filmova()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("BigScreen.jpg");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Trazilica T = new Trazilica();
            T.label9.Text = label9.Text;
            T.label10.Text = ime.Text;
            T.label11.Text = prezime.Text;
            T.label7.Text = lozinka.Text;
            T.label6.Text = username.Text;
            T.label9.Text = label9.Text;
            T.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtgodina.Text != "" && txtjezik.Text != "" && txtnaziv.Text != "" && txtopis.Text != "" && txtslika.Text != "" && txtvideo.Text != "" && txtzanr.Text != "")
            {
                label9.Text = (int.Parse(label11.Text) + int.Parse(label9.Text)).ToString();
                Admin.UnosFilmova(txtnaziv.Text, txtgodina.Text, txtzanr.Text, txtjezik.Text, txtopis.Text, txtvideo.Text, txtslika.Text);
                txtgodina.Clear();
                txtjezik.Clear();
                txtnaziv.Clear();
                txtzanr.Clear();
                txtopis.Clear();
                txtslika.Clear();
                txtvideo.Clear();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pomoc1 P = new pomoc1();
            P.pictureBox1.Image = Image.FromFile(@"Pomoc5.png");
            P.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            P.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Za unijeti youtube video morate izbrisati 'watch?', a '=' koji dolazi nakon v zamijeniti '/'. Npr.'https://www.youtube.com/watch?v=KzJNYYkkhzc' mora biti 'https://www.youtube.com/v/KzJNYYkkhzc'");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Svaka rijec mora zapoceti velikim slovom.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Slova opisa nesmiju sadrzavati dijakriticke znakove.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Molimo Vas da pisete imenicu, a ne pridjev. Npr. 'Akcija', a ne 'akcijski'. ");
        }
    }
}
