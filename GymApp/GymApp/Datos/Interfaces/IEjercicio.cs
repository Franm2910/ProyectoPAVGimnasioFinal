using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.Interfaces
{
    internal interface IEjercicio
    {
        List<Ejercicio> RecuperarFiltrados(string Ejercicio, int? IdGM);
        List<Ejercicio> RecuperarTodos();
        int InsertarUno(Ejercicio ej);
        Ejercicio RecuperarUno(int idEj);
        int ActualizarEjercicio(Ejercicio ej);

        int EliminarEjercicio(int idEj);
    }
}
