using GymApp.Datos.DAOs;
using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using GymApp.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios.Implementaciones
{
    class TipoDocumentoService : ITipoDocumentoService
    {
        private ITipoDocumento dao;
        public TipoDocumentoService()
        {
            dao = new TipoDocumentoDao();
        }
        public List<TipoDocumento> RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
