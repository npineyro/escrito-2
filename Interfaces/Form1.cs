using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;

namespace Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refrescarTablaDeDatos();
        }

        private void refrescarTablaDeDatos()
        {
            tablaDeDatos.Refresh();
            tablaDeDatos.DataSource = AppControlador.Listar();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            AppControlador.Crear(TextboxNombre.Text, TextboxApellido.Text);
            refrescarTablaDeDatos();
            MessageBox.Show("Su usuario ha sido creado");
            refrescarTablaDeDatos();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            AppControlador.Eliminar(TextboxIDBaja.Text);
            refrescarTablaDeDatos();
            MessageBox.Show("Su usuario ha sido eliminado");
            refrescarTablaDeDatos();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
