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

namespace TestApp20_FileIODemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = @"B:\\test.txt";

            #region Create
           
            if(!File.Exists(s))
            {
                File.Create(s);
                MessageBox.Show("Created");
            }

            else
            {
                MessageBox.Show("File Already Exists");
            }

            #endregion

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = @"B:\\test.txt";
            #region Delete File

            if (File.Exists(s))
            {
                File.Delete(s);
                MessageBox.Show("Deleted");
            }

            else
            {
                MessageBox.Show("File doesn't Exists");
            }

            #endregion
        }
    }
}
