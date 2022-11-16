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
    class BarrioService : IBarrioService
    {
        private IBarrio dao;
        public BarrioService()
        {
            dao = new BarrioDao();
        }

        public List<Barrio> RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }

        public List<Barrio> RecuperarFiltrados(string Nombre, int? IdLoc )
        {
            return dao.RecuperarFiltrados(Nombre,IdLoc);
        }


        public int InsertarUno(Barrio b)
        {
            return dao.InsertarUno(b);
        }

        public int ActualizarBarrio(Barrio ej)
        {
            return dao.ActualizarBarrio(ej);
        }

        public Barrio RecuperarUno(int idBr)
        {
            return dao.RecuperarUno(idBr);
        }

    }
}
