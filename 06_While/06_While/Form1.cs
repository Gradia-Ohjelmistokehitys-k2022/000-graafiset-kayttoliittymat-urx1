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
            DialogBox();
        }

        private void DialogBox()
        {
            DialogResult dialogBox = MessageBox.Show("Paina YES jatkaaksesi ja NO lopettaaksesi.", "HUOM!", MessageBoxButtons.YesNo);
            while (dialogBox == DialogResult.No) 
            {
                Close();
            }
        }
    }
}
