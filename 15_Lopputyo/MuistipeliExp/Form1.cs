/*using System.Runtime.CompilerServices;
using System.Security.Cryptography;
*/

using System.DirectoryServices;
using KorttiNS;

namespace Muistipeli
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox1, k1);
            pictureBox2.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox2, k2);
            pictureBox3.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox3, k3);
            pictureBox4.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox4, k4);
            pictureBox5.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox5, k5);
            pictureBox6.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox6, k6);
            pictureBox7.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox7, k7);
            pictureBox8.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox8, k8);
            pictureBox9.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox9, k9);
            pictureBox10.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox10, k10);
            pictureBox11.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox11, k11);
            pictureBox12.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox12, k12);
        }

        private static Random rng = new Random();

        int clicks = 0;
        int points = 0;
        static int tries = 6;

        static Kortti keltainen = new Kortti(Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\MuistipeliExp\\kuvia\\keltainen.png"));
        static Kortti musta = new Kortti(Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\MuistipeliExp\\kuvia\\musta.png"));
        static Kortti pinkki = new Kortti(Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\MuistipeliExp\\kuvia\\pinkki.png"));
        static Kortti tummapunainen = new Kortti(Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\MuistipeliExp\\kuvia\\tummapunainen.png"));
        static Kortti vaaleasininen = new Kortti(Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\MuistipeliExp\\kuvia\\vaaleasininen.png"));
        static Kortti vihrea = new Kortti(Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\MuistipeliExp\\kuvia\\vihrea.png"));
        


        static List<Kortti> kuvapakka = new List<Kortti> { keltainen, keltainen, musta, musta, pinkki, pinkki, tummapunainen, tummapunainen, vaaleasininen, vaaleasininen, vihrea, vihrea };

        PictureBox lastClickedBox = null;

        Image lastClickedImg;

        static List<Kortti> kuvapakkaSekoitettu = kuvapakka.OrderBy(_ => rng.Next()).ToList();


        Kortti k1 = kuvapakkaSekoitettu[0];
        Kortti k2 = kuvapakkaSekoitettu[1];
        Kortti k3 = kuvapakkaSekoitettu[2];
        Kortti k4 = kuvapakkaSekoitettu[3];
        Kortti k5 = kuvapakkaSekoitettu[4];
        Kortti k6 = kuvapakkaSekoitettu[5];
        Kortti k7 = kuvapakkaSekoitettu[6];
        Kortti k8 = kuvapakkaSekoitettu[7];
        Kortti k9 = kuvapakkaSekoitettu[8];
        Kortti k10 = kuvapakkaSekoitettu[9];
        Kortti k11 = kuvapakkaSekoitettu[10];
        Kortti k12 = kuvapakkaSekoitettu[11];


        private void pictureBoxClick(object sender, EventArgs e, PictureBox picbox, Kortti kortti)
        {
            picbox.BackgroundImage = kortti._etukuva;
            clicks++;
            label1.Text = clicks.ToString();


            /*
            if (lastClickedBox == null)
            {
                picbox.BackgroundImage = picboximg;
                lastClickedBox = picbox;
                lastClickedImg = picboximg;
            }
            if (lastClickedBox.BackgroundImage != picboximg && clicks < 2)
            {
                clicks++;
                picbox.BackgroundImage = picboximg;
                tries--;
                l_tries.Text = "Yrityksiä jäljellä: " + tries;
            }
            else if (lastClickedBox.BackgroundImage == picboximg)
            {
                clicks++;
                picbox.BackgroundImage = picboximg;
                points++;
                lastClickedBox = null;
                l_points.Text = "Pisteet: " + points;
            }

            else
            {
                picbox.BackgroundImage = picboximg;
                var timer = new System.Windows.Forms.Timer();
                timer.Tick += (sender, e) => TimeOut(picbox, lastClickedBox, sender, e);
                timer.Interval = 2000;
                timer.Start();

                tries--;
                l_tries.Text = "Yrityksiä jäljellä: " + tries;
            }
            */

    }

    /*
    if (lastClickedBox == null) 
    { 
        picbox.BackgroundImage = picboximg;
        lastClickedBox = picbox;
        lastClickedImg = picboximg;

    }
    if (clicks <= 1 && lastClickedImg == picboximg)
    {
        picbox.BackgroundImage = picboximg;
        lastClickedImg = pb1img;
        points++;
        l_points.Text = "Pisteet: " + points.ToString();
    }

    if (lastClickedBox != null && lastClickedImg != picboximg) 
    {
        lastClickedBox.BackgroundImage = valkoinen;
        picbox.BackgroundImage = picboximg;
        lastClickedBox = picbox;
        lastClickedImg = picboximg;
    }
    */


    /*
    private void pictureBox1_Click(object sender, EventArgs e)
    {
        if (clicks <= 1) 
        {
            pictureBox1.BackgroundImage = pb1img;
            lastClicked = pb1img;
            var timer = new System.Windows.Forms.Timer();
            timer.Tick += (sender, e) => TimeOut(pictureBox1, sender, e);
            timer.Interval = 2000;
            timer.Start();
        }
        if (clicks <= 1 && lastClicked == pb1img)
        {
            pictureBox1.BackgroundImage = pb1img;
            lastClicked = pb1img;
            points++;
            l_points.Text = "Pisteet: " + points.ToString();
        }
    }
    

    static void TimeOut(PictureBox picbox, PictureBox picbox2, object sender, EventArgs e)
        {
            picbox.BackgroundImage = valkoinen;
            picbox2.BackgroundImage = valkoinen;
        }


    */



    }
}
