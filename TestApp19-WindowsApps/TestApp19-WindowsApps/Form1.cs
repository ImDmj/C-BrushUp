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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Windows Form");
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Calc c = new Calc();
        //    c.Show(); // cursor can shift to the previous window
        //    c.ShowDialog(); // creates a model dialog box and doesn't allow you to go back to the previous window unless you close
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    MyEditor e = new MyEditor();
        //    e.Show();
        //}
    }
}
