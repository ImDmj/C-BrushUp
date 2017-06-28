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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        SqlDataAdapter da1;
        DataSet ds;
        SqlCommandBuilder cmb;

        private void Form4_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-67C9IMH\SQLEXPRESS;Initial Catalog=manju_db;Integrated Security=True");
            da1 = new SqlDataAdapter("select * from department", cn);
            
            ds = new DataSet();
            cmb = new SqlCommandBuilder(da1);
            

            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey; // to make primary key avaialble to client set
            da1.Fill(ds, "department");
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            da1.Update(ds, "department");
            MessageBox.Show("Updated");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(DataRow r in ds.Tables[0].Rows)
            {
                MessageBox.Show(r.RowState.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataView dv = ds.Tables[0].DefaultView;
            dv.Sort = "dept_id";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataView dv = ds.Tables[0].DefaultView;
            dv.Sort = "deptname";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowStateFilter = DataViewRowState.Added;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowStateFilter = DataViewRowState.ModifiedOriginal;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowStateFilter = DataViewRowState.Deleted;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "dept_id>=" + textBox1.Text;
        }
    }
}
