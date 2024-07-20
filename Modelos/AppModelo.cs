using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class AppModelo : Modelo
    {
        public int Id;
        public string Nombre;
        public string Apellido;

        public void Guardar()
        {
            string sql = $"INSERT INTO usuarios (nombre,apellido) VALUES('{this.Nombre}','{this.Apellido}')";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();

        }

        public void Borrar()
        {
            string sql = $"UPDATE usuarios SET eliminado = true WHERE id ='{this.Id}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public List<AppModelo> ObtenerTodos()
        {
            List<AppModelo> usuarios = new List<AppModelo>();

            string sql = $"SELECT * FROM usuarios WHERE eliminado = false";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                AppModelo usuario = new AppModelo();
                usuario.Id = Int32.Parse(this.Lector["Id"].ToString());
                usuario.Nombre = this.Lector["Nombre"].ToString();
                usuario.Apellido = this.Lector["Apellido"].ToString();
                usuarios.Add(usuario);
            }
            return usuarios;

        }
    }
}
