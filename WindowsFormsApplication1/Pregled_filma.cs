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
    public partial class Pregled_filma : Form
    {
        string poruka;
        public string Poruka { set { poruka = value; } get { return poruka; } }
        public Pregled_filma()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("swtfa.jpg");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 483);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(label3.Text) >= int.Parse(label4.Text))
                label3.Text = (int.Parse(label3.Text) - int.Parse(label4.Text)).ToString();
            else
                MessageBox.Show("Zao nam je no potrosili ste sav novac.");
        }

        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Trazilica T = new Trazilica();
            T.Show();

            T.label10.Text = lblime.Text;
            T.label10.ForeColor = System.Drawing.Color.Transparent;
            T.label10.BackColor = System.Drawing.Color.Transparent;

            T.label11.Text = lblprezime.Text;
            T.label11.ForeColor = System.Drawing.Color.Transparent;
            T.label11.BackColor = System.Drawing.Color.Transparent;

            T.label6.Text = label6.Text;
            T.label9.Text = label3.Text;
            T.label7.Text = label7.Text;
            T.label7.ForeColor = System.Drawing.Color.Transparent;
            T.label7.BackColor = System.Drawing.Color.Transparent;


            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Trazilica T=new Trazilica();
            label6.Text = T.label6.Text;
            label7.Text = T.label7.Text;
            label3.Text = T.label9.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Poruka);



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblprezime_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pomoc1 P = new pomoc1();
            P.pictureBox1.Image = Image.FromFile(@"Pomoc3.png");
            P.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            P.Show();
        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {

        }
    }
}
