using System;
using System.IO;
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
        public string p1 { get; set; }
        public string p2 { get; set; }

        Random random = new Random();

        PictureBox firstBoxClick = null;
        PictureBox secondBoxClick = null;

        public Form3(string p1name, string p2name)
        {
            InitializeComponent();

            this.p1 = p1name;
            this.p2 = p2name;

            l_p1pts.Text = p1name + " pisteet: " + p1pts.ToString();
            l_p2pts.Text = p2name + " pisteet: " + p2pts.ToString();
            l_vuoro.Text = "Vuoro: " + p1;

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

        int clickCounter = 0;
        int p1pts = 0;
        int p2pts = 0;
        bool p1turn = true;
        bool p2turn = false;

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
            if (p1pts > p2pts)
            {
                MessageBox.Show(p1 + " voitti pelin " + p1pts.ToString() + " pisteellä!");
                saveResults(p1 + "voitti pelin.", p1, p1pts, p2, p2pts);

                Close();
            }
            else if (p1pts < p2pts)
            {
                MessageBox.Show(p2 + " voitti pelin " + p2pts.ToString() + " pisteellä!");
                saveResults(p2 + "voitti pelin.", p1, p1pts, p2, p2pts);
                Close();
            }
            else if (p1pts == p2pts)
            {
                MessageBox.Show("Tasapeli! Olette molemmat voittajia!");
                saveResults(p1 + " ja " + p2 + "pelasivat tasapelin.", p1, p1pts, p2, p2pts);
                Close();
            }

        }

        private void pictureBoxClick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //timer pyörii, klikkaus ignoreen
            {
                return;
            }

            PictureBox clickedBox = sender as PictureBox;

            if (clickedBox != null) //jos jotain on jo klikattu
            {
                if (clickedBox.Image == null) //jos kyseinen ruutu on jo klikattu, klikkaus ignoreen
                {
                    return;
                }

                if (firstBoxClick == null)  //EKA KLIKKAUS, lisätään +1 clickCounteriin
                {
                    firstBoxClick = clickedBox;
                    firstBoxClick.Image = null;
                    clickCounter++;
                    clickCheck();
                    return;
                }

                secondBoxClick = clickedBox; //TOKA KLIKKAUS EI PARIA
                secondBoxClick.Image = null;
                Voitto();


                if (firstBoxClick.BackgroundImage == secondBoxClick.BackgroundImage)
                {
                    firstBoxClick = null;
                    secondBoxClick = null;
                    if (p1turn == true)
                    {
                        p1pts++;
                        l_p1pts.Text = p1 + ":n pisteet: " + p1pts.ToString();
                        changeTurn();
                        return;
                    }
                    if (p2turn == true) 
                    {
                        p2pts++;
                        l_p2pts.Text = p2 + ":n pisteet: " + p2pts.ToString();
                        changeTurn();
                        return;
                    }

                    //return;
                }

                Voitto();

                timer1.Start();

            }
        }

        private void changeTurn()
        {
            clickCounter = 0;

            if (p1turn == true)
            {
                p1turn = false;
                p2turn = true;
                l_vuoro.Text = "Vuoro: " + p2;
            }
            else if (p2turn == true)
            {
                p2turn = false;
                p1turn = true;
                l_vuoro.Text = "Vuoro: " + p1;
            }

        }

        private void clickCheck()
        {
            if (clickCounter == 2)
            {
                clickCounter = 0;
                changeTurn();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        timer1.Stop();

        firstBoxClick.Image = valkoinen;
        secondBoxClick.Image = valkoinen;

        clickCounter++;
        clickCheck();

        firstBoxClick = null;
        secondBoxClick = null;

        }

        private void saveResults(string tulos, string p1nimi, int p1pisteet, string p2nimi, int p2pisteet)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\Users\\Koti\\muistipeli.txt");
                //Write a line of text
                sw.WriteLine("Tulos: " + tulos);
                //Write a second line of text
                sw.WriteLine(p1nimi + " pisteet: " + p1pisteet.ToString());
                //Close the file
                sw.WriteLine(p2nimi + " pisteet: " + p2pisteet.ToString());
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
