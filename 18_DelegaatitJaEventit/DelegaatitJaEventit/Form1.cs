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
    }
}
