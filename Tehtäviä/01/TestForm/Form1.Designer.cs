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
            TreeNode treeNode5 = new TreeNode("Label");
            TreeNode treeNode6 = new TreeNode("Button");
            TreeNode treeNode7 = new TreeNode("Checkbox");
            TreeNode treeNode8 = new TreeNode("Root", new TreeNode[] { treeNode5, treeNode6, treeNode7 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chkC));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lstCity = new ListBox();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            checkBox1 = new CheckBox();
            chkASP = new CheckBox();
            btnSubmit = new Button();
            treeView1 = new TreeView();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // lstCity
            // 
            lstCity.FormattingEnabled = true;
            lstCity.Items.AddRange(new object[] { "Jyväskylä", "Tampere", "Helsinki", "Turku", "Oulu" });
            lstCity.Location = new Point(61, 267);
            lstCity.Name = "lstCity";
            lstCity.Size = new Size(175, 84);
            lstCity.TabIndex = 2;
            lstCity.SelectedIndexChanged += listBox1_SelectedIndexChanged;
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
            btnSubmit.Click += btnSubmit_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(508, 144);
            treeView1.Name = "treeView1";
            treeNode5.Name = "Label";
            treeNode5.Text = "Label";
            treeNode6.Name = "Button";
            treeNode6.Text = "Button";
            treeNode7.Name = "Checkbox";
            treeNode7.Text = "Checkbox";
            treeNode8.Name = "Root";
            treeNode8.Text = "Root";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode8 });
            treeView1.Size = new Size(151, 121);
            treeView1.TabIndex = 8;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(508, 289);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 168);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // chkC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(treeView1);
            Controls.Add(btnSubmit);
            Controls.Add(chkASP);
            Controls.Add(checkBox1);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(lstCity);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "chkC";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ListBox lstCity;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private CheckBox checkBox1;
        private CheckBox chkASP;
        private Button btnSubmit;
        private TreeView treeView1;
        private PictureBox pictureBox1;
    }
}
