using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class Form3 : Form
    {
        Random random = new Random();

        PictureBox firstBoxClick = null;
        PictureBox secondBoxClick = null;

        public Form3()
        {
            InitializeComponent();
            JaaKortit();

            pictureBox1.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox2.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox3.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox4.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox5.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox6.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox7.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox8.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox9.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox10.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox11.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox12.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox13.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox14.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox15.Click += (sender, e) => pictureBoxClick(sender, e);
            pictureBox16.Click += (sender, e) => pictureBoxClick(sender, e);


        }

        private static Random rng = new Random();

        int clicks = 0;
        int points = 0;
        static int tries = 6;

        static Image keltainen = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\keltainen.png");
        static Image musta = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\musta.png");
        static Image pinkki = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\pinkki.png");
        static Image tummapunainen = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\tummapunainen.png");
        static Image vaaleasininen = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\vaaleasininen.png");
        static Image vihrea = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\vihrea.png");
        static Image oranssi = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\oranssi.png");
        static Image harmaa = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\harmaa.png");

        static Image valkoinen = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\valkoinen.png");

        static List<Image> kuvapakka = new List<Image> { keltainen, keltainen, musta, musta, pinkki, pinkki, tummapunainen, tummapunainen, vaaleasininen, vaaleasininen, vihrea, vihrea, oranssi, oranssi, harmaa, harmaa };

        private void JaaKortit()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                PictureBox pictureBox = c as PictureBox;
                if (pictureBox != null)
                {
                    int rnd = random.Next(kuvapakka.Count);
                    pictureBox.BackgroundImage = kuvapakka[rnd];
                    pictureBox.Image = valkoinen;
                    kuvapakka.RemoveAt(rnd);
                }
            }
        }

        private void Voitto()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                PictureBox pictureBox = c as PictureBox;

                if (pictureBox != null)
                {
                    if (pictureBox.Image != null)
                    {
                        return;
                    }
                }
            }

            MessageBox.Show("voitit pelin jes");
            Close();
        }

        private void pictureBoxClick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                return;
            }

            PictureBox clickedBox = sender as PictureBox;

            if (clickedBox != null)
            {
                if (clickedBox.Image == null)
                {
                    return;
                }

                if (firstBoxClick == null)
                {
                    firstBoxClick = clickedBox;
                    firstBoxClick.Image = null;
                    return;
                }

                secondBoxClick = clickedBox;
                secondBoxClick.Image = null;

                Voitto();

                if (firstBoxClick.BackgroundImage == secondBoxClick.BackgroundImage)
                {
                    firstBoxClick = null;
                    secondBoxClick = null;
                    return;
                }

                timer1.Start();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        timer1.Stop();

        firstBoxClick.Image = valkoinen;
        secondBoxClick.Image = valkoinen;

        firstBoxClick = null;
        secondBoxClick = null;

        }
    }
}
