namespace _10_Dictionary
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
            button1 = new Button();
            tb_lisaakey = new TextBox();
            tb_lisaavalue = new TextBox();
            tb_haekey = new TextBox();
            b_lisaa = new Button();
            b_hae = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(239, 95);
            button1.Name = "button1";
            button1.Size = new Size(164, 29);
            button1.TabIndex = 0;
            button1.Text = "Luo Dictionary";
            button1.UseVisualStyleBackColor = true;
            // 
            // tb_lisaakey
            // 
            tb_lisaakey.Location = new Point(166, 165);
            tb_lisaakey.Name = "tb_lisaakey";
            tb_lisaakey.Size = new Size(197, 27);
            tb_lisaakey.TabIndex = 1;
            // 
            // tb_lisaavalue
            // 
            tb_lisaavalue.Location = new Point(166, 224);
            tb_lisaavalue.Name = "tb_lisaavalue";
            tb_lisaavalue.Size = new Size(197, 27);
            tb_lisaavalue.TabIndex = 2;
            // 
            // tb_haekey
            // 
            tb_haekey.Location = new Point(166, 283);
            tb_haekey.Name = "tb_haekey";
            tb_haekey.Size = new Size(197, 27);
            tb_haekey.TabIndex = 3;
            // 
            // b_lisaa
            // 
            b_lisaa.Location = new Point(397, 224);
            b_lisaa.Name = "b_lisaa";
            b_lisaa.Size = new Size(94, 29);
            b_lisaa.TabIndex = 4;
            b_lisaa.Text = "Lisää";
            b_lisaa.UseVisualStyleBackColor = true;
            // 
            // b_hae
            // 
            b_hae.Location = new Point(397, 283);
            b_hae.Name = "b_hae";
            b_hae.Size = new Size(94, 29);
            b_hae.TabIndex = 5;
            b_hae.Text = "Hae";
            b_hae.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 165);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 6;
            label1.Text = "Key:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 224);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 7;
            label2.Text = "Value:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 283);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 8;
            label3.Text = "Key:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 342);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 9;
            label4.Text = "Value:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(166, 342);
            label5.Name = "label5";
            label5.Size = new Size(52, 22);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(b_hae);
            Controls.Add(b_lisaa);
            Controls.Add(tb_haekey);
            Controls.Add(tb_lisaavalue);
            Controls.Add(tb_lisaakey);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tb_lisaakey;
        private TextBox tb_lisaavalue;
        private TextBox tb_haekey;
        private Button b_lisaa;
        private Button b_hae;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
