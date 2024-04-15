using TuoteNS;

namespace DelegaatitJaEventit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 f2;


        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tarkistaPvmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new Form2();
                //f2.MdiParent = this;
                //jos ei käytä tätä voi vaihtaa form 1 MdiContainer = false
                f2.Show();
            }
            else
            {
                f2.Activate();
            }
        }

        private void b_lisaatuote_Click(object sender, EventArgs e)
        {
            if (tb_nimi.Text == "" || tb_paino.Text == "" || tb_lukumaara.Text == "" || tb_hakupaiva.Text == "")
            {
                MessageBox.Show("Puutteelliset tiedot.");
            }
            else
            {
                string objNimi = tb_nimi.Text;
                int objPaino = Int32.Parse(tb_paino.Text);
                int objLukumaara = Int32.Parse(tb_lukumaara.Text);
                DateTime objHakupaiva = DateTime.Parse(tb_hakupaiva.Text);
                Tuote Tuote = new Tuote(objNimi, objPaino, objLukumaara, objHakupaiva);
                MessageBox.Show("Tuote lisätty");
            }
        }
    }
}
