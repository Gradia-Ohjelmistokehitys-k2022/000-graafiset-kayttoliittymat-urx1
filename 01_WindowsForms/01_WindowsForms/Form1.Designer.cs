namespace _01_WindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            l_elokuvantiedot = new Label();
            l_toiminnallisuus = new Label();
            button1 = new Button();
            button2 = new Button();
            b_uusitietue = new Button();
            b_tallenna = new Button();
            b_poista = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            l_id = new Label();
            l_elokuvannimi = new Label();
            l_julkaisuvuosi = new Label();
            l_kesto = new Label();
            b_edellinen = new Button();
            b_seuraava = new Button();
            l_arvosana = new Label();
            textBox5 = new TextBox();
            l_arvio = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            menuStrip1 = new MenuStrip();
            tiedostoToolStripMenuItem = new ToolStripMenuItem();
            poistuToolStripMenuItem = new ToolStripMenuItem();
            tietojaToolStripMenuItem = new ToolStripMenuItem();
            testaaTietokantayhteyttäToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // l_elokuvantiedot
            // 
            l_elokuvantiedot.AutoSize = true;
            l_elokuvantiedot.Location = new Point(13, 10);
            l_elokuvantiedot.Name = "l_elokuvantiedot";
            l_elokuvantiedot.Size = new Size(112, 20);
            l_elokuvantiedot.TabIndex = 0;
            l_elokuvantiedot.Text = "Elokuvan tiedot";
            // 
            // l_toiminnallisuus
            // 
            l_toiminnallisuus.AutoSize = true;
            l_toiminnallisuus.Location = new Point(17, 10);
            l_toiminnallisuus.Name = "l_toiminnallisuus";
            l_toiminnallisuus.Size = new Size(110, 20);
            l_toiminnallisuus.TabIndex = 1;
            l_toiminnallisuus.Text = "Toiminnallisuus";
            l_toiminnallisuus.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(69, 206);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(195, 206);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // b_uusitietue
            // 
            b_uusitietue.Location = new Point(17, 77);
            b_uusitietue.Name = "b_uusitietue";
            b_uusitietue.Size = new Size(230, 46);
            b_uusitietue.TabIndex = 4;
            b_uusitietue.Text = "Uusi tietue";
            b_uusitietue.UseVisualStyleBackColor = true;
            b_uusitietue.Click += button3_Click;
            // 
            // b_tallenna
            // 
            b_tallenna.BackColor = Color.FromArgb(0, 192, 0);
            b_tallenna.Location = new Point(17, 138);
            b_tallenna.Name = "b_tallenna";
            b_tallenna.Size = new Size(230, 53);
            b_tallenna.TabIndex = 5;
            b_tallenna.Text = "Tallenna";
            b_tallenna.UseVisualStyleBackColor = false;
            b_tallenna.Click += button4_Click;
            // 
            // b_poista
            // 
            b_poista.BackColor = Color.Red;
            b_poista.ForeColor = SystemColors.ActiveBorder;
            b_poista.Location = new Point(17, 204);
            b_poista.Name = "b_poista";
            b_poista.Size = new Size(230, 52);
            b_poista.TabIndex = 6;
            b_poista.Text = "Poista";
            b_poista.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(166, 52);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 27);
            textBox4.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(142, 511);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(49, 27);
            numericUpDown1.TabIndex = 11;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(206, 511);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(50, 27);
            numericUpDown2.TabIndex = 12;
            // 
            // l_id
            // 
            l_id.AutoSize = true;
            l_id.Location = new Point(33, 55);
            l_id.Name = "l_id";
            l_id.Size = new Size(27, 20);
            l_id.TabIndex = 13;
            l_id.Text = "ID:";
            // 
            // l_elokuvannimi
            // 
            l_elokuvannimi.AutoSize = true;
            l_elokuvannimi.Location = new Point(33, 99);
            l_elokuvannimi.Name = "l_elokuvannimi";
            l_elokuvannimi.Size = new Size(104, 20);
            l_elokuvannimi.TabIndex = 14;
            l_elokuvannimi.Text = "Elokuvan nimi:";
            // 
            // l_julkaisuvuosi
            // 
            l_julkaisuvuosi.AutoSize = true;
            l_julkaisuvuosi.Location = new Point(33, 142);
            l_julkaisuvuosi.Name = "l_julkaisuvuosi";
            l_julkaisuvuosi.Size = new Size(96, 20);
            l_julkaisuvuosi.TabIndex = 15;
            l_julkaisuvuosi.Text = "Julkaisuvuosi:";
            // 
            // l_kesto
            // 
            l_kesto.AutoSize = true;
            l_kesto.Location = new Point(33, 189);
            l_kesto.Name = "l_kesto";
            l_kesto.Size = new Size(88, 20);
            l_kesto.TabIndex = 16;
            l_kesto.Text = "Kesto (min):";
            // 
            // b_edellinen
            // 
            b_edellinen.FlatAppearance.BorderColor = Color.Black;
            b_edellinen.FlatAppearance.BorderSize = 4;
            b_edellinen.Location = new Point(41, 246);
            b_edellinen.Name = "b_edellinen";
            b_edellinen.Size = new Size(150, 50);
            b_edellinen.TabIndex = 17;
            b_edellinen.Text = "Edellinen";
            b_edellinen.UseVisualStyleBackColor = true;
            // 
            // b_seuraava
            // 
            b_seuraava.FlatAppearance.BorderSize = 4;
            b_seuraava.Location = new Point(223, 246);
            b_seuraava.Name = "b_seuraava";
            b_seuraava.Size = new Size(159, 50);
            b_seuraava.TabIndex = 18;
            b_seuraava.Text = "Seuraava";
            b_seuraava.UseVisualStyleBackColor = true;
            // 
            // l_arvosana
            // 
            l_arvosana.AutoSize = true;
            l_arvosana.Location = new Point(13, 511);
            l_arvosana.Name = "l_arvosana";
            l_arvosana.Size = new Size(73, 20);
            l_arvosana.TabIndex = 19;
            l_arvosana.Text = "Arvosana:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(33, 348);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(377, 142);
            textBox5.TabIndex = 20;
            // 
            // l_arvio
            // 
            l_arvio.AutoSize = true;
            l_arvio.Location = new Point(13, 313);
            l_arvio.Name = "l_arvio";
            l_arvio.Size = new Size(47, 20);
            l_arvio.TabIndex = 21;
            l_arvio.Text = "Arvio:";
            // 
            // panel1
            // 
            panel1.Controls.Add(l_elokuvantiedot);
            panel1.Controls.Add(l_arvio);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(l_arvosana);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(b_seuraava);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(b_edellinen);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(l_kesto);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(l_julkaisuvuosi);
            panel1.Controls.Add(l_id);
            panel1.Controls.Add(l_elokuvannimi);
            panel1.Location = new Point(16, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 553);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(l_toiminnallisuus);
            panel2.Controls.Add(b_uusitietue);
            panel2.Controls.Add(b_poista);
            panel2.Controls.Add(b_tallenna);
            panel2.Location = new Point(493, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 553);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(12, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 583);
            panel3.TabIndex = 24;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiedostoToolStripMenuItem, tietojaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // tiedostoToolStripMenuItem
            // 
            tiedostoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { poistuToolStripMenuItem });
            tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            tiedostoToolStripMenuItem.Size = new Size(81, 24);
            tiedostoToolStripMenuItem.Text = "Tiedosto";
            tiedostoToolStripMenuItem.Click += tiedostoToolStripMenuItem_Click;
            // 
            // poistuToolStripMenuItem
            // 
            poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            poistuToolStripMenuItem.Size = new Size(224, 26);
            poistuToolStripMenuItem.Text = "Poistu";
            // 
            // tietojaToolStripMenuItem
            // 
            tietojaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testaaTietokantayhteyttäToolStripMenuItem, infoToolStripMenuItem });
            tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            tietojaToolStripMenuItem.Size = new Size(69, 24);
            tietojaToolStripMenuItem.Text = "Tietoja";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            testaaTietokantayhteyttäToolStripMenuItem.Size = new Size(258, 26);
            testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(258, 26);
            infoToolStripMenuItem.Text = "Info";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 626);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_elokuvantiedot;
        private Label l_toiminnallisuus;
        private Button button1;
        private Button button2;
        private Button b_uusitietue;
        private Button b_tallenna;
        private Button b_poista;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label l_id;
        private Label l_elokuvannimi;
        private Label l_julkaisuvuosi;
        private Label l_kesto;
        private Button b_edellinen;
        private Button b_seuraava;
        private Label l_arvosana;
        private TextBox textBox5;
        private Label l_arvio;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem poistuToolStripMenuItem;
        private ToolStripMenuItem tietojaToolStripMenuItem;
        private ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
    }
}
