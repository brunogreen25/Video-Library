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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Trazilica : Form
    {
        
        public Trazilica()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("istock_000000581126xsmall.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Korisnik aa=new Korisnik();
            aa.Krediti = int.Parse(label9.Text);
            aa.Ime = label10.Text;
            aa.Prezime = label11.Text;
            aa.Username = label6.Text;
            aa.Lozinka = label7.Text;

            Admin.UnosKredita(aa.Krediti, aa.Ime, aa.Prezime, aa.Username, aa.Lozinka);

            this.Hide();
            Log_in a=new Log_in();
            a.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void directortextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;


            listView1.Items.Clear();

            string naziv = txtBoxNaziv.Text;

            StreamReader sr = new StreamReader(@"FILMOVI.txt");
            string linija;
            bool kraj = false;
            int i, j = 0;
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
                    string[] razlomljenalinija2 = razlomljenalinija[0].Split(' ');
                    {
                        i = 0;
                        do
                        {
                            if (razlomljenalinija2[i] == naziv)
                            {
                                
                                listView1.Items.Add(razlomljenalinija[0]);
                                listView1.Items[j].SubItems.Add(razlomljenalinija[1]);
                                listView1.Items[j].SubItems.Add(razlomljenalinija[2]);
                                listView1.Items[j].SubItems.Add(razlomljenalinija[3]);
                                j++;
                            }
                            i++;
                        } while (razlomljenalinija2[i] != ".");
                    }
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Pregled_filma aaa = new Pregled_filma();
            aaa.Show();
            Image myimage = new Bitmap(@"movie-theater-auditorium.jpg");
            aaa.BackgroundImage = myimage;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Text = null;
            txtBoxNaziv.Text = null;
            comboBox3.Text = null;

            listView1.Items.Clear();
            string naziv = comboBox2.Text;

            StreamReader sr = new StreamReader(@"FILMOVI.txt");
            string linija;
            bool kraj = false;
            int j = 0;
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
                            if (razlomljenalinija[2] == naziv)
                            {

                                listView1.Items.Add(razlomljenalinija[0]);
                                listView1.Items[j].SubItems.Add(razlomljenalinija[1]);
                                listView1.Items[j].SubItems.Add(razlomljenalinija[2]);
                                listView1.Items[j].SubItems.Add(razlomljenalinija[3]);
                                j++;
                            }
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxNaziv.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            listView1.Items.Clear();

            string naziv = comboBox1.Text;
            StreamReader sr = new StreamReader(@"FILMOVI.txt");
            string linija;
            bool kraj = false;
            int j = 0;
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
                        if (razlomljenalinija[1] == naziv)
                        {

                            listView1.Items.Add(razlomljenalinija[0]);
                            listView1.Items[j].SubItems.Add(razlomljenalinija[1]);
                            listView1.Items[j].SubItems.Add(razlomljenalinija[2]);
                            listView1.Items[j].SubItems.Add(razlomljenalinija[3]);
                            j++;
                        }
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBoxNaziv.Text = null;
            comboBox2.Text = null;
            comboBox1.Text = null;
            listView1.Items.Clear();

            string naziv = comboBox3.Text;
            StreamReader sr = new StreamReader(@"FILMOVI.txt");
            string linija;
            bool kraj = false;
            int j = 0;
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
                        if (razlomljenalinija[3] == naziv)
                        {

                            listView1.Items.Add(razlomljenalinija[0]);
                            listView1.Items[j].SubItems.Add(razlomljenalinija[1]);
                            listView1.Items[j].SubItems.Add(razlomljenalinija[2]);
                            listView1.Items[j].SubItems.Add(razlomljenalinija[3]);
                            j++;
                        }
                    }
                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox3.Text = null;
            txtBoxNaziv.Text = null;
            comboBox2.Text = null;
            comboBox1.Text = null;
            listView1.Items.Clear();

            string naziv = comboBox3.Text;
            StreamReader sr = new StreamReader(@"FILMOVI.txt");
            string linija;
            bool kraj = false;
            int j = 0;
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
                            listView1.Items.Add(razlomljenalinija[0]);
                            listView1.Items[j].SubItems.Add(razlomljenalinija[1]);
                            listView1.Items[j].SubItems.Add(razlomljenalinija[2]);
                            listView1.Items[j].SubItems.Add(razlomljenalinija[3]);
                            j++;
                        
                    }
                }
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = listView1.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                String textic = listView1.Items[intselectedindex].Text;
                Pregled_filma P = new Pregled_filma();
              
                P.Show();
                MessageBox.Show("Prije izlaza obavezno pauzirajte video!!!");
                

                
                StreamReader sr = new StreamReader(@"FILMOVI.txt");          
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
                            if (razlomljenalinija[0] == textic)
                            {
                                string[] r = razlomljenalinija[0].Split('.');
                                {
                                    //PROFESORE,OVDE SE TRIBA UCITAT URL YOUTUBE VIDEA I URL SLIKE.DOMA MI TO RADI.OVDEN U UCIONICI NIJE 
                                    P.label1.Text = r[0];
                                    P.label1.AutoSize = false;
                                    P.lblime.Text = label10.Text;
                                    P.lblime.ForeColor = System.Drawing.Color.Transparent;
                                    P.lblime.BackColor = System.Drawing.Color.Transparent;

                                    P.lblprezime.Text = label11.Text;
                                    P.lblprezime.ForeColor = System.Drawing.Color.Transparent;
                                    P.lblprezime.BackColor = System.Drawing.Color.Transparent;

                                    P.label1.TextAlign = ContentAlignment.MiddleCenter;
                                    P.axShockwaveFlash1.Movie = razlomljenalinija[5];
                                    P.Poruka = razlomljenalinija[4];

                                    P.label6.Text = label6.Text;
                                    P.label6.ForeColor = System.Drawing.Color.Transparent;
                                    P.label6.BackColor = System.Drawing.Color.Transparent;

                                    P.label7.Text = label7.Text;
                                    P.label7.ForeColor = System.Drawing.Color.Transparent;
                                    P.label7.BackColor = System.Drawing.Color.Transparent;
                                    P.label3.Text = label9.Text.ToString();

                                    P.pictureBox1.ImageLocation = razlomljenalinija[6];
                                    P.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                                this.Hide();

                            }
                        }
                    }
                }
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pomoc1 P = new pomoc1();
            P.pictureBox1.Image = Image.FromFile("Pomoc4.png");
            P.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            P.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dodavanje_filmova d = new Dodavanje_filmova();
            d.label9.Text = label9.Text;
            d.ime.Text = label10.Text;
            d.prezime.Text = label11.Text;
            d.lozinka.Text = label7.Text;
            d.username.Text = label6.Text;
            d.Show();
            this.Hide();
        }
    }
}
