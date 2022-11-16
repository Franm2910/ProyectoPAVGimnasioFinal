using GymApp.Datos.DAOs;
using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using GymApp.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios
{
    internal class EjercicioService: IEjercicioService
    {
        private IEjercicio dao;

        public EjercicioService()
        {
            dao = new EjercicioDao();
        }

        public List<Ejercicio> RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }

        public List<Ejercicio> RecuperarFiltrados(string Ejercicio, int? IdGM)
        {
            return dao.RecuperarFiltrados(Ejercicio, IdGM);
        }
        public Ejercicio RecuperarUno(int idEj)
        {
            return dao.RecuperarUno(idEj);
        }
        public int InsertarUno(Ejercicio ej)
        {
            return dao.InsertarUno(ej);
        }
        public int ActualizarEjercicio(Ejercicio ej)
        {
            return dao.ActualizarEjercicio(ej);
        }
        public int EliminarEjercicio(int ej)
        {
            return dao.EliminarEjercicio(ej);
        }
    }
}
