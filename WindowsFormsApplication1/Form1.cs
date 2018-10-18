using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student_login frm2 = new student_login();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            faculty_login frm3 = new faculty_login();
            frm3.Show();
        }
    }
}
