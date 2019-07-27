using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("8903691-Popcorn-texture-Stock-Photo-popcorn.jpg");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_account a = new Create_account();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string A, B;
            A = textBox1.Text;
            B = textBox2.Text;
            Trazilica T = new Trazilica();
            Korisnik a = new Korisnik();


            StreamReader sr = new StreamReader("USERS.txt");
            string linija;
            bool kraj = false;
           
            while (!kraj)
            {
                linija = sr.ReadLine();
                if (linija == null)
                {
                    kraj = true;
                    
                }
                else
                {
                    
                    string[] razlomljenalinija = linija.Split('|');
                    {
                        if (razlomljenalinija[2] == textBox1.Text && razlomljenalinija[3] == textBox2.Text)
                        {
                            a.Krediti = int.Parse(razlomljenalinija[4]);
                            a.Ime = razlomljenalinija[0];
                            a.Prezime = razlomljenalinija[1];
                            a.Username = razlomljenalinija[2];
                            a.Lozinka = razlomljenalinija[3];
                            
                            T.label6.Text = a.Username;

                            T.label7.Text = a.Lozinka;
                            T.label7.BackColor = System.Drawing.Color.Transparent;
                            T.label7.ForeColor = System.Drawing.Color.Transparent;

                            T.label9.Text = a.Krediti.ToString();

                            T.label10.Text = a.Ime;
                            T.label10.BackColor = System.Drawing.Color.Transparent;
                            T.label10.ForeColor = System.Drawing.Color.Transparent;

                            
                            T.label11.Text = a.Prezime;
                            T.label11.ForeColor = System.Drawing.Color.Transparent;
                            T.label11.BackColor = System.Drawing.Color.Transparent;


                            this.Hide();
                            T.Show();
                            MessageBox.Show("Molimo Vas da se odjavite na 'Log out' u lijevom donjem kutu kada zavrsite s programom!");
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pomoc1 P = new pomoc1();
            P.pictureBox1.Image = Image.FromFile("Pomoc1.png");
            P.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            P.Show();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            pomoc1 P = new pomoc1();
            P.pictureBox1.Image = Image.FromFile(@"Pomoc1.png");
            P.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            P.Show();
        }
    }
}
