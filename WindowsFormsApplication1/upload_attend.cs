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
    public partial class upload_attend : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public upload_attend()
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
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "update stud_course set attendance = '" + textBox3.Text + "' where course_id = '" + textBox2.Text + "' and stud_id = '" + textBox1.Text + "'";
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Attendance uploaded!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
