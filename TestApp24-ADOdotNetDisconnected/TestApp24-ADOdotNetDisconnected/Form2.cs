using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestApp24_ADOdotNetDisconnected
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        SqlDataAdapter da1,da2;
        DataSet ds;
        SqlCommandBuilder cmb,cmb2;
        
        private void button1_Click(object sender, EventArgs e)
        {
            da1.Update(ds,"department");
            da2.Update(ds, "Employee");
            MessageBox.Show("db Updated");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-67C9IMH\SQLEXPRESS;Initial Catalog=manju_db;Integrated Security=True");
            da1 = new SqlDataAdapter("select * from department",cn);
            da2 = new SqlDataAdapter("select * from Employee", cn);
            ds = new DataSet();
            cmb = new SqlCommandBuilder(da1);
            cmb2 = new SqlCommandBuilder(da2);

            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey; // to make primary key avaialble to client set
            da1.Fill(ds,"department");
            da2.Fill(ds, "Employee");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView2.DataSource = ds.Tables[1];
        }
    }
}
