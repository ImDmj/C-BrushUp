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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        SqlDataAdapter da1,da2;
        DataSet ds;
        SqlCommandBuilder cmb,cmb2;

        private void Form3_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-67C9IMH\SQLEXPRESS;Initial Catalog=manju_db;Integrated Security=True");
            da1 = new SqlDataAdapter("select * from department", cn);
            da2 = new SqlDataAdapter("select * from Employee", cn);
            ds = new DataSet();

            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey; // to make primary key avaialble to client set

            da1.Fill(ds, "department");
            da2.Fill(ds, "Employee");

            DataRelation drel = new DataRelation("dept_emp", ds.Tables[0].Columns["dept_id"], ds.Tables[1].Columns["deptid"]);
            ds.Relations.Add(drel);


            dataGridView1.DataSource = ds.Tables[0];
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.DataMember = "dept_emp";
        }
    }
}
