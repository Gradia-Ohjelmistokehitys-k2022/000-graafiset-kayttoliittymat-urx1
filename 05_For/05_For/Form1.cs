using System.Diagnostics.Metrics;

namespace _05_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            var updateTask = new Thread(UpdateLabel);
            updateTask.Start();
        }

        private void UpdateLabel()
        {
            int usrInput = int.Parse(tb_int.Text);
            for (int i = 1; i <= usrInput; i++)
            //foreach (int value in Enumerable.Range(1, usrInput))
            {
                string valueString = i.ToString();
                l_display.Text = i.ToString();
                Thread.Sleep(1000);
            }
        }

        private void tb_int_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
