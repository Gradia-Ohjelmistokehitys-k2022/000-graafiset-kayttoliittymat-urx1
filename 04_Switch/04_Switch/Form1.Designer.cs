namespace _04_Switch
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
            b_valinta1 = new Button();
            b_valinta2 = new Button();
            b_valinta3 = new Button();
            b_valinta4 = new Button();
            b_default = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            posuitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // b_valinta1
            // 
            b_valinta1.Location = new Point(88, 78);
            b_valinta1.Name = "b_valinta1";
            b_valinta1.Size = new Size(94, 29);
            b_valinta1.TabIndex = 0;
            b_valinta1.Text = "Valinta 1";
            b_valinta1.UseVisualStyleBackColor = true;
            b_valinta1.Click += button_Click;
            // 
            // b_valinta2
            // 
            b_valinta2.Location = new Point(88, 131);
            b_valinta2.Name = "b_valinta2";
            b_valinta2.Size = new Size(94, 29);
            b_valinta2.TabIndex = 1;
            b_valinta2.Text = "Valinta 2";
            b_valinta2.UseVisualStyleBackColor = true;
            b_valinta2.Click += button_Click;
            // 
            // b_valinta3
            // 
            b_valinta3.Location = new Point(88, 181);
            b_valinta3.Name = "b_valinta3";
            b_valinta3.Size = new Size(94, 29);
            b_valinta3.TabIndex = 2;
            b_valinta3.Text = "Valinta 3";
            b_valinta3.UseVisualStyleBackColor = true;
            b_valinta3.Click += button_Click;
            // 
            // b_valinta4
            // 
            b_valinta4.Location = new Point(88, 235);
            b_valinta4.Name = "b_valinta4";
            b_valinta4.Size = new Size(94, 29);
            b_valinta4.TabIndex = 3;
            b_valinta4.Text = "Valinta 4";
            b_valinta4.UseVisualStyleBackColor = true;
            b_valinta4.Click += button_Click;
            // 
            // b_default
            // 
            b_default.Location = new Point(88, 292);
            b_default.Name = "b_default";
            b_default.Size = new Size(94, 29);
            b_default.TabIndex = 4;
            b_default.Text = "Default";
            b_default.UseVisualStyleBackColor = true;
            b_default.Click += button_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { posuitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // posuitToolStripMenuItem
            // 
            posuitToolStripMenuItem.Name = "posuitToolStripMenuItem";
            posuitToolStripMenuItem.Size = new Size(131, 26);
            posuitToolStripMenuItem.Text = "Poistu";
            posuitToolStripMenuItem.Click += posuitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(b_default);
            Controls.Add(b_valinta4);
            Controls.Add(b_valinta3);
            Controls.Add(b_valinta2);
            Controls.Add(b_valinta1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_valinta1;
        private Button b_valinta2;
        private Button b_valinta3;
        private Button b_valinta4;
        private Button b_default;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem posuitToolStripMenuItem;
    }
}
