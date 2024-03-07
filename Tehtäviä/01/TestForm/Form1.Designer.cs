namespace TestForm
{
    partial class chkC
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            City = new ListBox();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            checkBox1 = new CheckBox();
            chkASP = new CheckBox();
            btnSubmit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 41);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Hello world!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(50, 105);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 133);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Details";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(72, 77);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(114, 27);
            txtAddress.TabIndex = 3;
            txtAddress.TextChanged += textBox1_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(72, 39);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 77);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 1;
            label3.Text = "Address";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 39);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // City
            // 
            City.FormattingEnabled = true;
            City.Items.AddRange(new object[] { "Jyväskylä", "Tampere", "Helsinki", "Turku", "Oulu" });
            City.Location = new Point(61, 267);
            City.Name = "City";
            City.Size = new Size(175, 84);
            City.TabIndex = 2;
            City.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(326, 147);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(63, 24);
            rdMale.TabIndex = 3;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(326, 177);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(78, 24);
            rdFemale.TabIndex = 4;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            rdFemale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(326, 237);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(49, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "C#";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkASP
            // 
            chkASP.AutoSize = true;
            chkASP.Location = new Point(326, 267);
            chkASP.Name = "chkASP";
            chkASP.Size = new Size(84, 24);
            chkASP.TabIndex = 6;
            chkASP.Text = "ASP.Net";
            chkASP.UseVisualStyleBackColor = true;
            chkASP.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(326, 322);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSubmit);
            Controls.Add(chkASP);
            Controls.Add(checkBox1);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(City);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "chkC";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txtAddress;
        private TextBox txtName;
        private ListBox City;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private CheckBox checkBox1;
        private CheckBox chkASP;
        private Button btnSubmit;
    }
}
