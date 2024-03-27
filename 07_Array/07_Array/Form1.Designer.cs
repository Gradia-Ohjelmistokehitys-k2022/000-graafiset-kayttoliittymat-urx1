namespace _07_Array
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            l_hakutulos = new Label();
            tb_taulukonkoko = new TextBox();
            tb_talletettavanumero = new TextBox();
            tb_talletuspaikanindeksi1 = new TextBox();
            tb_talletuspaikanindeksi2 = new TextBox();
            b_luotaulukko = new Button();
            b_talleta = new Button();
            b_hae = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 75);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Taulukon koko:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 28);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 1;
            label2.Text = "TAULUKON LUONTI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 180);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 2;
            label3.Text = "Talletettava numero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 229);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 3;
            label4.Text = "Talletuspaikan indeksi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 330);
            label5.Name = "label5";
            label5.Size = new Size(155, 20);
            label5.TabIndex = 4;
            label5.Text = "Talletuspaikan indeksi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(218, 135);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 5;
            label6.Text = "TALLENNUS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(218, 284);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 6;
            label7.Text = "HAKU";
            // 
            // l_hakutulos
            // 
            l_hakutulos.AutoSize = true;
            l_hakutulos.Location = new Point(218, 396);
            l_hakutulos.Name = "l_hakutulos";
            l_hakutulos.Size = new Size(0, 20);
            l_hakutulos.TabIndex = 7;
            // 
            // tb_taulukonkoko
            // 
            tb_taulukonkoko.Location = new Point(218, 75);
            tb_taulukonkoko.Name = "tb_taulukonkoko";
            tb_taulukonkoko.Size = new Size(125, 27);
            tb_taulukonkoko.TabIndex = 8;
            // 
            // tb_talletettavanumero
            // 
            tb_talletettavanumero.Location = new Point(218, 177);
            tb_talletettavanumero.Name = "tb_talletettavanumero";
            tb_talletettavanumero.Size = new Size(125, 27);
            tb_talletettavanumero.TabIndex = 9;
            // 
            // tb_talletuspaikanindeksi1
            // 
            tb_talletuspaikanindeksi1.Location = new Point(218, 222);
            tb_talletuspaikanindeksi1.Name = "tb_talletuspaikanindeksi1";
            tb_talletuspaikanindeksi1.Size = new Size(125, 27);
            tb_talletuspaikanindeksi1.TabIndex = 10;
            // 
            // tb_talletuspaikanindeksi2
            // 
            tb_talletuspaikanindeksi2.Location = new Point(218, 327);
            tb_talletuspaikanindeksi2.Name = "tb_talletuspaikanindeksi2";
            tb_talletuspaikanindeksi2.Size = new Size(125, 27);
            tb_talletuspaikanindeksi2.TabIndex = 11;
            // 
            // b_luotaulukko
            // 
            b_luotaulukko.Location = new Point(381, 75);
            b_luotaulukko.Name = "b_luotaulukko";
            b_luotaulukko.Size = new Size(176, 29);
            b_luotaulukko.TabIndex = 12;
            b_luotaulukko.Text = "Luo taulukko";
            b_luotaulukko.UseVisualStyleBackColor = true;
            b_luotaulukko.Click += b_luotaulukko_Click;
            // 
            // b_talleta
            // 
            b_talleta.Location = new Point(381, 222);
            b_talleta.Name = "b_talleta";
            b_talleta.Size = new Size(176, 29);
            b_talleta.TabIndex = 13;
            b_talleta.Text = "Talleta";
            b_talleta.UseVisualStyleBackColor = true;
            b_talleta.Click += b_talleta_Click;
            // 
            // b_hae
            // 
            b_hae.Location = new Point(381, 327);
            b_hae.Name = "b_hae";
            b_hae.Size = new Size(176, 29);
            b_hae.TabIndex = 14;
            b_hae.Text = "Hae";
            b_hae.UseVisualStyleBackColor = true;
            b_hae.Click += b_hae_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(b_hae);
            Controls.Add(b_talleta);
            Controls.Add(b_luotaulukko);
            Controls.Add(tb_talletuspaikanindeksi2);
            Controls.Add(tb_talletuspaikanindeksi1);
            Controls.Add(tb_talletettavanumero);
            Controls.Add(tb_taulukonkoko);
            Controls.Add(l_hakutulos);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label l_hakutulos;
        private TextBox tb_taulukonkoko;
        private TextBox tb_talletettavanumero;
        private TextBox tb_talletuspaikanindeksi1;
        private TextBox tb_talletuspaikanindeksi2;
        private Button b_luotaulukko;
        private Button b_talleta;
        private Button b_hae;
    }
}
