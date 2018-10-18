using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApplication1
{
    public partial class student_login : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public student_login()
        {
            InitializeComponent();
        }
        public void DB_connect()
        {
            String oradb = "Data Source = HPPRO58; User ID = SYSTEM ; Password = avabbittu";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from login1";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "TB1_login1");
            dt = ds.Tables["TB1_login1"];
            int t = dt.Rows.Count;
            //dr = dt.Rows[0];
            int i = 0;
            int Flag = 0;
            for (; i < t; i++)
            {
                dr = dt.Rows[i];
                if (textBox1.Text == dr["id"].ToString() && textBox2.Text == dr["PASSWORD"].ToString())
                {
                    student_features frm4 = new student_features (int.Parse(dr["sf_id"].ToString()));
                    frm4.Show();
                    Flag = 1;
                    break;
                }
            }
            if (Flag == 0)
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void student_login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            forgot_pass frm10 = new forgot_pass();
            frm10.Show();
        }
    }
}
