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
    public partial class fm7 : Form
    {
        public fm7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fm8 frm = new fm8();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fm6 frm = new fm6();
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fm6 frm = new fm6();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fm8 frm = new fm8();
            frm.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            fm6 frm = new fm6();
            frm.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            fm8 frm = new fm8();
            frm.Show();
        }
    }
}
