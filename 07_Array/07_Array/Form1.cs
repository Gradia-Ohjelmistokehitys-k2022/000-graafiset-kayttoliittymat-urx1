namespace _07_Array
{
    public partial class Form1 : Form
    {

        public static int[] myArray = new int[0];
        public Form1()
        {
            InitializeComponent();
        }

        public void b_luotaulukko_Click(object sender, EventArgs e)
        {
            if (tb_taulukonkoko.Text != "")
            {
                int number;
                bool isInt = int.TryParse(tb_taulukonkoko.Text, out number);
                if (isInt == true)
                {
                    int arrayLength = Int32.Parse(tb_taulukonkoko.Text);
                    Array.Resize<int>(ref myArray, arrayLength);
                }
                else
                {
                    MessageBox.Show("Tähän kenttään voi syöttää vaan numeroita.");
                }
            }
            else
            {
                MessageBox.Show("Puutteelliset tiedot.");
            }

        }

        public void b_talleta_Click(object sender, EventArgs e)
        {
            if (tb_talletettavanumero.Text != "" && tb_talletuspaikanindeksi1.Text != "")
            {
                int number;
                bool isInt = int.TryParse(tb_taulukonkoko.Text, out number);
                if (isInt == true)
                {
                    int intToSave = Int32.Parse(tb_talletettavanumero.Text);
                    int intIndex = Int32.Parse(tb_talletuspaikanindeksi1.Text);
                    myArray[intIndex] = intToSave;
                }
                else
                {
                    MessageBox.Show("Tähän kenttään voi syöttää vaan numeroita.");
                }
            }
            else
            {
                MessageBox.Show("Puutteelliset tiedot.");
            }
        }

        private void b_hae_Click(object sender, EventArgs e)
        {
            if (tb_talletuspaikanindeksi2.Text != "")
            {
                int number;
                bool isInt = int.TryParse(tb_talletuspaikanindeksi2.Text, out number);                
                if (isInt == true)
                {
                    int intToFind = Int32.Parse(tb_talletuspaikanindeksi2.Text);
                    int intFromArray = myArray[intToFind];
                    l_hakutulos.Text = intFromArray.ToString();

                }
                else
                {
                    MessageBox.Show("Tähän kenttään voi syöttää vain numeroita.");
                }
            }
            else
            {
                MessageBox.Show("Puutteelliset tiedot.");
            }
        }
    }
}
