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
            int lisänumero;
            int[] lottonumerot = new int[7];
            int[] lisänumerot = new int[2];
            var kaikkinumerot = lottonumerot.Concat(lisänumerot);

            Random rnd = new Random();

            while (counter < 7)
            {
                lottonumerot:
                lottonumero = rnd.Next(2,41);

                foreach (int x in lottonumerot)
                    if (x == lottonumero)
                    {
                        Console.WriteLine("TUPLAT: " + x + ", aloitetaan alusta.");
                        counter--;
                        goto lottonumerot;
                    }

                lottonumerot[counter] = lottonumero;

                Console.WriteLine(counter + " " + lottonumero);

                counter++;


            }

            while (counter < 9)
            {
            lisänumerot:
                lisänumero = rnd.Next(2, 41);

               // var kaikkinumerot = lottonumerot.Concat(lisänumerot);

                foreach (int x in kaikkinumerot)
                    if (x == lisänumero)
                    {
                        Console.WriteLine("TUPLAT: " + x + ", aloitetaan alusta.");

                        if ((counter-1) - 7 < 0 || (counter-1) > 2)
                        {
                            goto lisänumerot;
                        }

                        counter--;

                        goto lisänumerot;

                    }


                lisänumerot[counter-7] = lisänumero;
                Console.WriteLine(counter + " " + lisänumero);
                counter++;

            }

            Console.WriteLine("Numerot arvottu" + " " + counter);

            Array.Sort(lottonumerot);
            Array.Sort(lisänumerot);

            l_lottonumerot.Text = "Lottonumerot: " + string.Join(", ", lottonumerot) + " Lisänumerot: " + string.Join(",", lisänumerot);

            /*
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
                var lisänumerot = numerot[7..9];

                Array.Sort(lottonumerot);
                Array.Sort(lisänumerot);

                l_lottonumerot.Text = "Lottonumerot: " + string.Join(", ", lottonumerot) + " Lisänumerot: " + string.Join(",", lisänumerot);
                counter++;

                Console.WriteLine(counter.ToString() + " " + lottonumero.ToString());

            }
            */
        }
    }
}
