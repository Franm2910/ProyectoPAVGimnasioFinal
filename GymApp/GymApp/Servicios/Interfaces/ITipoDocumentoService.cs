using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios.Interfaces
{
    interface ITipoDocumentoService
    {
        List<TipoDocumento> RecuperarTodos();
    }
}
