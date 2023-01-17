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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            registro frm = new registro();
            frm.Show();
            this.Hide();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("conexion exitosa");
        }

        private void hola_Click(object sender, EventArgs e)
        {
            sesion frm = new sesion();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sesion frm = new sesion();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            registro frm = new registro();
            frm.Show();
            this.Hide();
        }
    }
}
