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
    class LocalidadService : ILocalidadService
    {
        private ILocalidad dao;
        public LocalidadService()
        {
            dao = new LocalidadDao();
        }
        public List<Localidad> RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
        public List<Localidad> RecuperarFiltrados()
        {
            return dao.RecuperarFiltrados();
        }
        public int InsertarUno(Localidad l)
        {
            return dao.InsertarUno(l);
        }

        public int ActualizarLocalidad(Localidad l)
        {
            return dao.ActualizarLocalidad(l);
        }

        public Localidad RecuperarUna(int idLocalidad)
        {
            return dao.RecuperarUna(idLocalidad);
        }
    }
}
