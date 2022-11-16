using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios.Interfaces
{
    internal interface IEjercicioService
    {
        List<Ejercicio> RecuperarTodos();
        List<Ejercicio> RecuperarFiltrados(string Ejercicio, int? IdGM);
        Ejercicio RecuperarUno(int idEj);
        int InsertarUno(Ejercicio ej);
        int ActualizarEjercicio(Ejercicio ej);
        int EliminarEjercicio(int ej);
    }
}
