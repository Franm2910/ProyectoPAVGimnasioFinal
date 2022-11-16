using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.Interfaces
{
    interface IBarrio
    {
        List<Barrio> RecuperarTodos();

        List<Barrio> RecuperarFiltrados(string nombre, int? IdLoc);

        int InsertarUno(Barrio b);

        int ActualizarBarrio(Barrio b);

        Barrio RecuperarUno(int idBr);

    }
}
