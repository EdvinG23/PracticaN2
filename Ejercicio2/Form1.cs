using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public List<Estudiantes> listEstudents = new List<Estudiantes>();

            public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                listEstudents.Add(new Estudiantes()
                {
                    Id = id,
                    Nombres = nombres,
                    Apellidos = apellidos

                });
                MessageBox.Show("Su registro fue agregado con exito");
                txtId.Clear();
                txtNombres.Clear();
                txtApellidos.Clear();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (listEstudents.Count > 0)
            {
                // Enviar datos
                f2.listEstudents = this.listEstudents;
                f2.Show();
            }
            else
            {
                MessageBox.Show("Debe agregar al menos un registro");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
