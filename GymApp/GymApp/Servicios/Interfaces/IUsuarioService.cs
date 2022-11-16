using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios.Interfaces
{
    internal interface IUsuarioService
    {
        List<Usuario> RecuperarTodos();
        List<Usuario> RecuperarFiltrados(string NombreUsuario, int? IdTipoUsuario);
        Usuario RecuperarUno(int id);
        int InsertarUsuario(Usuario usuario);
        int ActualizarUsuario(Usuario usuario);
        int BajaLogicaUsuario(int IdUsr);
        bool Existe(string NombreUsuario, int? IdUsuario);
        Usuario ValidarUsuario(string nombreusr);

    }
}
