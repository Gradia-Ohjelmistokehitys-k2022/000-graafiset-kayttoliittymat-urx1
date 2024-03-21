namespace _01_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //uusitietue
        {
            tb_elokuvannimi.Text = "Syötä elokuvan nimi";
            tb_julkaisuvuosi.Text = "Syötä elokuvan julkaisuvuosi";
            tb_kesto.Text = "Syötä elokuvan kesto minuuteissa";
            textBox5.Text = "Syötä elokuvan arvio";
        }

        private void button4_Click(object sender, EventArgs e) //tallenna
        {
            if (tb_elokuvannimi.Text == "" || tb_julkaisuvuosi.Text == ""
            || tb_kesto.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Kaikkia tarvittavia tietoja ei ole syötetty.");
            }


            if (tb_julkaisuvuosi.Text.All(char.IsDigit) == false || tb_kesto.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Julkaisuvuosi ja Kesto kenttiin ei voi syöttää muita kuin numeroita");
                tb_julkaisuvuosi.Text = "";
                tb_kesto.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("Kaikki ok!");

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tiedostoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Urho Tulonen!");
        }

        private void tb_elokuvannimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_id_Click(object sender, EventArgs e)
        {
            tb_elokuvannimi.Text = "";
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_elokuvannimi_Click(object sender, EventArgs e)
        {
            tb_elokuvannimi.Text = "";
        }

        private void tb_julkaisuvuosi_Click(object sender, EventArgs e)
        {
            tb_julkaisuvuosi.Text = "";
        }

        private void tb_kesto_Click(object sender, EventArgs e)
        {
            tb_kesto.Text = "";
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Syötä elokuvan arvio";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_elokuvannimi_Leave(object sender, EventArgs e)
        {
            if (tb_elokuvannimi.Text == "")
            {
                tb_elokuvannimi.Text = "Syötä elokuvan nimi";
            }
        }

        private void tb_julkaisuvuosi_Leave(object sender, EventArgs e)
        {
            if (tb_julkaisuvuosi.Text == "")
            {
                tb_julkaisuvuosi.Text = "Syötä elokuvan julkaisuvuosi";
            }
        }

        private void tb_kesto_Leave(object sender, EventArgs e)
        {
            if (tb_kesto.Text == "")
            {
                tb_kesto.Text = "Syötä elokuvan kesto";
            }
        }
    }
}
