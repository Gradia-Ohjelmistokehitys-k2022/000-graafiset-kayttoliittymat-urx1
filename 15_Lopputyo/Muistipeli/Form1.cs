/*using System.Runtime.CompilerServices;
using System.Security.Cryptography;
*/

using System.DirectoryServices;

namespace Muistipeli
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox1, pb1img);
            pictureBox2.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox2, pb2img);
            pictureBox3.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox3, pb3img);
            pictureBox4.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox4, pb4img);
            pictureBox5.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox5, pb5img);
            pictureBox6.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox6, pb6img);
            pictureBox7.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox7, pb7img);
            pictureBox8.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox8, pb8img);
            pictureBox9.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox9, pb9img);
            pictureBox10.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox10, pb10img);
            pictureBox11.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox11, pb11img);
            pictureBox12.Click += (sender, e) => pictureBoxClick(sender, e, pictureBox12, pb12img);
        }

        private static Random rng = new Random();

        int clicks = 0;
        int points = 0;
        static int tries = 6;

        static Image keltainen = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli\\kuvia\\keltainen.png");
        static Image musta = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli\\kuvia\\musta.png");
        static Image pinkki = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli\\kuvia\\pinkki.png");
        static Image tummapunainen = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli\\kuvia\\tummapunainen.png");
        static Image vaaleasininen = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli\\kuvia\\vaaleasininen.png");
        static Image vihrea = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli\\kuvia\\vihrea.png");
        static Image valkoinen = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli\\kuvia\\valkoinen.png");

        static List<Image> kuvapakka = new List<Image> { keltainen, keltainen, musta, musta, pinkki, pinkki, tummapunainen, tummapunainen, vaaleasininen, vaaleasininen, vihrea, vihrea };

        PictureBox lastClickedBox = null;

        Image lastClickedImg;

        static List<Image> kuvapakkaSekoitettu = kuvapakka.OrderBy(_ => rng.Next()).ToList();


        Image pb1img = kuvapakkaSekoitettu[0];
        Image pb2img = kuvapakkaSekoitettu[1];
        Image pb3img = kuvapakkaSekoitettu[2];
        Image pb4img = kuvapakkaSekoitettu[3];
        Image pb5img = kuvapakkaSekoitettu[4];
        Image pb6img = kuvapakkaSekoitettu[5];
        Image pb7img = kuvapakkaSekoitettu[6];
        Image pb8img = kuvapakkaSekoitettu[7];
        Image pb9img = kuvapakkaSekoitettu[8];
        Image pb10img = kuvapakkaSekoitettu[9];
        Image pb11img = kuvapakkaSekoitettu[10];
        Image pb12img = kuvapakkaSekoitettu[11];


        private void pictureBoxClick(object sender, EventArgs e, PictureBox picbox, Image picboximg)
        {

            if (lastClickedBox == null)
            {
                picbox.BackgroundImage = picboximg;
                lastClickedBox = picbox;
                lastClickedImg = picboximg;
            }
            else if (lastClickedBox.BackgroundImage == picboximg)
            {
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
                l_tries.Text = "Yrityksi� j�ljell�: " + tries;
            }


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
        */
        
        static void TimeOut(PictureBox picbox, PictureBox picbox2, object sender, EventArgs e)
        {
            picbox.BackgroundImage = valkoinen;
            picbox2.BackgroundImage = valkoinen;            
        }






    }
}