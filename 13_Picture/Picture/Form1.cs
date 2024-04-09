namespace Picture
{
    public partial class Form1 : Form
    {

        int p_x;
        int p_y;
        Bitmap img;

        Point piste = new Point();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point piste = new Point(p_x, p_y);

            Bitmap img = Properties.Resources.picture04;

            Image newImg = img;

            img.MakeTransparent();
            
            e.Graphics.DrawImage(newImg, p_x, p_y, newImg.Width, newImg.Height);
            

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

  
                p_x = e.Location.X;
                p_y = e.Location.Y;



               ointi ja t�m�n j�lkeen Paint()-metodin kutsu. 

                Invalidate();

            }
        }
    }
}
