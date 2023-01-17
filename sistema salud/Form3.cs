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
    public partial class sesion : Form
    {
        public sesion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hola_Click(object sender, EventArgs e)
        {
            fm1 frm = new fm1();
            frm.Show();
        }

        private void sesion_Load(object sender, EventArgs e)
        {

        }

        private void retro_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            fm1 frm = new fm1();
            frm.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();

        }
    }
}
