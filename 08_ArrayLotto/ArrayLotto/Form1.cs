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
            int oikeatluvut = 0;


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

            int ol1 = Int32.Parse(textBox1.Text);
            int ol2 = Int32.Parse(textBox2.Text);
            int ol3 = Int32.Parse(textBox3.Text);
            int ol4 = Int32.Parse(textBox4.Text);
            int ol5 = Int32.Parse(textBox5.Text);
            int ol6 = Int32.Parse(textBox6.Text);
            int ol7 = Int32.Parse(textBox7.Text);

            int[] omarivi = {ol1,ol2,ol3,ol4,ol5,ol6,ol7};

            foreach (int x in omarivi)
            {
                foreach (int y in kaikkinumerot)
                {
                    if (x==y)
                    {
                        oikeatluvut++;
                    }
                }
            }
            l_oikeatluvut.Text = "Oikeat luvut: " + oikeatluvut.ToString();


        }
    }
}
