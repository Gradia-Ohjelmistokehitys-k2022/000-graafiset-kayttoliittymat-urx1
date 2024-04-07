namespace _10_Dictionary
{
    public partial class Form1 : Form
    {

        Dictionary<string, string> dict1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dict1 = new Dictionary<string, string>();
            Console.WriteLine("Dictionary luotu.");
        }

        private void b_lisaa_Click(object sender, EventArgs e)
        {
            if (dict1 == null)
            {
                MessageBox.Show("Datarakennetta ei ole luotu.");
            }
            if (tb_lisaavalue.Text == "")
            {
                MessageBox.Show("Value kenttä ei voi olla tyhjä.");

            }
            if (tb_lisaakey.Text == "")
            {
                MessageBox.Show("Key ei voi olla tyhjä.");

            }
            else
            {
                dict1.Add(tb_lisaakey.Text, tb_lisaavalue.Text);
                Console.WriteLine("lisätty");
            }
        }

        private void b_hae_Click(object sender, EventArgs e)
        {
            if (tb_haekey.Text == "")
            {
                MessageBox.Show("Täsmennä millä avaimella haetaan.");
            }

            string haettavaAvain = tb_haekey.Text;

            if (dict1.ContainsKey(haettavaAvain))
            {
                l_haevalue.Text = dict1[haettavaAvain];
            }
            else
            {
                MessageBox.Show("Haettava avain ei löydy.");
            }
        }
    }
}
