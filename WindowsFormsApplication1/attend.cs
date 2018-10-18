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
    public partial class attend : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int id1;
        public attend(int id)
        {
            id1 = id;
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
                comm.CommandText = "select * from stud_course where stud_id = '" + id1 + "'";
                comm.CommandType = CommandType.Text;
                ds = new DataSet();
                da = new OracleDataAdapter(comm.CommandText, conn);
                //DataTable d = new DataTable();
                da.Fill(ds, "stud");
                //da.Fill(ds);
                dt = ds.Tables["stud"];
                int t = dt.Rows.Count;
                dr = dt.Rows[i];
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "stud";
                //dataGridView1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
            conn.Close();
        }
    }
}
