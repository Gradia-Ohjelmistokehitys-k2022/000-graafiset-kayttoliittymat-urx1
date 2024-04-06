using System.Diagnostics.Metrics;

namespace ArrayLotto
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_arvoluvut_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int lottonumero;
            int[] lottonumerot = new int[7];
            int[] lisänumerot = new int[2];
            Random rnd = new Random();

            while (counter < 7)           
            {
                alku:
                lottonumero = rnd.Next(2, 41);

                foreach (int x in lottonumerot)
                    if (x == lottonumero)
                    {
                        Console.WriteLine("TUPLAT: " + x + ", aloitetaan alusta.");
                        counter-- ;
                        goto alku;
                    }

                lottonumerot[counter] = lottonumero;
                l_lottonumerot.Text = string.Join(", ", lottonumerot);
                counter++;
                Console.WriteLine(counter.ToString() + " " + lottonumero.ToString());

            }

        }
    }
}
