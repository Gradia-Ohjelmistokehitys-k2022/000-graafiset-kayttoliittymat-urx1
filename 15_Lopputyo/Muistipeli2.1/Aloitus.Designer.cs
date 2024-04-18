namespace Muistipeli
{
    partial class Aloitus
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
            b_aloita3x4 = new Button();
            SuspendLayout();
            // 
            // b_aloita3x4
            // 
            b_aloita3x4.Location = new Point(301, 155);
            b_aloita3x4.Name = "b_aloita3x4";
            b_aloita3x4.Size = new Size(180, 29);
            b_aloita3x4.TabIndex = 0;
            b_aloita3x4.Text = "Aloita peli (3x4)";
            b_aloita3x4.UseVisualStyleBackColor = true;
            b_aloita3x4.Click += b_aloita3x4_Click;
            // 
            // Aloitus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(b_aloita3x4);
            Name = "Aloitus";
            Text = "Aloitus";
            ResumeLayout(false);
        }

        #endregion

        private Button b_aloita3x4;
    }
}