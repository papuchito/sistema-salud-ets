using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_salud
{
    public partial class fm2 : Form
    {
        public fm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fm3 frm = new fm3();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fm1 frm = new fm1();
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fm1 frm = new fm1();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fm3 frm = new fm3();
            frm.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            fm1 frm = new fm1();
            frm.Show();
            this.Hide();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            fm3 frm = new fm3();
            frm.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
