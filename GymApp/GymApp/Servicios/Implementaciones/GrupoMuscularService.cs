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
    internal class GrupoMuscularService:IGrupoMuscularService
    {
        private IGrupoMuscular dao;

        public GrupoMuscularService()
        {
            dao = new GrupoMuscularDao();
        }

        public List<GrupoMuscular> RecuperarFiltrados(string Nombre)
        {
           return dao.RecuperarFiltrados(Nombre);
        }

        public List<GrupoMuscular> RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }

        public GrupoMuscular RecuperarUno(int IdGM)
        {
            return dao.RecuperarUno(IdGM);
        }

        public int AgregarGrupoMuscular(GrupoMuscular gm)
        {
            return dao.AgregarGrupoMuscular(gm);
        }

        public int ActualizarGrupoMuscular(GrupoMuscular gm)
        {
            return dao.ActualizarGrupoMuscular(gm);
        }

        public int DarDeBajaGrupoMuscular(int IdGM)
        {
            return dao.DarDeBajaGrupoMuscular(IdGM);
        }
    }
}
