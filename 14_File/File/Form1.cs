using System.IO;
using System.Linq.Expressions;

namespace File
{
    public partial class Form1 : Form
    {

        private String EditorFileName = "Untitled";

        public Form1()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorFileName = "Untitled";
            richTextBox1.Clear();
            SetFormTitleText();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SetFormTitleText()
        {
            FileInfo fileinfo = new FileInfo(EditorFileName);
            Text = fileinfo.Name + " - Editor";
        }

        private void ReadFile()
        {
            try
            {
                using (StreamReader Reader = new StreamReader(EditorFileName))
                {
                    richTextBox1.Clear();
                    richTextBox1.Text = Reader.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Open File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SaveFile()
        {
            try
            {
                using (StreamWriter StrWriter = new StreamWriter(EditorFileName))
                {
                    StrWriter.Write(richTextBox1.Text);
                }
            }
            catch (IOException ex) 
            {
                MessageBox.Show("Error: " + ex.Message, "Save File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }   

    }
}
