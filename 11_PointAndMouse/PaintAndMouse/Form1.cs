namespace PaintAndMouse
{
    public partial class Form1 : Form
    {

        Point piste = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
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

    }
}
