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
    public partial class broad_message : Form
    {

        OracleConnection conn;
        int id1;
        public broad_message(int id)
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_connect();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "update teaches set message_sent = '" + richTextBox1.Text + "'where sec_id ='" + textBox1.Text + "'";
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("Message Sent");
            conn.Close();

        }
    }
}
