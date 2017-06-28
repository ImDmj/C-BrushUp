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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace TestApp22_Serialization_Deserial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FileStream fs;
        BinaryFormatter bfor;
        XmlSerializer xmls;
        SoapFormatter sfrm;
        string type;
        
        private void serialize(object sender, EventArgs e)
        {
            employee obj = new employee();
            obj.eno = Convert.ToInt32(textBox1.Text);
            obj.ename = textBox2.Text;
            obj.bsal = Convert.ToInt32(textBox3.Text);

            bfor = new BinaryFormatter();
            xmls = new XmlSerializer(typeof(employee));
            sfrm = new SoapFormatter();

            fs= new FileStream(@"B:\emp.bin",FileMode.Append,FileAccess.Write);

            type = (sender as Button).Text;

            if (type == "B_Serialize")
            {
                bfor.Serialize(fs, obj);
            }
            else if (type == "X_Serialize")
            {
                xmls.Serialize(fs, obj);
            }
            else
            {
                sfrm.Serialize(fs, obj);
            }
            
            fs.Close();
            MessageBox.Show("Done...");
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void deserialize(object sender, EventArgs e)
        {
            fs = new FileStream(@"B:\emp.bin", FileMode.Open, FileAccess.Read);
            employee emp = new employee();
            bfor = new BinaryFormatter();
            xmls = new XmlSerializer(typeof(employee));
            sfrm = new SoapFormatter();

            type = (sender as Button).Text;

            if (type == "B_Deserialize")
            {
                emp = (employee)bfor.Deserialize(fs);
            }
            else 
            if (type == "X_Deserialize")
            {
                using(fs)
                {
                    emp = (employee)xmls.Deserialize(fs);
                }
            }
            else
            {
                emp = (employee)sfrm.Deserialize(fs);
            }

            fs.Close();
            MessageBox.Show(emp.ToString());
        }
    }
}
