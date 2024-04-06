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

            foreach (int value in Enumerable.Range(1, 7))
            {
                lottonumero = rnd.Next(2, 41);
                foreach (int i in lottonumerot)
                    if (counter < 8)
                    {
                        if (i == lottonumero)
                        {
                            counter--;
                            return;
                        }
                    }
                    else
                    {
                        break;
                    }

                lottonumerot[counter] = lottonumero;
                counter++;

                l_lottonumerot.Text = string.Join(",", lottonumerot);
                Console.WriteLine(counter);

            }

        }
    }
}
