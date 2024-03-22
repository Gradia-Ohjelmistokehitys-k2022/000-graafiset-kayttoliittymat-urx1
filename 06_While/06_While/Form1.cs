namespace _06_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            show_b_start_mbox();
        }

        private void show_b_start_mbox()
        {
            DialogResult dialogResult = MessageBox.Show("Paina YES jatkaaksesi, NO lopettaaksesi.", "HUOM!", MessageBoxButtons.YesNo);
            while (dialogResult == DialogResult.No)
            {
                Close();
            }
        }
    }
}
