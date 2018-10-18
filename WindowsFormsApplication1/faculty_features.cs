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
    public partial class faculty_features : Form
    {
        int id1;
        public faculty_features(int id)
        {
            id1 = id;
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            my_details frm6 = new my_details(id1);
            frm6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            upload_grade frm8 = new upload_grade();
            frm8.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            modify_grade frm9 = new modify_grade();
            frm9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            broad_message frm10 = new broad_message(id1);
            frm10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            report_class frm11 = new report_class();
            frm11.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            upload_attend frm18 = new upload_attend();
            frm18.Show();
        }
    }
}
