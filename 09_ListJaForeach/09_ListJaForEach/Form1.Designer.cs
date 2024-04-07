namespace _09_ListJaForEach
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
            b_luolista = new Button();
            b_lisaa = new Button();
            b_haku = new Button();
            tb_lisaa = new TextBox();
            cb_haku = new ComboBox();
            SuspendLayout();
            // 
            // b_luolista
            // 
            b_luolista.Location = new Point(218, 108);
            b_luolista.Name = "b_luolista";
            b_luolista.Size = new Size(94, 29);
            b_luolista.TabIndex = 0;
            b_luolista.Text = "Luo lista";
            b_luolista.UseVisualStyleBackColor = true;
            b_luolista.Click += b_luolista_Click;
            // 
            // b_lisaa
            // 
            b_lisaa.Location = new Point(385, 197);
            b_lisaa.Name = "b_lisaa";
            b_lisaa.Size = new Size(94, 29);
            b_lisaa.TabIndex = 1;
            b_lisaa.Text = "Lisää";
            b_lisaa.UseVisualStyleBackColor = true;
            b_lisaa.Click += b_lisaa_Click;
            // 
            // b_haku
            // 
            b_haku.Location = new Point(385, 290);
            b_haku.Name = "b_haku";
            b_haku.Size = new Size(94, 29);
            b_haku.TabIndex = 2;
            b_haku.Text = "Haku";
            b_haku.UseVisualStyleBackColor = true;
            b_haku.Click += b_haku_Click;
            // 
            // tb_lisaa
            // 
            tb_lisaa.Location = new Point(110, 197);
            tb_lisaa.Name = "tb_lisaa";
            tb_lisaa.Size = new Size(236, 27);
            tb_lisaa.TabIndex = 3;
            // 
            // cb_haku
            // 
            cb_haku.FormattingEnabled = true;
            cb_haku.Location = new Point(110, 290);
            cb_haku.Name = "cb_haku";
            cb_haku.Size = new Size(236, 28);
            cb_haku.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_haku);
            Controls.Add(tb_lisaa);
            Controls.Add(b_haku);
            Controls.Add(b_lisaa);
            Controls.Add(b_luolista);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_luolista;
        private Button b_lisaa;
        private Button b_haku;
        private TextBox tb_lisaa;
        private ComboBox cb_haku;
    }
}
