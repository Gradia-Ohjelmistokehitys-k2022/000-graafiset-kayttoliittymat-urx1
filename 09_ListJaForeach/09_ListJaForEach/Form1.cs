namespace _09_ListJaForEach
{
    public partial class Form1 : Form
    {

        List<string> lista1;

        public Form1()
        {
            InitializeComponent();
        }

        public void b_luolista_Click(object sender, EventArgs e)
        {
            lista1 = new List<string>();
            Console.WriteLine("Lista luotu.");
        }

        public void b_lisaa_Click(object sender, EventArgs e)
        {
            if (tb_lisaa.Text == "")
            {
                MessageBox.Show("Ei voida lis‰t‰ tyhj‰‰ merkkijonoa.");
            }
            else
            {
                lista1.Add(tb_lisaa.Text);
                Console.WriteLine(lista1.ToString());
            }
        }

        private void b_haku_Click(object sender, EventArgs e)
        {

            int counter = 0;

            foreach (string s in lista1) 
            {
                cb_haku.Items.Add(s);
            }

        }
    }
}
