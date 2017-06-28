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
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        int no1, no2;
        string op;

        private void button4_Click_1(object sender, EventArgs e)
        {
            //textBox1.Text += button4.Text;
            textBox1.Text += (sender as Button).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToInt32(textBox1.Text);
            op = (sender as Button).Text;
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            no2 = Convert.ToInt32(textBox1.Text);

            switch(op)
            {
                case "+":
                    textBox1.Text = (no1 + no2).ToString();
                    break;
                case "-":
                    textBox1.Text = (no1 - no2).ToString();
                    break;
                case "*":
                    textBox1.Text = (no1 * no2).ToString();
                    break;
                case "/":
                    textBox1.Text = (no1 / no2).ToString();
                    break;
            }
        }
    }
}
