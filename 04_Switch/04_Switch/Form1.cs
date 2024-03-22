namespace _04_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void posuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Click(object sender, EventArgs e) 
        {
            Button painettuNappi = sender as Button;
            MessageBox.Show(painettuNappi.Text);
        }

    }
}
