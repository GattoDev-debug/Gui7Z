using System.Diagnostics;
namespace Gui7Z
{
    public partial class Form1 : Form
    {

        string loc;
        string dest;
        public Form1()
        {
            InitializeComponent();
        }


        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loc = openFileDialog1.FileName;
            label1.Text = loc;
            textBox1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.SelectReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                label2.Text = folderBrowserDialog1.SelectedPath;
                dest = folderBrowserDialog1.SelectedPath;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c 7z.exe x " + loc + " -p" + textBox1.Text + " -o" + dest + "> zip.log");
            Thread.Sleep(1500);
            Process.Start("explorer.exe", dest);
        }

    }
}
