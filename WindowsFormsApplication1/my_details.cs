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
    public partial class my_details : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int id1;
        String ids;
        public my_details(int id)
        {
            id1 = id;
            ids = id1.ToString();
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
                comm.CommandText = "select name,sec_id,room_no,building from ((instructor join teaches using(inst_id)) join section using(sec_id)) where inst_id = '" + id1 + "'";
                comm.CommandType = CommandType.Text;
                ds = new DataSet();
                da = new OracleDataAdapter(comm.CommandText, conn);
                da.Fill(ds,"details_faculty");
                dt = ds.Tables["details_faculty"];
                int t = dt.Rows.Count;
                dr = dt.Rows[i];
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "details_faculty";
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
            conn.Close();
        }
    }
}
