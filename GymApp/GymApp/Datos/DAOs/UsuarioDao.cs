using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.DAOs
{
    class UsuarioDao : IUsuario
    {
        //LLAMADAS A BASE DE DATOS
        public List<Usuario> RecuperarFiltrados(string NombreUsuario, int? IdTipoUsuario)
        {
            string consulta = "SELECT U.IdUsuario, U.NombreUsuario, U.Clave,TU.IdTipoUsuario , TU.Descripcion as 'Perfil', E.Nombre as 'Estado', E.IdEstado FROM Usuario U JOIN Estado E ON E.IdEstado = U.Estado JOIN TipoUsuario TU ON TU.IdTipoUsuario = U.IdTipoUsuario ";
            if (NombreUsuario != "" && IdTipoUsuario != null)
            {
                consulta = consulta + "WHERE U.NombreUsuario LIKE '%" + NombreUsuario + "%' AND U.IdTipoUsuario =" + IdTipoUsuario;
            }
            else
            {

                if (IdTipoUsuario != null)
                {
                    consulta = consulta + "WHERE U.IdTipoUsuario =" + IdTipoUsuario;
                }
                if (NombreUsuario != "")
                {
                    consulta = consulta + "WHERE U.NombreUsuario LIKE '%" + NombreUsuario + "%'";
                }
            }
            consulta = consulta + " ORDER BY U.IdUsuario desc";
            return MapeoAListaDeUsuarios(DBHelper.obtenerInstancia().consultar(consulta));
        }

        public List<Usuario> RecuperarTodos()
        {
            string consulta = "SELECT U.IdUsuario, U.NombreUsuario, U.Clave,TU.IdTipoUsuario ,TU.Descripcion as 'Perfil', E.Nombre as 'Estado', E.IdEstado FROM Usuario U JOIN Estado E ON E.IdEstado = U.Estado JOIN TipoUsuario TU ON TU.IdTipoUsuario = U.IdTipoUsuario ORDER BY U.IdUsuario desc";
            return MapeoAListaDeUsuarios(DBHelper.obtenerInstancia().consultar(consulta));
        }

        public Usuario RecuperarUno(int id)
        {
            string consulta = "SELECT U.IdUsuario, U.NombreUsuario, U.Clave, TU.IdTipoUsuario, TU.Descripcion as 'Perfil', E.Nombre as 'Estado', E.IdEstado FROM Usuario U JOIN TipoUsuario TU ON TU.IdTipoUsuario = U.IdTipoUsuario JOIN Estado E ON E.IdEstado = U.Estado WHERE U.IdUsuario =" + id;
            return MapToObjetoUsuario( DBHelper.obtenerInstancia().consultar(consulta));
        }

        public int InsertarUsuario(Usuario usuario)
        {
            string consulta = "INSERT INTO Usuario (NombreUsuario, Clave, IdTipoUsuario, Estado) VALUES ('" + usuario.NombreUsuario + "','" + usuario.Clave + "'," + usuario.TipoUsuario.IdTipoUsuario + "," + usuario.Estado.IdEstado + ")";
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }
        public int ActualizarUsuario(Usuario usuario)
        {
            string consulta = "UPDATE Usuario SET NombreUsuario='" + usuario.NombreUsuario + "', Clave='" + usuario.Clave + "', IdTipoUsuario = '" + usuario.TipoUsuario.IdTipoUsuario + "', Estado = '" + usuario.Estado.IdEstado + "' WHERE IdUsuario =" + usuario.IdUsuario;
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public int BajaLogicaUsuario(int IdUsr)
        {
            string consulta = "UPDATE Usuario SET Estado = 0 WHERE IdUsuario = " + IdUsr;
            return DBHelper.obtenerInstancia().actualizar(consulta);

        }
        public bool Existe(string NombreUsuario, int? IdUsuario)
        {
            string consulta = "SELECT * FROM Usuario WHERE NombreUsuario = '" + NombreUsuario + "'";
            if (IdUsuario != null)
            {
                consulta = consulta + " AND IdUsuario != " + IdUsuario;
            }
            return (DBHelper.obtenerInstancia().consultar(consulta).Rows.Count > 0);
        }

        public Usuario ValidarUsuario(string nombreUsr)
        {
            List<Usuario> lista = new List<Usuario>();
            lista = this.RecuperarFiltrados(nombreUsr, null);
            if (lista.Count > 0)
            {
                return lista[0];
            }
            else
            {
                return null;
            }
        }

        //METODOS DE SOPORTE
        public List<Usuario> MapeoAListaDeUsuarios(DataTable tabla)
        {
            List<Usuario> lstUsuarios = new List<Usuario>();
            foreach (DataRow row in tabla.Rows)
            {
                Usuario usuario = new Usuario();
                usuario.IdUsuario = int.Parse(row["IdUsuario"].ToString());
                usuario.NombreUsuario = row["NombreUsuario"].ToString();
                usuario.Clave = row["Clave"].ToString();
                usuario.TipoUsuario = new TipoUsuario();
                usuario.TipoUsuario.IdTipoUsuario = int.Parse(row["IdTipoUsuario"].ToString());
                usuario.TipoUsuario.Descripcion = row["Perfil"].ToString();
                usuario.Estado = new Estado();
                usuario.Estado.IdEstado = int.Parse(row["IdEstado"].ToString());
                usuario.Estado.Nombre = row["Estado"].ToString();

                lstUsuarios.Add(usuario);
            }
            return lstUsuarios;
        }
        public Usuario MapToObjetoUsuario(DataTable tabla)
        {
            Usuario usuario = new Usuario();
            usuario.IdUsuario = int.Parse(tabla.Rows[0]["IdUsuario"].ToString());
            usuario.NombreUsuario = tabla.Rows[0]["NombreUsuario"].ToString();
            usuario.Clave = tabla.Rows[0]["Clave"].ToString();
            usuario.TipoUsuario = new TipoUsuario();
            usuario.TipoUsuario.IdTipoUsuario = int.Parse(tabla.Rows[0]["IdTipoUsuario"].ToString());
            usuario.TipoUsuario.Descripcion = tabla.Rows[0]["Perfil"].ToString();
            usuario.Estado = new Estado();
            usuario.Estado.IdEstado = int.Parse(tabla.Rows[0]["IdEstado"].ToString());
            usuario.Estado.Nombre = tabla.Rows[0]["Estado"].ToString();

            return usuario;
        }


    }
}
