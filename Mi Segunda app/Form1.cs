using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi_Segunda_app
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Window;

            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Window;

            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Window;

            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.Window;

            if (txtApellido.Text == "" || txtEdad.Text == "" || txtNombre.Text == "" || txtDireccion.Text == "")
                MessageBox.Show("Por favor complete todos los datos antes de presionar aceptar");
            else
            {
                string Apellido = txtApellido.Text;
                string Nombre = txtNombre.Text;
                string Edad = txtEdad.Text;
                string Direccion = txtDireccion.Text;

                txtResultado.Text = "Apellido y nombre: " + Apellido + " " + Nombre + "\n Edad: " + Edad + "\n Direccion: " + Direccion;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        
    }
}
