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
            int lis�numero;
            int[] lottonumerot = new int[7];
            int[] lis�numerot = new int[2];
            var kaikkinumerot = lottonumerot.Concat(lis�numerot);

            Random rnd = new Random();

            while (counter < 7)
            {
                lottonumerot:
                lottonumero = rnd.Next(2,41);

                foreach (int x in lottonumerot)
                    if (x == lottonumero)
                    {
                        Console.WriteLine("TUPLAT: " + x + ", arvotaan uudelleen.");
                        counter--;
                        goto lottonumerot;
                    }

                lottonumerot[counter] = lottonumero;

                Console.WriteLine(counter + " " + lottonumero);

                counter++;


            }

            while (counter < 9)
            {
            lis�numerot:
                lis�numero = rnd.Next(2, 41);

                foreach (int x in kaikkinumerot)
                    if (x == lis�numero)
                    {
                        Console.WriteLine("TUPLAT: " + x + ", arvotaan uudelleen.");

                        if ((counter-1) - 7 < 0 || (counter-1) > 2)
                        {
                            goto lis�numerot;
                        }

                        counter--;

                        goto lis�numerot;

                    }


                lis�numerot[counter-7] = lis�numero;
                Console.WriteLine(counter + " " + lis�numero);
                counter++;

            }

            Console.WriteLine("Numerot arvottu" + " " + counter);

            Array.Sort(lottonumerot);
            Array.Sort(lis�numerot);

            l_lottonumerot.Text = "Lottonumerot: " + string.Join(", ", lottonumerot) + " Lis�numerot: " + string.Join(",", lis�numerot);

        }
    }
}
