using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.Interfaces
{
    interface IUsuario
    {
        List<Usuario> RecuperarTodos();
        List<Usuario> RecuperarFiltrados(string NombreUsuario, int? IdTipoUsuario);
        Usuario RecuperarUno(int id);
        int InsertarUsuario(Usuario usuario);
        int ActualizarUsuario(Usuario usuario);
        int BajaLogicaUsuario(int IdUsr);
        bool Existe(string NombreUsuario, int? IdUsuario);
        Usuario ValidarUsuario(string nombreUsr);
    }
}
