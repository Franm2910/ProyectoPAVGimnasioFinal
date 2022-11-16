using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios.Interfaces
{
    interface IBarrioService
    {
        List<Barrio> RecuperarTodos();
        List<Barrio> RecuperarFiltrados(string Nombre, int? IdLoc);

        int InsertarUno(Barrio b);

        int ActualizarBarrio(Barrio ej);

        Barrio RecuperarUno(int Idbr);
        
    }
}
