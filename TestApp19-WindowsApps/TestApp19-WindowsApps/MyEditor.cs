using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp19_WindowsApps
{
    public partial class MyEditor : Form
    {
        public MyEditor()
        {
            InitializeComponent();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            // All files fires *.* command and text files fires *.text command
            saveFileDialog1.Filter = "All Files | *.*|Text Files|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.RichText);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
        }
    }
}
