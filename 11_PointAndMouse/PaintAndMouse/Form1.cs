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

            //p‰‰n piirto
            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);

            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            //sel‰n piirto
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41, piste.X + 21, piste.Y + 131);

            //k‰sien piirto
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
    }
}
