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
    public partial class report_class : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public report_class()
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
            try
            {
                int i = 0;
                DB_connect();
                comm = new OracleCommand();
                comm.CommandText = "select sec_id,year,semester,room_no,building from section where sec_id = '" + textBox1.Text +"'";
                comm.CommandType = CommandType.Text;
                ds = new DataSet();
                da = new OracleDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "section");
                dt = ds.Tables["section"];
                int t = dt.Rows.Count;
                dr = dt.Rows[i];
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "section";
                //dataGridView1.Enabled = true;
            }
            catch (Exception ex)
            {
            }
            try
            {
                int i = 0;
                DB_connect();
                comm = new OracleCommand();
                comm.CommandText = "select name,stud_id from student1 join takes using(stud_id) where sec_id = '" + textBox1.Text + "'";
                comm.CommandType = CommandType.Text;
                ds = new DataSet();
                da = new OracleDataAdapter(comm.CommandText, conn);
                da.Fill(ds, "sec");
                dt = ds.Tables["sec"];
                int t = dt.Rows.Count;
                dr = dt.Rows[i];
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "sec";
            }
            catch (Exception ex)
            {
                MessageBox.Show("This Section is Vacant");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
