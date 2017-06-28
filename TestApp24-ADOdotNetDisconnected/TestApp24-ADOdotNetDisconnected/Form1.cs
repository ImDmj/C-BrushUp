using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestApp24_ADOdotNetDisconnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmb;

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-67C9IMH\SQLEXPRESS;Initial Catalog=manju_db;Integrated Security=True");
            da = new SqlDataAdapter("select * from department",cn);
            ds = new DataSet();
            cmb = new SqlCommandBuilder(da);
            

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey; // to make primary key avaialble to client set
            da.Fill(ds,"department");
            
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void EnableBinding()
        {
            textBox1.DataBindings.Add("text", ds.Tables[0], "dept_id");
            textBox2.DataBindings.Add("text", ds.Tables[0], "deptname");
        }
        private void DisableBinding()
        {
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisableBinding();
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables[0].NewRow();
            r["dept_id"] = textBox1.Text;
            r["deptname"] = textBox2.Text;

            ds.Tables[0].Rows.Add(r);
            EnableBinding();
            MessageBox.Show("Added");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables[0].Rows.Find(textBox1.Text);
            if(r == null)
            {
                MessageBox.Show("no department found");
            }
            else
            {
                r.Delete();
                MessageBox.Show("Record Deleted");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables[0].Rows.Find(textBox1.Text);
            if (r == null)
            {
                MessageBox.Show("no department found");
            }
            else
            {
                r[1] = textBox2.Text;
                MessageBox.Show("Record Updated");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            da.Update(ds, "department");
            MessageBox.Show("Database updated");
        }
    }
}
