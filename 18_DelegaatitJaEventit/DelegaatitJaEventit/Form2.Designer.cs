namespace DelegaatitJaEventit
{
    partial class Form2
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
            dateTimePicker1 = new DateTimePicker();
            l_pvm = new Label();
            b_tarkista = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 46);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // l_pvm
            // 
            l_pvm.AutoSize = true;
            l_pvm.Location = new Point(39, 51);
            l_pvm.Name = "l_pvm";
            l_pvm.Size = new Size(88, 20);
            l_pvm.TabIndex = 1;
            l_pvm.Text = "Päivämäärä:";
            // 
            // b_tarkista
            // 
            b_tarkista.Location = new Point(149, 111);
            b_tarkista.Name = "b_tarkista";
            b_tarkista.Size = new Size(169, 29);
            b_tarkista.TabIndex = 2;
            b_tarkista.Text = "Tarkista päivämäärä";
            b_tarkista.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 202);
            Controls.Add(b_tarkista);
            Controls.Add(l_pvm);
            Controls.Add(dateTimePicker1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label l_pvm;
        private Button b_tarkista;
    }
}