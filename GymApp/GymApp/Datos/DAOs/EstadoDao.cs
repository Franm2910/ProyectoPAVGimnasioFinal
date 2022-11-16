using GymApp.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.DAOs
{
    class EstadoDao : IEstado
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM Estado";
            return DBHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
