namespace DelegaatitJaEventit
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
            label1 = new Label();
            label2 = new Label();
            tb_nimi = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tb_paino = new TextBox();
            tb_lukumaara = new TextBox();
            menuStrip1 = new MenuStrip();
            tiedostoToolStripMenuItem = new ToolStripMenuItem();
            tarkistaPvmToolStripMenuItem = new ToolStripMenuItem();
            suljeToolStripMenuItem = new ToolStripMenuItem();
            b_lisaatuote = new Button();
            dp_hakupvm = new DateTimePicker();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 105);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Tuotteen nimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 226);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 1;
            label2.Text = "Viimeinen hakupäivä";
            // 
            // tb_nimi
            // 
            tb_nimi.Location = new Point(232, 105);
            tb_nimi.Name = "tb_nimi";
            tb_nimi.Size = new Size(250, 27);
            tb_nimi.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 146);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 3;
            label3.Text = "Tuotteen paino";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 185);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 4;
            label4.Text = "Tuotteen lukumäärä";
            // 
            // tb_paino
            // 
            tb_paino.Location = new Point(232, 146);
            tb_paino.Name = "tb_paino";
            tb_paino.Size = new Size(250, 27);
            tb_paino.TabIndex = 5;
            // 
            // tb_lukumaara
            // 
            tb_lukumaara.Location = new Point(232, 185);
            tb_lukumaara.Name = "tb_lukumaara";
            tb_lukumaara.Size = new Size(250, 27);
            tb_lukumaara.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiedostoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(618, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            tiedostoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tarkistaPvmToolStripMenuItem, suljeToolStripMenuItem });
            tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            tiedostoToolStripMenuItem.Size = new Size(81, 24);
            tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // tarkistaPvmToolStripMenuItem
            // 
            tarkistaPvmToolStripMenuItem.Name = "tarkistaPvmToolStripMenuItem";
            tarkistaPvmToolStripMenuItem.Size = new Size(174, 26);
            tarkistaPvmToolStripMenuItem.Text = "Tarkista pvm";
            tarkistaPvmToolStripMenuItem.Click += tarkistaPvmToolStripMenuItem_Click;
            // 
            // suljeToolStripMenuItem
            // 
            suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            suljeToolStripMenuItem.Size = new Size(174, 26);
            suljeToolStripMenuItem.Text = "Sulje";
            suljeToolStripMenuItem.Click += suljeToolStripMenuItem_Click;
            // 
            // b_lisaatuote
            // 
            b_lisaatuote.Location = new Point(232, 272);
            b_lisaatuote.Name = "b_lisaatuote";
            b_lisaatuote.Size = new Size(162, 29);
            b_lisaatuote.TabIndex = 11;
            b_lisaatuote.Text = "Lisää tuote";
            b_lisaatuote.UseVisualStyleBackColor = true;
            b_lisaatuote.Click += b_lisaatuote_Click;
            // 
            // dp_hakupvm
            // 
            dp_hakupvm.Location = new Point(232, 221);
            dp_hakupvm.Name = "dp_hakupvm";
            dp_hakupvm.Size = new Size(250, 27);
            dp_hakupvm.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 404);
            Controls.Add(dp_hakupvm);
            Controls.Add(b_lisaatuote);
            Controls.Add(tb_lukumaara);
            Controls.Add(tb_paino);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_nimi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_nimi;
        private Label label3;
        private Label label4;
        private TextBox tb_paino;
        private TextBox tb_lukumaara;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem tarkistaPvmToolStripMenuItem;
        private ToolStripMenuItem suljeToolStripMenuItem;
        private Button b_lisaatuote;
        private DateTimePicker dp_hakupvm;
    }
}
