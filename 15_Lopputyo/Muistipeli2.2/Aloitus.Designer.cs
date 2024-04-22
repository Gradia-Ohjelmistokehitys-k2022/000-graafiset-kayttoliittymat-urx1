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
            b_aloita4x4 = new Button();
            b_aloita2p = new Button();
            b_luetulokset = new Button();
            SuspendLayout();
            // 
            // b_aloita3x4
            // 
            b_aloita3x4.Location = new Point(299, 94);
            b_aloita3x4.Name = "b_aloita3x4";
            b_aloita3x4.Size = new Size(180, 29);
            b_aloita3x4.TabIndex = 0;
            b_aloita3x4.Text = "Aloita peli (3x4)";
            b_aloita3x4.UseVisualStyleBackColor = true;
            b_aloita3x4.Click += b_aloita3x4_Click;
            // 
            // b_aloita4x4
            // 
            b_aloita4x4.Location = new Point(299, 158);
            b_aloita4x4.Name = "b_aloita4x4";
            b_aloita4x4.Size = new Size(180, 29);
            b_aloita4x4.TabIndex = 1;
            b_aloita4x4.Text = "Aloita peli (4x4)";
            b_aloita4x4.UseVisualStyleBackColor = true;
            b_aloita4x4.Click += b_aloita4x4_Click;
            // 
            // b_aloita2p
            // 
            b_aloita2p.Location = new Point(299, 222);
            b_aloita2p.Name = "b_aloita2p";
            b_aloita2p.Size = new Size(180, 29);
            b_aloita2p.TabIndex = 2;
            b_aloita2p.Text = "Aloita kaksinpeli";
            b_aloita2p.UseVisualStyleBackColor = true;
            b_aloita2p.Click += b_aloita2p_Click;
            // 
            // b_luetulokset
            // 
            b_luetulokset.Location = new Point(299, 288);
            b_luetulokset.Name = "b_luetulokset";
            b_luetulokset.Size = new Size(180, 29);
            b_luetulokset.TabIndex = 3;
            b_luetulokset.Text = "Lue pelien tuloksia";
            b_luetulokset.UseVisualStyleBackColor = true;
            b_luetulokset.Click += b_luetulokset_Click;
            // 
            // Aloitus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(b_luetulokset);
            Controls.Add(b_aloita2p);
            Controls.Add(b_aloita4x4);
            Controls.Add(b_aloita3x4);
            Name = "Aloitus";
            Text = "Aloitus";
            ResumeLayout(false);
        }

        #endregion

        private Button b_aloita3x4;
        private Button b_aloita4x4;
        private Button b_aloita2p;
        private Button b_luetulokset;
    }
}