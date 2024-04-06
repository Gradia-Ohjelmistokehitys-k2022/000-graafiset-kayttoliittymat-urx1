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
            SuspendLayout();
            // 
            // b_arvoluvut
            // 
            b_arvoluvut.Location = new Point(345, 155);
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
            l_lottonumerot.Location = new Point(386, 88);
            l_lottonumerot.Name = "l_lottonumerot";
            l_lottonumerot.Size = new Size(0, 20);
            l_lottonumerot.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
