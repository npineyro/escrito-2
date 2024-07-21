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
            AppControlador.Modificar(TextboxIDModificacion.Text, TextboxNombreModificacion.Text, TextboxApellidoModificacion.Text);
            MessageBox.Show("Usuario Modificado");
            refrescarTablaDeDatos(); 
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            (tablaDeDatos.DataSource as DataTable).DefaultView.RowFilter = string.Format("(nombre) LIKE '%{0}%'", TextboxBusquedaNombre.Text);
            (tablaDeDatos.DataSource as DataTable).DefaultView.RowFilter = string.Format("(apellido) LIKE '%{0}%'", TextboxBusquedaApellido.Text);
            (tablaDeDatos.DataSource as DataTable).DefaultView.RowFilter = string.Format("id = {0}", TextboxBusquedaID.Text);
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            refrescarTablaDeDatos();
        }
    }
}
