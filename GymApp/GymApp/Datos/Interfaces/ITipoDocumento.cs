using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.Interfaces
{
    interface ITipoDocumento
    {
        List<TipoDocumento> RecuperarTodos();
    }
}
