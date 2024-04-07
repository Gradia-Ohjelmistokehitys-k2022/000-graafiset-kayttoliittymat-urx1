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
            int[] numerot = new int[9];
            Random rnd = new Random();

            while (counter < 9)           
            {
                alku:
                lottonumero = rnd.Next(2, 41);

                foreach (int x in numerot)
                    if (x == lottonumero)
                    {
                        Console.WriteLine("TUPLAT: " + x + ", aloitetaan alusta.");
                        counter-- ;
                        goto alku;
                    }

                numerot[counter] = lottonumero;

                var lottonumerot = numerot[0..7];
                var lis�numerot = numerot[7..9];

                Array.Sort(lottonumerot);
                Array.Sort(lis�numerot);

                l_lottonumerot.Text = "Lottonumerot: " + string.Join(", ", lottonumerot) + " Lis�numerot: " + string.Join(",", lis�numerot);
                counter++;

                Console.WriteLine(counter.ToString() + " " + lottonumero.ToString());

            }

        }
    }
}
