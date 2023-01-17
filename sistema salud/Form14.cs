using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_salud
{
    public partial class fm11 : Form
    {
        public fm11()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Evaluacion enviada correctamente su resultado sera enviado a su correo");
            MessageBox.Show("Gracias!!!!");

            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            fm10 frm = new fm10();
            frm.Show();
            this.Hide();

        }
    }
}
