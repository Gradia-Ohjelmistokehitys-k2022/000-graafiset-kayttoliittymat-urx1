using System.DirectoryServices;
using KorttiNS;

namespace Muistipeli
{
    public partial class Form1 : Form
    {

        Random random = new Random();

        PictureBox firstBoxClick = null;
        PictureBox secondBoxClick = null;

        public Form1()
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

        }

        private static Random rng = new Random();


        static Image keltainen = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\keltainen.png");
        static Image musta = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\musta.png");
        static Image pinkki = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\pinkki.png");
        static Image tummapunainen = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\tummapunainen.png");
        static Image vaaleasininen = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\vaaleasininen.png");
        static Image vihrea = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\vihrea.png");
        static Image valkoinen = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli2.2\\kuvia\\valkoinen.png");

        static List<Image> kuvapakka = new List<Image> { keltainen, keltainen, musta, musta, pinkki, pinkki, tummapunainen, tummapunainen, vaaleasininen, vaaleasininen, vihrea, vihrea };

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

                if ( pictureBox != null ) 
                { 
                    if (pictureBox.Image != null)
                    {
                        return;
                    }
                }
            }

            MessageBox.Show("Voitit pelin!");
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
