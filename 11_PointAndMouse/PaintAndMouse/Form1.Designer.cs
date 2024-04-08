namespace PaintAndMouse
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
            b_siirra = new Button();
            tb_y = new TextBox();
            tb_x = new TextBox();
            SuspendLayout();
            // 
            // b_siirra
            // 
            b_siirra.Location = new Point(102, 214);
            b_siirra.Name = "b_siirra";
            b_siirra.Size = new Size(94, 29);
            b_siirra.TabIndex = 0;
            b_siirra.Text = "Siirrä";
            b_siirra.UseVisualStyleBackColor = true;
            b_siirra.Click += b_siirra_Click;
            // 
            // tb_y
            // 
            tb_y.Location = new Point(158, 170);
            tb_y.Name = "tb_y";
            tb_y.Size = new Size(38, 27);
            tb_y.TabIndex = 1;
            // 
            // tb_x
            // 
            tb_x.Location = new Point(102, 170);
            tb_x.Name = "tb_x";
            tb_x.Size = new Size(38, 27);
            tb_x.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_x);
            Controls.Add(tb_y);
            Controls.Add(b_siirra);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_siirra;
        private TextBox tb_y;
        private TextBox tb_x;
    }
}
