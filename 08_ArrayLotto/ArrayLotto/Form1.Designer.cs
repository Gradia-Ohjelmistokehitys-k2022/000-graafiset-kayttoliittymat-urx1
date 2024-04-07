namespace ArrayLotto
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
            b_arvoluvut = new Button();
            l_lottonumerot = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            l_oikeatluvut = new Label();
            SuspendLayout();
            // 
            // b_arvoluvut
            // 
            b_arvoluvut.Location = new Point(356, 161);
            b_arvoluvut.Name = "b_arvoluvut";
            b_arvoluvut.Size = new Size(94, 29);
            b_arvoluvut.TabIndex = 0;
            b_arvoluvut.Text = "Arvo luvut";
            b_arvoluvut.UseVisualStyleBackColor = true;
            b_arvoluvut.Click += b_arvoluvut_Click;
            // 
            // l_lottonumerot
            // 
            l_lottonumerot.AutoSize = true;
            l_lottonumerot.Location = new Point(402, 96);
            l_lottonumerot.Name = "l_lottonumerot";
            l_lottonumerot.Size = new Size(0, 20);
            l_lottonumerot.TabIndex = 1;
            l_lottonumerot.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 223);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(30, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(338, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(30, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(386, 223);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(30, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(479, 223);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(30, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(237, 223);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(30, 27);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(431, 223);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(30, 27);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(529, 223);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(30, 27);
            textBox7.TabIndex = 8;
            // 
            // l_oikeatluvut
            // 
            l_oikeatluvut.AutoSize = true;
            l_oikeatluvut.Location = new Point(386, 308);
            l_oikeatluvut.Name = "l_oikeatluvut";
            l_oikeatluvut.Size = new Size(0, 20);
            l_oikeatluvut.TabIndex = 9;
            l_oikeatluvut.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(l_oikeatluvut);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(l_lottonumerot);
            Controls.Add(b_arvoluvut);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_arvoluvut;
        private Label l_lottonumerot;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label l_oikeatluvut;
    }
}
