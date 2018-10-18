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
    public partial class modify_grade : Form
    {

        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;

        public modify_grade()
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
                DB_connect();
                OracleCommand cm = new OracleCommand();
                cm.Connection = conn;
                cm.CommandText = "update evaluation set grade = '" + textBox4.Text + "' where stud_id = '" + textBox1.Text + "'";
                cm.CommandType = CommandType.Text;
                
                cm.ExecuteNonQuery();
                MessageBox.Show("Grade Modified");
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Deadline crossed"); 
            }
            conn.Close();
        }
    }
}
