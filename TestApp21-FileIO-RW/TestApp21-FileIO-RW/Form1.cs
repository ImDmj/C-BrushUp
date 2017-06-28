using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestApp21_FileIO_RW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FileStream fs;
        StreamWriter sw;
        StreamReader sr;

        private void button1_Click(object sender, EventArgs e)
        {
            fs = new FileStream(@"B:\test.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);

            sw.WriteLine(textBox1.Text);
            sw.Close();
            fs.Close();
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fs = new FileStream(@"B:\test.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            fs.Seek(5, SeekOrigin.Begin);

            //Read whole file line by line till the file ends
            while(!sr.EndOfStream)
            {
                richTextBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
           
            sr.Close();
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fs = new FileStream(@"B:\test.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);

            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }
    }
}
