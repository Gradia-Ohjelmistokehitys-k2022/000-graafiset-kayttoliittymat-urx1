﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void b_aloitapeli_Click(object sender, EventArgs e)
        {
            var form3 = new Form3(tb_p1nimi.Text, tb_p2nimi.Text);
            form3.Show();
        }
    }
}
