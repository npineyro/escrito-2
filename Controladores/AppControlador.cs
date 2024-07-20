using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Modelos;

namespace Controladores
{
    public class AppControlador
    {
        public static void Crear(string nombre, string apellido)
        {
            AppModelo usuario = new AppModelo();
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Guardar();

        }

        public static void Eliminar(string id)
        {
            AppModelo usuario = new AppModelo();
            usuario.Id = Int32.Parse(id);
            usuario.Borrar();
        }

        public static void Modificar(string id, string nombre, string precio)
        {

        }



        public static DataTable Listar()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Apellido", typeof(string));


            AppModelo usuario = new AppModelo();
            foreach (AppModelo p in usuario.ObtenerTodos())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = p.Id;
                fila["Nombre"] = p.Nombre;
                fila["Apellido"] = p.Apellido;
                tabla.Rows.Add(fila);
            }

            return tabla;

        }
    }
}