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
    public partial class Form2 : Form
    {
        public string mensaje1;

        public Form2(string mensaje)
        {
            InitializeComponent();
            lblMensaje2.Text = mensaje;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = mensaje1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
