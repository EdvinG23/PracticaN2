using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
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

        private void btnMensaje1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMensaje1.Text))
            {
                MessageBox.Show("Debe completar el campo solicitado");
            }
            else
            {
                string mensaje = txtMensaje1.Text;
                Form2 f2 = new Form2("");
                f2.mensaje1 = mensaje;
                f2.Show();
            }
        }

        private void btnMensaje2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMensaje2.Text))
            {
                MessageBox.Show("Debe completar el campo solicitado");
            }
            else
            {
                string mensaje = txtMensaje2.Text;
                Form2 f2 = new Form2(mensaje);
                f2.Show();
            }
        }
    }
}
