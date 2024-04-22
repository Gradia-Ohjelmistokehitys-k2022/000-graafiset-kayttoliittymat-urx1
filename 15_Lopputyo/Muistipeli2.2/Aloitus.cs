using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class Aloitus : Form
    {
        public Aloitus()
        {
            InitializeComponent();
        }

        private void b_aloita3x4_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
        }

        private void b_aloita4x4_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void b_aloita2p_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.Show();
        }

        private void b_luetulokset_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Koti\\Desktop\\muistipeli.txt";

            if (File.Exists(path)) 
            {
                try
                {
                    // Open the text file using a stream reader.
                    using (var sr = new StreamReader(path))
                    {
                        // Read the stream as a string, and write the string to the console.
                        MessageBox.Show(sr.ReadToEnd());
                    }
                }
                catch (IOException x)
                {
                    MessageBox.Show("Tiedostoa ei löydy! Oletko jo pelannut peliä?");
                }
            }
        }
    }
}
