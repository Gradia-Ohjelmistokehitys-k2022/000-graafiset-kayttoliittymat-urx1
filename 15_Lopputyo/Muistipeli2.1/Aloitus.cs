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
    }
}
