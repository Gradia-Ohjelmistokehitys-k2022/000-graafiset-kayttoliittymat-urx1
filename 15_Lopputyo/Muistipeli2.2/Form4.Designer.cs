namespace Muistipeli
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tb_p1nimi = new TextBox();
            tb_p2nimi = new TextBox();
            b_aloitapeli = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 92);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Pelaaja 2 nimi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 39);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Pelaaja 1 nimi:";
            // 
            // tb_p1nimi
            // 
            tb_p1nimi.Location = new Point(164, 36);
            tb_p1nimi.Name = "tb_p1nimi";
            tb_p1nimi.Size = new Size(244, 27);
            tb_p1nimi.TabIndex = 2;
            // 
            // tb_p2nimi
            // 
            tb_p2nimi.Location = new Point(164, 89);
            tb_p2nimi.Name = "tb_p2nimi";
            tb_p2nimi.Size = new Size(244, 27);
            tb_p2nimi.TabIndex = 3;
            // 
            // b_aloitapeli
            // 
            b_aloitapeli.Location = new Point(164, 142);
            b_aloitapeli.Name = "b_aloitapeli";
            b_aloitapeli.Size = new Size(94, 29);
            b_aloitapeli.TabIndex = 4;
            b_aloitapeli.Text = "Aloita peli!";
            b_aloitapeli.UseVisualStyleBackColor = true;
            b_aloitapeli.Click += b_aloitapeli_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 201);
            Controls.Add(b_aloitapeli);
            Controls.Add(tb_p2nimi);
            Controls.Add(tb_p1nimi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_p1nimi;
        private TextBox tb_p2nimi;
        private Button b_aloitapeli;
    }
}