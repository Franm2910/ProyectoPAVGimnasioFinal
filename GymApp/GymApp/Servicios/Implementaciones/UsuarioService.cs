using GymApp.Datos.DAOs;
using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using GymApp.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios
{
    class UsuarioService: IUsuarioService
    {
        private IUsuario dao;

        public UsuarioService()
        {
            dao = new UsuarioDao();
        }

        public List<Usuario> RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
        public List<Usuario> RecuperarFiltrados(string NombreUsuario, int? IdTipoUsuario)
        {
            return dao.RecuperarFiltrados(NombreUsuario, IdTipoUsuario);
        }
        public Usuario RecuperarUno(int id)
        {
            return dao.RecuperarUno(id);
        }
        public int InsertarUsuario(Usuario usuario)
        {
            return dao.InsertarUsuario(usuario);
        }
        public int ActualizarUsuario(Usuario usuario)
        {
            return dao.ActualizarUsuario(usuario);
        }
        public int BajaLogicaUsuario(int IdUsr)
        {
            return dao.BajaLogicaUsuario(IdUsr);
        }
        public bool Existe(string NombreUsuario, int? IdUsuario)
        {
            bool test = dao.Existe(NombreUsuario, IdUsuario);
            return test;
        }
        public Usuario ValidarUsuario(string nombreusr)
        {
            return dao.ValidarUsuario(nombreusr);
        }

    }
}
