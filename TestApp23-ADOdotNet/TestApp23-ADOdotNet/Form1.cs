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

namespace TestApp23_ADOdotNetConnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;


        private void Form1_Load_1(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"server=DESKTOP-67C9IMH\SQLEXPRESS;Initial Catalog=manju_db;Integrated Security=True");
            //cn = new SqlConnection("server=mayur\sqlserver2008; database=manjula_db;integrated security=true");
            cmd = new SqlCommand();
            //Data Source=DESKTOP-67C9IMH\SQLEXPRESS;Initial Catalog=manju_db;Integrated Security=True
            ShowData();
            EnableBinding();
        }

        private void EnableBinding()
        {
            textBox1.DataBindings.Add("Text", dt, "dept_id");
            textBox2.DataBindings.Add("Text", dt, "deptname");
        }

        private void DisableBinding()
        {
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
        }

        private void ShowData()
        {
            cmd.CommandText = "select * from department";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dt = new DataTable();
                dt.Load(dr);

                //databinding - connecting/associating data to control
                dataGridView1.DataSource = dt;      //must implement IListSource  interface
                    
            }
            else
            {
                MessageBox.Show("no rows available...");
            }
            dr.Close();
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisableBinding();
            textBox1.Clear();
            textBox2.Clear();

            cmd.CommandText = "select max(dept_id) from department";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            cn.Open();
            object o = cmd.ExecuteScalar();
            cn.Close();
            
            if(o == DBNull.Value)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = (Convert.ToInt32(o) + 1).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "AddDept";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);

            cn.Open();
            int i =cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(i + " row(s) inserted.");
            EnableBinding();
            ShowData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "update department set deptname=@p2 where dept_id=@p1";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);

            cn.Open();
            int i = cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(i + " row(s) updated.");

            ShowData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "delete from department where dept_id=@p1";
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);


            cn.Open();
            int i = cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show(i + " row(s) deleted.");

            ShowData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             BindingContext[dt].Position = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
             BindingContext[dt].Position -= 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
             BindingContext[dt].Position += 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
              BindingContext[dt].Position = dt.Rows.Count - 1;
        }

        }
    }

