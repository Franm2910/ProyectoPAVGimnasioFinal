using GymApp.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.DAOs
{
    class TipoUsuarioDao : ITipoUsuario
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM TipoUsuario";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
