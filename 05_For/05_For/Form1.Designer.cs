namespace _05_For
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
            tb_int = new TextBox();
            b_start = new Button();
            l_display = new Label();
            SuspendLayout();
            // 
            // tb_int
            // 
            tb_int.Location = new Point(89, 91);
            tb_int.Name = "tb_int";
            tb_int.Size = new Size(125, 27);
            tb_int.TabIndex = 0;
            tb_int.TextChanged += tb_int_TextChanged;
            // 
            // b_start
            // 
            b_start.Location = new Point(259, 91);
            b_start.Name = "b_start";
            b_start.Size = new Size(94, 29);
            b_start.TabIndex = 1;
            b_start.Text = "Start";
            b_start.UseVisualStyleBackColor = true;
            b_start.Click += b_start_Click;
            // 
            // l_display
            // 
            l_display.AutoSize = true;
            l_display.Location = new Point(192, 216);
            l_display.Name = "l_display";
            l_display.Size = new Size(0, 20);
            l_display.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(l_display);
            Controls.Add(b_start);
            Controls.Add(tb_int);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_int;
        private Button b_start;
        private Label l_display;
    }
}
