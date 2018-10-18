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
    public partial class student_features : Form
    {
        int id;
        public student_features(int id1)
        {
            id = id1;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            msg frm13 = new msg(id);
            frm13.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            attend frm17 = new attend(id);
            frm17.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eval_schem frm14 = new Eval_schem();
            frm14.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grd frm15 = new grd(id);
            frm15.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            noti frm16 = new noti(id);
            frm16.Show();
        }
    }
}
