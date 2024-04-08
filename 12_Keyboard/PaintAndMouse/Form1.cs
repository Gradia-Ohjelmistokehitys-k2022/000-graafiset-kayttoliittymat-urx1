namespace PaintAndMouse
{
    public partial class Form1 : Form
    {
        int p_x = 666;
        int p_y = 222;

        //818x497
        Point piste = new Point();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point piste = new Point(p_x, p_y);

            Graphics Graf = e.Graphics;

            //pään piirto
            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);

            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            //selän piirto
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41, piste.X + 21, piste.Y + 131);

            //käsien piirto
            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60, piste.X + 70, piste.Y + 60);

            //jalkojen piirto
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131, piste.X - 30, piste.Y + 181);

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131, piste.X + 70, piste.Y + 181);

        }

        private void DrawCordinates(Graphics Graf)
        {
            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",

                new Font("Arial", 14, System.Drawing.FontStyle.Regular),

                new SolidBrush(Color.Black), 8, 30);
        }

        private void b_siirra_Click(object sender, EventArgs e)
        {
            p_x = Int32.Parse(tb_x.Text);
            p_y = Int32.Parse(tb_x.Text);
            Point piste = new Point(p_x, p_y);
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                // Talletetaan hiiren klikkauskohdan koordinaatit. Piste (0, 0) 

                // on formin työalueen vasemmassa ylä nurkassa 

                p_x = e.Location.X;
                p_y = e.Location.Y;



                // Merkitään formin työalue epäkelvoksi, jolloin saadaan aikaiseksi 

                // paint-eventin signalointi ja tämän jälkeen Paint()-metodin kutsu. 

                Invalidate();

            }


        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                p_x = e.Location.X;
                p_y = e.Location.Y;

                Invalidate();

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A)
            {
                p_x = p_x - 10;
            }
            if (e.KeyCode == Keys.S)
            {
                p_y = p_y + 10;
            }
            if (e.KeyCode == Keys.D)
            {
                p_x = p_x + 10;
            }
            if (e.KeyCode == Keys.W)
            {
                p_y = p_y - 10;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Invalidate();
        }
    }
}
